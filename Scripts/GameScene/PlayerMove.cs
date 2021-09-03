using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed;
    private float horMove;
    Rigidbody2D rb;



    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        horMove=Input.GetAxis("Horizontal");
        rb.velocity=new Vector2(horMove*moveSpeed*Time.deltaTime,rb.velocity.y);
        
    }
}
