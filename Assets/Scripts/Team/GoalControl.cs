using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalControl : MonoBehaviour
{

    private ClockManager clockManager;

    void Start()
    {
        clockManager = FindObjectOfType<ClockManager>();
    }

    void Update()
    {
        /*
         Saati durdurduğumda kontrol etmesi gerekli.
         */
        if (clockManager.clock_is_Starting == false)
        {
            if (clockManager.milliseconds >= 0)
            {

                if (clockManager.milliseconds < 1)
                {
                    Debug.Log("GOALLL");
                    //FindObjectOfType<ScoreManager>().Increase_Score(1);
                    
                    ScoreManager.Score_instance.Increase_Score(1);
                }
            }
        }
    }
}
