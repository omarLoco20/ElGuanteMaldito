using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grapho : MonoBehaviour
{
    public nodeComport[] arrayNodos;
    public nodeComport nodoInicial;
    public enemyComport enemycomport;

    // Start is called before the first frame update
    void Start()
    {
        enemycomport.inicialNode(nodoInicial);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
