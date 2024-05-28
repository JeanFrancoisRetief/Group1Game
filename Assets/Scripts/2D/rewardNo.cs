using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rewardNo : MonoBehaviour
{
    public playerStats playerStats;
    public dailyRewards dailyRewards;

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

            dailyRewards.reward1.SetActive(false);
        }

        if (rewardNumber == 2)
        {
            //reward

            dailyRewards.reward2.SetActive(false);
        }

        if (rewardNumber == 3)
        {
            //reward

            dailyRewards.reward3.SetActive(false);
        }

        if (rewardNumber == 4)
        {
            //reward

            dailyRewards.reward4.SetActive(false);
        }

        if (rewardNumber == 5)
        {
            //reward

            dailyRewards.reward5.SetActive(false);
        }

        if (rewardNumber == 6)
        {
            //reward

            dailyRewards.reward6.SetActive(false);
        }
    }

    public void buyReward()
    {
        if (playerStats.gems >= gemCost) 
        {
            playerStats.gems = playerStats.gems - gemCost;

            if (rewardNumber == 1)
            {
                dailyRewards.reward2.SetActive(true);
            }

            if (rewardNumber == 2)
            {
                dailyRewards.reward3.SetActive(true);
            }

            if (rewardNumber == 3)
            {
                dailyRewards.reward4.SetActive(true);
            }

            if (rewardNumber == 4)
            {
                dailyRewards.reward5.SetActive(true);
            }

            if (rewardNumber == 5)
            {
                dailyRewards.reward6.SetActive(true);
            }
        }
    }
}
