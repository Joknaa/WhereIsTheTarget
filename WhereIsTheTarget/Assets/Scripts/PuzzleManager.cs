using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PuzzleManager : MonoBehaviour {
    public List<GameObject> puzzlePrefabs = new List<GameObject>();
    public GameObject targetFoundPanel;
    public GameObject canvas;

    private int puzzleIndex = 0;
    private SoundManager soundManager;
    private bool newPuzzleIsLoaded = false;
    private GameObject currentPuzzle;
    private GameObject targetFoundInstance;

    private void Start() {
        // canvas = GameObject.FindGameObjectWithTag("Canvas");
        currentPuzzle = Instantiate(puzzlePrefabs[puzzleIndex], canvas.transform);
        soundManager = GameObject.FindObjectOfType<SoundManager>();
    }


    public void SetupNextPuzzle() {
        soundManager.PlayTargetFound();
        targetFoundInstance = Instantiate(targetFoundPanel, canvas.transform);

        Invoke(nameof(LoadNextPuzzle), 1f);
    }

    public void LoadNextPuzzle() {
        
        Destroy(currentPuzzle);
        Destroy(targetFoundInstance);
        puzzleIndex++;
        if (puzzleIndex >= puzzlePrefabs.Count) {
            puzzleIndex = puzzlePrefabs.Count - 1;
            print("GameWon !!");
        }

        currentPuzzle = Instantiate(puzzlePrefabs[puzzleIndex], canvas.transform);
    }
}