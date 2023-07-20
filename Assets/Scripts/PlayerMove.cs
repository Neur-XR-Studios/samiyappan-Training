using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float MoveForce;
    [SerializeField]
    private float MovementX;
    [SerializeField]
    private float Jumpforce;
    [SerializeField]
    private Rigidbody2D MyBody;
    private Animator Anim;
    private SpriteRenderer SpritRender;
    private string Walking_animation = "Walk";
   // public string idile_animation = "Idile";
    private bool isGround;
    private string Ground_tag = "Ground";
    private string Enemy_tag = "Enemy_T";


    // Start is called before the first frame update
    void Start()
    {
        MyBody = GetComponent<Rigidbody2D>();
        SpritRender = GetComponent<SpriteRenderer>();
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        AnimationPlayer();
    }
    private void FixedUpdate()
    {
        Jump();
    }
    void PlayerMovement()
    {
        MovementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(MovementX, 0f, 0f) * MoveForce * Time.deltaTime;


    }
    void AnimationPlayer()
    {
        if(MovementX > 0) 
        {
            Anim.SetBool(Walking_animation, true);
            SpritRender.flipX = false;
        }
        else if  (MovementX  < 0)
        {  
            Anim.SetBool(Walking_animation, true);
            SpritRender.flipX= true;
        }
        else
        {
            Anim.SetBool(Walking_animation, false);
            //
        }
    }
    void Jump()
    {
        if(Input.GetButtonDown("Jump") && isGround)
        {
            isGround = false;
            MyBody.AddForce(new Vector2(0f, Jumpforce), ForceMode2D.Impulse);
        }
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag(Ground_tag))
        {
            isGround = true;

        }
        if(collision.gameObject.CompareTag(Enemy_tag))
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag(Enemy_tag))
        {
            Destroy(gameObject);    
        } 
        
    }
}
