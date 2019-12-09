using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
	//public GameObject effect;
	public KeyCode key;
	private bool triggerEntered = false;
   	
   	private GameObject currentNote;

    // Update is called once per frame
    void Update()
    {
        if(triggerEntered){
        	if(Input.GetKeyDown(key)){
	        	//Instantiate(effect, transform.position, Quaternion.identity);
	            Destroy(currentNote);
        	}	
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
    	Debug.Log("Hello");

    	triggerEntered = true;
    	currentNote = other.gameObject;

    }

    private void OnTriggerExit2D(){
    	triggerEntered = false;
    	currentNote = null;
    }
}
