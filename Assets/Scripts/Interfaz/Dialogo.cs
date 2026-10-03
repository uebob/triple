using UnityEngine;

[CreateAssetMenu(fileName = "NuevoDialogo", menuName = "Sistema de Dialogos/Dialogo")]
public class Dialogo : ScriptableObject
{
    [TextArea(3, 10)]
    public string[] lineas;
}