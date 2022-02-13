using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound_E : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip shoot;
    public AudioClip hit;
    private void Awake()
    {
        audioSource.volume = 0.07f;
        audioSource.playOnAwake = false;
    }
    public void Shoot()
    {
        audioSource.PlayOneShot(shoot);
    }
    public void hitt()
    {
        audioSource.PlayOneShot(hit);
    }
}
