using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemysCount : MonoBehaviour
{
    public TMP_Text enemyCount;
    public GameObject player;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        enemyCount.text = player.GetComponent<Stats>().howManyEnemys.ToString();

    }
}
