using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartDialogueOnSecondsAfterLoad : MonoBehaviour
{
    [SerializeField] float seconds;
    [SerializeField] Dialogo dialogo;
    [SerializeField] string nombre;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(StartDialogue(seconds));
    }

    IEnumerator StartDialogue(float sec)
    {
        yield return new WaitForSeconds(sec);
        DialogueManager.Instancia.IniciarDialogo(dialogo, nombre, AccionesAlTerminar);
    }

    void AccionesAlTerminar()
    {
        GameObject.FindWithTag("GameManager").GetComponent<SceneChanger>().ChangeScene("SampleScene");
    }
}
