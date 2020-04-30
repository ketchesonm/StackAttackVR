using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerCard : MonoBehaviour
{
    public Layer correspondingLayer;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.tag = "LayerUI";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Layer getLayer()
    {
        return correspondingLayer;
    }
}
