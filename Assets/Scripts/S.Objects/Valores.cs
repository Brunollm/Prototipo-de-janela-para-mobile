using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Dados")]
public class Valores : ScriptableObject
{
    public Sprite foto;
    public string nomeFunc;
    public float porcentagem;
    public int nVendas;
    public float fLiquido;
    public float fBruto;
    public float mediaItensVenda;
    public float mediaVendaFunc;
}
