using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public CoinManager coinManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            coinManager.AddCoin();
            gameObject.SetActive(false); // Deactivate the coin
        }
    }
}

