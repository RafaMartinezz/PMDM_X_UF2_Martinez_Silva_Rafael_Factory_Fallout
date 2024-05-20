using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Maneja el movimiento y el salto del jugador.
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    /// <summary>
    /// Velocidad de movimiento del jugador.
    /// </summary>
    [SerializeField] float speed;

    /// <summary>
    /// Fuerza de salto del jugador.
    /// </summary>
    [SerializeField] float jumpForce;

    /// <summary>
    /// Referencia al componente Rigidbody para manejar la física del jugador.
    /// </summary>
    Rigidbody rb;

    /// <summary>
    /// Referencia al componente CapsuleCollider para detectar colisiones.
    /// </summary>
    CapsuleCollider col;

    /// <summary>
    /// Método Start se llama antes de la primera actualización del frame.
    /// Inicializa el estado del cursor y las referencias a los componentes Rigidbody y CapsuleCollider.
    /// </summary>
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
        col = GetComponent<CapsuleCollider>();
    }

    /// <summary>
    /// Método Update se llama una vez por frame.
    /// Controla el movimiento horizontal del jugador, el salto y la liberación del cursor del ratón.
    /// </summary>
    void Update()
    {
        Vector2 moveInput = Vector2.zero;
        moveInput.x = Input.GetAxis("Horizontal") * speed;
        moveInput.y = Input.GetAxis("Vertical") * speed;
        moveInput *= Time.deltaTime;
        transform.Translate(moveInput.x, 0, moveInput.y);

        if (IsGrounded() && Input.GetButtonDown("Jump")) {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.Escape)) {
            Cursor.lockState = CursorLockMode.None;
        }
    }

    /// <summary>
    /// Verifica si el jugador está en el suelo.
    /// </summary>
    /// <returns>Verdadero si el jugador está en el suelo, falso de lo contrario.</returns>
    bool IsGrounded() 
    {
        return Physics.Raycast(transform.position, Vector3.down, col.bounds.extents.y + 0.1f);
    }
}
