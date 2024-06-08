using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class microtransactionScript : MonoBehaviour
{
    public playerStats playerStats;
    public GameObject img_NoMoreGems;

    public void GemsForCoinsOnClick()
    {
        if (playerStats.gems > 0)
        {
            playerStats.gems--;
            playerStats.coins = playerStats.coins + 150;
        }
        else
        {
            img_NoMoreGems.SetActive(true);
        }
    }
}
