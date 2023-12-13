using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float fuerzaSalto;
    public float fuerzaGravedad;
    public bool Suelo = true;
    public bool gameOver = false;
    private Animator animator;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Physics.gravity *= fuerzaGravedad;
        animator = GetComponent<Animator>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && Suelo && !gameOver)
        {
            animator.SetTrigger("Jump");
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);

            Suelo = false;
        }
    }
    private void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject.CompareTag("Suelo"))
        {
            Suelo = true;
        }
    }

    private void OnTriggerEnter(Collider collision) 
    {
                if(collision.gameObject.CompareTag("Obstaculo"))
        {
            gameOver = true;
            Debug.Log("Perdiste");

        }
    }
}
