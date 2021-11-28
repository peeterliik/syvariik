using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioController : MonoBehaviour
{
    [SerializeField]
    CandidateList startingCandidates; //Only needed for initialization 

    List<Candidate> candidates = new List<Candidate>();
    Candidate currentCandidate;
    int currentIndex;

    UIPresenter UIInstance;

    private void Start()
    {
        UIInstance = UIPresenter.instance;
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

    public void switchCandiate(int direction)
    { 
        currentIndex += direction;
        if (currentIndex < 0) currentIndex = candidates.Count - 1;
        else if (currentIndex >= candidates.Count) currentIndex = 0;
        //Debug.Log(currentIndex - direction + " " + currentIndex);
        currentCandidate = candidates[currentIndex];
        UIInstance.refreshCandidate(currentCandidate);
    }
}
