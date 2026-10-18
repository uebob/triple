using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class ManagerMin2 : MonoBehaviour
{
    public TextMeshProUGUI textoNaranjas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int naranjas = 0;

    public GameObject winCanvas;
    void Start()
    {
        if(winCanvas.activeSelf) winCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        textoNaranjas.text = "Naranjas: "+ naranjas + "/15";
        if (naranjas >= 15)
        {
            Win();
        }
    }

    void Win()
    {
        winCanvas.SetActive(true);
    }
}
