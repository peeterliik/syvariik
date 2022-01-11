using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// This class takes care of everything related to UI rendering

public class UIPresenter : MonoBehaviour
{
    public static UIPresenter instance{get; private set;}

    public StoryPool storyPool;

    //CandidateData currentCandidate;
    // Main panel fields
    public TextMeshProUGUI CandidateName;
    public Image CandidadeImage;
    public TextMeshProUGUI stats;
    public TextMeshProUGUI politicalViews;
    // Press panel fields
    public TextMeshProUGUI pressCandidateName;
    public TextMeshProUGUI pressReputation;

    private void Awake()
    {
        storyPool = GetComponent<StoryPool>();
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
        stats.text = "<b>"+"Press Charisma: " + "</b>" + storyPool.GetPressStatsText(candidate.pressCharisma) + "\n\n" +
                        "<b>" + "Lobby Skill: " + "</b>" + storyPool.GetLobbyStatsText(candidate.lobbySkill) + "\n\n" +
                        "<b>" + "Family Rolemodel: " + "</b>" + storyPool.GetFamiliyStatsText(candidate.familyRolemodel) + "\n\n" +
                        "<b>" + "Confidence: " + "</b>" + storyPool.GetConfidenceText(candidate.confidence) + "\n\n";
        politicalViews.text = "<b>" + "Political Views: " + "</b>" + storyPool.GetPoliticalLeftRigh(candidate.leftRight) + "\n" +
                               storyPool.GetPoliticalConLib(candidate.consLib);
    }

    public void refreshPress(Candidate candidate)
    {
        pressCandidateName.text = candidate.candidateName;

        pressReputation.text = "Press has a big impact on candidates’ reputation. With good press the reputation will boost and with bad it will deteriorate. " +
            "But be careful, your intentions can backfire. There is a possibility that good can be too good to be true and bad can make the public actually feel " +
            "sorry for the candidate." + "\n\n" + "If you want to leave it all on the candidate – choose true press and the outcome will be decided purely on the media " +
            "skill and confidence of the candidate.";
    }

    public void refreshPressOutcome(Candidate candidate, int option)
    {
        if (option == 1)
        {
            pressReputation.text = "Major outlet publishes a feature on the potential new president of Hekrestan. It really sounds believable. ";
        }
        else if (option == 2)
        {
            pressReputation.text = "Katrin Lust makes a story about the candidate and finds out that the wannabe new president has a criminal record with multiple sexual assault allegations. ";
        } 
        else if (option == 3)
        {
            pressReputation.text = "The candidate gives half an hour interview to the biggest news channel in the country.";
            if (((candidate.pressCharisma+candidate.confidence)/2)>7)
            {
                pressReputation.text += " Everyone talks about it the next day. They think they have found the right president.";
            } else if (((candidate.pressCharisma + candidate.confidence)/2)>4)
            {
                pressReputation.text += " Nobody really remembers the drab show the next day. Or who the hell was actually on it.";
            } else
            {
                pressReputation.text += " Everyone talks about it the next day. Because it was an absolute trainwreck! ";
            }
        }
    }

}
