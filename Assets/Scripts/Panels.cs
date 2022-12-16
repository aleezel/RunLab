using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panels : MonoBehaviour
{

    public GameObject panelInicio;
    public GameObject panelPerdiste;
    public GameObject panelConfig;
    public GameObject panelInfoNa;
    public GameObject panelAbout;



    // Start is called before the first frame update
    void Start()
    {
        panelInfoNa.SetActive(false);
        panelInicio.SetActive(true);
    }


    public void cerrarInfoNA()
    {
        panelInfoNa.SetActive(false);
    }

    public void Jugar()
    {
        panelInicio.SetActive(false);
    }

    public void IrConfig()
    {
        panelConfig.SetActive(true);
    }
    public void salirConfig()
    {
        panelConfig.SetActive(false);
    }
    public void IrAbout()
    {
        panelAbout.SetActive(true);
    }
    public void salirAbout()
    {
        panelAbout.SetActive(false);
    }
}
