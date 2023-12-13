using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoParallax : MonoBehaviour
{
    private Vector3 posicionInicial;
    public float speed = 10; // Convención de nomenclatura: camelCase
    private float reinicioDistancia;

    void Start()
    {
        posicionInicial = transform.position;

        // Obtener el componente Terrain directamente
        Terrain terrain = GetComponent<Terrain>();

        if (terrain != null)
        {
            // Obtener la longitud del terreno a lo largo del eje X
            reinicioDistancia = terrain.terrainData.size.x / 4;
        }
        else
        {
            Debug.LogError("No se encontró el componente Terrain adjunto al objeto.");
        }
    }

    void Update()
    {
        // Mover el fondo
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        // Verificar si se debe reiniciar la posición
        if (transform.position.x < posicionInicial.x - reinicioDistancia)
        {
            transform.position = posicionInicial;
        }
    }
}
