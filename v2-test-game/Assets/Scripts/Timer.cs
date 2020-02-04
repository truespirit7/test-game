using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public Text timerText;
    public float timeStartSeconds = 30f;
    private int timeStartMinutes = 0;
    private float timeInSeconds;
    public float addTime; 
    public void AdditionalTime() 
    {
        timeStartSeconds += 30f;
    }
    // Start is called before the first frame update
    void Start()
    {
        timerText.text = timeStartMinutes.ToString() + ":" + Mathf.Round(timeInSeconds).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timeStartMinutes = (int)timeStartSeconds / 60;
        timeInSeconds = timeStartSeconds - (timeStartMinutes * 60);
        if (timeStartSeconds>=0)
        {
            timeStartSeconds -= Time.deltaTime;
        }
            timerText.text = timeStartMinutes.ToString() + ":" + Mathf.Round(timeInSeconds).ToString();

    }
}
