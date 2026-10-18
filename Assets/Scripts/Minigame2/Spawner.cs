using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] prefabs = new GameObject[3];

    public float alturaFijaY = 5.0f;
    
    public float minX = -10.0f;
    
    public float maxX = 10.0f;
    
    public float posicionZ = 0.0f;
    private int timer = 0;

    public int timerLimit = 40;
    void FixedUpdate()
    {
        timer++;
        if (timer > timerLimit)
        {
            SpawnearObjetos();
            timer = 0;
        }
        
    }

    void SpawnearObjetos()
    {
        
        int i = Random.Range(0, 3);
            if (prefabs[i] != null)
            {
                // Generar una posición X aleatoria para cada objeto
                float xAleatoria = Random.Range(minX, maxX);
                Vector3 posicionSpawn = new Vector3(xAleatoria, alturaFijaY, posicionZ);

                // Crear el objeto en la escena
                Instantiate(prefabs[i], posicionSpawn, Quaternion.identity);
            }
        
    }
}
