using Scenes.Brick_Breaker_2._Scripts;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    //tutorial: https://youtu.be/POq1i8FyRyQ?feature=shared
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;

    //
    void Update()
    {
        //decreases the time left by 1 second every second
        if(remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        // reloads game when timer reaches 0
        else if(remainingTime < 0)
        {
            remainingTime = 0;
            SceneManager.LoadScene("Ball Game");
        }

        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
