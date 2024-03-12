using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySaltarinDaño : MonoBehaviour
{
    public enemySaltarin es;
    public pisarEnemys pe;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            es.life = es.life - pe.damage;
            print(es.life);
            pe.rb.AddForce(Vector2.up * 15, ForceMode2D.Impulse);
        }
    }
}
