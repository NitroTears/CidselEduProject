using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    private Queue<string> names;
    private bool DialogueStarted = false;
    private bool ButtonJustPressed = false;
    private float ButtonDelayTime;
    public Text charNameText;
    public Text dialogueText;

    // Start is called before the first frame update
    void Start()
    {
        //initialise Queue object.
        sentences = new Queue<string>();
        names = new Queue<string>();
    }

    private void Update()
    {
        CheckDelay();
        if (DialogueStarted)
        {
            if (Input.GetButtonDown("Submit") && !ButtonJustPressed)
            {
                ButtonJustPressed = true;
                ButtonDelayTime = 0.3f;
                DisplayNextSentence();
            }
        }
    }
    public void StartDialogue(DialogueObject dialogue)
    {
        //charNameText.text = dialogue.name;
        names.Clear();
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        foreach (string name in dialogue.names)
        {
            names.Enqueue(name);
        }
        DialogueStarted = true;
        DisplayNextSentence();
        
    }
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string name = names.Dequeue();
        string sentence = sentences.Dequeue();
        charNameText.text = name;
        dialogueText.text = sentence;
    }
    void EndDialogue()
    {
        DialogueStarted = false;
        Debug.Log("End of conversation.");
    }

    void CheckDelay()
    {
        if (ButtonJustPressed && ButtonDelayTime > 0)
        {
            ButtonDelayTime -= Time.deltaTime;
        }
        if (ButtonDelayTime < 0)
        {
            ButtonDelayTime = 0;
            ButtonJustPressed = false;
        }
    }

}

// ~Sources~
// Button Delay: https://answers.unity.com/questions/679948/how-to-make-a-delay-on-key-input.html
// Dialogue Stuff: Brackeys
