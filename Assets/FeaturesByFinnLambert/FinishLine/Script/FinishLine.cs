using UnityEngine;

namespace FinnLambert
{
    public class FinishLine : MonoBehaviour
    {
        public GameObject playerOneUI;
        public GameObject playerTwoUI;
        private void OnTriggerEnter(Collider collision)
        {
            if(collision.gameObject.tag == "PlayerOne")
            {
                Debug.Log("PlayerOneWins");
                playerOneUI.SetActive(true);
            }
            else if (collision.gameObject.tag == "PlayerTwo")
            {
                Debug.Log("PlayerTwoWins");
                playerTwoUI.SetActive(true);
            }
        }
    }
}
