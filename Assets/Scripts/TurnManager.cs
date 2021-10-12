using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
/// <summary> PLACEHOLDER </summary>
public class TurnManager : MonoBehaviour
{
    private int score = 1;

    private void Awake()
    {
        Events.OnSetScore += OnSetScore; //Subscribing method to event
        Events.OnRequestScore += OnRequestScore;
    }

    private void OnDestroy()
    {
        Events.OnSetScore -= OnSetScore; //Unsubscribing method from event
        Events.OnRequestScore -= OnRequestScore;
    }

    private void OnSetScore(int amount)
    {
        score = amount;
    }

    private int OnRequestScore()
    {
        return score;
    }

}
