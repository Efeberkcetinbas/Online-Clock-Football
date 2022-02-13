using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClockManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI clock_Text;

    private static ClockManager instance { get; set; }
    public static ClockManager Instance { get { return instance; } }

    //public olmalı başka class'ta golleri kontrol edeceğim.
    public float minutes, seconds = 0, milliseconds;

    public bool clock_is_Starting;

    void Start()
    {
        clock_is_Starting = true;
    }

    void Update()
    {
        Clock_Control();
    }

    void Clock_Control()
    {
        if (clock_is_Starting)
        {
            if (milliseconds > 100)
            {
                if (seconds >= 60)
                {
                    minutes++;
                    seconds = 0;
                }
                else if (seconds < 60)
                {
                    seconds++;
                }
                milliseconds = 0;
            }
            milliseconds += Time.deltaTime * 75;
        }

        clock_Text.text = string.Format("{0}:{1}:{2}", minutes, seconds, (int)milliseconds); 
    }

    public void Clock_Change()
    {
        clock_is_Starting = !clock_is_Starting;
    }
}
