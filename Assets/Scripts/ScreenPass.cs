using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenPass : MonoBehaviour
{
    public GameObject dialogBase;
    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextScreenUp()
    {
        Vector3 goner = transform.position;
        goner.y += distance;
        transform.position = goner;
    }
    public void NextScreenDown()
    {
        Vector3 goner = transform.position;
        goner.y -= distance;
        transform.position = goner;
    }
    public void NextScreenRight()
    {
        Vector3 goner = transform.position;
        goner.x += distance;
        transform.position = goner;
    }
    public void NextScreenLeft()
    {
        Vector3 goner = transform.position;
        goner.x -= distance;
        transform.position = goner;
    }
}
