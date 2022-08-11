using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace FinnLambert
{
    public class GameTimer : MonoBehaviour
    {
        [SerializeField] private float countDown;
        public Text countDownTxt;
        public GameObject drawScreen;
        [SerializeField] private TankGameManager gameManager;

        

        // Update is called once per frame
        void Update()
        {
            if (countDown > 0)
            {
                countDown -= Time.deltaTime;
                updateTimer(countDown);
            }
            else
            {
                
                drawScreen.SetActive(true);

                for (int i = 0; i < gameManager.allTanksSpawnedIn.Count; i++)
                {
                    gameManager.allTanksSpawnedIn[i].DisableInput();
                }
            }
        }

        void updateTimer(float currentTime)
        {
            currentTime += 1;

            float minutes = Mathf.FloorToInt(currentTime / 60);
            float seconds = Mathf.FloorToInt(currentTime % 60);

            countDownTxt.text = string.Format("{0:00} : {1:00}", minutes, seconds);
        }
    }
}
