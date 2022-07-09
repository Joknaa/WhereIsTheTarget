using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PuzzleManager : MonoBehaviour {
    public List<GameObject> puzzlePrefabs = new List<GameObject>();

    private GameObject currentPuzzle;
    private int puzzleIndex = 0;
    public GameObject canvas;

    private void Start() {
        // canvas = GameObject.FindGameObjectWithTag("Canvas");
        currentPuzzle = Instantiate(puzzlePrefabs[puzzleIndex], canvas.transform);
    }
    
    
    public void SetupNextPuzzle() {
        Destroy(currentPuzzle);
        puzzleIndex++;
        if (puzzleIndex >= puzzlePrefabs.Count) {
            puzzleIndex = 0;
            print("GameWon !!");
        }
        currentPuzzle = Instantiate(puzzlePrefabs[puzzleIndex], canvas.transform);
    }
}