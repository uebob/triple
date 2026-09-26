using UnityEngine;

public class DesplazamientoLateral : MonoBehaviour
{
    [SerializeField] private float distancia = 2f; 

    public void MoverIzquierda()
    {
        transform.position += Vector3.left * distancia;
    }

    public void MoverDerecha()
    {
        transform.position += Vector3.right * distancia;
    }
}