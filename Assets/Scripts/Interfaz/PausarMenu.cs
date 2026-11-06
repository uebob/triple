using System.Diagnostics;
using UnityEngine;

public class PausarMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject pauseButton;

    public void PausarGame()
    {
        

        pauseButton.SetActive(false);

        pauseMenu.SetActive(true);
    }

    public void SeguirGame()
    {
        

        pauseButton.SetActive(true);

        pauseMenu.SetActive(false);
    }

    public void SalirGame()
    {
        
        Application.Quit();
    }
}
