using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalControl : MonoBehaviour
{

    private ClockManager clockManager;

    private bool goal_is_called=false;

    void Start()
    {
        clockManager = FindObjectOfType<ClockManager>();
    }

    void Update()
    {
        /*
         Saati durdurduğumda kontrol etmesi gerekli.
         Gol durumlarını burada kontrol ediyorum. 0-1 100-101 arası gibi.
         */
        if (clockManager.clock_is_Starting == false)
        {
            //Gol durumuna bakıyor. True döndürerek sadece 1 kez çalışmasını sağlıyor.
            if (goal_is_called == false)
            {
                if (clockManager.milliseconds < 1)
                {
                    if (clockManager.milliseconds >= 0)
                    {
                        EventTextControl.Instance.goal_Text();
                        goal_is_called = true;
                        Debug.Log("GOALLL");
                        //FindObjectOfType<ScoreManager>().Increase_Score(1);

                        ScoreManager.Score_instance.Increase_Score(1);
                    }
                }

                else if (clockManager.milliseconds < 101)
                {
                    if (clockManager.milliseconds >= 100)
                    {
                        EventTextControl.Instance.goal_Text();
                        goal_is_called = true;
                        Debug.Log(clockManager.milliseconds);
                        //FindObjectOfType<ScoreManager>().Increase_Score(1);

                        ScoreManager.Score_instance.Increase_Score(1);
                    }
                }

                else
                {

                }
            }
        }
        else
        {
            goal_is_called = false;
            EventTextControl.Instance.empty_Text();

        }
    }
}
