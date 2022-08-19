using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace FinnLambert
{
    public class GameTimer : MonoBehaviour
    {
        [SerializeField] private float timeLeft;
        [SerializeField] private bool timerOn = false;
        [SerializeField] private Text timerTxt;
        [SerializeField] private GameObject drawUI;
        [SerializeField] private TankGameManager gameManager;

        //public delegate void EndTheGame();
        //public event EndTheGame OnEndGame;


        private void Start()
        {
            timerOn = true;
        }

        private void Update()
        {
            if (timerOn)
            {
                if (timeLeft > 0)
                {
                    timeLeft -= Time.deltaTime;
                    UpdateTimer(timeLeft);
                }
                else
                {
                    timerOn = false;
                    drawUI.SetActive(true);
                    EndGame();
                }
            }
        }
        public void EndGame()
        {

            for (int i = 0; i < gameManager.allTanksSpawnedIn.Count; i++)
            {
                gameManager.allTanksSpawnedIn[i].DisableInput();
            }
        }
        private void UpdateTimer(float currentTime)
        {
            currentTime += 1f;

            float minutes = Mathf.FloorToInt(currentTime / 60);
            float seconds = Mathf.FloorToInt(currentTime % 60);

            timerTxt.text = string.Format("{0:00} : {1:00}", minutes, seconds);
        }
    }
}
