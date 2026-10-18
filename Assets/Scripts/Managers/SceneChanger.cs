using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    
    public string[] MinigameSceneNames;

    public void ChangeToMinigame(int i)
    {
        SceneManager.LoadScene(MinigameSceneNames[i-1]);
    }
    public void ReturnScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    
}
