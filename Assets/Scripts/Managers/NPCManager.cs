using UnityEngine;

public class NPCManager : MonoBehaviour
{
    public Transform[] NPCs;
    public Transform[] destinations;
    void Awake()
    {
        //esto no deberia estar en update ni de coña
        GameManager gm = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
        for (int i = 0; i < 4; i++)
        {
            if(gm.completados[i]) NPCs[i].position = destinations[i].position;
        }
    }
}
