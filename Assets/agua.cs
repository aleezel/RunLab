using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agua : MonoBehaviour
{
    public GameObject panelPerdiste;

    private void Start()
    {
        panelPerdiste.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Estoy tocando");
            panelPerdiste.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Player.isGame = false;
        }
    }
}
