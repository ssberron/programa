using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float salto;
    [SerializeField] float bajar;
    [SerializeField] float move;
    bool izquierda;
    bool derecha;
    bool arriba;
    bool abajo;
    void Awake ()
    {
        Debug.Log("soy awake");
        //rb.GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("soy Start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("soy Update");
        if (Input.GetKey(KeyCode.A))
        {
            izquierda = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            derecha = true;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            arriba = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            abajo = true;
        }
    }
    void FixedUpdate()
    {
        if (izquierda==true)
        {
            izquierda = false;
            rb.AddForce(Vector3.left*move);
        }
        if (derecha==true)
        {
            derecha = false;
            rb.AddForce(Vector3.right * move);
        }
        if (arriba == true)
        {
            arriba = false;
            rb.AddForce(Vector3.up * salto);
        }
        if (abajo == true)
        {
            abajo = false;
            rb.AddForce(Vector3.down * bajar);
        }
    }
}
