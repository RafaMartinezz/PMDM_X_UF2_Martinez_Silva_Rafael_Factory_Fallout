using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Maneja la generación de power-ups en puntos específicos de la escena.
/// </summary>
public class PowerUpSpawner : MonoBehaviour
{
    /// <summary>
    /// Prefab del power-up que será instanciado.
    /// </summary>
    [SerializeField] GameObject prefab;

    /// <summary>
    /// Array de puntos de aparición donde los power-ups pueden ser generados.
    /// </summary>
    [SerializeField] Transform[] spawnPoints;

    /// <summary>
    /// Retraso en segundos antes de generar un nuevo power-up.
    /// </summary>
    [SerializeField] float delay;

    /// <summary>
    /// Referencia al power-up actual en la escena.
    /// </summary>
    GameObject powerUp;

    /// <summary>
    /// Método Start se llama antes de la primera actualización del frame.
    /// Inicia la corrutina de generación de power-ups.
    /// </summary>
    void Start()
    {
        StartCoroutine("Spawn");
    }

    /// <summary>
    /// Corrutina que maneja la lógica de generación de power-ups.
    /// Genera un power-up en una posición aleatoria de los puntos de aparición después de un retraso,
    /// y verifica continuamente si el power-up ha sido recogido.
    /// </summary>
    /// <returns>IEnumerator necesario para la implementación de la corrutina.</returns>
    IEnumerator Spawn() {
        while (true) {
            if (powerUp == null) {
                yield return new WaitForSeconds(delay);

                Vector3 position = spawnPoints[Random.Range(0, spawnPoints.Length)].position;
                powerUp = Instantiate(prefab, position, Quaternion.identity);
            }

            yield return new WaitForSeconds(0.5f);
        }
    }
}
