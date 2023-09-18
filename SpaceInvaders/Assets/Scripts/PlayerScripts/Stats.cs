using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stats : MonoBehaviour
{
    public int health = 3;
    public int howManyEnemys = 4;
    public int afterHowManyHitsDeath = 2;

    private void Update() {
        if(health <= 0) {
            SceneManager.LoadScene("LostScreen");
        }
        else if(howManyEnemys <= 0 && SceneManager.GetActiveScene().name != "Level 3") {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if(howManyEnemys <= 0 && SceneManager.GetActiveScene().name == "Level 3") {
            SceneManager.LoadScene("WonGameScreen");
        }
    }

}
