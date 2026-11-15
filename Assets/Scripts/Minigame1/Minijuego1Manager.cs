using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Minijuego1Manager : MonoBehaviour
{
    public TextMeshProUGUI textoVidas;
    public int vidas = 3;
    [HideInInspector] public int correctas = 0;
    public int objetivos = 5;
    public Dialogo dialogoFinal;
    public Dialogo dialogoPerder;
    private bool won = false;

    void Update()
    {
        textoVidas.text = "Vidas: " + vidas + "     coorectas:" + correctas;

        if(correctas>=objetivos)
        {
            if(!won)
            Win();
        }
        if(vidas <= 0)
        {
            Lose();
        }
    }

    void Win()
    {
        if(!DialogueManager.Instancia.isOnDialogue)
        {
            DialogueManager.Instancia.IniciarDialogo(dialogoFinal, "MINIJUEGOMANAGER1", AccionesAlTerminar);
            won=true;
        }
    }

    private void AccionesAlTerminar()
    {
        GameObject.FindWithTag("GameManager").GetComponent<SceneChanger>().ChangeScene("SampleScene");
    }

    private void AccionesAlPerder()
    {
        GameObject.FindWithTag("GameManager").GetComponent<SceneChanger>().ChangeScene("SampleScene");
    }

    void Lose()
    {
        DialogueManager.Instancia.IniciarDialogo(dialogoPerder, "MINIJUEGOMANAGER1", AccionesAlPerder);
    }
}
