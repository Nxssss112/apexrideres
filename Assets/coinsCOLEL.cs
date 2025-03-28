using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    private int coin = 0; 
    public TextMeshProUGUI coinText; 
    public int Coin 
    {
        get { return coin; }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin")) 
        {
            coin++; 
            UpdateCoinText(); 
            Destroy(other.gameObject); 
        }
    }

    private void UpdateCoinText()
    {
        if (coinText != null)
        {
            coinText.text = "Coin: " + coin.ToString(); 
        }
    }
}