using UnityEngine;

namespace FinnLambert
{
    public class FinishLine : MonoBehaviour
    {
        public GameObject playerOneUI;
        public GameObject playerTwoUI;
        public delegate void EndingTheGame();
        public static event EndingTheGame OnEndingGame;

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

            }
            else if (collision.gameObject.tag == "PlayerTwo")
            {
                Debug.Log("PlayerTwoWins");
                playerTwoUI.SetActive(true);
                if (OnEndingGame != null)
                {
                    OnEndingGame();
                }

            }
        }
    }
}
