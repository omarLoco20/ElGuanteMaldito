using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuanteRaycast : MonoBehaviour
{
    RaycastHit2D rchit;
    float distancia=1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("k"))
        {
            print("raycast lanzado");
            rchit = Physics2D.Raycast(this.gameObject.transform.position,Vector2.right,distancia);
            Debug.DrawRay(gameObject.transform.position, Vector2.right * distancia, Color.green);
        }
        if (rchit.collider.gameObject.tag == "enemy")
        {
            Debug.DrawRay(gameObject.transform.position, Vector2.right * distancia, Color.red);

            print("choco con enemigo");
        }
        else if (rchit.collider == null)
        {
            Debug.DrawRay(gameObject.transform.position, Vector2.right * distancia, Color.green);

            print("No choco con enemigo");
        }
    }
}
