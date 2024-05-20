using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Maneja el disparo de proyectiles desde un objeto.
/// </summary>
public class FireProjectile : MonoBehaviour
{
    /// <summary>
    /// Referencia al prefab del proyectil que será disparado.
    /// </summary>
    [SerializeField] GameObject projectile;

    /// <summary>
    /// Retraso en segundos antes de destruir el proyectil instanciado.
    /// </summary>
    [SerializeField] float delay;

    /// <summary>
    /// Método Update se llama una vez por frame.
    /// Detecta la entrada del usuario para disparar un proyectil.
    /// </summary>
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            GameObject clone = Instantiate(projectile, transform.position, transform.rotation);
            Destroy(clone, delay);
        }    
    }
}
