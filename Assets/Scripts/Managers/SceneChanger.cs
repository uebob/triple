using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    
    public string[] MinigameSceneNames;

    public void ChangeScene()
    {
        SceneManager.LoadScene(MinigameSceneNames[0]);
    }
    public void ChangeScene2()
    {
        SceneManager.LoadScene(MinigameSceneNames[1]);
    }

    public void ReturnScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    
}
