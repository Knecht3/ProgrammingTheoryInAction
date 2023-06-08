using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class GreenCube : Cube
{
    [SerializeField] private float rotateSpeedMultiplier = 0.5f;

    // POLYMORPHISM
    protected override void Rotate(float rotateSpeed)
    {
        base.Rotate(rotateSpeed * rotateSpeedMultiplier);
    }
}
