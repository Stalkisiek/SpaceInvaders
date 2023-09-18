using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToSettings : MonoBehaviour
{
    // Start is called before the first frame update
    public void settingsMenu() {
        SceneManager.LoadScene("SettingsMenu");
    }
}
