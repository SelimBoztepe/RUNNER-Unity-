using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerCtrl :MonoBehaviour { 

    Animator anim;

    public GameManager gm;
    private Rigidbody2D rb2;

    public float JumpHeight;
    private bool isJumping;

    public float MoveSpeed=2f;

    public float JumpForce;
     
    void Start() { 
        rb2 = GetComponent<Rigidbody2D>(); 
        anim = GetComponent<Animator>();
    } 

    void HorizontalMove(){

        rb2.velocity=new Vector2(Input.GetAxis("Horizontal")*MoveSpeed,rb2.velocity.y);
        anim.SetFloat("Hiz", Mathf.Abs( Input.GetAxis("Horizontal")));

        if(Input.GetAxisRaw("Horizontal")== -1){
            transform.rotation=Quaternion.Euler(0f, 180f, 0f);
        }
        if(Input.GetAxisRaw("Horizontal")== 1){
            transform.rotation=Quaternion.Euler(0f, 0f, 0f);
        }

    }

    void Escape(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            SceneManager.LoadScene(0);
        }
    }

    void Update() { 

        HorizontalMove();
        Escape();

    } 

    
    
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.tag=="Coin"){
            gm.Coin+=1;
            Destroy(collision.gameObject);

            Debug.Log("Coin Toplandı");

        }
        if(collision.gameObject.tag=="Enemy"){
            Destroy(gameObject);

        }

    }

    public void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Trambolin"))
        {
            rb2.velocity=Vector2.up*JumpForce;
        }
    }
    
}