using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    //Singleton

    private static ScoreManager score_instance { get; set; }
    public static ScoreManager Score_instance { get { return score_instance; } }

    public int score = 0;

    void Awake()
    {
        score = 0;

        if (score_instance == null)
        {
            score_instance = this;
        }
    }

    public int Increase_Score(int goal)
    {
        return score += goal;
    }

}
