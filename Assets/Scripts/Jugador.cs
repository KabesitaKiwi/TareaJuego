using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float velocidad = 5f;
    private Rigidbody rb;
    private Animator anim; 

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        
        anim = GetComponentInChildren<Animator>();
    }

    void Update()
{
    float horizontal = Input.GetAxisRaw("Horizontal");
    float vertical = Input.GetAxisRaw("Vertical");
    Vector3 direccion = new Vector3(horizontal, 0, vertical).normalized;

    if (direccion.magnitude > 0.1f)
    {
        rb.linearVelocity = new Vector3(direccion.x * velocidad, rb.linearVelocity.y, direccion.z * velocidad);
        Quaternion targetRotation = Quaternion.LookRotation(direccion);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 15f);
    }
    else
    {
        rb.linearVelocity = new Vector3(0, rb.linearVelocity.y, 0);
        rb.angularVelocity = Vector3.zero;
    }

   
    if (anim != null) 
    {
        anim.SetFloat("Speed", direccion.magnitude);
    }
}
}