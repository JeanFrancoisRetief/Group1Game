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
    public GameObject reward6;

    public GameObject reward1Accept;
    public GameObject reward2Accept;
    public GameObject reward3Accept;
    public GameObject reward4Accept;
    public GameObject reward5Accept;

    // Update is called once per frame
    void Update()
    {
        if (playerStats.day == 1)
        {
            reward1.SetActive(true);
            reward2.SetActive(false);
            reward3.SetActive(false);
            reward4.SetActive(false);
            reward5.SetActive(false);
        }

        if (playerStats.day == 2)
        {
            reward1.SetActive(false);
            reward2.SetActive(true);
            reward3.SetActive(false);
            reward4.SetActive(false);
            reward5.SetActive(false);
        }

        if (playerStats.day == 3)
        {
            reward1.SetActive(false);
            reward2.SetActive(false);
            reward3.SetActive(true);
            reward4.SetActive(false);
            reward5.SetActive(false);
        }

        if (playerStats.day == 4)
        {
            reward1.SetActive(false);
            reward2.SetActive(false);
            reward3.SetActive(false);
            reward4.SetActive(true);
            reward5.SetActive(false);
        }

        if (playerStats.day == 5)
        {
            reward1.SetActive(false);
            reward2.SetActive(false);
            reward3.SetActive(false);
            reward4.SetActive(false);
            reward5.SetActive(true);
        }
    }
}
