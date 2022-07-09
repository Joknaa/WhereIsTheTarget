using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetFoundButton : MonoBehaviour {
    void Start() {
        GetComponent<Button>().onClick.AddListener(() => {
            //GameObject.FindGameObjectWithTag("Canvas").GetComponent<PuzzleManager>().LoadNextPuzzle();
        });
    }
}