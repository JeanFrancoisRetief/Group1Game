using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class DialogueTriggerScript : MonoBehaviour
{
    public Text TextHint;

    public GameObject DialoguePanel;
    public Text DialogueText;

    public int dialogueCount = 0;
    public bool inDialogue = false;

    // Start is called before the first frame update
    void Start()
    {
        dialogueCount = 0;
        inDialogue = false;
        DialoguePanel.SetActive(false);
        DialogueText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        TextHint.text = "Press E to Talk to neighbor";
        inDialogue = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if ((Input.GetKeyDown(KeyCode.E)) && (inDialogue == false))
        {
            TextHint.text = "";
            EnterDialogue();

        }
    }

    private void OnTriggerExit(Collider other)
    {
        TextHint.text = "";
        DialoguePanel.SetActive(false);

        if (inDialogue == true)
        {
            gameObject.SetActive(false);
        }
    }

    void EnterDialogue()
    {
        inDialogue = true;
        dialogueCount++;
        DialoguePanel.SetActive(true);
        if(dialogueCount == 1)
        {
            DialogueText.text = "I'm a bit busy. Playing a new game I got today!!! Talk to you tommorow though?";
        }
        else if (dialogueCount == 2)
        {
            DialogueText.text = "Hey, can't come out now. This new game is SOOOO addictive!";
        }
        else if (dialogueCount == 3)
        {
            DialogueText.text = "(I can hear mouse clicks from the room - They must be ignoring me.)";
        }
        else
        {
            DialogueText.text = "";
        }
    }

}
