using System;
using System.Collections;
using System.Collections.Generic;
using SlapCook;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour {
    private void Start() {
        GameStateController.Instance.SetState(GameStateController.GameState.StartingMenu);
        GetComponent<Button>().onClick.AddListener(() => {
            GameStateController.Instance.SetState(GameStateController.GameState.Playing);
            FindObjectOfType<PuzzleManager>().StartPuzzles();
        });
    }
}