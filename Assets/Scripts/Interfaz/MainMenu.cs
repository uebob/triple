using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        gameObject.GetComponent<SceneChanger>().ChangeScene("IntroScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
