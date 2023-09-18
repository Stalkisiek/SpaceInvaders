using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speedEnemy = 5f;
    public GameObject leftRest;
    public GameObject rightRest;
    public GameObject obj;


    private int whereMove = -1;
    // -1 - left; 1 - right
    private void Start() {
         whereMove = Random.Range(0, 2) * 2 - 1;
    }
    private void Update() {
        bool ifReturnLeft = leftRest.GetComponent<WhenReturn>().ifReturn;
        bool ifReturnRight = rightRest.GetComponent<WhenReturn>().ifReturn;
        if (whereMove == -1 && ifReturnLeft == true) {
            whereMove = 1;
            leftRest.GetComponent<WhenReturn>().ifReturn = false;
        }

        else if (whereMove == 1 && ifReturnRight== true) {
            whereMove = -1;
            rightRest.GetComponent<WhenReturn>().ifReturn = false;
        }
        //
        if (transform.position.x >= 20f && whereMove == 1) {
            whereMove = -1;
        }
        else if(transform.position.x <= 0f && whereMove == -1){
            whereMove = 1;
        }
        transform.Translate(Time.deltaTime * (speedEnemy / 2) * whereMove, 0f, 0f);
        Rigidbody cc = obj.GetComponent<Rigidbody>();
            cc.constraints = RigidbodyConstraints.FreezeRotation;
        //obj.transform.position = new Vector3(obj.transform.position.x, 2f, obj.transform.position.z);
    }
}
