using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;
public class ManagerMinijuego4 : MonoBehaviour
{
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool cocinado = false;

    public GameObject botonRemover;

    public GameObject botonSacar;
    public int removerDelay = 3;

    public GameObject patatas;
    public Dialogo dialogoQuemadas;
    public Dialogo dialogoCocinadas;
    public Dialogo dialogoDemasiadoPronto;
    public bool actualizar = true;


    void Start()
    {
         if(!botonSacar.activeSelf) botonSacar.SetActive(true);
        if(botonRemover.activeSelf) botonRemover.SetActive(false);

        StartCoroutine(RemoverCount());
    }

    void Win()
    {
        DialogueManager.Instancia.IniciarDialogo(dialogoCocinadas, "MINIJUEGOMANAGER1", AccionesAlTerminar);
    }
    void Lose(Dialogo dialogo)
    {
        DialogueManager.Instancia.IniciarDialogo(dialogo, "MINIJUEGOMANAGER1", AccionesAlPerder);
    }

    public void Sacar()
    {
        if (cocinado)
        {
            actualizar = false;
           Win(); 
        }
        else
        {
            Dialogo dialogo = null;
            actualizar = false;

            if(GameObject.FindWithTag("Patatas").GetComponent<Patatas>().estadoActual <= 1) dialogo = dialogoDemasiadoPronto;
            if(GameObject.FindWithTag("Patatas").GetComponent<Patatas>().estadoActual > 2) dialogo = dialogoQuemadas;
            Lose(dialogo);
        }
    }

    IEnumerator RemoverCount()
    {
       
        yield return new WaitForSeconds(removerDelay);
        botonSacar.SetActive(false);
        botonRemover.SetActive(true);
        
    }
    public IEnumerator CorutinaRemover()
    {
        botonRemover.SetActive(false);
        patatas.GetComponent<Patatas>().removerPatatas();
       yield return new WaitForSeconds(2);
        botonSacar.SetActive(true);
        StartCoroutine(RemoverCount());
    }

    public void Remover()
    {
        StartCoroutine(CorutinaRemover());
    }

    private void AccionesAlTerminar()
    {
        GameObject.FindWithTag("GameManager").GetComponent<SceneChanger>().ChangeScene("SampleScene");
    }

    private void AccionesAlPerder()
    {
        GameObject.FindWithTag("GameManager").GetComponent<SceneChanger>().ChangeScene("Minigame4");
    }
}
