using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCubeMovement : MonoBehaviour
{
    public GameObject obj;
    public GameObject player;
    public GameObject cube;
    float speedAmmo;
    

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.name == "Enemy") {
            Physics.IgnoreCollision(collision.collider, cube.GetComponent<BoxCollider>());
        }
    }

    private void Start() {
        if (cube.name != "CubeEnemy") {
            cube.GetComponent<SoundOfCube>().playFire();
        }
    }

    void Update() {
        speedAmmo = player.GetComponent<Spawner>().speedAmmo;
        Vector3 localForward = transform.worldToLocalMatrix.MultiplyVector(transform.forward);
        transform.Translate((-localForward / 300) * speedAmmo);

    }
}
