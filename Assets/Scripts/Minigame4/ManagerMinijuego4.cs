using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;
public class ManagerMinijuego4 : MonoBehaviour
{
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool cocinado = false;

    public GameObject winCanvas;

    public GameObject loseCanvas;

    public GameObject botonRemover;

    public GameObject botonSacar;
    public int removerDelay = 3;

    public GameObject patatas;

    void Start()
    {
        if(winCanvas.activeSelf) winCanvas.SetActive(false);
        if(loseCanvas.activeSelf) loseCanvas.SetActive(false);

         if(!botonSacar.activeSelf) botonSacar.SetActive(true);
        if(botonRemover.activeSelf) botonRemover.SetActive(false);

        StartCoroutine(RemoverCount());
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void Win()
    {
        winCanvas.SetActive(true);
    }
    void Lose()
    {
        loseCanvas.SetActive(true);
    }

    public void Sacar()
    {
        if (cocinado)
        {
           Win(); 
        }
        else
        {
            Lose();
        }
    }

    IEnumerator RemoverCount()
    {
       
        yield return new WaitForSeconds(removerDelay);
        botonSacar.SetActive(false);
        botonRemover.SetActive(true);
        
    }
    public IEnumerator CorutinaRemover()
    {
        botonRemover.SetActive(false);
        patatas.GetComponent<Patatas>().removerPatatas();
       yield return new WaitForSeconds(2);
        botonSacar.SetActive(true);
        StartCoroutine(RemoverCount());
    }

    public void Remover()
    {
        StartCoroutine(CorutinaRemover());
    }
}
