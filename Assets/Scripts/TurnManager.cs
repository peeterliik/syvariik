using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TurnManager : MonoBehaviour
{
    private int score = 1;

    private void Awake()
    {
        Events.OnSetScore += OnSetScore;
        Events.OnRequestScore += OnRequestScore;
    }

    private void OnDestroy()
    {
        Events.OnSetScore -= OnSetScore;
        Events.OnRequestScore -= OnRequestScore;
    }

    private void OnSetScore(int amount)
    {
        Debug.Log("XD" + score);
        score = amount;
    }

    private int OnRequestScore()
    {
        return score;
    }

}
