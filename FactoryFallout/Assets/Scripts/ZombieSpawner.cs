using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Maneja la generación de zombis en puntos específicos de la escena.
/// </summary>
public class ZombieSpawner : MonoBehaviour
{
    /// <summary>
    /// Prefab del zombi que será instanciado.
    /// </summary>
    [SerializeField] GameObject zombie;

    /// <summary>
    /// Retraso en segundos antes de generar un nuevo zombi.
    /// </summary>
    [SerializeField] float spawnDelay;

    /// <summary>
    /// Número máximo de zombis que pueden ser generados.
    /// </summary>
    [SerializeField] int zombieMax;

    /// <summary>
    /// Contador del número de zombis actualmente generados.
    /// </summary>
    int numZombies;

    /// <summary>
    /// Método Start se llama antes de la primera actualización del frame.
    /// Inicia la corrutina de generación de zombis.
    /// </summary>
    void Start()
    {
        StartCoroutine("SpawnZombie");
    }

    /// <summary>
    /// Corrutina que maneja la lógica de generación de zombis.
    /// Genera zombis en posiciones aleatorias alrededor del objeto después de un retraso,
    /// y continúa generando hasta alcanzar el número máximo de zombis.
    /// </summary>
    /// <returns>IEnumerator necesario para la implementación de la corrutina.</returns>
    IEnumerator SpawnZombie() {
        yield return new WaitForSeconds(spawnDelay * 2);

        while (numZombies < zombieMax) {
            Vector2 randomPoint = Random.insideUnitCircle * 2f;

            Instantiate(zombie, new Vector3(transform.position.x + randomPoint.x, transform.position.y, transform.position.z + randomPoint.y), Quaternion.identity);
            ++numZombies;

            yield return new WaitForSeconds(spawnDelay);
        }
    }
}
