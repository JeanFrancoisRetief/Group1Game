using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cows : MonoBehaviour
{
    [Header("Misc")]
    public playerStats playerStats;
    public GameObject collectBtn;
    public GameObject notEnoughCoins;

    [Header("Main")]
    public int milkBottles;
    public Text cowAmtTxt;
    public Text milkBottlesAmtTxt;
    public float timeToMilk;
    public float actualTimeToMilk;

    [Header("Upgrades")]
    public Text cowUp1;
    public Text cowUp2;
    public Text cowUp3;
    public int cowUpCost;
    public Text cowUpCostTxt;

    [Header("Unlock")]
    public int barnPrice;
    public bool isUnlocked;
    public GameObject btnPurchaseBarn;
    public GameObject btnCows;
    public GameObject btnUpgradeCows;
    public Text txtBarnPrice;

    // Start is called before the first frame update
    void Start()
    {
        playerStats.cowAmt = 1;
        playerStats.maxCowAmt = 2;
        playerStats.milkBottlesAmt = 0;
        playerStats.maxMilkBottlesAmt = 5;
        milkBottles = 1;
        cowUpCost = 25;
        actualTimeToMilk = 120f;

        collectBtn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //timer for eggs
        if (timeToMilk > 0)
        {
            timeToMilk -= Time.deltaTime;
            collectBtn.SetActive(false);
        }
        else if (timeToMilk < 0)
        {
            timeToMilk = 0;

            collectBtn.SetActive(true);
        }
        int minutes = Mathf.FloorToInt(timeToMilk / 60);
        int seconds = Mathf.FloorToInt(timeToMilk % 60);
        //timerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        cowUp1.text = "Number of Cows: +1";
        cowUp2.text = "Number of Milk Bottles Filled: +1";
        cowUp3.text = "Time Milks Bottles take to be Filled: -20 seconds";

        cowUpCostTxt.text = "Cost: " + cowUpCost;

        cowAmtTxt.text = playerStats.cowAmt.ToString();
        milkBottlesAmtTxt.text = playerStats.milkBottlesAmt.ToString();

        //unlock
        txtBarnPrice.text = "Buy " + barnPrice + " Coins";

        if (isUnlocked == true)
        {
            btnCows.GetComponent<UnityEngine.UI.Image>().color = Color.white;
            btnUpgradeCows.SetActive(true);
            btnPurchaseBarn.SetActive(false);

        }
        else
        {
            btnCows.GetComponent<UnityEngine.UI.Image>().color = Color.gray;
            btnUpgradeCows.SetActive(false);
            btnPurchaseBarn.SetActive(true);
        }
    }

    public void BuyBarn()
    {
        if (playerStats.coins >= barnPrice)
        {
            playerStats.coins = playerStats.coins - barnPrice;
            isUnlocked = true;

            playerStats.xp = playerStats.xp + 100;
        }
        else
        {
            playerStats.notEnoughCoins.SetActive(true);
        }
    }

    public void BuyCows()
    {
        if (playerStats.coins >= cowUpCost)
        {
            if (playerStats.cowAmt <= playerStats.maxCowAmt)
            {
                playerStats.cowAmt = playerStats.cowAmt + 1;
                playerStats.coins = playerStats.coins - cowUpCost;
                cowUpCost = cowUpCost * 2;
            }
        }
        else
        {
            notEnoughCoins.SetActive(true);
        }

        if (playerStats.cowAmt == 2)
        {
            timeToMilk = actualTimeToMilk;
        }
    }

    public void IncNumberOfMilkBottles()
    {
        if (playerStats.coins >= cowUpCost)
        {
            milkBottles = milkBottles + 1;
            playerStats.coins = playerStats.coins - cowUpCost;
            cowUpCost = cowUpCost * 2;
        }
        else
        {
            notEnoughCoins.SetActive(true);
        }
    }

    public void InctRateOfMilkBottles()
    {
        if (playerStats.coins >= cowUpCost)
        {
            actualTimeToMilk = actualTimeToMilk - 20f;
            playerStats.coins = playerStats.coins - cowUpCost;
            cowUpCost = cowUpCost * 2;
        }
        else
        {
            notEnoughCoins.SetActive(true);
        }
    }

    public void CollectMilkBottles()
    {
        if (playerStats.eggsAmt < playerStats.maxEggsAmt)
        {
            playerStats.milkBottlesAmt = playerStats.milkBottlesAmt + milkBottles;

            if (playerStats.cowAmt >= 2)
            {
                timeToMilk = actualTimeToMilk;
            }
        }
    }
}
