using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhenReturn : MonoBehaviour
{

    public GameObject which; 

    public bool ifReturn = false;

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "Wall") {
            Physics.IgnoreCollision(collision.collider, which.GetComponent<BoxCollider>());
        }
        if (collision.gameObject.name == "Enemy" || collision.gameObject.name == "ConstrainsLeft" || collision.gameObject.name == "ConstrainsRight") {
            //Physics.IgnoreCollision(collision.collider, which.GetComponent<BoxCollider>());
            ifReturn = true;
            //Debug.Log(123);
        }
        
    }

    private void OnCollisionStay(Collision collision) {
        if (collision.gameObject.name == "Wall" ) {
            Physics.IgnoreCollision(collision.collider, which.GetComponent<BoxCollider>());
        }
        //Debug.Log(123);
        if (collision.gameObject.name == "Enemy" || collision.gameObject.name == "ConstrainsLeft" || collision.gameObject.name == "ConstrainsRight") {
            //Physics.IgnoreCollision(collision.collider, which.GetComponent<BoxCollider>());
            ifReturn = true;
        }

    }

}

