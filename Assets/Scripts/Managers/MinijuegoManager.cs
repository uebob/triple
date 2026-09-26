using UnityEngine;

public class MinijuegoManager : MonoBehaviour
{
     
    public GameManager GM;

    void Start()
    {
        GM = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
    }
    public void CompletarMinijuego(int i)
    {
        GM.completados[i] = true;
        Debug.Log(GM.completados[i]);
    }
}
