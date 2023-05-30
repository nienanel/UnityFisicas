using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    public float rotationSpeed = 30f;
    public Vector3 rotationAxis = Vector3.up;
    private void Update()
    {
        RotateCube();
    }
    void RotateCube()
    {
        float rotationAmount = rotationSpeed * Time.deltaTime;
        transform.Rotate(rotationAxis, rotationAmount);
    }
}
