using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using SlapCook;
using TMPro;
using UnityEngine;

public class PuzzleManager : MonoBehaviour {
    public List<GameObject> puzzlePrefabs = new List<GameObject>();
    public GameObject targetFoundPanel;
    public GameObject canvas;

    private int puzzleIndex = 0;
    private SoundManager soundManager;
    private GameObject currentPuzzle;
    private GameObject targetFoundInstance;

  

    public void StartPuzzles() { 
        FindObjectOfType<Timer>().ResetTimer();
        currentPuzzle = FindObjectOfType<UIController>().firstLevel;
        // currentPuzzle = Instantiate(puzzlePrefabs[puzzleIndex], canvas.transform);
        soundManager = FindObjectOfType<SoundManager>();
    }


    public void SetupNextPuzzle() {
        soundManager.PlayTargetFound();
        targetFoundInstance = Instantiate(targetFoundPanel, canvas.transform);

        Invoke(nameof(LoadNextPuzzle), 1f);
    }

    public void LoadNextPuzzle() {

        if (puzzleIndex == 0) currentPuzzle.SetActive(false);
        else Destroy(currentPuzzle);
        
        Destroy(targetFoundInstance);
        puzzleIndex++;
        if (puzzleIndex >= puzzlePrefabs.Count) {
            puzzleIndex = puzzlePrefabs.Count - 1;
            GameStateController.Instance.SetState(GameStateController.GameState.GameWon);
            print("GameWon !!");
            return;
        }

        currentPuzzle = Instantiate(puzzlePrefabs[puzzleIndex], canvas.transform);
    }
}