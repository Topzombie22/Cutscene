using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KamehamehaMove : MonoBehaviour
{
    public float ScrollX;
    public float ScrollY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float OffsetX = Time.time * ScrollX;
        float OffsetY = Time.time * ScrollY;

        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(OffsetX, OffsetY);
    }
}
