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
        if(!GameObject.FindWithTag("ManagerMinijuego1").GetComponent<ManagerMin2>().stopSpawn)
        {
            Vector3 posicionRatonPantalla = Input.mousePosition;

            Vector3 posicionMundo = camaraPrincipal.ScreenToWorldPoint(posicionRatonPantalla);

            transform.position = new Vector3(posicionMundo.x, transform.position.y, transform.position.z);
        }
    }
}
