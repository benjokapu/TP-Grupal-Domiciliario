using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class juegoBehaviour : MonoBehaviour
{
    public Text objeto1;
    public Text objeto2;
    public InputField resul;
    public GameObject panelBien;
    public GameObject panelMal;
    public GameObject panelNoResponde;
    public Button botonResponder;
    public Button botonVolverAjugar;
    bool checkearSuma(int num1, int num2, int resul)
    {
        return (num1 + num2 == resul) ? true : false;
    }

    void botonResponderActivado()
    {
        if (resul.text=="")
        {
            panelNoResponde.SetActive(true);
            return;
        }
        int resultado = Convert.ToInt32(objeto1.text) + Convert.ToInt32(objeto2.text);
        if (checkearSuma(Convert.ToInt32(objeto1.text), Convert.ToInt32(objeto2.text), resultado)){
            panelBien.SetActive(true);
            return;
        }
        else
        {
            panelMal.SetActive(true);
            return;
        }
    }

    void volverAJugarActivado()
    {
        panelNoResponde.SetActive(false);
        panelMal.SetActive(false);
        panelBien.SetActive(false);
    }
}
