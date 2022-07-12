using System;

namespace SlapCook {
    public class GameStateController {
        public enum GameState {
            StartingMenu,
            Playing,
            LevelFinished,
            GameWon,
            GameLost,
        }

        public static GameStateController Instance => instance ??= new GameStateController();
        private static GameStateController instance;
        private GameState currentGameState;
        public event Action<GameState> OnGameStateChanged;

        public void SetState(GameState state) {
            currentGameState = state;
            OnGameStateChanged?.Invoke(currentGameState);
        }

        public void SetState_StartingMenu() => currentGameState = GameState.StartingMenu;
        public void SetState_Playing() => currentGameState = GameState.Playing;


        public bool IsStartingMenu() => currentGameState == GameState.StartingMenu;
        public bool IsPlaying() => currentGameState == GameState.Playing;
        public bool IsGameWon() => currentGameState == GameState.GameWon;
        public bool IsGameLost() => currentGameState == GameState.GameLost;
        public bool IsLevelFinished() => currentGameState == GameState.LevelFinished;
        
        
    }
}