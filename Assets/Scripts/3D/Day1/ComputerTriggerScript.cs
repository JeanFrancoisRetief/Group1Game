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

    // Start is called before the first frame update
    void Start()
    {
        TextHint.text = "";
        CurrentScene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        
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
        if(CurrentScene.name == "3D_Day1")
        {
            SceneManager.LoadScene("3D_Day2");//for testing purposes
        }

        if (CurrentScene.name == "3D_Day2")
        {
            SceneManager.LoadScene("3D_Day3");
        }

        if (CurrentScene.name == "3D_Day3")
        {
            SceneManager.LoadScene("3D_Day4");
        }

        if (CurrentScene.name == "3D_Day4")
        {
            SceneManager.LoadScene("3D_Day5");
        }

    }

}
