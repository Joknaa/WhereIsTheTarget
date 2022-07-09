using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour {
    private void Start() {
        GetComponent<Button>().onClick.AddListener(() => {
            SceneManager.LoadScene("MainScene");
            GetComponent<Button>().interactable = false;
        });
    }
    
    
}