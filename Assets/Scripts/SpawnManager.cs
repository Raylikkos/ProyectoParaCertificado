using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] Obstaculos;
    private Vector3 spawnPos = new Vector3(20,0,0);

    private float Delay = 1.0f;
    private float Intervalo = 3.0f;
    private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("RepetirSpawn", Delay, Intervalo);
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void RepetirSpawn()
    {
        if(playerController.gameOver == false)
        {
            int ObstaculoIndex = Random.Range (0, Obstaculos.Length);
            Instantiate(Obstaculos[ObstaculoIndex], spawnPos, Obstaculos[ObstaculoIndex].transform.rotation);
        }
    }
}
