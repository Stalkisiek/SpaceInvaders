using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public GameObject obj;
    public GameObject cube;
    float speedAmmo;


    // Update is called once per frame


    private void Start() {
        if (cube.name != "Cube") {
            cube.GetComponent<SoundOfCube>().playFire();
        }
    }

    void Update()
    {
        speedAmmo = obj.GetComponent<Spawner>().speedAmmo;
        Vector3 localForward = transform.worldToLocalMatrix.MultiplyVector(transform.forward);
        transform.Translate((localForward / 300)*speedAmmo);  
        
    }
}
