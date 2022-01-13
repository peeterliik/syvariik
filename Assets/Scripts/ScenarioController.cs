using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioController : MonoBehaviour
{
    public static ScenarioController Instance;

    [SerializeField]
    CandidateList startingCandidates; //Only needed for initialization 

    [SerializeField]
    List<Candidate> candidates = new List<Candidate>();
    Candidate currentCandidate;
    int currentIndex;

    UIPresenter UIInstance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    private void Start()
    {
        UIInstance = UIPresenter.Instance;
        foreach (CandidateData c in startingCandidates.candidates)
        {
            GameObject temp = new GameObject();
            Candidate candidate = temp.AddComponent<Candidate>();
            candidate.Init(c);
            candidates.Add(Instantiate(candidate));
            Destroy(temp);
        }
        currentCandidate = candidates[0];
        UIInstance.refreshCandidate(currentCandidate);
    }


    public List<Candidate> GetCandidates()
    {
        return candidates;
    }

    public void SetCandidates(List<Candidate> list)
    {
        candidates = list;
    }


    public void switchCandiate(int direction)
    { 
        currentIndex += direction;
        if (currentIndex < 0) currentIndex = candidates.Count - 1;
        else if (currentIndex >= candidates.Count) currentIndex = 0;
        currentCandidate = candidates[currentIndex];
        UIInstance.refreshCandidate(currentCandidate);
    }

    public void SetReputationGoodButton()
    {
        SoundManager.instance.playSound(SoundManager.instance.endTurn, 2.1f);
        currentCandidate = candidates[currentIndex];
        currentCandidate.SetReputationGood();
        UIInstance.refreshPressOutcome(currentCandidate, 1);
    }

    public void SetReputationBadButton()
    {
        SoundManager.instance.playSound(SoundManager.instance.endTurn, 0.6f);
        currentCandidate = candidates[currentIndex];
        currentCandidate.SetReputationBad();
        UIInstance.refreshPressOutcome(currentCandidate, 2);
    }

    public void SetReputationTrueButton()
    {
        SoundManager.instance.playSound(SoundManager.instance.endTurn, 1);
        currentCandidate = candidates[currentIndex];
        currentCandidate.SetReputationTrue();
        UIInstance.refreshPressOutcome(currentCandidate, 3);
    }
}
