using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A publicly accessible class that hold persistent data between scenes.
/// This includes data relating to what decisions have been made by the player.
/// </summary>
public class PersistantData : MonoBehaviour
{
    public static bool isBitten;
    public static bool befriendedSpiky;
    public static bool scn1Choice;
    public static bool scn2Choice;
    public static bool scn3Choice;
    public static bool scn4Choice;
    public static bool scn5Choice;
    public static bool scn6Choice;
    public static bool scn7Choice;

    public int GetTotalScore()
    {
        var totalScore = 0;

        if (scn1Choice)
        {
            totalScore += 1;
        }
        if (scn2Choice)
        {
            totalScore += 1;
        }
        if (scn3Choice)
        {
            totalScore += 1;
        }
        if (scn4Choice)
        {
            totalScore += 1;
        }
        if (scn5Choice)
        {
            totalScore += 1;
        }
        return totalScore;
    }
}
