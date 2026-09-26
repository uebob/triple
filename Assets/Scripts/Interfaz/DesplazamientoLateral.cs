using UnityEngine;

public class DesplazamientoLateral : MonoBehaviour
{
    [SerializeField] private float distanciaPaso = 2f; 
    [SerializeField] private float velocidad = 5f;

    public void MoverIzquierda()
    {
        transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        Debug.Log("mover izq");
    }

    public void MoverDerecha()
    {
        transform.Translate(Vector3.right * velocidad * Time.deltaTime);
    }
}