using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeNow : MonoBehaviour
{
    public Text TextOfTime; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextOfTime.text = DateTime.Now.ToString("t");
    }
}
