using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nodeComport : MonoBehaviour
{
    public nodeComport[] arrayNodos;
    public int peso;
    public enemyComport enemyComportDesc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public nodeComport randomNode()
    {
        int randomNodes = Random.Range(0,arrayNodos.Length);
        enemyComportDesc.energia = enemyComportDesc.energia - arrayNodos[randomNodes].peso;
        
        return arrayNodos[randomNodes];
        
    }
}
