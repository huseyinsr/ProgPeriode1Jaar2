/*using UnityEngine;
using TMPro;
using System;

public class CoinUI : MonoBehaviour
{
    [SerializeField] private TMP_Text coinText; 
    private int coinsCollected = 0;

    void Start()
    {
        Coin.OnCoinDestroyed += UpdateCoinUI;
        UpdateText();
    }

    public void UpdateCoinUI()
    {
        coinsCollected++;
        UpdateText();
    }

    private void UpdateText()
    {
        coinText.text = "Coins: " + coinsCollected;
    }

    void OnDestroy()
    {
        Coin.OnCoinDestroyed -= UpdateCoinUI;
    }
}
*/