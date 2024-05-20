using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// Maneja el comportamiento de una bala cuando colisiona con diferentes objetos.
/// </summary>
public class BulletHit : MonoBehaviour
{
    /// <summary>
    /// Partícula a instanciar cuando la bala golpea a un zombi.
    /// </summary>
    [SerializeField] GameObject chunkParticle;

    /// <summary>
    /// Partícula a instanciar cuando la bala golpea algo que no sea un zombi.
    /// </summary>
    [SerializeField] GameObject hitParticle;

    /// <summary>
    /// Método llamado cuando la bala colisiona con otro objeto.
    /// </summary>
    /// <param name="other">Los datos de la colisión asociados con este evento.</param>
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Zombie")
        {
            Instantiate(chunkParticle, transform.position, Quaternion.identity);
            Destroy(other.gameObject);
        }
        else
        {
            Instantiate(hitParticle, transform.position, Quaternion.identity);
        }

        Destroy(gameObject);
    }
}
