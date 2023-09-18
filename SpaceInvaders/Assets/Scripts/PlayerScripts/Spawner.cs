using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public Transform spawnPos;
    public float howLongToWait = 1f;
    public GameObject spawnWhat;
    public float speedAmmo = 10f;
    private float timer = 0f;
    private float seconds = 0;
    //public int howManyShots = 0;
    // Update is called once per frame
    void Update() {
        Vector3 where = new Vector3(0, 0, 5);
        // bez down w sumie œmieszny efekt
        if (Input.GetKeyDown(KeyCode.Space) && seconds >= howLongToWait) {
            Instantiate(spawnWhat, spawnPos.localPosition + transform.forward * 2, spawnPos.localRotation);
            //howManyShots++;
            timer = 0f;
        }
        timer += Time.deltaTime;
        seconds = timer % 60;
        
    }
}
