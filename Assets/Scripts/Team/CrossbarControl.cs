using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossbarControl : MonoBehaviour
{

    private bool is_crossbar_Called = false;


    void Update()
    {
        if (ClockManager.Instance.clock_is_Starting == false)
        {
            if (is_crossbar_Called == false)
            {
                if (ClockManager.Instance.milliseconds < 99)
                {
                    if (ClockManager.Instance.milliseconds >= 98)
                    {
                        is_crossbar_Called = true;
                        EventTextControl.Instance.crossbar_Text();
                    }
                }
            }
        }

        else
        {
            is_crossbar_Called = false;
            EventTextControl.Instance.empty_Text();
        }
    }
}
