using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private const int MAX_NOTES = 5;
	private float timeBtwSpawns;
    public float startTimeBtwSpawns;
    public float timeDecrease;
    public float minTime;	

    public GameObject[] noteTemplate;

    // Start is called before the first frame update
    void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;
    }


    // Update is called once per frame
    void Update()
    {
        if (timeBtwSpawns <= 0)
        {
            int rand = Random.Range(0, MAX_NOTES);
            Instantiate(noteTemplate[rand], noteTemplate[rand].transform.position, Quaternion.identity);
            timeBtwSpawns = startTimeBtwSpawns;
            if (startTimeBtwSpawns > minTime) {
                startTimeBtwSpawns -= timeDecrease;
            }
        }
        else {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
}
