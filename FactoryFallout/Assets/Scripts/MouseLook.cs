using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controla la rotación del jugador y la cámara basándose en la entrada del ratón.
/// </summary>
public class MouseLook : MonoBehaviour
{
    /// <summary>
    /// Ángulo mínimo de rotación vertical (en grados).
    /// </summary>
    const float CLAMP_MIN = -45;

    /// <summary>
    /// Ángulo máximo de rotación vertical (en grados).
    /// </summary>
    const float CLAMP_MAX = 45;

    /// <summary>
    /// Sensibilidad del ratón para el giro.
    /// </summary>
    float lookSensitivity = 2;

    /// <summary>
    /// Referencia al objeto jugador.
    /// </summary>
    GameObject player;

    /// <summary>
    /// Vector para almacenar la rotación actual.
    /// </summary>
    Vector2 rotation = Vector2.zero;

    /// <summary>
    /// Vector para almacenar la rotación suavizada.
    /// </summary>
    Vector2 smoothRot = Vector2.zero;

    /// <summary>
    /// Vector para almacenar la velocidad de la rotación (usado por Mathf.SmoothDamp).
    /// </summary>
    Vector2 velRot = Vector2.zero;

    /// <summary>
    /// Método Start se llama antes de la primera actualización del frame.
    /// Inicializa la referencia al objeto jugador.
    /// </summary>
    void Start()
    {
        player = transform.parent.gameObject;
    }

    /// <summary>
    /// Método Update se llama una vez por frame.
    /// Controla la rotación del jugador alrededor del eje Y y la rotación vertical de la cámara.
    /// </summary>
    void Update()
    {
        player.transform.RotateAround(transform.position, Vector3.up, Input.GetAxis("Mouse X") * lookSensitivity);

        rotation.y += Input.GetAxis("Mouse Y");
        rotation.y = Mathf.Clamp(rotation.y, CLAMP_MIN, CLAMP_MAX);

        smoothRot.y = Mathf.SmoothDamp(smoothRot.y, rotation.y, ref velRot.y, 0.01f);

        transform.localEulerAngles = new Vector3(-smoothRot.y, 0, 0);
    }
}
