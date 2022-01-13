using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class Elections : MonoBehaviour
{
    List<Candidate> candidates;

    public AudioSource electionSound;

    private void OnEnable()
    {
        UIPresenter.Instance.refreshElectionIntro();
        //electionWinner.gameObject.SetActive(false);
        electionSound = GetComponent<AudioSource>();
    }

    public void PresentWinner()
    {
        candidates = ScenarioController.Instance.GetCandidates();
        candidates = candidates.OrderBy(o => o.parliament).ToList();
        candidates.Reverse();
        ScenarioController.Instance.SetCandidates(candidates);
        int sumRep = 0;
        foreach (Candidate candidate in candidates)
        {
            sumRep += candidate.parliament;
        }
        Debug.Log(candidates[0].parliament / (float)sumRep);
        if (candidates[0].parliament/(float)sumRep>=0.51) // Election won, game ends
        {
            UIPresenter.Instance.refreshElectionWinOutcome(candidates[0], sumRep);
            UIPresenter.Instance.triggerElectionsButton.gameObject.SetActive(false);
        }
        else if (TurnManager.Instance.activeStage==3) {
            UIPresenter.Instance.refreshElectionLoseOutcome();
            UIPresenter.Instance.triggerElectionsButton.gameObject.SetActive(false);
        }
        else // Election continues
        {
            UIPresenter.Instance.refreshElectionContinueOutcome(candidates, sumRep);
            candidates.Remove(candidates[candidates.Count - 1]); // Eliminate candidate with least score
            UIPresenter.Instance.triggerElectionsButton.gameObject.SetActive(false);
        }
        electionSound.Play();
    }
}
