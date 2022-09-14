using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FinnLambert
{
    public class EndGame : MonoBehaviour
    {
        [SerializeField] private TankGameManager gameManager;

        private void OnEnable()
        {
            GameTimer.OnEndGame += EndTheGame;
        }

        private void OnDisable()
        {
            GameTimer.OnEndGame -= EndTheGame;
        }

        public void EndTheGame()
        {

            for (int i = 0; i < gameManager.allTanksSpawnedIn.Count; i++)
            {
                gameManager.allTanksSpawnedIn[i].DisableInput();
            }
        }
    }
}
