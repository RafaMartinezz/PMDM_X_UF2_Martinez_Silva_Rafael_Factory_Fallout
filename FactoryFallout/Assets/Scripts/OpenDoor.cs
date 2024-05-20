using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Maneja la apertura de una puerta cuando un jugador entra en el área de colisión.
/// </summary>
public class OpenDoor : MonoBehaviour
{
    /// <summary>
    /// Referencia al componente Animator para controlar las animaciones de la puerta.
    /// </summary>
    [SerializeField] Animator anim;

    /// <summary>
    /// Método llamado cuando otro collider entra en el trigger.
    /// </summary>
    /// <param name="other">El collider del objeto que entra en el trigger.</param>
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            anim.SetTrigger("Open");
        }
    }
}
