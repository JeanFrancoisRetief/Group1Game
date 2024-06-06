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
    public Text chickenUp4;
    public GameObject chickenUp4GO;
    public GameObject btnChickenUp4;

    [Header("Unlock")]
    public int coopPrice;
    public bool isUnlocked;
    public GameObject btnPurchaseCoop;
    public GameObject btnChickens;
    public GameObject btnUpgradeChickens;
    public Text txtCoopPrice;

    [Header("Incubator")]
    public int incUnlockLvl;
    public int incUnlockPrice;
    public Text txtTimeToHatch;
    public float timeToHatch;
    public float actualTimeToHatch;
    public GameObject btnPlaceEgg;
    public GameObject btnHatchEgg;
    public GameObject GOTimeToHatch;
    public GameObject GOInc;

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
        actualTimeToHatch = 150f;

        GOInc.SetActive(false);
        collectBtn.SetActive(false);
        btnPlaceEgg.SetActive(true);
        btnHatchEgg.SetActive(false);
        GOTimeToHatch.SetActive(false);

        chickenUp4GO.SetActive(false);
        btnChickenUp4.SetActive(false);
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

        chickenUp1.text = "Number of Chickens: +1";
        chickenUp2.text = "Number of Eggs Laid: +1";
        chickenUp3.text = "Time of Eggs Laids: -20 seconds";
        chickenUp4.text = "Buy Incubator";

        if (playerStats.lvl >= 8)
        {
            chickenUp4GO.SetActive(true);
        }
        else
        {
            chickenUp4GO.SetActive(false);
        }

        chickenUpCostTxt.text = "Cost: " + chickenUpCost;

        chickenAmtTxt.text = playerStats.chickenAmt.ToString();
        eggsAmtTxt.text = playerStats.eggsAmt.ToString();

        //unlock
        txtCoopPrice.text = "Buy " + coopPrice + " Coins";

        if (isUnlocked == true)
        {
            btnChickens.GetComponent<UnityEngine.UI.Image>().color = Color.white;
            btnUpgradeChickens.SetActive(true);
            btnPurchaseCoop.SetActive(false);

        }
        else
        {
            btnChickens.GetComponent<UnityEngine.UI.Image>().color = Color.gray;
            btnUpgradeChickens.SetActive(false);
            btnPurchaseCoop.SetActive(true);
        }

        //timer for eggs to hatch

        txtTimeToHatch.text = "Time to Hatch: " + timeToHatch;

        if (timeToHatch > 0)
        {
            timeToHatch -= Time.deltaTime;
            GOTimeToHatch.SetActive(true);
        }
        else if (timeToHatch < 0)
        {
            timeToHatch = 0;
            btnHatchEgg.SetActive(true);
            GOTimeToHatch.SetActive(false);
        }
        int minutesHatch = Mathf.FloorToInt(timeToHatch / 60);
        int secondsHatch = Mathf.FloorToInt(timeToHatch % 60);
    }

    public void BuyCoop()
    {
        if (playerStats.coins >= coopPrice)
        {
            playerStats.coins = playerStats.coins - coopPrice;
            isUnlocked = true;

            playerStats.xp = playerStats.xp + 75;
        }
        else
        {
            playerStats.notEnoughCoins.SetActive(true);
        }
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

    public void BuyIncubator()
    {
        if (playerStats.coins >= incUnlockPrice)
        {
            playerStats.coins = playerStats.coins - incUnlockPrice;

            GOInc.SetActive(true);
            chickenUp4GO.SetActive(false);
        }
    }

    public void PlaceEgg()
    {
        if (playerStats.eggsAmt >= 1)
        {
            playerStats.eggsAmt = playerStats.eggsAmt - 1;

            btnPlaceEgg.SetActive(false);

            timeToHatch = actualTimeToHatch;
        }
    }

    public void HatchEgg()
    {
        if (playerStats.chickenAmt < playerStats.maxChickenAmt)
        {
            playerStats.chickenAmt = playerStats.chickenAmt + 1;

            btnHatchEgg.SetActive(false);
            btnPlaceEgg.SetActive(true);
        }    
    }
}
