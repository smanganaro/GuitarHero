using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

	public KeyCode key;

	public GameObject effect;

	private SpriteRenderer buttonLight;

	private bool triggerEntered = false;
   	
   	private GameObject currentNote;


   	void Start(){

   		//buttonLight = GetComponentInChildren<SpriteRenderer>();
   	}

    // Update is called once per frame
    void Update()
    {
    	if(Input.GetKeyDown(key)){
        	if(triggerEntered){
        	   	Instantiate(effect, transform.position, Quaternion.identity);
	            Destroy(currentNote);
        	}else{
        		//buttonLight.color = Color.red;
        	}	
        }
        //buttonLight.color = Color.white;
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
