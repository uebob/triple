using UnityEngine;

public class VerdiuraInteractuable : MonoBehaviour
{
    public bool esCorrecta = true;
    private Minijuego1Manager manager;

    void Start()
    {
        manager = GameObject.FindWithTag("ManagerMinijuego1").GetComponent<Minijuego1Manager>();
    }

    private void OnMouseUp()
    {
        if(!esCorrecta) manager.vidas--;
        else manager.correctas++;
        
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        gameObject.GetComponent<SpriteRenderer>().color = new Color(0.4f, 0.4f, 0.4f, 1f);
    }
}
