using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ReceberAnimacao : MonoBehaviour
{
    int arredondarNumero;
    private TextMeshProUGUI valorExibido;

    private float tNumero, mNumero;
    public float vNumero = 0;
    bool ativarCalculo = false;

    private void Awake()
    {
        valorExibido = GetComponent<TextMeshProUGUI>();
    }

    public void AtivarContagem(float maxNumeros, float velocidade)
    {
        tNumero = 0;
        mNumero = maxNumeros;
        vNumero = velocidade;
        ativarCalculo = true;
    }

    private void Update()
    {
        if (ativarCalculo == true)
        {
            Calculo();
        }
    }


    private void Calculo()
    {
        tNumero += Mathf.Lerp(0, mNumero, vNumero);
        arredondarNumero = (int)tNumero;
        if (tNumero >= mNumero)
        {
            ativarCalculo=false;
            valorExibido.text = mNumero.ToString();
        }
        else
        {
            valorExibido.text = arredondarNumero.ToString();
        }
    }

}
