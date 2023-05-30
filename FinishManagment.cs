using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishManagment : MonoBehaviour
{
    public Text gameOverText;
    public PointsUI pointsUI;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            gameOverText.text = "Game Over\nTotal Points: " + pointsUI.pointsCount.text;
            print("Total Score: " + pointsUI.pointsCount.text);
        }
    }
}
