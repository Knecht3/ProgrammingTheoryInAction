using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider), typeof(Rigidbody))]

public class Click : MonoBehaviour
{
    bool isClicked = false;
    private SphereCollider sphereCollider;
    private Camera cam;
    private Vector3 mousePos;
    [SerializeField] private float offset = 1.0f;

    private void Awake()
    {
        sphereCollider = GetComponent<SphereCollider>();
        cam = Camera.main;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isClicked = true;
            UpdateComponent();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isClicked = false;
            UpdateComponent();
        }

        if (isClicked)
        {
            UpdateMousePosition();
        }
    }

    void UpdateComponent()
    {
        sphereCollider.enabled = isClicked;
    }

    void UpdateMousePosition()
    {
        mousePos = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, offset));
        transform.position = mousePos;
    }
}
