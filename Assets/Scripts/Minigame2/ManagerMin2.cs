using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class ManagerMin2 : MonoBehaviour
{
    public TextMeshProUGUI textoNaranjas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int naranjas = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textoNaranjas.text = "Naranjas: "+ naranjas + "/15";
    }
}
