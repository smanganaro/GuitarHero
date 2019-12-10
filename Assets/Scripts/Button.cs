using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

	public KeyCode key;

	public GameObject effect;

	private SpriteRenderer[] lightSprite;

	private Transform buttonLight;

	private bool triggerEntered = false;
   	
   	private GameObject currentNote;


   	void Start(){

		lightSprite = GetComponentsInChildren<SpriteRenderer>();
   		/*buttonLight = this.transform.Find("ButtonLight");
   		if (buttonLight != null){
   			lightSprite = buttonLight.GetComponent<SpriteRenderer>(); 
   		}*/
   	}

    // Update is called once per frame
    void Update()
    {
    	if(Input.GetKeyDown(key)){
        	if(triggerEntered){
        	   	Instantiate(effect, transform.position, Quaternion.identity);
	            Destroy(currentNote);
        	}else{
        		StartCoroutine( missingNote() );
        	}	
        }       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
    	triggerEntered = true;
    	currentNote = other.gameObject;
    }

    private void OnTriggerExit2D(){
    	triggerEntered = false;
    	currentNote = null;
    }


	private IEnumerator missingNote(){
		lightSprite[1].color = Color.red;
		yield return new WaitForSeconds(0.5f);
		lightSprite[1].color = Color.white;
	}

}
