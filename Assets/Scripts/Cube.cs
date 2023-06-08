using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Cube : MonoBehaviour
{
    private bool isClicked = false;
    private AudioSource audioSource;
    public AudioClip audioClip;
    [SerializeField] private float rotateSpeed = 6.0f;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isClicked)
        {
            Rotate(rotateSpeed);
        }
        else
        {
            Rotate(0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isClicked)
        {
            isClicked = true;
            PlayMusic();
        }
        else
        {
            isClicked = false;
            StopMusic();
        }
    }

    void PlayMusic()
    {
        audioSource.PlayOneShot(audioClip, 1.0f);
    }

    void StopMusic()
    {
        audioSource.Stop();
    }

    protected virtual void Rotate(float rotateSpeed)
    {
        transform.Rotate(Vector3.forward, rotateSpeed);
    }
}
