using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 thrust;
    public Vector2 side;
    private float timer;

    public Rigidbody2D rb2D;
    public Animator animator;
    public bool dead = false;

    void Start()
    {
        // thrust = new Vector2(1, 4);//thrust will be 4 times as strong in the y af it is in the x
        rb2D = GetComponent<Rigidbody2D>();
    }
    void Move()
    {
        rb2D.AddForce(thrust, ForceMode2D.Impulse);
    }
    void Update()
    {

        timer += Time.deltaTime;
        rb2D.AddForce(side * Time.deltaTime);

        if (timer > 10f)
        {
            animator.SetBool("Enough", true);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            if(transform.position.y <= 12)
            {
            Move();
            animator.SetBool("isJumping", true);
            
            }
        }
        else
        {
            animator.SetBool("isJumping", false);

        }
        if (transform.position.y <= 12)
        {
            animator.SetBool("onGround", true);
        }
        else
        {
            animator.SetBool("onGround",false);
        }


    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            side = new Vector2(5, 0);
            dead = true;
            animator.SetBool("isDead", true);
            //Score.scoreText.text = "GAME OVER !!   your score :" + score.ToString() ;

        }
    }
}
