using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsUI : MonoBehaviour
{
    public Text pointsCount;
    private int count2;

    public int Count
    {
        get { return count2; }
        set
        {
            count2 = value;
            CountRefresh();
        }
    }

    private void Start()
    {
        Count = 0;
        CountRefresh();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("CubeGreen"))
        {
            Count += 10;
            CountRefresh();
        }
        else if (collision.gameObject.CompareTag("CubeRed"))
        {
            Count -= 20;
            CountRefresh();
        }
    }
    private void CountRefresh()
    {
        pointsCount.text = "points: " + Count.ToString();
    }
}