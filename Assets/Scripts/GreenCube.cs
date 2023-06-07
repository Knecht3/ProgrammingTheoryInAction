using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCube : Cube
{
    private AudioSource audioSource;
    public AudioClip audioClip;
    [SerializeField] private float rotateSpeedMultiplier = 0.5f;

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

    protected override void Rotate(float rotateSpeed)
    {
        base.Rotate(rotateSpeed * rotateSpeedMultiplier);
    }
}
