using System.Collections;
using System.Collections.Generic;
using SlapCook;
using UnityEngine;
using UnityEngine.UI;

public class TryAgainButton : MonoBehaviour {
    void Start() {
        GetComponent<Button>().onClick.AddListener(() => {
            GameStateController.Instance.SetState(GameStateController.GameState.StartingMenu);
        });
    }
}