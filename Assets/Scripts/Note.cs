using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
   	public KeyCode key;
   	//public GameObject effect;
   	public float speed;
   	public string myTag;
   	public bool triggerEntered = false;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if(triggerEntered){
        	if(Input.GetKeyDown(key)){
	        	//Instantiate(effect, transform.position, Quaternion.identity);
	            Destroy(gameObject);
        	}	
        }
        
    }

   	private void OnTriggerEnter2D(Collider2D other)
    {
    	Debug.Log("Hello");

    	triggerEntered = true;

    }

    private void OnTriggerExit2D(){
    	triggerEntered = false;
    }
    
}
