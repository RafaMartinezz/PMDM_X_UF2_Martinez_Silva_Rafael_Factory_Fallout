using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Aplica un beneficio al jugador cuando este entra en el área de colisión del power-up.
/// </summary>
public class PowerUpApply : MonoBehaviour
{
    /// <summary>
    /// Cantidad de poder o salud a aplicar al jugador.
    /// </summary>
    const int POWER = 50;

    /// <summary>
    /// Clip de audio que se reproduce cuando el jugador recoge el power-up.
    /// </summary>
    [SerializeField] AudioClip clip;

    /// <summary>
    /// Método llamado cuando otro collider entra en el trigger.
    /// </summary>
    /// <param name="other">El collider del objeto que entra en el trigger.</param>
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            other.gameObject.SendMessage("ApplyDamage", -POWER);
            AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
            Destroy(gameObject);
        }
    }
}
