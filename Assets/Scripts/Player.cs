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

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spriteR = GetComponent<SpriteRenderer>();
        col2D = GetComponent<Collider2D>();
    }

    private void FixedUpdate()
    {
        float hori = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        mover(hori, vert);
        saltar();

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
}
