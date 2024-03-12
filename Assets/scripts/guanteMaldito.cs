using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guanteMaldito : MonoBehaviour
{
    public float DañoGuante;
    public float dañoRecoi;
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
          /*  en2.life = en2.life - DañoGuante;
            mvp.life = mvp.life - dañoRecoi;
            print("player: "+mvp.life);
            Destroy(this.gameObject);*/


        }
    }
}
