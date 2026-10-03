using System.Collections;
using UnityEngine;
using TMPro; // Usa TextMeshPro para el texto
using System;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager Instancia;


    public GameObject panelDialogo;
    public TextMeshProUGUI textoDialogo;
    public float velocidadEscritura = 0.05f;

    private string[] lineasActuales;
    private int indiceLinea;
    private bool escribiendo;
    private Action onDialogoTerminado;

    private void Awake()
    {
        if (Instancia == null) Instancia = this;
        else Destroy(gameObject);
    }

    public void IniciarDialogo(Dialogo dialogo, Action callbackFinal = null)
    {
        lineasActuales = dialogo.lineas;
        onDialogoTerminado = callbackFinal;
        indiceLinea = 0;
        
        panelDialogo.SetActive(true);
        StartCoroutine(EscribirLinea());
    }

    private void Update()
    {
        if (panelDialogo.activeInHierarchy && Input.GetMouseButtonDown(0))
        {
            if (escribiendo)
            {
                //dar clic salta al final
                StopAllCoroutines();
                textoDialogo.text = lineasActuales[indiceLinea];
                escribiendo = false;
            }
            else
            {
                SiguienteLinea();
            }
        }
    }

    private IEnumerator EscribirLinea()
    {
        escribiendo = true;
        textoDialogo.text = "";
        
        foreach (char letra in lineasActuales[indiceLinea].ToCharArray())
        {
            textoDialogo.text += letra;
            yield return new WaitForSeconds(velocidadEscritura);
        }
        
        escribiendo = false;
    }

    private void SiguienteLinea()
    {
        indiceLinea++;

        if (indiceLinea < lineasActuales.Length)
        {
            StartCoroutine(EscribirLinea());
        }
        else
        {
            panelDialogo.SetActive(false);
            //ejecuta codigo remoto
            onDialogoTerminado?.Invoke();
        }
    }
}