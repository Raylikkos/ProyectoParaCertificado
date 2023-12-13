using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoParallax : MonoBehaviour
{
    private Vector3 posicionInicial;
    public float Speed = 10;
    private float Repeticion;
    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = transform.position;
        Repeticion = GetComponent<BoxCollider>().size.x / 2;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Speed * Time.deltaTime);
        if(transform.position.x < posicionInicial.x -Repeticion)
        {
            transform.position = posicionInicial;
        }
    }
}
