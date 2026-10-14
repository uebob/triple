using UnityEngine;
// Fíjate que hemos quitado el "using UnityEngine.Events"

public class NPCInteractivo : MonoBehaviour
{
    //todas las condiciones que deberian existir antes de chequiar un dialogo (bloque de 6000 flags e ifs de undertale)
    public bool minijuego1completado;
    
    //variables especificas del NPC
    public string nombre = "???";
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

        DialogueManager.Instancia.IniciarDialogo(dialogoAUsar, nombre, AccionesAlTerminar);
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