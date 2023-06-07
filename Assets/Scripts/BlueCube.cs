using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCube : Cube
{
    private AudioSource audioSource;
    public AudioClip audioClip;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    protected override void PlayMusic()
    {
        audioSource.PlayOneShot(audioClip, 1.0f);
    }

    protected override void StopMusic()
    {
        audioSource.Stop();
    }
}