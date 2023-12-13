using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEntorno : MonoBehaviour
{
    [SerializeField] private GameObject[] objectsToSpawn;

        private float Delay = 1.0f;
    private float Intervalo = 3.0f;


    private void Start()
    {
        InvokeRepeating("SpawnObjects", Delay, Intervalo);
    }

    private void SpawnObjects()
    {
        
        
            // Selecciona un objeto aleatorio del array
        GameObject objectToSpawn = objectsToSpawn[Random.Range(0, objectsToSpawn.Length)];

            // Genera posiciones aleatorias en los ejes X y Z
        float randomZ = Random.Range(-1, 1);

         // Crea una instancia del objeto seleccionado en la posición aleatoria
        Vector3 spawnPosition = new Vector3(10, 0, randomZ);
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }
}