using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelsInicio : MonoBehaviour
{
    public GameObject panelConfig;
    public GameObject panelInicio;
    public GameObject panelAbout;
    public GameObject panelElementosInfo;
    public GameObject BlackTransition;

    public float delayBeforeLoading = 1f;
    private float timeElapsed;


    void Start()
    {
        panelInicio.SetActive(true);
        BlackTransition.SetActive(true);
        panelConfig.SetActive(false);
        panelElementosInfo.SetActive(false);
        panelAbout.SetActive(false);


    }

    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > delayBeforeLoading)
        {
            BlackTransition.SetActive(false);
        }
    }

    public void Jugar()
    {
        SceneManager.LoadScene("RunLab");
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

    public void IrElementosInfo()
    {
        panelElementosInfo.SetActive(true);
    }
    public void salirElementosInfo()
    {
        panelElementosInfo.SetActive(false);
    }
}
