using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rewardNo : MonoBehaviour
{
    public playerStats playerStats;

    public int rewardNumber;
    public int gemCost;
    public Text gemCostTxt;

    private void Update()
    {
        gemCostTxt.text = "Buy for " + gemCost + " Gems";

        if (rewardNumber == 1)
        {
            gemCost = 0;
        }

        if (rewardNumber == 2)
        {
            gemCost = 0;
        }

        if (rewardNumber == 3)
        {
            gemCost = 0;
        }

        if (rewardNumber == 4)
        {
            gemCost = 0;
        }

        if (rewardNumber == 5)
        {
            gemCost = 0;
        }

        if (rewardNumber == 6)
        {
            gemCost = 0;
        }
    }

    public void AcceptReward()
    {
        if (rewardNumber == 1)
        {
            //reward
        }

        if (rewardNumber == 2)
        {
            //reward
        }

        if (rewardNumber == 3)
        {
            //reward
        }

        if (rewardNumber == 4)
        {
            //reward
        }

        if (rewardNumber == 5)
        {
            //reward
        }

        if (rewardNumber == 6)
        {
            //reward
        }
    }

    public void buyReward()
    {
        if (playerStats.gems >= gemCost) 
        {
            playerStats.gems = playerStats.gems - gemCost;
        }
    }
}
