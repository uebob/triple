using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class ManagerMin2 : MonoBehaviour
{
    public TextMeshProUGUI textoNaranjas;
    public int naranjas = 0;
    public Dialogo dialogoFinal;
    private bool won = false;
    public bool stopSpawn = false;

    void Update()
    {
        textoNaranjas.text = "Naranjas: "+ naranjas + "/15";
        if (naranjas >= 15)
        {
            stopSpawn=true;
            if(!won)
            Win();
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
}
