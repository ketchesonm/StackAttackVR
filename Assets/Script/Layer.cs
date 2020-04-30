using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layer : MonoBehaviour
{


    public List<GameObject> childPlatforms;
    private LayerManager lm;
    public bool inLevel = false;
    

    // Start is called before the first frame update
    void Start()
    {
        lm = FindObjectOfType(typeof(LayerManager)) as LayerManager;
       
        //get all platforms
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            if (child.tag == "platform")
            {
                childPlatforms.Add(child.gameObject);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject getLayer()
    {
        return this.gameObject;
    }

    public void Toggle()
    {
        if (inLevel == false) {
            inLevel = true;
             foreach (GameObject GO in childPlatforms)
             {
                GO.SetActive(true);
             }
        }else if (inLevel == true)
        {
            inLevel = false;
            foreach (GameObject GO in childPlatforms)
            {
                GO.SetActive(false);
            }
        }

    }



}
