using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb2d;

    Animator anim;
    public float velocidad;
    SpriteRenderer spriteR;

    public LayerMask layerm;
    Collider2D col2D;

    bool isColliderSuelo;
    public float VelocidadS;

    Rigidbody2D rb;
    Sliders sliderVida;
    Sliders sliderItem;

    public float velocidadBoost = 8;
    public float timerBoost = 100;
    public bool isBoost = false;
    public int boostMax = 100;
    public float velocidadInicial;
    public static bool isGame;


    void Start()
    {
        isGame = true;
        velocidad = velocidadInicial;
    }

    void Update()
    {
        if(isGame)
        {

        

            if (Sliders.itemActual >= boostMax || isBoost == true)
            {
                isBoost = true;

                if (isBoost)
                {
                    timerBoost -= Time.deltaTime;
                    Sliders.itemActual = Mathf.FloorToInt(timerBoost);
                    velocidad = velocidadBoost;

                    if (timerBoost <= 0)
                    {
                        isBoost = false;
                        timerBoost = 100;
                        velocidad = velocidadInicial;
                    }
                }
            }
        }
    }


    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spriteR = GetComponent<SpriteRenderer>();
        col2D = GetComponent<Collider2D>();

        rb = GetComponent<Rigidbody2D>();
        sliderVida = GameObject.FindObjectOfType<Sliders>();
        sliderItem = GameObject.FindObjectOfType<Sliders>();

    }

    private void FixedUpdate()
    {

        if (isGame)
        {


        float hori = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        mover(hori, vert);
        saltar();

        }


    }

    public void mover(float h, float v)
    {
        //Vector2 movimiento = new Vector2(h, v);
        rb2d.velocity = new Vector2(h * velocidad, rb2d.velocity.y);

        if (h > 0)
        {
            anim.SetBool("Walk", true);
            //spriteR.flipX = false;
            transform.localScale = new Vector3(0.51F, 0.51F, 0.51F);
        }
        else if (h < 0)
        {
            anim.SetBool("Walk", true);
            //spriteR.flipX = true;
            transform.localScale = new Vector3(-0.51F, 0.51F, 0.51F);
        }
        else
        {
            anim.SetBool("Walk", false);
        }
    }

    public void saltar()
    {
        isColliderSuelo = Physics2D.IsTouchingLayers(col2D, layerm);

        if (Input.GetKey(KeyCode.Space) && isColliderSuelo)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, VelocidadS);
            //anim.SetBool("jump", true);

        }
        else
        {
            anim.SetBool("jump", true);
        }
        if (isColliderSuelo)
        {
            anim.SetBool("jump", false);
        }
    }

    //Collision con enemigos e items
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("vida"))
        {
            sliderVida.vidaObtenida(20);
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("enemigo"))
        {
            sliderVida.dañoRecibido(20);
        }

        if (collision.CompareTag("item"))
        {
            sliderVida.itemObtenido(20);
            Destroy(collision.gameObject);
        }

        
    }
}
