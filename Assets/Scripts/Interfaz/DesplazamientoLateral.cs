using UnityEngine;

public class DesplazamientoLateral : MonoBehaviour
{
    [SerializeField] private float distancia = 2f; 
    [HideInInspector] public int posActual = 0;

    public void MoverIzquierda()
    {
        if(DialogueManager.Instancia.isOnDialogue) return;

        if(posActual > -2)
        {
            transform.position += Vector3.left * distancia;
            posActual--;
        }
    }

    public void MoverDerecha()
    {
        if(DialogueManager.Instancia.isOnDialogue) return;
        
        if(posActual < 2)
        {
            transform.position += Vector3.right * distancia;
            posActual++;
        }
    }
}