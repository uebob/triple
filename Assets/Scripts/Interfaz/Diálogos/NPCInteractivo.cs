using Unity.Tutorials.Editor;
using Unity.VectorGraphics;
using UnityEngine;
// Fíjate que hemos quitado el "using UnityEngine.Events"

public class NPCInteractivo : MonoBehaviour
{
    
    //variables especificas del NPC
    public string nombre = "???";
    public Dialogo dialogoPorDefecto;
    public Dialogo dialogoMisionCompletada;
    public string sceneChangeName = null;

    private void OnMouseUp()
    {
        if(DialogueManager.Instancia.isOnDialogue) return;

        Dialogo dialogoAUsar;
        if (false) //cambiar luego cuando existan las flags
        {
            //dialogoAUsar = dialogoMisionCompletada;
        }
        else
        {
            dialogoAUsar = dialogoPorDefecto;
        }
        DialogueManager.Instancia.IniciarDialogo(dialogoAUsar, nombre, AccionesAlTerminar);
    }

    private void AccionesAlTerminar()
    {
        if(!string.IsNullOrEmpty(sceneChangeName))
        {
            GameObject.FindWithTag("GameManager").GetComponent<SceneChanger>().ChangeScene(sceneChangeName);
        }
    }
}