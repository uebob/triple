using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Rosquilleta : MonoBehaviour
{
    public float tamañoIdealX = 3f;
    public float tamañoMinimoY = 0.4f;
    public float velocidadEstiramiento = 0.8f;
    public float limiteRoturaX = 3.8f; 

    private Vector3 escalaInicial;
    private Vector3 posicionRatonAnterior;
    
    // Estados
    private bool estaAmasando = false;
    private bool estaLista = false;
    private bool estaRota = false;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        escalaInicial = transform.localScale;
    }

    // Se activa solo si haces clic sobre el Collider2D de ESTA rosquilleta
    void OnMouseDown()
    {
        if (estaLista || estaRota) return;
        
        posicionRatonAnterior = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        estaAmasando = true;
    }

    // Se ejecuta cada frame mientras mantengas pulsado el clic sobre la rosquilleta
    void OnMouseDrag()
    {
        if (!estaAmasando || estaRota) return;

        Vector3 posicionRatonActual = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        // Calculamos cuánto se ha movido el ratón en X (valor absoluto para que funcione de izquierda a derecha y viceversa)
        float distanciaX = Mathf.Abs(posicionRatonActual.x - posicionRatonAnterior.x);

        if (distanciaX > 0.01f)
        {
            EstirarMasa(distanciaX);
            posicionRatonAnterior = posicionRatonActual;
        }
    }

    void OnMouseUp()
    {
        estaAmasando = false;
    }

    void EstirarMasa(float cantidad)
    {
        Vector3 escalaActual = transform.localScale;
        
        //modificar tamaño
        escalaActual.x += cantidad * velocidadEstiramiento; 

        float progreso = Mathf.InverseLerp(escalaInicial.x, tamañoIdealX, escalaActual.x);
        escalaActual.y = Mathf.Lerp(escalaInicial.y, tamañoMinimoY, progreso);

        transform.localScale = escalaActual;

        if (escalaActual.x >= limiteRoturaX)
        {
            RomperMasa();
        }
        else if (escalaActual.x >= tamañoIdealX && !estaLista)
        {
            MasaLista();
        }
    }

    void MasaLista()
    {
        estaLista = true;
        //aqui hay que hacer algo para que se sepa que está lista ya
        Debug.Log(gameObject.name + " divina!!");
    }

    void RomperMasa()
    {
        estaRota = true;
        estaLista = false;
        
        //temporal: tintar de rojo cuando se rompe, aqui se cambiara el sprite
        spriteRenderer.color = new Color(1f, 0.5f, 0.5f); 
    }
}