using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// Maneja el daño recibido por un enemigo y su destrucción tras recibir un número específico de golpes.
/// </summary>
public class EnemyDamage : MonoBehaviour
{
    /// <summary>
    /// Número de golpes necesarios para destruir el enemigo.
    /// </summary>
    const int HITS_TO_DIE = 5;

    /// <summary>
    /// Contador de golpes recibidos.
    /// </summary>
    int hitCount;

    /// <summary>
    /// Referencia al componente Animator para controlar las animaciones del enemigo.
    /// </summary>
    [SerializeField] Animator anim;

    /// <summary>
    /// Referencia al componente NavMeshAgent para controlar el movimiento del enemigo.
    /// </summary>
    NavMeshAgent agent;

    /// <summary>
    /// Método Start se llama antes de la primera actualización del frame.
    /// Inicializa las referencias a los componentes Animator y NavMeshAgent.
    /// </summary>
    void Start()
    {
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    /// <summary>
    /// Método llamado cuando otro collider entra en el trigger.
    /// </summary>
    /// <param name="other">El collider del objeto que entra en el trigger.</param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            ++hitCount;
            if (hitCount == HITS_TO_DIE)
            {
                anim.SetTrigger("FallBack");
                agent.enabled = false;
                Destroy(gameObject, 10f);
            }
        }
    }
}
