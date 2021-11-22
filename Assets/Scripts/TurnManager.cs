using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TurnManager : MonoBehaviour
{
    public static TurnManager Instance;

    public AudioSource endTurn;
    public GameObject electionsPanel;
    public GameObject turnPanel;

    public int activeStage = 1;

    public Image turnBar;
    public Button goodButton;
    public Button badButton;
    public Button trueButton;
    public int turnCounter;
    public int weekCounter;
    public TextMeshProUGUI week;

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
        endTurn = GetComponent<AudioSource>();
    }

    private void Start()
    {
        
    }


    private void Update()
    {
        week.text = "Week " + weekCounter;


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
        endTurn.Play();
        turnLeft = 1f;
        SetTurnBar();
        turnCounter += 1;
        if (turnCounter == 3)
        {                
           weekCounter += 1;
           turnCounter = 0;
        }

        if (weekCounter == 3)
        {
            electionsPanel.SetActive(true);
            turnPanel.SetActive(false);
            
        }
    }

    public void NextStage()
    {
        electionsPanel.SetActive(false);
        turnPanel.SetActive(true);
        activeStage += 1;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void SetTurnBar()
    {
        turnBar.fillAmount = turnLeft;
    }

}
