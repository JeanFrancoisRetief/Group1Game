using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class farmShop : MonoBehaviour
{
    public playerStats playerStats;
    public int item;
    public int itemSold;
    public bool findRange;

    public int wheatInShop;
    public Text txtWheatName;
    public Text txtWheatInShop;
    public Text txtWheatSale;

    public int cornInShop;
    public Text txtCornName;
    public Text txtCornInShop;
    public Text txtCornSale;

    public int riceInShop;
    public Text txtRiceName;
    public Text txtRiceInShop;
    public Text txtRiceSale;

    public int chickensInShop;
    public Text txtChickenName;
    public Text txtChickenInShop;
    public Text txtChickenSale;

    public int eggsInShop;
    public Text txtEggsName;
    public Text txtEggsInShop;
    public Text txtEggsSale;

    public int cowsInShop;
    public Text txtCowsName;
    public Text txtCowsInShop;
    public Text txtCowsSale;

    public int milkBottlesInShop;
    public Text txtMilkBottlesName;
    public Text txtMilkBottlesInShop;
    public Text txtMilkBottlesSale;

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(sellItem());

        //wheat
        txtWheatName.text = "Wheat";
        txtWheatInShop.text = "Wheat in Shop: " + wheatInShop;
        txtWheatSale.text = "Sale: 10 Coins";

        //corn
        txtCornName.text = "Corn";
        txtCornInShop.text = "Corn in Shop: " + cornInShop;
        txtCornSale.text = "Sale: 10 Coins";

        //rice
        txtRiceName.text = "Rice";
        txtRiceInShop.text = "Rice in Shop: " + riceInShop;
        txtRiceSale.text = "Sale: 10 Coins";

        //chickens
        txtChickenName.text = "Chicken Pieces";
        txtChickenInShop.text = "Chickens in Shop: " + chickensInShop;
        txtChickenSale.text = "Sale: 25 Coins";

        //eggs
        txtEggsName.text = "Eggs";
        txtEggsInShop.text = "Eggs in Shop: " + eggsInShop;
        txtEggsSale.text = "Sale: 30 Coins";

        //cows
        txtCowsName.text = "Beef Pieces";
        txtCowsInShop.text = "Cows in Shop: " + cowsInShop;
        txtCowsSale.text = "Sale: 40 Coins";

        //milk bottles
        txtMilkBottlesName.text = "Milk Bottles";
        txtMilkBottlesInShop.text = "Milk Bottles in Shop: " + milkBottlesInShop;
        txtMilkBottlesSale.text = "Sale: 10 Coins";
    }

    public IEnumerator sellItem()
    {
        if (findRange == true)
        {
            itemSold = Random.Range(0, 8);
            findRange = false;

            yield return new WaitForSeconds(30f);

            findRange = true;
        }

        #region item sold

        if (itemSold == 1)
        {
            if (wheatInShop >= 10)
            {
                wheatInShop = wheatInShop - 10;

                playerStats.coins = playerStats.coins + 10;
                playerStats.xp = playerStats.xp + 5;
            }
        }

        if (itemSold == 2)
        {
            if (cornInShop >= 10)
            {
                cornInShop = cornInShop - 10;

                playerStats.coins = playerStats.coins + 10;
                playerStats.xp = playerStats.xp + 5;
            }
        }

        if (itemSold == 3)
        {
            if (riceInShop >= 10)
            {
                riceInShop = riceInShop - 10;

                playerStats.coins = playerStats.coins + 10;
                playerStats.xp = playerStats.xp + 5;
            }
        }

        if (itemSold == 4)
        {
            if (chickensInShop >= 1)
            {
                chickensInShop = chickensInShop - 1;

                playerStats.coins = playerStats.coins + 25;
                playerStats.xp = playerStats.xp + 15;
            }
        }

        if (itemSold == 5)
        {
            if (eggsInShop >= 6)
            {
                eggsInShop = eggsInShop - 6;

                playerStats.coins = playerStats.coins + 30;
                playerStats.xp = playerStats.xp + 10;
            }
        }

        if (itemSold == 6)
        {
            if (cowsInShop >= 1)
            {
                cowsInShop = cowsInShop - 1;

                playerStats.coins = playerStats.coins + 40;
                playerStats.xp = playerStats.xp + 25;
            }
        }

        if (itemSold == 7)
        {
            if (milkBottlesInShop >= 1)
            {
                milkBottlesInShop = milkBottlesInShop - 1;

                playerStats.coins = playerStats.coins + 10;
                playerStats.xp = playerStats.xp + 10;
            }
        }

        #endregion
    }

    #region add items to shop

    public void addWheatToShop()
    {
        if (playerStats.wheatAmt >= 10)
        {
            playerStats.wheatAmt = playerStats.wheatAmt - 10;
            wheatInShop = wheatInShop + 10;
        }
    }

    public void addCornToShop()
    {
        if (playerStats.cornAmt >= 10)
        {
            playerStats.cornAmt = playerStats.cornAmt - 10;
            cornInShop = cornInShop + 10;
        }
    }

    public void addRiceToShop()
    {
        if (playerStats.riceAmt >= 10)
        {
            playerStats.riceAmt = playerStats.riceAmt - 10;
            riceInShop = riceInShop + 10;
        }
    }

    public void addChickensToShop()
    {
        if (playerStats.chickenAmt >= 1)
        {
            playerStats.chickenAmt = playerStats.chickenAmt - 1;
            chickensInShop = chickensInShop + 1;
        }
    }

    public void addEggsToShop()
    {
        if (playerStats.eggsAmt >= 6)
        {
            playerStats.eggsAmt = playerStats.eggsAmt - 6;
            eggsInShop = eggsInShop + 6;
        }
    }

    public void addCowsToShop()
    {
        if (playerStats.cowAmt >= 1)
        {
            playerStats.cowAmt = playerStats.cowAmt - 1;
            cowsInShop = cowsInShop + 1;
        }
    }

    public void addMilkBottlesToShop()
    {
        if (playerStats.milkBottlesAmt >= 1)
        {
            playerStats.milkBottlesAmt = playerStats.milkBottlesAmt - 1;
            milkBottlesInShop = milkBottlesInShop + 1;
        }
    }

    #endregion
}
