using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LeituraDados : MonoBehaviour
{
    public Image foto;
    public TextMeshProUGUI nomeFuncionario;
    public TextMeshProUGUI porcentagem;
    public TextMeshProUGUI nVendas;
    public TextMeshProUGUI fLiquido;
    public TextMeshProUGUI fBruto;
    public TextMeshProUGUI mediaItensVendas;
    public TextMeshProUGUI mediaVendaFunc;

    public Valores[] valores;
    public Animacao animCirculo;
    public ReceberAnimacao[] receberAnimacao;


    private int count = 0;
    public float velocidade = 0.05f;

    public Animator animacaoGrafica;

    private void Start()
    {
        valores = Resources.LoadAll<Valores>("Database");
        ReceberDados();

    }

    public void MudarValor(bool proximo)
    {
        if (proximo == true)
        {
            if (count < valores.Length - 1)
            {
                count++;
                ReceberDados();
            }
        }
        else
        {
            if (count > 0)
            {
                count--;
                ReceberDados();
            }
        }
    }

    public void ExibirGrafico()
    {
        animacaoGrafica.gameObject.SetActive(true);
        animacaoGrafica.SetBool("Exibir", true);
    }

    public void OcultarGrafico()
    {
        animacaoGrafica.SetBool("Exibir", false);
    }

    private void ReceberDados()
    {
        animCirculo.AnimarCirculo(valores[count].porcentagem);
        receberAnimacao[0].AtivarContagem(valores[count].nVendas, velocidade);
        receberAnimacao[1].AtivarContagem(valores[count].fLiquido, velocidade);
        receberAnimacao[2].AtivarContagem(valores[count].fBruto, velocidade);
        receberAnimacao[3].AtivarContagem(valores[count].mediaItensVenda, velocidade);
        receberAnimacao[4].AtivarContagem(valores[count].mediaVendaFunc, velocidade);


        foto.GetComponent<Image>().sprite = valores[count].foto;
        nomeFuncionario.text = valores[count].nomeFunc;
        porcentagem.text = (valores[count].porcentagem.ToString() + "%");
    }
}
