using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoPlay : MonoBehaviour
{
    public void startGame() {
        SceneManager.LoadScene("Level 1");
    }
}
