using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{

    /*
     Genel Game Manager'da bool tanımla.
     Oyun Başladığında yani iki oyuncu da start'a bastığında Timer'ı bu bool ile çalıştır.
         */

    [SerializeField] private float timer;

    [SerializeField] private TextMeshProUGUI timer_Text;




    void Update()
    {
        timer -= Time.deltaTime;
        timer_Text.text = Mathf.FloorToInt(timer).ToString();
    }
}
