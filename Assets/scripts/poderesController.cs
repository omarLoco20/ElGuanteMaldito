using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poderesController : MonoBehaviour
{
    bool saltoGrande;
    public movimientoPlayer playerMov;
    bool teleport;

    // Start is called before the first frame update
    void Start()
    {
        saltoGrande = false;
        teleport = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (teleport)
        {      
            
                teletransportacion();
            
        }
    }

    public void  poderSalto()
    {
        playerMov.forceJump = playerMov.forceJump + (playerMov.forceJump * 0.20f);
    }

    public void teletransportacion()
    {
        
        float tp = 5;
       
            if ((Input.GetKeyDown("l") && Input.GetKey("d")))
            {
                transform.position = new Vector2(transform.position.x + tp, transform.position.y);
            }
            else if (Input.GetKeyDown("l") && Input.GetKey("a"))
            {
                transform.position = new Vector2(transform.position.x - tp, transform.position.y);
            }
            
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "saltoGrande")
        {
            saltoGrande = true;
            poderSalto();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "teleport")
        {
            teleport = true;
            
            Destroy(collision.gameObject);
        }
    }
}
