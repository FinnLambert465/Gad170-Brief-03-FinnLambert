using UnityEngine;

namespace FinnLambert
{
    public class FinishLine : MonoBehaviour
    {
        public GameObject playerOneUI;
        public GameObject playerTwoUI;
        public delegate void EndingTheGame();
        public static event EndingTheGame OnEndingGame;
        public delegate void PlayerOneWins();
        public static event PlayerOneWins OnPlayerOneWins;
        public delegate void PlayerTwoWins();
        public static event PlayerOneWins OnPlayerTwoWins;

        private void OnTriggerEnter(Collider collision)
        {
            
            if (collision.gameObject.tag == "PlayerOne")
            {
                Debug.Log("PlayerOneWins");
                playerOneUI.SetActive(true);
                if (OnEndingGame != null)
                {
                    OnEndingGame();
                }
                if (OnPlayerOneWins != null)
                {
                    OnPlayerOneWins();
                }

            }
            else if (collision.gameObject.tag == "PlayerTwo")
            {
                Debug.Log("PlayerTwoWins");
                playerTwoUI.SetActive(true);
                if (OnEndingGame != null)
                {
                    OnEndingGame();
                }
                if (OnPlayerTwoWins != null)
                {
                    OnPlayerTwoWins();
                }

            }
        }
    }
}
