using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

  public class ScoringSystem : MonoBehaviour
{
    public GameObject ScoreText;
    public static int theScore;
    void OnTriggerEnter(Collider other)
    {
        theScore += 1;
        ScoreText.GetComponent<Text>().text = "GEMS Collected " + theScore;
        Destroy(gameObject);
    }  
}
