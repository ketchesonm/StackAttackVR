using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerManager : MonoBehaviour
{

    Stack<Layer> LayerStack = new Stack<Layer>();
	Layer[] layers;

	// Start is called before the first frame update
	void Start()
    {
		layers = FindObjectsOfType(typeof(Layer)) as Layer[];

	}

    // Update is called once per frame
    void Update()
    {
        
    }

	public void AddToStack(Layer layer)
	{
		LayerStack.Push(layer);
		layer.Toggle();
		//layer.enable();
		
	}

	public void RemoveFromStack()
	{
		if (LayerStack.Count > 0)
		{
			Layer layer = LayerStack.Pop();
			layer.Toggle();
			
			//layer.inStack = false;
			//layer.Focus();
		}
	}
}
