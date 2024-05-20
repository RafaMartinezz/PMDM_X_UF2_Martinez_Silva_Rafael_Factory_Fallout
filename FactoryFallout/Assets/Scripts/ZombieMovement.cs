using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// Controla el movimiento del zombi y su comportamiento al detectar al jugador.
/// </summary>
public class ZombieMovement : MonoBehaviour
{
    /// <summary>
    /// Distancia a la que el zombi detecta al jugador y comienza a moverse hacia él.
    /// </summary>
    [SerializeField] float proximityDetect;

    /// <summary>
    /// Distancia a la que el zombi comienza a correr hacia el jugador.
    /// </summary>
    [SerializeField] float runDistance;

    /// <summary>
    /// Transform del jugador, el objetivo del zombi.
    /// </summary>
    Transform target;

    /// <summary>
    /// Referencia al componente Animator para controlar las animaciones del zombi.
    /// </summary>
    Animator anim;

    /// <summary>
    /// Referencia al componente NavMeshAgent para manejar el movimiento del zombi.
    /// </summary>
    NavMeshAgent agent;

    /// <summary>
    /// Distancia actual entre el zombi y el jugador.
    /// </summary>
    float distancia;

    /// <summary>
    /// Método Start se llama antes de la primera actualización del frame.
    /// Inicializa las referencias a los componentes NavMeshAgent y Animator, y encuentra al jugador en la escena.
    /// </summary>
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    /// <summary>
    /// Método Update se llama una vez por frame.
    /// Controla la detección de proximidad al jugador y ajusta el comportamiento del zombi (caminar, correr, atacar).
    /// </summary>
    void Update()
    {
        distancia = Vector3.Distance(agent.gameObject.transform.position, target.position);

        if (distancia < proximityDetect)
        {
            agent.SetDestination(target.position);
            agent.speed = 3;
            anim.SetTrigger("Walk");
        }

        if (distancia < 3) {
            anim.SetTrigger("Attack");
        }
    }
}
