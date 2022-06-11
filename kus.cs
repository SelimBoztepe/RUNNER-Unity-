using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kus : MonoBehaviour
{
    private Rigidbody2D rb2;
    Animator anim;
    public float MoveSpeed=2f;

    void Start(){
        rb2 = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    
    void HorizontalMove(){

        rb2.velocity=new Vector2(Input.GetAxis("Horizontal")*MoveSpeed,rb2.velocity.y);
        anim.SetFloat("Hiz", Mathf.Abs( Input.GetAxis("Horizontal")));

        if(Input.GetAxisRaw("Horizontal")== -1){
            transform.rotation=Quaternion.Euler(0f, 0f, 0f);
        }
        if(Input.GetAxisRaw("Horizontal")== 1){
            transform.rotation=Quaternion.Euler(0f, 180f, 0f);
        }

    }

    void Update(){
        HorizontalMove();
        
    }
}

