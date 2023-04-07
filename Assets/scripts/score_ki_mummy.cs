using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_ki_mummy : MonoBehaviour
{
    public Text scoreText;

    public int score = 0;
    void Start()
    {
        scoreText.text = score.ToString();
        InvokeRepeating("AddPoint", 0, 1.0f);
    }

    
    public void AddPoint()
    {
        score++;   
        scoreText.text = score.ToString();

        PlayerPrefs.SetInt("randScore", score);
    }
}
