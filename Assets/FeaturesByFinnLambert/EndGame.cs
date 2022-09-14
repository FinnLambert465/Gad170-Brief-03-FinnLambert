using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FinnLambert
{
    public class EndGame : MonoBehaviour
    {
        [SerializeField] private TankGameManager gameManager;
        [SerializeField] private GameTimer gameTimer;

        private void OnEnable()
        {
            GameTimer.OnEndGame += EndTheGame;
            FinishLine.OnEndingGame += EndTheGame;
        }

        private void OnDisable()
        {
            GameTimer.OnEndGame -= EndTheGame;
            FinishLine.OnEndingGame -= EndTheGame;
        }

        public void EndTheGame()
        {
            gameTimer.timerOn = false;

            for (int i = 0; i < gameManager.allTanksSpawnedIn.Count; i++)
            {
                gameManager.allTanksSpawnedIn[i].DisableInput();
            }
        }
    }
}
