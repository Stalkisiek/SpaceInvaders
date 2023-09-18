using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOfDeath : MonoBehaviour
{
    public AudioSource death;
    public void playDeathSound() {
        death.Play();
    }
}
