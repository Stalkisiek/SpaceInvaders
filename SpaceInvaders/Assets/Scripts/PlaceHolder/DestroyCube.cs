using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCube : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {       
            //Debug.Log(collision.collider.name);

        GameObject cube = collision.gameObject;

        if (collision.collider.name == "Cube(Clone)") {
            //GameObject player = cube.GetComponent<CubeMovement>().obj;
            //player.GetComponent<Spawner>().howManyShots--;
           // var colPlace = collision.contacts[0];
            //var position = colPlace.point;
            //var rotation = Quaternion.FromToRotation(Vector3.up, colPlace.normal);
            //Debug.Log(rotation);
            Destroy(cube);
        }
    }
}
