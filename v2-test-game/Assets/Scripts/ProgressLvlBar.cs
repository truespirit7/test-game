﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressLvlBar : MonoBehaviour
{
    public Image bar;
    public float fill;
    // Start is called before the first frame update
    void Start()
    {
        fill = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        bar.fillAmount = fill;
    }
}
