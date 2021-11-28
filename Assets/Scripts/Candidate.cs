using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candidate : MonoBehaviour
{
    //CandidateData tempData;
    public string candidateName;
    public Sprite image;



    //Stats (out of 10)
    [Range(1, 10)]
    public int pressCharisma;
    [Range(1, 10)]
    public int lobbySkill;
    [Range(1, 10)]
    public int familyRolemodel;
    [Range(1, 10)]
    public int confidence;

    //Political views (out of 10 = 0-left, 5-middel, 10-righ etc).    
    [Range(1, 10)]
    public int leftRight;
    [Range(1, 10)]
    public int consLib;

    //Reputation (out of 10)
    [Range(1, 10)]
    public int parliament;
    [Range(1, 10)]
    public int electoral;
    [Range(1, 10)]
    public int people;

    // Factory method as constructors aren't applicable for MonoBehaviours.
    public void Init(CandidateData data) 
    {
        //tempData = data;
        candidateName = data.candidateName;
        image = data.image;
        pressCharisma = data.pressCharisma;
        lobbySkill = data.lobbySkill;
        familyRolemodel = data.familyRolemodel;
        confidence = data.confidence;
        leftRight = data.leftRight;
        consLib = data.consLib;
        parliament = data.parliament;
        electoral = data.electoral;
        people = data.people;
    }

}
