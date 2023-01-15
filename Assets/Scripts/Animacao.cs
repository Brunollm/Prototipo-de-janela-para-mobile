using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Animacao : MonoBehaviour
{
    public Image circulo;
    private bool calcularCirculo = false;
    private float maxCirculo = 0;
    private float tempCirculo = 0;
    public float velocidadeCirculo;

    private void Update()
    {
        if (calcularCirculo == true)
        {
            tempCirculo += Mathf.Lerp(0, maxCirculo / 100, velocidadeCirculo);
            
            if (tempCirculo >= maxCirculo/100)
            {
                calcularCirculo = false;
            }
            circulo.fillAmount = tempCirculo;
        }
    }

    public void AnimarCirculo(float valor)
    {
        tempCirculo = 0;
        circulo.fillAmount = 0;
        maxCirculo = valor;
        calcularCirculo = true;
    }
}
