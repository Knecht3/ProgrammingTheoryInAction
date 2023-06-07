using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Cube : MonoBehaviour
{
    bool isClicked = false;
    [SerializeField] private float rotateSpeed = 6.0f;

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

    protected abstract void PlayMusic();

    protected abstract void StopMusic();

    protected virtual void Rotate(float rotateSpeed)
    {
        transform.Rotate(Vector3.forward, rotateSpeed);
    }
}
