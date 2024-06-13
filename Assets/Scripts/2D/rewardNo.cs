using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rewardNo : MonoBehaviour
{
    public playerStats playerStats;
    public dailyRewards dailyRewards;
    public progression progression;

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
            playerStats.wheatAmt = playerStats.wheatAmt + 25;
            playerStats.cornAmt = playerStats.cornAmt + 25;
            playerStats.riceAmt = playerStats.riceAmt + 25;

            dailyRewards.reward1Accept.SetActive(false);
        }

        if (rewardNumber == 2)
        {
            playerStats.coins += playerStats.coins + 250;

            dailyRewards.reward2Accept.SetActive(false);
        }

        if (rewardNumber == 3)
        {
            playerStats.chickenAmt = playerStats.chickenAmt + 3;
            playerStats.cowAmt = playerStats.cowAmt + 2;

            dailyRewards.reward3Accept.SetActive(false);
        }

        if (rewardNumber == 4)
        {
            playerStats.gems = playerStats.gems + 10;

            dailyRewards.reward4Accept.SetActive(false);
        }

        if (rewardNumber == 5)
        {
            progression.toilet.SetActive(true);

            dailyRewards.reward5Accept.SetActive(false);
        }
    }
}
