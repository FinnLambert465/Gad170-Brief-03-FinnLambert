using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FinnLambert
{
    public class FinishLine : MonoBehaviour
    {
        private void OnTriggerEnter(Collider collision)
        {
            if(collision.tag == "PlayerOne")
            {
                Debug.Log("PlayerOneWins");
            }
            else if (collision.tag == "PlayerTwo")
            {
                Debug.Log("PlayerTwoWins");
            }
        }
    }
}
