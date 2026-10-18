using UnityEngine;

public class MovimientoCesta : MonoBehaviour
{
    private Camera camaraPrincipal;

    void Start()
    {
        camaraPrincipal = Camera.main;
    }

    void Update()
    {
        
        Vector3 posicionRatonPantalla = Input.mousePosition;

        Vector3 posicionMundo = camaraPrincipal.ScreenToWorldPoint(posicionRatonPantalla);

        transform.position = new Vector3(posicionMundo.x, transform.position.y, transform.position.z);
    }
}
