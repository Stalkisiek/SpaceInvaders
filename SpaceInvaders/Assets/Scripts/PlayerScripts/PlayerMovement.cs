using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    // Start is called before the first frame update
    public GameObject obj;
    public float speedPublic = 10f;
    public float speedRotationPublic = 80f;
    private float speed;
    private float speedRotation;

    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

        speed = speedPublic;
        speedRotation = speedRotationPublic;
        if (Input.GetAxis("Horizontal") * Input.GetAxis("Vertical") != 0) {
            //speed /= 2;
        }
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        }

        transform.Translate(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, speed * Input.GetAxis("Vertical") * Time.deltaTime);
        //transform.rotation = Quaternion.identity;

        if (Input.GetKey(KeyCode.Q)) {
            transform.Rotate(0f, -speedRotation * Time.deltaTime, 0f);
        }
        else if (Input.GetKey(KeyCode.E)) {
            transform.Rotate(0f, speedRotation * Time.deltaTime, 0f);
        }
        else {
            Rigidbody cc = obj.GetComponent<Rigidbody>();
            cc.constraints = RigidbodyConstraints.FreezeRotation;
        }

    }
}
