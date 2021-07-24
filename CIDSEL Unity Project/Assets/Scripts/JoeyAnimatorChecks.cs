using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoeyAnimatorChecks : MonoBehaviour
{
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void CheckAndPlayBandageAnimation(string stateName)
    {
        if (PersistantData.isBitten)
        {
            animator.Play(stateName + "Bandaged");
        }
        else
        {
            animator.Play(stateName);
        }
    }

}
