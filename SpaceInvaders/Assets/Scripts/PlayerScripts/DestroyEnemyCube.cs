using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemyCube : MonoBehaviour
{
    public GameObject player;
    public GameObject obj;

    private void OnCollisionEnter(Collision collision) {

        //Debug.Log(collision.collider.name);

        GameObject cube = collision.gameObject;
        if (collision.collider.name == "CubeEnemy(Clone)") {
            player.GetComponent<SoundOfDeath>().playDeathSound();
            player.GetComponent<Stats>().health--;
            //Debug.Log(player.GetComponent<Stats>().health);
            Destroy(cube);
        }
    }
}
