using UnityEngine;

namespace FinnLambert
{
    public class FinishLine : MonoBehaviour
    {
        public GameObject playerOneUI;
        public GameObject playerTwoUI;
        [SerializeField] private TankGameManager gameManager;
        [SerializeField] private GameTimer gameTimer;
        private void OnTriggerEnter(Collider collision)
        {
            if (collision.gameObject.tag == "PlayerOne")
            {
                Debug.Log("PlayerOneWins");
                playerOneUI.SetActive(true);

                for (int i = 0; i < gameManager.allTanksSpawnedIn.Count; i++)
                {
                    gameManager.allTanksSpawnedIn[i].DisableInput();
                }

            }
            else if (collision.gameObject.tag == "PlayerTwo")
            {
                Debug.Log("PlayerTwoWins");
                playerTwoUI.SetActive(true);

                for (int i = 0; i < gameManager.allTanksSpawnedIn.Count; i++)
                {
                    gameManager.allTanksSpawnedIn[i].DisableInput();
                }
                //GameTimer.updateTimer(flase);
            }
        }
    }
}
