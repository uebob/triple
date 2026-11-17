using Unity.Tutorials.Editor;
using Unity.VectorGraphics;
using UnityEngine;
// Fíjate que hemos quitado el "using UnityEngine.Events"

public class NPCAlcalde : MonoBehaviour
{
    
    //variables especificas del NPC
    public string nombre = "???";
    public Dialogo dialogoPorDefecto;
    public Dialogo dialogoFinal;
    public string sceneChangeName = null;

    private void OnMouseUp()
    {
        if(DialogueManager.Instancia.isOnDialogue) return;

        Dialogo dialogoAUsar;
        if (DialogueManager.Instancia.gameObject.GetComponent<GameManager>().completados[0] && 
            DialogueManager.Instancia.gameObject.GetComponent<GameManager>().completados[1] && 
            DialogueManager.Instancia.gameObject.GetComponent<GameManager>().completados[2] && 
            DialogueManager.Instancia.gameObject.GetComponent<GameManager>().completados[3])
        {
            dialogoAUsar = dialogoFinal;
            DialogueManager.Instancia.IniciarDialogo(dialogoAUsar, nombre, AccionesAlTerminar);
        }
        else
        {
            dialogoAUsar = dialogoPorDefecto;
            DialogueManager.Instancia.IniciarDialogo(dialogoAUsar, nombre);
        }
        
    }

    private void AccionesAlTerminar()
    {
        if(!string.IsNullOrEmpty(sceneChangeName))
        {
            GameObject.FindWithTag("GameManager").GetComponent<SceneChanger>().ChangeScene(sceneChangeName);
        }
    }
}