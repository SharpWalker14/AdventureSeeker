using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventDialogs : MonoBehaviour
{
    [SerializeField] EventBox[] events;
    // Update is called once per frame
    void Update()
    {
        ChockerEvents();
    }

    void ChockerEvents()
    {
        if (events[0].activated && events[0].changeableLine.arrayReferences[0] != events[0].tradeVariables[0].newly)
        {
            events[0].changeableLine.arrayReferences[0] = events[0].tradeVariables[0].newly;
        }
        else if(!events[0].activated && events[0].changeableLine.arrayReferences[0] != events[0].tradeVariables[0].oldly)
        {
            events[0].changeableLine.arrayReferences[0] = events[0].tradeVariables[0].oldly;
        }
    }
}
