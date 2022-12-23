using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Sliders : MonoBehaviour
{
    public Slider sliderVida;
    public int vidaInicial;
    public static int vidaActual;

    public Slider sliderItem;
    public int itemMax;
    public static int itemActual;
    public int itemInicial;

    public int sinVida = 0;
    public GameObject panelPerdiste;
    public GameObject player;


    void Start()
    {
        vidaActual = vidaInicial;
        sliderVida.value = sliderVida.maxValue;
        sliderVida.maxValue = vidaInicial;

        itemActual = 0;
        sliderItem.maxValue = itemMax;
        sliderItem.value = itemInicial;
    }

    // Update is called once per frame
    void Update()
    {
        sliderVida.value = vidaActual;
        sliderItem.value = itemActual;

        if (vidaActual <= 0)
        {
            player.SetActive(false);
            Player.isGame = false;
            panelPerdiste.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

        }
    }

    public void dañoRecibido(int daño)
    {
        daño = 2;
        vidaActual -= daño;
    }

    public void itemObtenido (int puntos)
    {
        puntos = 2;
        itemActual += puntos;

    }

    public void vidaObtenida(int puntos)
    {
        puntos = 2;
        vidaActual += puntos;

    }
}
