using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIPresenter : MonoBehaviour
{

    public CandidateData CandidateData;

    public TextMeshProUGUI CandidateName;
    public Image CandidadeImage;
    public TextMeshProUGUI stats;
    public TextMeshProUGUI politicalViews;
    public TextMeshProUGUI reputation;
   

    public void Awake()
    {
        CandidateName.text = CandidateData.candidateName;
        CandidadeImage.sprite = CandidateData.image;
        stats.text = "Press Charisma: " + CandidateData.pressCharisma + "\n" +
                     "Lobby Skill: " + CandidateData.lobbySkill + "\n" +
                     "Family Rolemodel: " + CandidateData.familyRolemodel + "\n" +
                     "Confidence: " + CandidateData.confidence + "\n";
        politicalViews.text = "Left(0) - Right(10): " + CandidateData.leftRight + "\n" +
                              "Conservative(0) - Liberal(0): " + CandidateData.consLib + "\n";
        reputation.text = "Parliament: " + CandidateData.parliament + "\n" +
                          "Electoral Collage: " + CandidateData.electoral + "\n" +
                          "General Public: " + CandidateData.people;
    }


    private void OnGUI()
    {
        
    }

    /*private void Start()
    {
        Events.SetScore(Events.RequestScore() + 1);
        
    }
    private void Awake()
    {
        Events.OnSetScore += OnSetScore;
    }

    private void OnDestroy()
    {
        Events.OnSetScore -= OnSetScore;
    }

    private void OnSetScore(int amount)
    {
        //testText.text = amount.ToString();
    }*/
}
