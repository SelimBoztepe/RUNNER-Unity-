using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerJump : MonoBehaviour {

Animator anim;
 public Rigidbody2D rb;
 public Collider2D cl;
 public float JumpHeight;
 private bool isJumping;


 void Start () {
   rb = GetComponent<Rigidbody2D>();
   anim = GetComponent<Animator>();
 }
 
 void Update () {
  
  if (Input.GetButtonDown("Jump") && Mathf.Approximately(rb.velocity.y,0))
     {
         rb.AddForce(Vector2.up * JumpHeight, ForceMode2D.Impulse);
         anim.SetBool("Ziplama",true);
     }

  if (anim.GetBool("Ziplama")&& Mathf.Approximately(rb.velocity.y,0)){
        anim.SetBool("Ziplama",false);
  }
 }

}
  
  
