using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyComport : MonoBehaviour
{
    public int energia=100;
    public float speed;
    float step;
    public nodeComport nodeComportDesc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, nodeComportDesc.transform.position, step);
        
       
    }

    public void selectNextNode()
    {
        
            nodeComportDesc = nodeComportDesc.randomNode();
        
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "nodo")
        {
            
            
                selectNextNode();           
            
            

        }
    }
    public void inicialNode(nodeComport inicialNodo)
    {
        nodeComportDesc = inicialNodo;
    }

    
}
