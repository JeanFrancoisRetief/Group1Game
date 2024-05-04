using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chickens : MonoBehaviour
{
    [Header("Misc")]
    public playerStats playerStats;
    public GameObject collectBtn;
    public GameObject notEnoughCoins;

    [Header("Main")]
    public int eggsLaid;
    public Text chickenAmtTxt;
    public Text eggsAmtTxt;
    public float timeToLay;
    public float actualTimeToLay;

    [Header("Upgrades")]
    public int chickenUpCost;
    public Text chickenUpCostTxt;
    public Text chickenUp1;
    public Text chickenUp2;
    public Text chickenUp3;

    // Start is called before the first frame update
    void Start()
    {
        playerStats.chickenAmt = 1;
        playerStats.maxChickenAmt = 2;
        playerStats.eggsAmt = 1;
        playerStats.maxEggsAmt = 5;
        eggsLaid = 1;
        chickenUpCost = 25;
        actualTimeToLay = 120f;

        collectBtn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //timer for eggs
        if (timeToLay > 0)
        {
            timeToLay -= Time.deltaTime;
            collectBtn.SetActive(false);
        }
        else if (timeToLay < 0)
        {
            timeToLay = 0;

            collectBtn.SetActive(true);
        }
        int minutes = Mathf.FloorToInt(timeToLay / 60);
        int seconds = Mathf.FloorToInt(timeToLay % 60);
        //timerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        chickenUp1.text = "Number of Chickens: +1";
        chickenUp2.text = "Number of Eggs Laid: +1";
        chickenUp3.text = "Time of Eggs Laids: -20 seconds";

        chickenUpCostTxt.text = "Cost: " + chickenUpCost;

        chickenAmtTxt.text = playerStats.chickenAmt.ToString();
        eggsAmtTxt.text = playerStats.eggsAmt.ToString();
    }

    public void BuyChickens()
    {
        if (playerStats.coins >= chickenUpCost)
        {
            if (playerStats.chickenAmt <= playerStats.maxChickenAmt)
            {
                playerStats.chickenAmt = playerStats.chickenAmt + 1;
                playerStats.coins = playerStats.coins - chickenUpCost;
                chickenUpCost = chickenUpCost * 2;
            }
        }
        else
        {
            notEnoughCoins.SetActive(true);
        }

        if (playerStats.chickenAmt == 2)
        {
            timeToLay = actualTimeToLay;
        }
    }

    public void IncNumberOfEggsLaid()
    {
        if (playerStats.coins >= chickenUpCost)
        {
            eggsLaid = eggsLaid + 1;
            playerStats.coins = playerStats.coins - chickenUpCost;
            chickenUpCost = chickenUpCost * 2;
        }
        else
        {
            notEnoughCoins.SetActive(true);
        }
    }

    public void InctRateOfEggsLaid()
    {
        if (playerStats.coins >= chickenUpCost)
        {
            actualTimeToLay = actualTimeToLay - 20f;
            playerStats.coins = playerStats.coins - chickenUpCost;
            chickenUpCost = chickenUpCost * 2;
        }
        else
        {
            notEnoughCoins.SetActive(true);
        }
    }

    public void CollectEggs()
    {
        if (playerStats.eggsAmt < playerStats.maxEggsAmt)
        {
            playerStats.eggsAmt = playerStats.eggsAmt + eggsLaid;

            if (playerStats.chickenAmt >= 2)
            {
                timeToLay = actualTimeToLay;
            }
        }
    }
}
