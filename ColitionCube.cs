using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColitionCube : MonoBehaviour
{
    private PointsUI pointsUI;
    private void Start()
    {
        pointsUI = FindObjectOfType<PointsUI>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("CubeGreen"))
        {
            Destroy(collision.gameObject);
            pointsUI.Count += 10;

        }
        else if (collision.gameObject.CompareTag("CubeRed"))
        {
            Destroy(collision.gameObject);
            pointsUI.Count -= 20;

        }
    }
}

