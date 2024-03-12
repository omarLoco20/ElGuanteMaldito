using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2 : MonoBehaviour
{
   
    public float speedEnemy2;
    public float min;
    public float max;
    
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x+speedEnemy2*Time.deltaTime, transform.position.y);
        if (transform.position.x <= min || transform.position.x >= max)
        {
            speedEnemy2 = speedEnemy2 * -1;
        }
    }

    

}
