using UnityEngine;
// Fíjate que hemos quitado el "using UnityEngine.Events"

public class NPCInteractivo : MonoBehaviour
{
    public bool minijuego1completado;

    public Dialogo dialogoPorDefecto;
    public Dialogo dialogoMisionCompletada;

    private void OnMouseDown()
    {
        Dialogo dialogoAUsar;
        if (minijuego1completado == true)
        {
            dialogoAUsar = dialogoMisionCompletada;
        }
        else
        {
            dialogoAUsar = dialogoPorDefecto;
        }

        DialogueManager.Instancia.IniciarDialogo(dialogoAUsar, AccionesAlTerminar);
    }

    private void AccionesAlTerminar()
    {
        if (minijuego1completado == false)
        {

        }
        else
        {
            
        }
    }
}