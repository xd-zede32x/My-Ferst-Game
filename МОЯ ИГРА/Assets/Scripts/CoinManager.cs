using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{

    public int NumberOfCoins;
    [SerializeField] private TextMeshProUGUI _text;

    private void Start()
    {
        NumberOfCoins = Progress.Instance.PlayerInfo.Coins;
        _text.text = NumberOfCoins.ToString();
    }

    public void AddOne()
    {
        NumberOfCoins += 1;
        _text.text = NumberOfCoins.ToString();
    }

    public void SaveToProgress() {
        Progress.Instance.PlayerInfo.Coins = NumberOfCoins;
    }

    public void SpendMoney(int value) {
        NumberOfCoins -= value;
        _text.text = NumberOfCoins.ToString();
    }

}
