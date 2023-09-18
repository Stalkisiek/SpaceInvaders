
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoting : MonoBehaviour
{

    public GameObject enemy;
    public GameObject spawnWhat;
    public GameObject boobies;

    public float speedAmmo = 10f;
    private float timer = 0f;
    private float seconds = 0;
    private int ifShoot = 0;
    private float rateOfFire;
    

    //public int howManyShots = 0;
    // Update is called once per frame
    private void FixedUpdate() {
        rateOfFire = boobies.GetComponent<PlaceHolder>().rateOfEnemyFire;
        ifShoot = Random.Range(0, 2000/(int)rateOfFire);
    }

    void Update() {
        Vector3 where = new Vector3(-1, 0, -6);
        
        if (ifShoot == 11 && seconds >= 0.5f ) {
            
            Instantiate(spawnWhat, enemy.transform.position + transform.forward * -2 , enemy.transform.rotation);
            //howManyShots++;
            timer = 0f;
        }
        timer += Time.deltaTime;
        seconds = timer % 60;

    }
}
