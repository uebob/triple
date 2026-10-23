using System;
using Unity.Tutorials.Editor;
using UnityEngine;

public class Minigame3Manager : MonoBehaviour
{
    public GameObject[] prefabRosquilletas;
    [SerializeField] GameObject winCanvas;
    [SerializeField] GameObject loseCanvas;
    public Dialogo dialogoFaltaAmasar;

    void Start()
    {
        prefabRosquilletas = GameObject.FindGameObjectsWithTag("Rosquilleta");
        winCanvas.SetActive(false);
        loseCanvas.SetActive(false);
    }

    public void Cocinar()
    {
        if(PuedeCocinar())
        {
            Win();
        }
    }

    bool PuedeCocinar()
    {
        bool checkedfornolistas = false;

        Rosquilleta rosquilleta;
        foreach(GameObject prefabRosquilleta in prefabRosquilletas)
        {
            rosquilleta = prefabRosquilleta.GetComponent<Rosquilleta>();
            if(rosquilleta.estaRota)
            {
                Lose();
                return false;
            }
            
        }

        bool veredicto = true;
        foreach(GameObject prefabRosquilleta in prefabRosquilletas)
        {
            rosquilleta = prefabRosquilleta.GetComponent<Rosquilleta>();   
            if(!rosquilleta.estaLista && !checkedfornolistas)
            {
                DialogueManager.Instancia.IniciarDialogo(dialogoFaltaAmasar, "CAMBIAR DESDE MINIGAMEMANAGER3", null);
                veredicto=false;
                checkedfornolistas = true;
            }
        }

        return veredicto;
    }

    void Lose()
    {
        loseCanvas.SetActive(true);
    }

    void Win()
    {
        Debug.Log("Cocinar!");
        winCanvas.SetActive(true);
    }
}
