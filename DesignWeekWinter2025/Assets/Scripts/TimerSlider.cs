using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSlider : MonoBehaviour
{
    public Slider slider;

    public void SetMaxTimer(float maxTimer)
    {
        slider.maxValue = maxTimer;
        slider.value = 0f;
    }
    public void SetTime(float gameTime)
    {
        slider.value = gameTime;
    }
}
