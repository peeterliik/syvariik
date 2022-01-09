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
    
    public string winnerName;
    public string loserName;

    public int stage = 1;

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
        List<Candidate> candidates = ScenarioController.Instance.GetCandidates();
        int maxRep = 0;
        int minRep = 10;
        string stageName = "parliament";

        switch (stage)
        {
            case 1:
                foreach (Candidate candidate in candidates)
                {
                    int value = candidate.parliament;
                    if (value > maxRep)
                    {
                        maxRep = value;
                        winnerName = candidate.candidateName;
                    }
                    if (value < minRep)
                    {
                        minRep = value;
                        loserName = candidate.candidateName;
                    }

                }
                break;
            case 2:
                foreach (Candidate candidate in candidates)
                {
                    int value = candidate.electoral;
                    if (value > maxRep)
                    {
                        maxRep = value;
                        winnerName = candidate.candidateName;
                    }
                    if (value < minRep)
                    {
                        minRep = value;
                        loserName = candidate.candidateName;
                    }

                }
                break;
            case 3:
                foreach (Candidate candidate in candidates)
                {
                    int value = candidate.people;
                    if (value > maxRep)
                    {
                        maxRep = value;
                        winnerName = candidate.candidateName;
                    }
                    if (value < minRep)
                    {
                        minRep = value;
                        loserName = candidate.candidateName;
                    }

                }
                break;
        };

        electionSound.Play();
    }

    public void PresentWinner()
    {
        GetWinner();
        introText.text = "And the winner is: ";
        electionWinner.text = winnerName;
        electionWinner.gameObject.SetActive(true);
        triggerElections.gameObject.SetActive(false);
        stage += 1;

    }
}
