using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EventTextControl : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI eventText;

    static EventTextControl instance { get; set; }

    public static EventTextControl Instance { get { return instance; } }

    void Start()
    {
        eventText.text = "";

        if (instance == null)
        {
            instance = this;
        }
    }

    public string empty_Text()
    {
        return eventText.text = "";
    }

    public string goal_Text()
    {
        return eventText.text = "GOALL";
    }

    public string crossbar_Text()
    {
        return eventText.text = "CROSSBAR";
    }

    public string penalty_Text()
    {
        return eventText.text = "PENALTY";
    }
}
