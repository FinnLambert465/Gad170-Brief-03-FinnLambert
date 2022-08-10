using UnityEngine;

namespace FinnLambert
{
    public class FinishLine : MonoBehaviour
    {
        public GameObject playerOneUI;
        public GameObject playerTwoUI;
        private void OnTriggerEnter(Collider collision)
        {
            if(collision.tag == "PlayerOne")
            {
                Debug.Log("PlayerOneWins");
                playerOneUI.SetActive(true);
            }
            else if (collision.tag == "PlayerTwo")
            {
                Debug.Log("PlayerTwoWins");
                playerTwoUI.SetActive(true);
            }
        }
    }
}
