using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    //public GameObject player;
    public TextMeshProUGUI timerText;
    public int totalSeconds = 12;

    private float elapsedTime = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        float timeRemaining = totalSeconds - elapsedTime;

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
