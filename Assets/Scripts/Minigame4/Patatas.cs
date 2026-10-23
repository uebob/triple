using UnityEngine;
using System.Collections;
public class Patatas : MonoBehaviour
{
    public Sprite[] estados;
    public int delay = 10;
    private int estadoActual = 0;
    public ManagerMinijuego4 manager4;

    private bool estaRemoviendo = false;
    void Start()
    {
        StartCoroutine(Cocinar());
    }

    // Update is called once per frame
    void Update()
    {
        if (!estaRemoviendo)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = estados[estadoActual];
        }
        
        
    }
    IEnumerator Cocinar()
    {
        manager4.cocinado = false;
        yield return new WaitForSeconds(delay);
        estadoActual++;
       
        
        yield return new WaitForSeconds(delay);
        estadoActual++;
        
        manager4.cocinado = true;
        yield return new WaitForSeconds(delay);
         manager4.cocinado = false;
         estadoActual++;
        
    }
    public void removerPatatas()
    {
        estaRemoviendo = true;
        gameObject.GetComponent<SpriteRenderer>().sprite = estados[4];
        StartCoroutine(Esperar());
    }
    IEnumerator Esperar()
    {
        yield return new WaitForSeconds(2);
        estaRemoviendo = false;
    }
    
}
