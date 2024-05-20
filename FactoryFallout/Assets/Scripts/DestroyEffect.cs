using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Maneja la destrucción automática de un objeto tras un tiempo específico.
/// </summary>
public class DestroyEffect : MonoBehaviour
{
    /// <summary>
    /// Tiempo en segundos antes de que el objeto sea destruido.
    /// </summary>
    const float TIME = 1;

    /// <summary>
    /// Temporizador para llevar la cuenta del tiempo transcurrido.
    /// </summary>
    float timer;

    /// <summary>
    /// Método Start se llama antes de la primera actualización del frame.
    /// </summary>
    void Start()
    {
        // Inicializa el temporizador a 0 al comienzo
        timer = 0f;
    }

    /// <summary>
    /// Método Update se llama una vez por frame.
    /// Actualiza el temporizador y destruye el objeto si ha transcurrido el tiempo especificado.
    /// </summary>
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > TIME) {
            Destroy(gameObject);
        }
    }
}
