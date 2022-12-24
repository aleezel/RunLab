using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelInfoElemento : MonoBehaviour
{
    public GameObject enemigo;
    public float pincho = 5f;
    public GameObject panelInfoElemento;

    private void Start()
    {
        Player.isGame = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(enemigo.transform.position, Vector2.up, pincho);

        if (hit.collider != null)
        {
            if (hit.collider.CompareTag("Player"))
            {
                panelInfoElemento.SetActive(true);
                Player.isGame = false;
                Debug.Log("Panel");
            }
        }
    }



}
