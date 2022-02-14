using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenaltyControl : MonoBehaviour
{
    private bool is_Penalty_Called = false;


    void Update()
    {
        if (ClockManager.Instance.clock_is_Starting == false)
        {
            if (is_Penalty_Called == false)
            {
                if (ClockManager.Instance.milliseconds >= 99)
                {
                    if (ClockManager.Instance.milliseconds < 100)
                    {
                        is_Penalty_Called = true;
                        EventTextControl.Instance.penalty_Text();
                    }
                }

                else if (ClockManager.Instance.milliseconds < 2)
                {
                    if (ClockManager.Instance.milliseconds >= 1)
                    {
                        is_Penalty_Called = true;
                        EventTextControl.Instance.penalty_Text();
                    }
                }
            }
        }

        else
        {
            is_Penalty_Called = false;
            EventTextControl.Instance.empty_Text();
        }
    }
}
