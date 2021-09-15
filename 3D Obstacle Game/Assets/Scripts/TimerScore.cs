using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScore : MonoBehaviour
{
    public static bool timer = false;
    public float Score;
    public Text ScoreText;

    public float scorePerSecond=1f;

    void Start()
    {
        StartTimer();
    }



    void Update()
    {
        if (timer)
        {
            Score += scorePerSecond * Time.deltaTime;

        }

        ScoreText.text = "SCORE: " + Mathf.Round(Score);
    }

    void StartTimer()
    {
        timer = true;
    }

    
}
