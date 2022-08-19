using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FinnLambert
{


    public class PowerUp : MonoBehaviour
    {
        public GameObject powerUp;
        [SerializeField] private Missile missile;
        [SerializeField] private OilSlip oilSlip;


        public void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("PowerUp"))
            {
                int randomNumberGenerator = Random.Range(1, 4);

                //if some other object is listening to MarbleReset
                if (randomNumberGenerator == 1)
                {

                }

            }

        }
    }
}