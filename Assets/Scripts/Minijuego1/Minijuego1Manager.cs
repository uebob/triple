using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Minijuego1Manager : MonoBehaviour
{
    public TextMeshProUGUI textoVidas;
    public int vidas = 3;

    void Start()
    {
        
    }


    void Update()
    {
        textoVidas.text = "Vidas: " + vidas;
    }
}
