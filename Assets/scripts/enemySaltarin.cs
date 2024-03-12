using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySaltarin : MonoBehaviour
{
    public int speed;
    public int forceJump;
    public int life;
    public Rigidbody2D rb;
    // Start is called before the first frame update

    
    private void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x-speed*Time.deltaTime, transform.position.y);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "saltarinLimite")
        {
            
            speed = speed * -1;
            if (GetComponent<SpriteRenderer>().flipX)
            {
                GetComponent<SpriteRenderer>().flipX = false;

            }
            else
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "piso")
        {
            rb.AddForce(Vector2.up * forceJump, ForceMode2D.Impulse);
        }
        if (collision.gameObject.tag == "enemySaltarin")
        {

            speed = speed * -1;
            if (GetComponent<SpriteRenderer>().flipX)
            {
                GetComponent<SpriteRenderer>().flipX = false;

            }
            else
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
        }
    }
}

