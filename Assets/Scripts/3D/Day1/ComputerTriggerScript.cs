using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using System.Xml.Serialization;

public class ComputerTriggerScript : MonoBehaviour
{
    public Text TextHint;

    public Scene CurrentScene;

    public Global globalScript;

    public GameObject farm;

    public GameObject player;

    //time
    public int frameCounter;
    public int seconds;

    //start message
    public Text StartText;
    public Color zm;  //  makes a new color zm

    // Start is called before the first frame update
    void Start()
    {
        TextHint.text = "";
        CurrentScene = SceneManager.GetActiveScene();

        frameCounter = 0;
        seconds = 0;

        StartText.text = "Monday 10:23 AM";
        zm = StartText.color;
        zm.a = 255f;

        StartText.color = zm;
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(Cursor.lockState);

        if (farm)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else 
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        //time
        frameCounter++;
        zm.a--;

        if (zm.a <= 0)
        {
            zm.a = 0;
        }

        StartText.color = zm;

        if (frameCounter >= 60 && farm)
        {
            seconds++;

            frameCounter = 0;
        }

        if (seconds >= 60*3)
        {
            farm.SetActive(false);

            if (globalScript.DayCounter == 2)
            {
                StartText.text = "Tuesday 09:03 AM";
            }

            if (globalScript.DayCounter == 3)
            {
                StartText.text = "Wednesday 07:12 AM";
            }

            if (globalScript.DayCounter == 4)
            {
                StartText.text = "Thursday 17:16 PM";
            }

            if (globalScript.DayCounter == 5)
            {
                StartText.text = "???";
            }

            if (seconds == 60 * 3)
            {
                StartCoroutine(startText());
            }

            seconds = 0;
        }
    }

    public IEnumerator startText()
    {
        zm = StartText.color;
        zm.a = 240f;

        StartText.color = zm;
        
        StartText.enabled = true;

        yield return new WaitForSeconds(4f);

        zm.a = 0;

        StartText.enabled = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        TextHint.text = "Press E to USE the Computer";
    }

    private void OnTriggerStay(Collider other)
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            TextHint.text = "";
            OpenComputer();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        TextHint.text = "";
    }

    void OpenComputer()
    {
        //Debug.Log("Open Computer 2");
        //TextHint.text = "Computer";
        if (globalScript.DayCounter == 1/*CurrentScene.name == "3D_Day1"*/)
        {
            //SceneManager.LoadScene("3D_Day2");//for testing purposes
            globalScript.SwitchDay1ToDay2();

            farm.SetActive(true);

            player.SetActive(false);

            player.transform.position = new Vector3 (0, 30.6f, -2.58f);

            player.SetActive(true);
        }

        else if (globalScript.DayCounter == 2/*CurrentScene.name == "3D_Day2"*/)
        {
            //SceneManager.LoadScene("3D_Day3");
            globalScript.SwitchDay2ToDay3();

            farm.SetActive(true);

            player.SetActive(false);

            player.transform.position = new Vector3(0, 30.6f, -2.58f);

            player.SetActive(true);
        }

        else if (globalScript.DayCounter == 3/*CurrentScene.name == "3D_Day3"*/)
        {
            //SceneManager.LoadScene("3D_Day4");
            globalScript.SwitchDay3ToDay4();

            farm.SetActive(true);

            player.SetActive(false);

            player.transform.position = new Vector3(0, 30.6f, -2.58f);

            player.SetActive(true);
        }

        else if (globalScript.DayCounter == 4/*CurrentScene.name == "3D_Day4"*/)
        {
            //SceneManager.LoadScene("3D_Day5");
            globalScript.SwitchDay4ToDay5();

            farm.SetActive(true);

            player.SetActive(false);

            player.transform.position = new Vector3(-7.74f, 30.11f, 20.56f);

            player.SetActive(true);
        }

    }

}
