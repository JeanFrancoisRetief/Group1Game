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

    public GameObject reward2Gem;
    public GameObject reward3Gem;
    public GameObject reward4Gem;
    public GameObject reward5Gem;
    public GameObject reward6Gem;

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
            reward6.SetActive(false);

            reward2Gem.SetActive(true);
            reward3Gem.SetActive(false);
            reward4Gem.SetActive(false);
            reward5Gem.SetActive(false);
            reward6Gem.SetActive(false);
        }

        if (playerStats.day == 2)
        {
            reward1.SetActive(false);
            reward2.SetActive(true);
            reward3.SetActive(false);
            reward4.SetActive(false);
            reward5.SetActive(false);
            reward6.SetActive(false);

            reward2Gem.SetActive(false);
            reward3Gem.SetActive(true);
            reward4Gem.SetActive(false);
            reward5Gem.SetActive(false);
            reward6Gem.SetActive(false);
        }

        if (playerStats.day == 3)
        {
            reward1.SetActive(false);
            reward2.SetActive(false);
            reward3.SetActive(true);
            reward4.SetActive(false);
            reward5.SetActive(false);
            reward6.SetActive(false);

            reward2Gem.SetActive(false);
            reward3Gem.SetActive(false);
            reward4Gem.SetActive(true);
            reward5Gem.SetActive(false);
            reward6Gem.SetActive(false);
        }

        if (playerStats.day == 4)
        {
            reward1.SetActive(false);
            reward2.SetActive(false);
            reward3.SetActive(false);
            reward4.SetActive(true);
            reward5.SetActive(false);
            reward6.SetActive(false);

            reward2Gem.SetActive(false);
            reward3Gem.SetActive(false);
            reward4Gem.SetActive(false);
            reward5Gem.SetActive(true);
            reward6Gem.SetActive(false);
        }

        if (playerStats.day == 5)
        {
            reward1.SetActive(false);
            reward2.SetActive(false);
            reward3.SetActive(false);
            reward4.SetActive(false);
            reward5.SetActive(true);
            reward6.SetActive(false);

            reward2Gem.SetActive(false);
            reward3Gem.SetActive(false);
            reward4Gem.SetActive(false);
            reward5Gem.SetActive(false);
            reward6Gem.SetActive(true);
        }
    }
}
