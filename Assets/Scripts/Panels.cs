using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Panels : MonoBehaviour
{


    public GameObject panelPerdiste;
    public GameObject panelConfig;
    public GameObject panelInfoNa;




    // Start is called before the first frame update
    void Start()
    {
        panelInfoNa.SetActive(false);
    }

    public void JugarDeNuevo()
    {
        SceneManager.LoadScene("RunLab");
    }

    public void cerrarInfoNA()
    {
        panelInfoNa.SetActive(false);
    }


    public void IrConfig()
    {
        panelConfig.SetActive(true);
    }
    public void salirConfig()
    {
        panelConfig.SetActive(false);
    }

}
