/* SceneHandler.cs*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;

public class SceneHandler : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;
    private LayerManager lm;

    void Awake()
    {
        laserPointer.PointerIn += PointerInside;
        laserPointer.PointerOut += PointerOutside;
        laserPointer.PointerClick += PointerClick;
        lm = FindObjectOfType(typeof(LayerManager)) as LayerManager;

    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        Debug.Log("Click Registered");
        Debug.Log(e.target.name);
       // Debug.Log(e.target.name);
        if (e.target.CompareTag("LayerUI") && e.target.gameObject.GetComponent<LayerCard>() != null)
        {
            Debug.Log("target passed tests");
            e.target.gameObject.GetComponent<LayerCard>().getLayer().Toggle();
        
        }
    }

    public void PointerInside(object sender, PointerEventArgs e)
    {
        if (e.target.gameObject.tag == "LayerUI")
        {
            Debug.Log("Cube was entered");
        }
        else if (e.target.name == "Button")
        {
            Debug.Log("Button was entered");
        }
    }

    public void PointerOutside(object sender, PointerEventArgs e)
    {
        if (e.target.name == "Cube")
        {
            Debug.Log("Cube was exited");
        }
        else if (e.target.name == "Button")
        {
            Debug.Log("Button was exited");
        }
    }
}