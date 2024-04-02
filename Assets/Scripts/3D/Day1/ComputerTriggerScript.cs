using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class ComputerTriggerScript : MonoBehaviour
{
    public Text TextHint;
    // Start is called before the first frame update
    void Start()
    {
        TextHint.text = "";
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
    }

}
