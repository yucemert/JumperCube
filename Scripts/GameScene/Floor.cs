using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public float JumpForce;
    Rigidbody2D rb;
   private void OnCollisionEnter2D(Collision2D col)
   {
       //Karakter yukarı zıplıyorsa
       if(col.relativeVelocity.y<0)
       {
            rb=col.gameObject.GetComponent<Rigidbody2D>();
       }
       
       if(rb != null)
       {
           Vector2 jumpVelocity=rb.velocity;
           jumpVelocity.y=JumpForce;
           rb.velocity=jumpVelocity;
       }
   }
}
