using UnityEngine;
using TMPro;
public class TextoObjetivos : MonoBehaviour
{
    public TMP_Text texto;
    public GameManager GM;
    void Update()
    {
        
        
        texto.text = "Minijuego 1 " + GM.completados[0] +
        "\n Minijuego 2 " + GM.completados[1] +
        "\n Minijuego 3 " + GM.completados[2] +
        "\n Minijuego 4 "+ GM.completados[3] ;
        
    }
    void Start()
    {
        GM = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
    }
}
