using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableManager : MonoBehaviour
{
    public float TableSpeed = 90f;
    public float MaxRotationZ = 30f;
    public float MinRotationZ = -30f;


    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            RotateTable(-TableSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            RotateTable(TableSpeed);
        }
    }

    void RotateTable(float speed)
    {
        transform.Rotate(Vector3.forward, speed * Time.deltaTime);
        float currentRotationZ = transform.rotation.eulerAngles.z;

        // Restar 360 grados si el ángulo es mayor a 180
        if (currentRotationZ > 180f)
            currentRotationZ -= 360f;

        float clampedRotationZ = Mathf.Clamp(currentRotationZ, MinRotationZ, MaxRotationZ);

        Vector3 newRotation = transform.rotation.eulerAngles;
        newRotation.z = clampedRotationZ;

        transform.rotation = Quaternion.Euler(newRotation);

    }
}


