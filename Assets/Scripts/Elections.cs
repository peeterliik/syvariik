using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Elections : MonoBehaviour
{
    public TextMeshProUGUI introText;
    public TextMeshProUGUI electionWinner;
    public Button triggerElections;
    public CandidateData winner;
    public string winnerName;

    public AudioSource electionSound;

    void Start()
    {
        introText.text = "Time to elect the president!";
        electionWinner.gameObject.SetActive(false);
        electionSound = GetComponent<AudioSource>();
    }

    public void GetWinner()
    {
        //TO-DO calculate the winning candidate
        winnerName = winner.candidateName;
        electionSound.Play();
    }

    public void PresentWinner()
    {
        GetWinner();
        introText.text = "And the winner is: ";
        electionWinner.text = winnerName;
        electionWinner.gameObject.SetActive(true);
        triggerElections.gameObject.SetActive(false);

    }

    
    void Update()
    {
        
    }
}