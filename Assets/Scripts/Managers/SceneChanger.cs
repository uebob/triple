using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class SceneChanger : MonoBehaviour
{
    public string[] MinigameSceneNames;

    public void ChangeScene(string name)
    {
        StartCoroutine(Change(name));
    }
    public void ChangeToMinigame(int i)
    {
        StartCoroutine(Change(MinigameSceneNames[i-1]));
    }
    public void ReturnScene()
    {
        StartCoroutine(Change("SampleScene"));
    }

    IEnumerator Change(string scene)
    {
        GameObject.FindWithTag("SceneFader").GetComponent<ScreenFader>().FadeIn(1);
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(scene);
    }
}
