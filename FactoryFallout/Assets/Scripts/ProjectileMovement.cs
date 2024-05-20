using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

/// <summary>
/// Maneja el movimiento de un proyectil hacia adelante.
/// </summary>
public class ProjectileMovement : MonoBehaviour
{
    /// <summary>
    /// Velocidad constante a la que el proyectil se mueve hacia adelante.
    /// </summary>
    const float SPEED = 100;

    /// <summary>
    /// Método Update se llama una vez por frame.
    /// Controla el movimiento del proyectil hacia adelante.
    /// </summary>
    void Update()
    {
        transform.Translate(Vector3.forward * SPEED * Time.deltaTime);
    }
}
