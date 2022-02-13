using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip shoot;
    public AudioClip hit;
    public AudioClip danger;
    public AudioClip death;
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
    public void lastChance()
    {
        audioSource.PlayOneShot(danger);
    }
    public void deaTh()
    {
        audioSource.PlayOneShot(death);
    }
}

