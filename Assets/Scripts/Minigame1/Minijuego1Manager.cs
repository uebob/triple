using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Minijuego1Manager : MonoBehaviour
{
    public TextMeshProUGUI textoVidas;
    public GameObject winCanvas;
    public GameObject loseCanvas;
    public int vidas = 3;
    [HideInInspector] public int correctas = 0;
    public int objetivos = 5;

    void Start()
    {
        if(winCanvas.activeSelf) winCanvas.SetActive(false);
        if(loseCanvas.activeSelf) loseCanvas.SetActive(false);
    }
    void Update()
    {
        textoVidas.text = "Vidas: " + vidas + "     coorectas:" + correctas;

        if(correctas>=objetivos)
        {
            Win();
        }
        if(vidas <= 0)
        {
            Lose();
        }
    }

    void Win()
    {
        winCanvas.SetActive(true);
    }
    void Lose()
    {
        loseCanvas.SetActive(true);
    }
}
