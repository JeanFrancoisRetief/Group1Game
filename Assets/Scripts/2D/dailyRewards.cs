using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class dailyRewards : MonoBehaviour
{
    public playerStats playerStats;

    public GameObject reward1;
    public GameObject reward2;
    public GameObject reward3;
    public GameObject reward4;
    public GameObject reward5;

    public GameObject reward1Accept;
    public GameObject reward2Accept;
    public GameObject reward3Accept;
    public GameObject reward4Accept;
    public GameObject reward5Accept;

    public bool reward1bool;
    public bool reward2bool;
    public bool reward3bool;
    public bool reward4bool;
    public bool reward5bool;

    // Update is called once per frame
    void Update()
    {
        if (playerStats.day == 1 && reward1bool == false)
        {
            reward1.SetActive(true);
            reward2.SetActive(false);
            reward3.SetActive(false);
            reward4.SetActive(false);
            reward5.SetActive(false);
        }
        else if (playerStats.day == 1 && reward1bool == true)
        {
            reward1.SetActive(false);
            reward2.SetActive(false);
            reward3.SetActive(false);
            reward4.SetActive(false);
            reward5.SetActive(false);
        }

        if (playerStats.day == 2 && reward2bool == false)
        {
            reward1.SetActive(false);
            reward2.SetActive(true);
            reward3.SetActive(false);
            reward4.SetActive(false);
            reward5.SetActive(false);
        }
        else if (playerStats.day == 2 && reward2bool == true)
        {
            reward1.SetActive(false);
            reward2.SetActive(false);
            reward3.SetActive(false);
            reward4.SetActive(false);
            reward5.SetActive(false);
        }

        if (playerStats.day == 3 && reward3bool == false)
        {
            reward1.SetActive(false);
            reward2.SetActive(false);
            reward3.SetActive(true);
            reward4.SetActive(false);
            reward5.SetActive(false);
        }
        else if (playerStats.day == 3 && reward3bool == true)
        {
            reward1.SetActive(false);
            reward2.SetActive(false);
            reward3.SetActive(false);
            reward4.SetActive(false);
            reward5.SetActive(false);
        }

        if (playerStats.day == 4 && reward4bool == false)
        {
            reward1.SetActive(false);
            reward2.SetActive(false);
            reward3.SetActive(false);
            reward4.SetActive(true);
            reward5.SetActive(false);
        }
        else if (playerStats.day == 4 && reward4bool == true)
        {
            reward1.SetActive(false);
            reward2.SetActive(false);
            reward3.SetActive(false);
            reward4.SetActive(false);
            reward5.SetActive(false);
        }

        if (playerStats.day == 5 && reward5bool == false)
        {
            reward1.SetActive(false);
            reward2.SetActive(false);
            reward3.SetActive(false);
            reward4.SetActive(false);
            reward5.SetActive(true);
        }
        else if (playerStats.day == 5 && reward5bool == true)
        {
            reward1.SetActive(false);
            reward2.SetActive(false);
            reward3.SetActive(false);
            reward4.SetActive(false);
            reward5.SetActive(false);
        }
    }
}
