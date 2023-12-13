using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    public float Velocidad = 20;
    private PlayerController playerController;

    private float Limite = -15;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerController.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * Velocidad);
        }
        if(transform.position.x < Limite)
        {
            Destroy(gameObject);
        }
        
    }
}
