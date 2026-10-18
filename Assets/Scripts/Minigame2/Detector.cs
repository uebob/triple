using UnityEngine;

public class Detector : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("S");
        if (collider.gameObject.CompareTag("Naranja"))
        {
            Debug.Log("N");
        }
        else if (collider.gameObject.CompareTag("Podrida"))
        {
            Debug.Log("P");
        }
        else
        {
            Debug.Log("R");
        }

        Destroy(collider.gameObject);
    }
}
