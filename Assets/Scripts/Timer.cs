using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    //public GameObject player;
    public TextMeshProUGUI timerText;
    public int totalSeconds = 12;

    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float timeRemaining = totalSeconds - Time.time - startTime;

        if (timeRemaining <= 0)
        {
            //GameObject.Find("Player").SendMessage("NoMoreTime");
            //player.SendMessage("NoMoreTime");
            GameObject.FindObjectOfType<PlayerController>().NoMoreTime();
        }
        else
        {
            string seconds = (timeRemaining % 60).ToString("f1");
            timerText.SetText(seconds);
        }        
    }

}
