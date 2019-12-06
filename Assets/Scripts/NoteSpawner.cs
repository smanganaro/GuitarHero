using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    public GameObject note;

     void Start()
    {
        Instantiate(note, transform.position, Quaternion.identity);
    }
}
