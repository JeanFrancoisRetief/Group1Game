using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
//using UnityEditor.MPE;
//using UnityEditor.Rendering.Universal;
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
    public int gems;
    //public Text gemsTxt;
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
    //public int lvlToUnlockSilo;
    public int siloPrice;
    public int siloBenefit;
    public int siloAnimalBenefit;
    public int siloUpgradePrice;
    public int siloUpgradeAmount;
    public int siloAnimalUpgradeAmount;
    public Text txtSiloRequiredLvl;
    public Text txtBuySilo;
    public Text txtSiloUpgrade;

    [Header("Greenhouse")]
    public GameObject greyGH;
    public GameObject GH;
    public GameObject btnBuyGH;
    public GameObject btnUpgradeGH;
    //public int lvlToUnlockGH;
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
    //public int lvlToUnlockCompost;
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

    public GameObject greyTransport;
    public GameObject transport;
    public GameObject btnBuyTransport;
    public GameObject btnUpgradeTransport;
    //public int lvlToUnlockTransport;
    public int transportPrice;
    public int transportBenefit;
    public int transportUpgradePrice;
    public int transportUpgradeAmount;
    public Text txtTransportRequiredLvl;
    public Text txtBuyTransport;
    public Text txtTransportUpgrade;

    [Header("Shop")]
    public GameObject greyShop;
    public GameObject shop;
    public GameObject btnBuyShop;
    //public int lvlToUnlockShop;
    public int shopPrice;
    public Text txtShopRequiredLvl;
    public Text txtBuyShop;
    public farmShop farmShop;

    [Header("Misc")]
    public GameObject notEnoughCoins;
    public crops crops;
    public Global global;

    // Start is called before the first frame update
    void Start()
    {
        lvl = 5;
        xp = 0;
        xpLimit = 10;
        time = 1;
        reqPending = 0;

        //silo
        greySilo.SetActive(true);
        Silo.SetActive(false);
        btnBuySilo.SetActive(true);
        btnUpgradeSilo.SetActive(false);
        siloBenefit = 10;
        siloAnimalBenefit = 2;
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

        //transport
        greyTransport.SetActive(true);
        transport.SetActive(false);
        btnBuyTransport.SetActive(true);
        btnUpgradeTransport.SetActive(false);
        transportBenefit = 0;
        transportUpgradeAmount = 5;

        //shop
        greyShop.SetActive(true);
        shop.SetActive(false);
        btnBuyShop.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        day = global.DayCounter - 1;
        dayTxt.text = "Day: " + day;
        timeTxt.text = " ";

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

        //silo
        //txtSiloRequiredLvl.text = "Required Lvl to Unlock: " + lvlToUnlockSilo;
        txtBuySilo.text = "Buy Silo " + siloPrice + " Coins";
        txtSiloUpgrade.text = "Coins: " + siloUpgradePrice;

        //greenhouse
        //txtGHRequiredLvl.text = "Required Lvl to Unlock: " + lvlToUnlockGH;
        txtBuyGH.text = "Buy Greenhouse " + ghPrice + " Coins";
        txtGHUpgrade.text = "Coins: " + ghUpgradePrice;

        //compost
        //txtCompostRequiredLvl.text = "Required Lvl to Unlock: " + lvlToUnlockCompost;
        txtBuyCompost.text = "Buy Compost Mixer " + compostPrice + " Coins";
        txtCompostUpgrade.text = "Coins: " + compostUpgradePrice;

        //transport
        //txtTransportRequiredLvl.text = "Required Lvl to Unlock: " + lvlToUnlockTransport;
        txtBuyTransport.text = "Buy Transport Vehicle " + transportPrice + " Coins";
        txtTransportUpgrade.text = "Coins: " + transportUpgradePrice;

        //shop
        //txtShopRequiredLvl.text = "Required Lvl to Unlock: " + lvlToUnlockShop;
        txtBuyShop.text = "Buy Shop " + shopPrice + " Coins";
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
        if (coins >= siloPrice)
        {
            Silo.SetActive(true);
            btnUpgradeSilo.SetActive(true);
            btnBuySilo.SetActive(false);
            greySilo.SetActive(false);

            coins = coins - siloPrice;
            maxWheatAmt = maxWheatAmt + siloBenefit;
            maxCornAmt = maxCornAmt + siloBenefit;
            maxRiceAmt = maxRiceAmt + siloBenefit;

            maxEggsAmt = maxEggsAmt + siloAnimalBenefit;
            maxMilkBottlesAmt = maxMilkBottlesAmt + siloAnimalBenefit;

            xp = xp + 50;
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
            siloAnimalBenefit = siloAnimalBenefit + siloAnimalUpgradeAmount;

            maxWheatAmt = maxWheatAmt + siloBenefit;
            maxCornAmt = maxCornAmt + siloBenefit;
            maxRiceAmt = maxRiceAmt + siloBenefit;

            maxEggsAmt = maxEggsAmt + siloAnimalBenefit;
            maxMilkBottlesAmt = maxMilkBottlesAmt + siloAnimalBenefit;

            siloUpgradeAmount = siloUpgradeAmount + 10;
            siloAnimalUpgradeAmount = siloAnimalUpgradeAmount + 2;
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
        if (coins >= ghPrice)
        {
            GH.SetActive(true);
            btnUpgradeGH.SetActive(true);
            btnBuyGH.SetActive(false);
            greyGH.SetActive(false);

            coins = coins - ghPrice;

            crops.yieldWheat = crops.yieldWheat + ghBenefit;
            crops.yieldCorn = crops.yieldCorn + ghBenefit;
            crops.yieldRice = crops.yieldRice + ghBenefit;

            xp = xp + 300;
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
        if (coins >= compostPrice)
        {
            compost.SetActive(true);
            btnUpgradeCompost.SetActive(true);
            btnBuyCompost.SetActive(false);
            greyCompost.SetActive(false);
            btnMakeCompost.SetActive(true);

            coins = coins - compostPrice;

            xp = xp + 150;
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

    #region Transport

    public void BuyTransport()
    {
        if (coins >= transportPrice)
        {
            transport.SetActive(true);
            btnUpgradeTransport.SetActive(true);
            btnBuyTransport.SetActive(false);
            greyTransport.SetActive(false);

            coins = coins - transportPrice;

            transportBenefit = transportBenefit + 5;

            xp = xp = 150;
        }
        else
        {
            notEnoughCoins.SetActive(true);
        }
    }

    public void upgradeTransport()
    {
        if (coins >= transportUpgradePrice)
        {
            coins = coins - transportUpgradePrice;
            transportBenefit = transportBenefit + transportUpgradeAmount;

            transportUpgradeAmount = transportUpgradeAmount + 5;
            transportUpgradePrice = transportUpgradePrice * 2;
        }
        else
        {
            notEnoughCoins.SetActive(true);
        }
    }

    #endregion

    #region Shop

    public void BuyShop()
    {
        if (coins >= shopPrice)
        {
            shop.SetActive(true);
            btnBuyShop.SetActive(false);
            greyShop.SetActive(false);

            coins = coins - shopPrice;
            farmShop.findRange = true;

            xp = xp + 500;
        }
        else
        {
            notEnoughCoins.SetActive(true);
        }
    }

    #endregion
}
