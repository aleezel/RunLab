using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenLoader : MonoBehaviour
{
    public GameObject PanelNegro;


    public float delayBeforeLoading = 3f;
    

    private float timeElapsed;

    private void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene("Inicio");
        }


    }

    public void Start()
    {
        PanelNegro.SetActive(true);
    }
}
