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

    public int cropPrice;

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

    [Header("Silo")]
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

    [Header("Greenhouse")]
    public GameObject greyGH;
    public GameObject GH;
    public GameObject btnBuyGH;
    public GameObject btnUpgradeGH;
    public int lvlToUnlockGH;
    public int ghPrice;
    public int ghBenefit;
    public int ghUpgradePrice;
    public int ghUpgradeAmount;
    public Text txtGHRequiredLvl;
    public Text txtBuyGH;
    public Text txtGHUpgrade;

    [Header("Compost")]
    public GameObject greyCompost;
    public GameObject compost;
    public GameObject btnBuyCompost;
    public GameObject btnUpgradeCompost;
    public GameObject btnMakeCompost;
    public int lvlToUnlockCompost;
    public int compostPrice;
    public int compostBenefit;
    public int compostUpgradePrice;
    public Text txtCompostRequiredLvl;
    public Text txtBuyCompost;
    public Text txtCompostUpgrade;

    public int compostWheatCost;
    public int compostCornCost;
    public int compostRiceCost;
    public int compostEggsCost;

    public float compostTime;
    public float timeCompostLasts;
    public Text txtTimeCompostLasts;
    public GameObject objTimeCompostLasts;
    public bool isCompostOn;

    [Header("Requests")]
    public int reqPending;
    public Text reqPendingTxt;

    [Header("Misc")]
    public GameObject notEnoughCoins;
    public crops crops;

    // Start is called before the first frame update
    void Start()
    {
        lvl = 10;
        xp = 0;
        xpLimit = 10;
        //coins = 10;
        day = 1;
        time = 1;
        reqPending = 0;

        //silo
        greySilo.SetActive(true);
        Silo.SetActive(false);
        btnBuySilo.SetActive(true);
        btnUpgradeSilo.SetActive(false);
        siloBenefit = 10;
        siloUpgradeAmount = 10;

        //greenhouse
        greyGH.SetActive(true);
        GH.SetActive(false);
        btnBuyGH.SetActive(true);
        btnUpgradeGH.SetActive(false);
        ghBenefit = 5;
        ghUpgradeAmount = 5;

        //compost
        greyCompost.SetActive(true);
        compost.SetActive(false);
        btnBuyCompost.SetActive(true);
        btnUpgradeCompost.SetActive(false);
        btnMakeCompost.SetActive(false);
        objTimeCompostLasts.SetActive(false);
        compostBenefit = 10;
        compostTime = 10f;
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

        //greenhouse
        txtGHRequiredLvl.text = "Required Lvl to Unlock: " + lvlToUnlockGH;
        txtBuyGH.text = "Buy Greenhouse " + ghPrice + " Coins";
        txtGHUpgrade.text = "Coins: " + ghUpgradePrice;

        //compost
        txtCompostRequiredLvl.text = "Required Lvl to Unlock: " + lvlToUnlockCompost;
        txtBuyCompost.text = "Buy Compost Mixer " + compostPrice + " Coins";
        txtCompostUpgrade.text = "Coins: " + compostUpgradePrice;

        if (timeCompostLasts > 0)
        {
            timeCompostLasts -= Time.deltaTime;
        }
        else if (timeCompostLasts < 0)
        {
            timeCompostLasts = 0;
        }
        int minutes = Mathf.FloorToInt(timeCompostLasts / 60);
        int seconds = Mathf.FloorToInt(timeCompostLasts % 60);
        txtTimeCompostLasts.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void StatsMenuDropDown()
    {
        if (statsMenu == false)
        {
            statsMenu.SetActive(true);
        }
    }

    #region Silo

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
            notEnoughCoins.SetActive(true);
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

            siloUpgradeAmount = siloUpgradeAmount + 10;
            siloUpgradePrice = siloUpgradePrice * 2;
        }
        else
        {
            notEnoughCoins.SetActive(true);
        }
    }

    #endregion

    #region Greenhouse

    public void BuyGH()
    {
        if (coins >= ghPrice && lvl >= lvlToUnlockGH)
        {
            GH.SetActive(true);
            btnUpgradeGH.SetActive(true);
            btnBuyGH.SetActive(false);
            greyGH.SetActive(false);

            coins = coins - ghPrice;

            crops.yieldWheat = crops.yieldWheat + ghBenefit;
            crops.yieldCorn = crops.yieldCorn + ghBenefit;
            crops.yieldRice = crops.yieldRice + ghBenefit;
        }
        else
        {
            notEnoughCoins.SetActive(true);
        }
    }

    public void upgradeGH()
    {
        if (coins >= ghUpgradePrice)
        {
            coins = coins - ghUpgradePrice;
            ghBenefit = ghBenefit + ghUpgradeAmount;

            crops.yieldWheat = crops.yieldWheat + ghBenefit;
            crops.yieldCorn = crops.yieldCorn + ghBenefit;
            crops.yieldRice = crops.yieldRice + ghBenefit;

            ghUpgradeAmount = ghUpgradeAmount + 5;
            ghUpgradePrice = ghUpgradePrice * 2;
        }
        else
        {
            notEnoughCoins.SetActive(true);
        }
    }

    #endregion

    #region Compost

    public void BuyCompostMixer()
    {
        if (coins >= compostPrice && lvl >= lvlToUnlockCompost)
        {
            compost.SetActive(true);
            btnUpgradeCompost.SetActive(true);
            btnBuyCompost.SetActive(false);
            greyCompost.SetActive(false);
            btnMakeCompost.SetActive(true);

            coins = coins - compostPrice;
        }
        else
        {
            notEnoughCoins.SetActive(true);
        }
    }

    public void upgradeCompostMixer()
    {
        if (coins >= compostUpgradePrice)
        {
            coins = coins - compostUpgradePrice;
            compostTime = compostTime + 15f;

            compostUpgradePrice = compostUpgradePrice * 2;
        }
        else
        {
            notEnoughCoins.SetActive(true);
        }
    }

    public void makeCompost()
    {
        if (wheatAmt >= compostWheatCost && cornAmt >= compostCornCost && riceAmt >= compostRiceCost && eggsAmt >= compostEggsCost)
        {
            wheatAmt = wheatAmt - compostWheatCost;
            cornAmt = cornAmt - compostCornCost;
            riceAmt = riceAmt - compostRiceCost;
            eggsAmt = eggsAmt - compostEggsCost;

            StartCoroutine(CompostOn());
        }
    }

    public IEnumerator CompostOn()
    {
        isCompostOn = true;
        btnMakeCompost.SetActive(false);
        timeCompostLasts = compostTime;
        objTimeCompostLasts.SetActive(true);

        crops.timeToGrowWheat = crops.timeToGrowWheat - (crops.timeToGrowWheat / compostBenefit);
        crops.timeToGrowCorn = crops.timeToGrowCorn - (crops.timeToGrowCorn / compostBenefit);
        crops.timeToGrowRice = crops.timeToGrowRice - (crops.timeToGrowRice / compostBenefit);

        yield return new WaitForSeconds(timeCompostLasts);

        isCompostOn = false;
        objTimeCompostLasts.SetActive(false);

        yield return new WaitForSeconds(1f);

        crops.timeToGrowWheat = crops.timeToGrowWheat + (crops.timeToGrowWheat / compostBenefit);
        crops.timeToGrowCorn = crops.timeToGrowCorn + (crops.timeToGrowCorn / compostBenefit);
        crops.timeToGrowRice = crops.timeToGrowRice + (crops.timeToGrowRice  /compostBenefit);
        btnMakeCompost.SetActive(true);
    }

    #endregion
}
