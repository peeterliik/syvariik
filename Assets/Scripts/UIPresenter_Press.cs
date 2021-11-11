using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIPresenter_Press : MonoBehaviour
{

    public CandidateData CandidateData;

    public TextMeshProUGUI CandidateName;
    
    public TextMeshProUGUI reputation;


    public void Update()
    {
        CandidateName.text = CandidateData.candidateName;
       
        reputation.text = "Parliament: " + CandidateData.parliament + "\n" +
                          "Electoral Collage: " + CandidateData.electoral + "\n" +
                          "General Public: " + CandidateData.people;
    }
}
