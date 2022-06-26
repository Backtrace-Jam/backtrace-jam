using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int scoreValue = 1;
 
    private void OnTriggerEnter(Collider other)     
    {
        if (other.gameObject.CompareTag("Plane"))
        {
            ScoreManager.instance.ChangeScore(scoreValue);
            //text.text = "100 + ";
           
           
        }
    }
}