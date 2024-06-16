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

    public void AcceptReward()
    {
        if (rewardNumber == 1)
        {
            playerStats.wheatAmt = playerStats.wheatAmt + 25;
            playerStats.cornAmt = playerStats.cornAmt + 25;
            playerStats.riceAmt = playerStats.riceAmt + 25;

            playerStats.coins += playerStats.coins + 50;


            dailyRewards.reward1bool = true;
        }

        if (rewardNumber == 2)
        {
            playerStats.coins += playerStats.coins + 450;

            dailyRewards.reward2bool = true;
        }

        if (rewardNumber == 3)
        {
            playerStats.chickenAmt = playerStats.chickenAmt + 3;
            playerStats.cowAmt = playerStats.cowAmt + 2;

            playerStats.coins += playerStats.coins + 200;

            dailyRewards.reward3bool = true;
        }

        if (rewardNumber == 4)
        {
            playerStats.gems = playerStats.gems + 10;

            playerStats.coins += playerStats.coins + 400;


            dailyRewards.reward4bool = true;
        }

        if (rewardNumber == 5)
        {
            progression.toilet.SetActive(true);

            playerStats.coins += playerStats.coins + 600;

            dailyRewards.reward5bool = true;
        }
    }
}
