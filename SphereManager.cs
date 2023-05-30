using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereManager : MonoBehaviour
{
    private int count = 0;
    public Text pointsCount;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("CubeGreen"))
        {
            count += 10;
            pointsCount.text = "Points: " + count.ToString();
        }
        if (collision.gameObject.CompareTag("CubeRed"))
        {
            count -= 20;
            pointsCount.text = "Points: " + count.ToString();
        }
    }
}

