using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class movimientoPlayer : MonoBehaviour
{
    public float life = 100;
    public float velocidad;
    public float direccion;
    public Rigidbody2D rb;
    public float forceJump;
    public detectorPiso dp;
    public GameObject guanteMaldito;

    public guanteMaldito gm;
    public enemy2 en2;
    public aniquilator ani;
   static bool tieneGuante = false;

    //barra de vida

    public Slider sliderVida;

    //efectos de sonido
    public AudioSource audio;
    public AudioClip fantasma;
    public AudioClip bicho;
    public AudioClip salto;
    public AudioClip puño;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        direccion = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(direccion * velocidad, rb.velocity.y);
        if (Input.GetKey("a")|| Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (Input.GetKey("d")||Input.GetKey(KeyCode.RightArrow)) { transform.rotation = Quaternion.Euler(0, 0, 0); }

        if ((Input.GetKeyDown("w")|| Input.GetKeyDown(KeyCode.UpArrow)) && (dp.enPiso == true || dp.numSaltos > 0))
        {
            audio.PlayOneShot(salto);
            rb.AddForce(Vector2.up * forceJump, ForceMode2D.Impulse);
            dp.numSaltos--;
        }
        puñoMaldito();
        if (life <= 0)
        {
            SceneManager.LoadScene(ani.scene);
        }

    }

     void puñoMaldito()
    {
        Vector2 posicionGuante;
        if (this.transform.rotation.y == 0)
        {
             posicionGuante = new Vector2(this.transform.position.x + 0.6f, this.transform.position.y);
        }else 
        {
            posicionGuante = new Vector2(this.transform.position.x - 0.6f, this.transform.position.y);
        }
        if (Input.GetKeyDown("l")|| Input.GetKeyDown("z"))
        {
            if (tieneGuante)
            {
                audio.PlayOneShot(puño);
                life = life - gm.dañoRecoi;
                Instantiate(guanteMaldito, posicionGuante, this.transform.rotation);
                sliderVida.value = life;
            }
        }
        


        }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy"|| collision.gameObject.tag == "enemySaltarin"|| collision.gameObject.tag == "roca")
        {
            audio.PlayOneShot(fantasma);
            life = life - 20;
            sliderVida.value = life;
        }
        if (collision.gameObject.tag == "enemySaltarin")
        {
            audio.PlayOneShot(bicho);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            tieneGuante = true;
        }
    }
}
