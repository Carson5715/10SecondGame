using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountdownTimer : MonoBehaviour
{
    public float timeLeft = 3.0f;
    public Text startText; // used for showing countdown
    void Update()
    {
        timeLeft -= Time.deltaTime;
        // Convert integer to string
        startText.text = (timeLeft).ToString("0");
        if (timeLeft < 1)
        {
            Application.LoadLevel ("GameOver");
        }
    }
}