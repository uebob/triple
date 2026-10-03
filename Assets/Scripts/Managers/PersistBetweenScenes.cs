using UnityEngine;

public class PersistBetweenScenes : MonoBehaviour
{
    public static PersistBetweenScenes Instance;

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
