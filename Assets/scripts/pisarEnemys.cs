using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pisarEnemys : MonoBehaviour
{
    public int numPaMatar;
    public int saltosKill;
    public Rigidbody2D rb;
    public movimientoPlayer mp;
    public int damage = 20;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            mp.life = mp.life + 10;
            print("se quito vida");
            saltosKill--;
            if (saltosKill <= 0)
            {
                Destroy(collision.gameObject);
                saltosKill = numPaMatar;
            }
            rb.AddForce(Vector2.zero);
            rb.AddForce(Vector2.up * 15, ForceMode2D.Impulse);
           

        }
    }
}
