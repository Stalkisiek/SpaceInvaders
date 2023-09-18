using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public GameObject particleSystemDeath;
    private int howManyHits = 0;
    private void OnCollisionEnter(Collision collision) {

        GameObject cube = collision.gameObject;
        if (cube.name == "Cube(Clone)") {
            //Debug.Log(123);
            howManyHits++;
            //GameObject player = cube.GetComponent<CubeMovement>().obj;
            //player.GetComponent<Spawner>().howManyShots--;
            enemy.GetComponent<SoundOfDeath>().playDeathSound();
            Destroy(cube);
        }

        if (howManyHits >= player.GetComponent<Stats>().afterHowManyHitsDeath) {
            enemy.GetComponent<SoundOfDeath>().playDeathSound();
            var colPlace = collision.contacts[0];
            var position = colPlace.point;
            Instantiate(particleSystemDeath, position, Quaternion.identity);
            player.GetComponent<Stats>().howManyEnemys--;
            Destroy(enemy);
        }
        if (cube.name == "Cube(Clone)") {
            Destroy(cube);
        }
    }
}
