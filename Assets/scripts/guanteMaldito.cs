using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guanteMaldito : MonoBehaviour
{
    public float Da�oGuante;
    public float da�oRecoi;
    public bool choco=false;
    
    // Start is called before the first frame update
    void Start()
    {
        
        Destroy(this.gameObject, 0.25f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy"|| collision.gameObject.tag == "enemySaltarin")
        {
            print("choco guante maldito");
            choco = true;
            Destroy(collision.gameObject);
          /*  en2.life = en2.life - Da�oGuante;
            mvp.life = mvp.life - da�oRecoi;
            print("player: "+mvp.life);
            Destroy(this.gameObject);*/


        }
    }
}
