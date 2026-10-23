using UnityEngine;

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
    public bool estaLista = false;
    public bool estaRota = false;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        escalaInicial = transform.localScale;
    }

    void OnMouseDown()
    {
        if (estaRota) return;
        
        posicionRatonAnterior = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        estaAmasando = true;
    }

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
        spriteRenderer.color = new Color(0.5f, 1f, 0.5f);
    }

    void RomperMasa()
    {
        estaRota = true;
        estaLista = false;
        
        //temporal: tintar de rojo cuando se rompe, aqui se cambiara el sprite
        spriteRenderer.color = new Color(1f, 0.5f, 0.5f); 
    }
}