using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// Maneja el daño al jugador, actualiza la interfaz de usuario, y controla el estado de la partida (ganar/perder).
/// </summary>
public class PlayerDamage : MonoBehaviour
{
    /// <summary>
    /// Salud máxima del jugador.
    /// </summary>
    const int MAX_LIFE = 100;

    /// <summary>
    /// Referencia al componente Text para mostrar la salud del jugador.
    /// </summary>
    [SerializeField] Text txtHealth;

    /// <summary>
    /// Referencia al componente Text para mostrar el mensaje de "game over".
    /// </summary>
    [SerializeField] Text gameOver;

    /// <summary>
    /// Referencia al componente Text para mostrar el mensaje de "victoria".
    /// </summary>
    [SerializeField] Text win;

    /// <summary>
    /// Tiempo transcurrido desde que la salud llegó a cero.
    /// </summary>
    float elapsedTime = 0f;

    /// <summary>
    /// Duración de la animación de "game over".
    /// </summary>
    float duration = 3.0f;

    /// <summary>
    /// Salud actual del jugador.
    /// </summary>
    int health = MAX_LIFE;

    /// <summary>
    /// Referencia al objeto que contiene a los enemigos.
    /// </summary>
    GameObject zombies;

    /// <summary>
    /// Método Start se llama antes de la primera actualización del frame.
    /// Inicializa la salud y oculta los textos de "game over" y "victoria".
    /// </summary>
    void Start()
    {
        ApplyDamage(0);
        gameOver.enabled = false;
        win.enabled = false;
    }

    /// <summary>
    /// Método Update se llama una vez por frame.
    /// Maneja la lógica del "game over", reinicio de la escena, y verificación de victoria.
    /// </summary>
    void Update()
    {
        if (health == 0)
        {
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / duration;
            transform.position = Vector3.Lerp(transform.position, new Vector3(0, 0.5f, 0), t);
            transform.rotation = Quaternion.Lerp(Quaternion.identity, Quaternion.Euler(-90, 0, 90), t);
            gameOver.enabled = true;
        }

        zombies = GameObject.FindWithTag("ZombieOut");

        if (zombies != null)
        {
            win.enabled = false;
        }
        else
        {
            win.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (Input.GetKeyDown(KeyCode.P)) {
            
        }
    }

    /// <summary>
    /// Aplica daño al jugador y actualiza la interfaz de usuario.
    /// </summary>
    /// <param name="damage">La cantidad de daño a aplicar.</param>
    void ApplyDamage(int damage)
    {
        if (health > 0)
        {
            health -= damage;
            txtHealth.text = health.ToString();
        }
    }
}
