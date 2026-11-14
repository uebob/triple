using UnityEngine;

public class HoverScaling : MonoBehaviour
{
    [SerializeField] private float hoverScale = 1.2f;
    [SerializeField] private float speed = 10f;

    private Vector3 originalScale;
    private Vector3 targetScale;

    void Start()
    {
        originalScale = transform.localScale;
        targetScale = originalScale;
    }

    void Update()
    {
        if(DialogueManager.Instancia.isOnDialogue) return;
        transform.localScale = Vector3.Lerp(transform.localScale, targetScale, Time.deltaTime * speed);
    }

    void OnMouseEnter()
    {
        targetScale = originalScale * hoverScale;
    }

    void OnMouseExit()
    {
        targetScale = originalScale;
    }
}