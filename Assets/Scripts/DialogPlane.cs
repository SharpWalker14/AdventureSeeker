using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "TextObject")]
public class DialogPlane : ScriptableObject
{
    [TextArea(3, 15)]
    public string narrativeText;

    [Space(20)]
    public string[] alternative;

    [Space(20)]
    [Tooltip("alternative misma que arrayReferences, si no hay alternative el arrayReferences debe ser 1, pero si termina, arrayReferences es a 0")]
    public int[] arrayReferences;

    [Space(20)]
    [Tooltip("Eso hará que se cambie de Font del diálogo, un font diferente significa que es el protagonista")]
    public bool protagonist;

    [Space(20)]
    [Tooltip("El dialogEnd solo se pone cuando alternative es 0, y sirve para finalizar una conversación")]
    public bool dialogEnd;

    [Tooltip("El personaje que está hablando")]
    public Sprite personWho;

}
