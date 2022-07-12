using System;
using System.Collections;
using System.Collections.Generic;
using SlapCook;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public TMP_Text timerText;

    private float elapsedTime;
    private int elapsedSeconds;
    private int elapsedMinutes;


    private void Update() {
        if (!GameStateController.Instance.IsPlaying()) return;
        
        elapsedTime += Time.deltaTime;
        TimeSpan time = TimeSpan.FromSeconds(elapsedTime);
        timerText.text = time.ToString(@"mm\:ss");
    }


    public void ResetTimer() => elapsedTime = 0;
}