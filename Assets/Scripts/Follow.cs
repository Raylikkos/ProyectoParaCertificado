using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform jugador; // El objeto (jugador) a seguir

    void Update()
    {
        if (jugador)
        {
            Vector3 posicion = jugador.position;
            posicion.z = transform.position.z;
            posicion.y = transform.position.y; // Mantener la misma posición en el eje z

            transform.position = Vector3.Lerp(transform.position, posicion, Time.deltaTime * 8); // Ajustar la posición suavemente
        }
    }
}
