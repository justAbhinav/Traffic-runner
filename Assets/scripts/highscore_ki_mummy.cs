using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscore_ki_mummy : MonoBehaviour
{
    public Text highScore;
    public Text currScore;

    void Start()
    {   
        if(PlayerPrefs.GetInt("highscore", 0)< PlayerPrefs.GetInt("score", 0))
        {
            PlayerPrefs.SetInt("highscore", PlayerPrefs.GetInt("score", 0));
        }
        highScore.text = PlayerPrefs.GetInt("highscore",0).ToString();
        currScore.text = PlayerPrefs.GetInt("score",0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
