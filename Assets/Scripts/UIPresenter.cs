using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// This class takes care of everything related to UI rendering

public class UIPresenter : MonoBehaviour
{
    public static UIPresenter instance{get; private set;}

//CandidateData currentCandidate;
    // Main panel fields
    public TextMeshProUGUI CandidateName;
    public Image CandidadeImage;
    public TextMeshProUGUI stats;
    public TextMeshProUGUI politicalViews;
    public TextMeshProUGUI reputation;
    // Press panel fields


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void refreshCandidate(Candidate candidate)
    {
        refreshMain(candidate);
        refreshPress(candidate);
    }

    public void refreshMain(Candidate candidate)
    {
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

    public void refreshPress(Candidate candidate)
    {
        CandidateName.text = candidate.candidateName;

        reputation.text = "Parliament: " + candidate.parliament + "\n" +
                          "Electoral Collage: " + candidate.electoral + "\n" +
                          "General Public: " + candidate.people;
    }
}
