using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        // Amount of time since the timer started
        float t = Time.time - startTime;

        // Minutes and seconds in the timer, f0 stands for how many decimals.
        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60).ToString("f0");

        // Timer text that shows up in the game
        timerText.text = minutes + ":" + seconds;
    }
}
