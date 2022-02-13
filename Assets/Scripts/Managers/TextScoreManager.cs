using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI score_Text;

    void Update()
    {
        score_Text.text = ScoreManager.Score_instance.score.ToString();
        //score_Text.text = FindObjectOfType<ScoreManager>().score.ToString();
    }
}
