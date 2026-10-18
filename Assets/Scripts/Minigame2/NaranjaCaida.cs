using UnityEngine;

public class NaranjaCaida : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    
    public float velocidadCaida = 5f;

    
    public float alturaLimite = -4f;


    void Update()
    {
        
        

        // Comprueba si el objeto ya pasó o llegó a la altura límite
        if (transform.position.y <= alturaLimite)
        {
            // Ajusta la posición exacta para que no se pase del límite
            transform.position = new Vector3(transform.position.x, alturaLimite, transform.position.z);
            Destroy(gameObject);
            
        }
        else
        {
            // Mueve el objeto hacia abajo constantemente
            transform.Translate(Vector3.down * velocidadCaida * Time.deltaTime);
        }
    }
    
}
