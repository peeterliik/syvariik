using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class Elections : MonoBehaviour
{
    List<Candidate> candidates;

    public Button triggerElections;

    public AudioSource electionSound;


    void Start()
    {
        UIPresenter.Instance.refreshElectionIntro();
        //electionWinner.gameObject.SetActive(false);
        electionSound = GetComponent<AudioSource>();

    }

    public void checkForWinner()
    {
        //TO-DO calculate the winning candidate
        candidates = ScenarioController.Instance.GetCandidates();
        candidates.OrderBy(o => o.parliament);

        int maxRep = 0;
        int minRep = 10;
        int sumRep = 0;
        foreach (Candidate candidate in candidates)
        {
            sumRep += candidate.parliament;
        }

        electionSound.Play();
    }

    public void PresentWinner()
    {
        candidates = ScenarioController.Instance.GetCandidates();
        candidates = candidates.OrderBy(o => o.parliament).ToList();
        candidates.Reverse();
        int sumRep = 0;
        foreach (Candidate candidate in candidates)
        {
            Debug.Log(candidate.parliament);
            sumRep += candidate.parliament;
        }
        UIPresenter.Instance.refreshElectionOutcome(candidates, sumRep);
        candidates.RemoveAt(candidates.Count - 1); // Eliminate candidate with least score
        triggerElections.gameObject.SetActive(false);
        electionSound.Play();
    }
}
