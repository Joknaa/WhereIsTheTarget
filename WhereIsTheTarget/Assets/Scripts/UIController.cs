using System;
using System.Collections;
using System.Collections.Generic;
using SlapCook;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour {
    public GameObject startingPanel;
    public GameObject firstLevel;
    public GameObject gameWonPanel;
    public GameObject gameLostPanel;
    public GameObject HUD;
    
    private void Start() {
        GameStateController.Instance.OnGameStateChanged += OnGameStateChanged;
        GameStateController.Instance.SetState(GameStateController.GameState.StartingMenu);
    }
    

    private void OnGameStateChanged(GameStateController.GameState currentState) {
        var isStarting = GameStateController.Instance.IsStartingMenu();
        var isPlaying = GameStateController.Instance.IsPlaying();
        var isWon = GameStateController.Instance.IsGameWon();
        var isLost = GameStateController.Instance.IsGameLost();
        
        startingPanel.SetActive(isStarting);
        firstLevel.SetActive(isPlaying);
        gameWonPanel.SetActive(isWon);
        gameLostPanel.SetActive(isLost);
        HUD.SetActive(!isStarting);
    }
    
    private void OnDestroy() {
        GameStateController.Instance.OnGameStateChanged -= OnGameStateChanged;
    }
}