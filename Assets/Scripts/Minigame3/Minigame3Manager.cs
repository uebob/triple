using System;
using Unity.Tutorials.Editor;
using UnityEngine;

public class Minigame3Manager : MonoBehaviour
{
    public GameObject[] prefabRosquilletas;
    public Dialogo dialogoFaltaAmasar;
    public Dialogo dialogoPerdido;
    public Dialogo dialogoGanado;
    private bool won = false;

    void Start()
    {
        prefabRosquilletas = GameObject.FindGameObjectsWithTag("Rosquilleta");
    }

    public void Cocinar()
    {
        if(PuedeCocinar())
        {
            if(!won)
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
        DialogueManager.Instancia.IniciarDialogo(dialogoPerdido, "MINIJUEGOMANAGER1", AccionesAlPerder);
    }

    private void AccionesAlPerder()
    {
        GameObject.FindWithTag("GameManager").GetComponent<SceneChanger>().ChangeScene("Minigame3");
    }

    void Win()
    {
        DialogueManager.Instancia.IniciarDialogo(dialogoGanado, "MINIJUEGOMANAGER1", AccionesAlGanar);
    }

    private void AccionesAlGanar()
    {
        GameObject.FindWithTag("GameManager").GetComponent<GameManager>().completados[2] = true;
        GameObject.FindWithTag("GameManager").GetComponent<SceneChanger>().ChangeScene("SampleScene");
    }
}
