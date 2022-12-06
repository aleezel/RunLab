using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panels : MonoBehaviour
{


    public GameObject panelInfoNa;

    // Start is called before the first frame update
    void Start()
    {
        panelInfoNa.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cerrarInfoNA()
    {
        panelInfoNa.SetActive(false);
    }
}
