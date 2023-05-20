using UnityEngine;
[System.Serializable]
public class EventBox
{
    [Tooltip("Nombre de un evento que altera una parte de di�logo")]
    public string eventName;

    [Tooltip("Si el evento est� activado o no")]
    public bool activated;

    [Tooltip("Oldly es el que est� normal, mientras que Newly es el nuevo")]
    public TradeVar[] tradeVariables;
    
    [Tooltip("El di�logo que alteras")]
    public DialogPlane changeableLine;

}
