using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIPresenter : MonoBehaviour
{
    //public CandidateData[] candidateList;
    private int currentCandidateIndex = 1;
    public CandidateData candidate1;
    public CandidateData candidate2;
    CandidateData candidate;
    public TextMeshProUGUI CandidateName;
    public Image CandidadeImage;
    public TextMeshProUGUI stats;
    public TextMeshProUGUI politicalViews;
    public TextMeshProUGUI reputation;

    private void Awake()
    {
        currentCandidateIndex = 1;
    }

    private void Start()
    {
        candidate = candidate1;
        //candidate = candidateList[currentCandidateIndex];

        //Debug.Log("Candidate: " + candidateList[currentCandidateIndex].name + " Candidates: " + candidateList.Length + "; Index: " + currentCandidateIndex);
        //candidate = candidateList[currentCandidateIndex];
        CandidateName.text = candidate.candidateName;
        CandidadeImage.sprite = candidate.image;
        stats.text = "Press Charisma: " + candidate.pressCharisma + "\n" +
                     "Lobby Skill: " + candidate.lobbySkill + "\n" +
                     "Family Rolemodel: " + candidate.familyRolemodel + "\n" +
                     "Confidence: " + candidate.confidence + "\n";
        politicalViews.text = "Left(0) - Right(10): " + candidate.leftRight + "\n" +
                              "Conservative(0) - Liberal(0): " + candidate.consLib + "\n";
        reputation.text = "Parliament: " + candidate.parliament + "\n" +
                          "Electoral Collage: " + candidate.electoral + "\n" +
                          "General Public: " + candidate.people;
    }

    public void switchCandidate()
    {
        if (currentCandidateIndex == 1)
        {
            currentCandidateIndex = 2;
            candidate = candidate2;
        }
        else
        {
            currentCandidateIndex = 1;
            candidate = candidate1;
        }
        //Debug.Log(currentCandidateIndex);
        //Debug.Log("Candidate: " + candidateList[currentCandidateIndex].name + " Candidates: " + candidateList.Length + "; Index: " + currentCandidateIndex);
        //Debug.Log("pre: " + currentCandidateIndex);
        /*if (currentCandidateIndex >= candidateList.Length)
        {
            currentCandidateIndex = 0;
        }
        else if (currentCandidateIndex < 0)
        {
            currentCandidateIndex = candidateList.Length - 1;
        }
        Debug.Log(currentCandidateIndex + " " + candidateList.Count);*/

        CandidateName.text = candidate.candidateName;
        CandidadeImage.sprite = candidate.image;
        stats.text = "Press Charisma: " + candidate.pressCharisma + "\n" +
                     "Lobby Skill: " + candidate.lobbySkill + "\n" +
                     "Family Rolemodel: " + candidate.familyRolemodel + "\n" +
                     "Confidence: " + candidate.confidence + "\n";
        politicalViews.text = "Left(0) - Right(10): " + candidate.leftRight + "\n" +
                              "Conservative(0) - Liberal(0): " + candidate.consLib + "\n";
        reputation.text = "Parliament: " + candidate.parliament + "\n" +
                          "Electoral Collage: " + candidate.electoral + "\n" +
                          "General Public: " + candidate.people;
    }
}
