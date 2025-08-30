using Microsoft.Win32;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Text myText = null;
    private float TimerElapsed = 0.00f; // a floating point value to store the elapsed time

    // Start is called before the first frame update
    void Awake()
    {
        myText = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        TimerElapsed += Time.deltaTime;
        myText.text = TimerElapsed.ToString("00");
    }
}
