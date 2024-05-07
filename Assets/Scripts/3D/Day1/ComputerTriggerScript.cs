using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class ComputerTriggerScript : MonoBehaviour
{
    public Text TextHint;

    public Scene CurrentScene;

    public Global globalScript;

    public GameObject farm;

    // Start is called before the first frame update
    void Start()
    {
        TextHint.text = "";
        CurrentScene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        if (!farm)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
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

        }

        else if (globalScript.DayCounter == 2/*CurrentScene.name == "3D_Day2"*/)
        {
            //SceneManager.LoadScene("3D_Day3");
            globalScript.SwitchDay2ToDay3();
        }

        else if (globalScript.DayCounter == 3/*CurrentScene.name == "3D_Day3"*/)
        {
            //SceneManager.LoadScene("3D_Day4");
            globalScript.SwitchDay3ToDay4();
        }

        else if (globalScript.DayCounter == 4/*CurrentScene.name == "3D_Day4"*/)
        {
            //SceneManager.LoadScene("3D_Day5");
            globalScript.SwitchDay4ToDay5();
        }

    }

}
