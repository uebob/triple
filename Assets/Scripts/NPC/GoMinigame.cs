using UnityEngine;
using UnityEngine.SceneManagement;

public class GoiMinigame : MonoBehaviour
{
    public string MinijuegoPaella;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        

        
        if (Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene(MinijuegoPaella);
        }
        

        
    }
}
