using System.Collections;
using System.Collections.Generic;
using SlapCook;
using UnityEngine;
using UnityEngine.UI;

public class LoseConditionButton : MonoBehaviour {
    void Start() {
        GetComponent<Button>().onClick.AddListener(() => {
            if (GameStateController.Instance.IsLevelFinished()) return;
                GameStateController.Instance.SetState(GameStateController.GameState.GameLost);
        });
    }
}