using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class RedCube : Cube
{
    [SerializeField] private float rotateSpeedMultiplier = 2.0f;

    // POLYMORPHISM
    protected override void Rotate(float rotateSpeed)
    {
        base.Rotate(rotateSpeed * rotateSpeedMultiplier);
    }
}
