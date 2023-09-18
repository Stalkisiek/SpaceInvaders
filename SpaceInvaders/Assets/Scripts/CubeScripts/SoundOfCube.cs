using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOfCube : MonoBehaviour
{
    public AudioSource fire;
    public void playFire(){
        fire.Play();
    }
}
