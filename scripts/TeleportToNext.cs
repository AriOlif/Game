using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TeleportToNext : MonoBehaviour
{
    private float CountDown = 120000;

   
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-0.27f, 0, -10);
    }

    // Update is called once per frame
    void Update()
    {
        CountDown -= 1;
        
        if(CountDown <= 0)
        {
            transform.position = new Vector3(-59, 53, -10);
        }

       
        /*if(Boat.instance.BoatClick >= 10)
        {
             transform.position = new Vector3(-59, 53, -10);
        }*/
    }

     /*void DisplayTime (float timeToDisplay){
            timeToDisplay -=1;
            float minutes = Mathf.FloorToInt(timeToDisplay / 60);
            float seconds = Mathf.FloorToInt(timeToDisplay % 60);
            timeText.text = string.Format("0:00 : 2:00", minutes, seconds);
        }*/
}
