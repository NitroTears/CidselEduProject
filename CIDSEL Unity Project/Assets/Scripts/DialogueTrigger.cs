using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class DialogueTrigger : MonoBehaviour
{
    public DialogueObject dialogue;
    public TimelineAsset cutsceneTimeline;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue, cutsceneTimeline);
    }
}
