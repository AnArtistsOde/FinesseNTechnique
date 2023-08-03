using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// tt: cross reference with ot there is a nre on mine 
/// </summary>
public class GreedyAlgorith : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int amount = 84;

        Dictionary<int, int> coins = MakeChange(amount);
        Debug.Log("Amount : " + amount);
        Debug.Log("Coins needed: ");
        foreach (var coin in coins)
        {
            Debug.Log(coin.Key + "coin(s)" + coin.Value + "Amounts to: " + coin.Key * coin.Value);
        }
    }

    public static Dictionary<int, int> MakeChange(int amount)
    {
        Dictionary<int, int> coins = new Dictionary<int, int>();
        int[] coinDenominations = { 20, 10, 5, 1 };

        foreach (int coinDenomination in coinDenominations)
        {
            if (amount >= coinDenomination)
            {
                int coinCount = amount / coinDenomination;
                coins.Add(coinDenomination, coinCount);
                amount -= coinCount * coinDenomination;
            }
        }
        return coins;
    }
}
