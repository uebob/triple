using UnityEngine;

public class Detector : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private ManagerMin2 manager;
    
    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("S");
        if (collider.gameObject.CompareTag("Naranja"))
        {
            manager.naranjas++;
        }
        else if (collider.gameObject.CompareTag("Podrida"))
        {
            if(naranjas >= 0)
            {
                manager.naranjas--;
            }
        }
        

        Destroy(collider.gameObject);
    }
}
