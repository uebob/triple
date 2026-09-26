using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string[] MinigameSceneNames;

    public void ChangeScene()
    {
        SceneManager.LoadScene(MinigameSceneNames[0]);
    }
}
