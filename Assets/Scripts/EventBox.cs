using UnityEngine;
[System.Serializable]
public class EventBox
{
    [Tooltip("Nombre de un evento que altera una parte de diálogo")]
    public string eventName;

    [Tooltip("Si el evento está activado o no")]
    public bool activated;

    [Tooltip("Oldly es el que está normal, mientras que Newly es el nuevo")]
    public TradeVar[] tradeVariables;
    
    [Tooltip("El diálogo que alteras")]
    public DialogPlane changeableLine;

}
