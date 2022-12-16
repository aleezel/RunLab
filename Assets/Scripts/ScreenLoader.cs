using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenLoader : MonoBehaviour
{
    public GameObject LoadingScreen;
    public GameObject PanelNegro;


    public float delayBeforeLoading = 3f;
    

    private float timeElapsed;

    private void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > delayBeforeLoading)
        {
            LoadingScreen.SetActive(false);
            PanelNegro.SetActive(false);
        }


    }

    public void Start()
    {
        LoadingScreen.SetActive(true);
        PanelNegro.SetActive(true);
    }
}
