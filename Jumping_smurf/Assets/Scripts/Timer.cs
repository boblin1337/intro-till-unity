using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


/// <summary>
/// Här är min timer class. Detta gör så att när spelet börjar så går tiden igång och räknar uppåt.
/// Man kan även välja vilken typ av siffra man vill ha. 
/// Samt när man når slutet så stannar tiden och man ser då sin slut tid. 
/// </summary>

public class Timer : MonoBehaviour
{

    public PlayerMovment move;
    public Lava lava;

    [Header("Component")]
    public TextMeshProUGUI timerText;

    [Header("Timer Settings")]
    public float currentTime;
    public bool countDown;


    [Header("Limit Settings")]
    public bool hasLimit;
    public float timerLimit;

    [Header("Format settings")]
    public bool hasFormat;
    public TimerFormats format;
    private Dictionary<TimerFormats, string> timeFormats = new Dictionary<TimerFormats, string>();

    void Start()
    {
        timeFormats.Add(TimerFormats.Whole, "0");
        timeFormats.Add(TimerFormats.TenthDecimal, "0.0");
        timeFormats.Add(TimerFormats.HundrethsDecimal, "0.00");
    }

    
    void Update()
    {
        highscore.timerscore = currentTime;

        if (move.start == false)
        {
            
        }

        if(move.start)
        { 
        currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;
        
        if(hasLimit && ((countDown && currentTime <= timerLimit || (!countDown && currentTime >= timerLimit))))
        {
            currentTime = timerLimit;
            SetTimerText();
            timerText.color = Color.red;
            enabled = false;
        }

        SetTimerText();

        }
    }


    private void SetTimerText()
    {
        timerText.text = hasFormat ? currentTime.ToString(timeFormats[format]) : currentTime.ToString();
    }

    public enum TimerFormats
    {
        Whole,
        TenthDecimal,
        HundrethsDecimal
    }



}
