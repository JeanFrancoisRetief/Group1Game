using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class request : MonoBehaviour
{
    [Header("Scripts")]
    public playerStats playerStats;

    [Header("Resources Requested")]
    public int wheatReq;
    public int cornReq;
    public int riceReq;

    public GameObject selectBtn;
    public GameObject sendBtn;

    public int pay;

    public GameObject unable;

    private void Start()
    {
        selectBtn.SetActive(true);
        sendBtn.SetActive(false);
    }

    public void Send()
    {
        if (playerStats.wheatAmt >= wheatReq && playerStats.cornAmt >= cornReq && playerStats.riceAmt >= riceReq) //checks to see if the player has enough of the resource
        {
            playerStats.coins = playerStats.coins + pay; //adds the money earned from request to the total coins
            playerStats.reqPending = playerStats.reqPending - 1; //removes one request because it was completed

            playerStats.wheatAmt = playerStats.wheatAmt - wheatReq; //subtracts once the resources are sent to requester
            playerStats.cornAmt = playerStats.cornAmt - cornReq;
            playerStats.riceAmt = playerStats.riceAmt - riceReq;

            this.gameObject.SetActive(false); //deletes the game object as the request is now complete
        }
        else
        {
            unable.SetActive(true);
        }
    }

    public void Selected()
    {
        playerStats.reqPending = playerStats.reqPending + 1; //adds to requests that need to be fulfilled

        selectBtn.SetActive(false); //disables request selected button
        sendBtn.SetActive(true); //enables button that allows us to send in the resources and complete the request
    }
}
