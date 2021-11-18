using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TurnManager : MonoBehaviour
{
    public static TurnManager Instance;

    public Image turnBar;
    public Button goodButton;
    public Button badButton;
    public Button trueButton;
    public int turnCounter;

    private float _turnLeft = 1f;
    public float turnLeft
    {
        get
        {
            return _turnLeft;
        }
        set
        {
            _turnLeft = value;
            SetTurnBar();
        }
    }

    private void Awake()
    {
        Instance = this;
        turnCounter = 0;
    }

    private void Start()
    {
        
    }


    private void Update()
    {
      if (turnLeft < 0.1)
        {
            goodButton.interactable = false;
            badButton.interactable = false;
            trueButton.interactable = false;
        } else
        {
            goodButton.interactable = true;
            badButton.interactable = true;
            trueButton.interactable = true;
        }  
    }

    public void EndTurn()
    {
        turnLeft = 1f;
        SetTurnBar();
        turnCounter += 1;
    }

    public void SetTurnBar()
    {
        turnBar.fillAmount = turnLeft;
    }

}
