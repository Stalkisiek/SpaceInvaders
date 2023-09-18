using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundGoingAfter : MonoBehaviour
{
    public GameObject enemy;
    public GameObject soundSource; 
    private void FixedUpdate()
    {
        if(enemy != null)
            transform.position = enemy.GetComponent<Transform>().position;
        
    }
}
