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
    public GameObject panelInfoPotasio;
    public GameObject panelInfoRubidio;
    public GameObject panelInfoCesio;
    public GameObject panelInfoFrancio;
    public GameObject panelInfoMagnesio;
    public GameObject panelInfoRb;

    public GameObject panelPausa;

    // Start is called before the first frame update
    void Start()
    {
        panelInfoNa.SetActive(false);
        panelPerdiste.SetActive(false);
        panelConfig.SetActive(false);
        panelInfoPotasio.SetActive(false);
        panelInfoCesio.SetActive(false);
        panelInfoFrancio.SetActive(false);
        panelInfoMagnesio.SetActive(false);
        panelInfoRb.SetActive(false);
    }

    public void JugarDeNuevo()
    {
        SceneManager.LoadScene("RunLab");
    }

    public void cerrarInfoNA()
    {
        panelInfoNa.SetActive(false);
    }

    public void cerrarInfoMg()
    {
        panelInfoMagnesio.SetActive(false);
    }
    public void cerrarInfoFr()
    {
        panelInfoFrancio.SetActive(false);
    }
    public void cerrarInfoK()
    {
        panelInfoPotasio.SetActive(false);
    }
    public void cerrarInfoRb()
    {
        panelInfoRb.SetActive(false);
    }
    public void cerrarInfoCs()
    {
        panelInfoCesio.SetActive(false);
    }

    public void IrConfig()
    {
        panelConfig.SetActive(true);
    }
    public void salirConfig()
    {
        panelConfig.SetActive(false);
    }

    public void PausaJuego()
    {
        panelPausa.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Player.isGame = false;
    }
    public void QuitarPausa()
    {
        panelPausa.SetActive(false);
        Player.isGame = true;
    }

}
