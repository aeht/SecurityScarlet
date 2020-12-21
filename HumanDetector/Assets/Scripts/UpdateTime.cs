using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateTime : MonoBehaviour
{
    public Text timeDisplay; 
    public Text dateDisplay; 
    private int hour; 
    private int minutes;
    private int month;
    private int day;
    private int year; 
    // Start is called before the first frame update
    void Start()
    {
        month = System.DateTime.Now.Month;
        day   = System.DateTime.Now.Day; 
        year  = System.DateTime.Now.Year; 
        dateDisplay.GetComponent<Text>().text = "Date: " + month + "/" + day + "/" + year; 
    }

    // Update is called once per frame
    void Update()
    {
        hour = (System.DateTime.Now.Hour)-12; 
        minutes = System.DateTime.Now.Minute;
        timeDisplay.GetComponent<Text>().text = "Time: " + hour + ":" + minutes;
    }
}
