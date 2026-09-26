using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public bool[] completados = [false, false, false, false];

    private void Awake()
    {
        // Patrón Singleton para evitar duplicados
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Persiste entre escenas
        }
        else
        {
            Destroy(gameObject);
        }
    }
}