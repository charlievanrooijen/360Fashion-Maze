using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class CoinManager : MonoBehaviour
{
    public int coinCount = 0; // To keep track of coins collected
    public TextMeshProUGUI coinCountText; // Reference to the TMP Text element
    public List<DoorEntry> doors; // List of doors and their thresholds

    void Start()
    {
        UpdateCoinCountUI(); // Update UI at the start
    }

    void UpdateCoinCountUI()
    {
        coinCountText.text = "Coins: " + coinCount.ToString();
    }

    public void AddCoin()
    {
        coinCount++; // Increase coin count
        UpdateCoinCountUI(); // Update UI
        CheckDoors(); // Check if any doors should open
    }

    private void CheckDoors()
    {
        foreach (var entry in doors)
        {
            if (coinCount >= entry.coinThreshold && !entry.doorManager.isOpening)
            {
                entry.doorManager.OpenDoor();
            }
        }
    }
}
