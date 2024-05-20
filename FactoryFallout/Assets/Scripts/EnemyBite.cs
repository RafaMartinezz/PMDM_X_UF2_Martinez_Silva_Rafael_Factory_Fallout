using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Maneja el comportamiento de morder a un jugador cuando está dentro del área de colisión del enemigo.
/// </summary>
public class EnemyBite : MonoBehaviour
{
    /// <summary>
    /// Método llamado una vez por frame mientras otro collider permanece dentro del trigger.
    /// </summary>
    /// <param name="other">El collider del objeto que permanece en el trigger.</param>
    private void OnTriggerStay(Collider other) {
        if (other.tag == "Player") {
            other.SendMessage("ApplyDamage", 1);
        }
    }
}
