using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemigo : MonoBehaviour
{
    public GameObject pos;
    public GameObject panelInfoElemento;
    public float pincho = 5f;

    //Para que se mueva de lado a otro
    public GameObject limiteA;
    public GameObject limiteB;
    public int velocidad;

    public SpriteRenderer Enemigolado;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(pos.transform.position, Vector2.up, pincho);

        if (hit.collider != null)
        {
            if (hit.collider.CompareTag("Player"))
            {
                Destroy(gameObject);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                panelInfoElemento.SetActive(true);
                Debug.Log("Panel");
            }
        }

        Debug.DrawRay(pos.transform.position, Vector2.up * pincho, Color.red);



        //Para que se mueva de un lado a otro

        transform.Translate(velocidad * Time.deltaTime, 0, 0);
        if (transform.position.x <= limiteA.transform.position.x)
        {
            velocidad = velocidad * -1;
            Enemigolado.flipX = true;
        }
        else if (transform.position.x >= limiteB.transform.position.x)
        {
            velocidad = velocidad * -1;
            Enemigolado.flipX = false;
        }
    }

    


}
