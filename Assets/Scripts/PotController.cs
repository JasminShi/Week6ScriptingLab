using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotController : MonoBehaviour
{
    public GameObject pot;
    
        private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("RightHand"))
        {
            pot.SetActive(false);
        }
    }
}

  