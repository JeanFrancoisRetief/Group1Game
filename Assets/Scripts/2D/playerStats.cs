using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.MPE;
using UnityEditor.Rendering.Universal;
using UnityEngine;
using UnityEngine.UI;

public class playerStats : MonoBehaviour
{
    [Header("Player Stats")]
    public int lvl;
    public Text lvlTxt;
    public int xp;
    public int xpLimit;
    public Slider sldXP;
    public int coins;
    public Text coinsTxt;
    public float time;
    public Text timeTxt;
    public int day;
    public Text dayTxt;

    [Header("Crop Stats")]
    public int wheatAmt;
    public int maxWheatAmt;
    public Text wheatAmtTxt;
    public int cornAmt;
    public int maxCornAmt;
    public Text cornAmtTxt;
    public int riceAmt;
    public int maxRiceAmt;
    public Text riceAmtTxt;

    public GameObject statsMenu;

    [Header("Chickens")]
    public int chickenAmt;
    public int maxChickenAmt;
    public Text chickenAmtTxt;
    public int eggsAmt;
    public int maxEggsAmt;
    public Text eggsAmtTxt;

    [Header("Cows")]
    public int cowAmt;
    public int maxCowAmt;
    public Text cowAmtTxt;
    public int milkBottlesAmt;
    public int maxMilkBottlesAmt;
    public Text milkBottlesTxt;

    [Header("Upgrades")]
    public GameObject greySilo;
    public GameObject Silo;
    public GameObject btnBuySilo;
    public GameObject btnUpgradeSilo;
    public int lvlToUnlockSilo;
    public int siloPrice;
    public int siloBenefit;
    public int siloUpgradePrice;
    public int siloUpgradeAmount;
    public Text txtSiloRequiredLvl;
    public Text txtBuySilo;
    public Text txtSiloUpgrade;

    [Header("Requests")]
    public int reqPending;
    public Text reqPendingTxt;

    // Start is called before the first frame update
    void Start()
    {
        lvl = 0;
        xp = 0;
        xpLimit = 10;
        coins = 10;
        day = 1;
        time = 1;
        reqPending = 0;

        //silo
        greySilo.SetActive(true);
        Silo.SetActive(false);
        btnBuySilo.SetActive(true);
        btnUpgradeSilo.SetActive(false);
        siloBenefit = 10;
    }

    // Update is called once per frame
    void Update()
    {
        dayTxt.text = "Day: " + day;
        timeTxt.text = "Time: " + time;

        sldXP.value = xp;
        sldXP.maxValue = xpLimit;
        lvlTxt.text = "Lvl: " + lvl;

        coinsTxt.text = "Coins: " + coins;

        if (xp >= xpLimit)
        {
            xp = 0;

            xpLimit = xpLimit * 2;

            lvl = lvl + 1;
        }

        //crops
        wheatAmtTxt.text = "Wheat: " + wheatAmt + "/" + maxWheatAmt;
        cornAmtTxt.text = "Corn: " + cornAmt + "/" + maxCornAmt;
        riceAmtTxt.text = "Rice: " + riceAmt + "/" + maxRiceAmt;

        //animals
        chickenAmtTxt.text = "Chickens: " + chickenAmt + "/" + maxChickenAmt;
        eggsAmtTxt.text = "Eggs: " + eggsAmt + "/" + maxEggsAmt;

        cowAmtTxt.text = "Cows: " + cowAmt + "/" + maxCowAmt;
        milkBottlesTxt.text = "Milk Bottles: " + milkBottlesAmt + "/" + maxMilkBottlesAmt;

        reqPendingTxt.text = "Req Pending: " + reqPending;

        //time of day
        //if (time > 0)
        //{
        //    time += Time.deltaTime;
        //}
        //else if (time < 0)
        //{
        //    time = 0;
        //}
        //int minutes = Mathf.FloorToInt(time / 60);
        //int seconds = Mathf.FloorToInt(time % 60);
        //timeTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        //silo
        txtSiloRequiredLvl.text = "Required Lvl to Unlock: " + lvlToUnlockSilo;
        txtBuySilo.text = "Buy Silo " + siloPrice + " Coins";
        txtSiloUpgrade.text = "Coins: " + siloUpgradePrice;
    }

    public void StatsMenuDropDown()
    {
        if (statsMenu == false)
        {
            statsMenu.SetActive(true);
        }
    }

    public void BuySilo()
    {
        if (coins >= siloPrice && lvl >= lvlToUnlockSilo)
        {
            Silo.SetActive(true);
            btnUpgradeSilo.SetActive(true);
            btnBuySilo.SetActive(false);
            greySilo.SetActive(false);

            coins = coins - siloPrice;
            maxWheatAmt = maxWheatAmt + siloBenefit;
            maxCornAmt = maxCornAmt + siloBenefit;
            maxRiceAmt = maxRiceAmt + siloBenefit;
        }
        else
        {
            //not enough coins
        }
    }

    public void upgradeSilo()
    {
        if (coins >= siloUpgradePrice)
        {
            coins = coins - siloUpgradePrice;
            siloBenefit = siloBenefit + siloUpgradeAmount;

            maxWheatAmt = maxWheatAmt + siloBenefit;
            maxCornAmt = maxCornAmt + siloBenefit;
            maxRiceAmt = maxRiceAmt + siloBenefit;

            siloUpgradeAmount = siloUpgradeAmount * 2;
            siloUpgradePrice = siloUpgradePrice * 2;
        }
        else
        {
            //not enough coins
        }
    }
}
