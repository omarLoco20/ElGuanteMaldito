using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectorPiso : MonoBehaviour
{
    public bool enPiso;
    public int numSaltos;
    public int cantidadSaltos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "piso")
        {
            enPiso = true;
            numSaltos = cantidadSaltos;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "piso")
        {
            enPiso = false;
        }
    }
}
