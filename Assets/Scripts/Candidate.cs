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

    int modifier;

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

    public void SetReputationGood()
    {
        modifier = Random.Range(1, 10);
        Debug.Log("Value of the modifier is: " + modifier);
        if (modifier == 1)
        {
            parliament = Mathf.Clamp(parliament - 2, 1, 10);
        }
        else
        {
            parliament = Mathf.Clamp(parliament + 1, 1, 10);
        }

        TurnManager.Instance.turnLeft -= 0.33f;
    }

    public void SetReputationBad()
    {
        modifier = Random.Range(1, 10);
        Debug.Log("Value of the modifier is: " + modifier);
        if (modifier == 1)
        {
            parliament = Mathf.Clamp(parliament + 2, 1, 10);
        }
        else
        {
            parliament = Mathf.Clamp(parliament - 1, 1, 10);
        }

        TurnManager.Instance.turnLeft -= 0.33f;
    }

    public void SetReputationTrue()
    {
        int pressSkill = Mathf.RoundToInt((pressCharisma + confidence) / 2) - 5;
        Debug.Log("Value of the modifier is: " + pressSkill);
        parliament = Mathf.Clamp(parliament + pressSkill, 1, 10);

        TurnManager.Instance.turnLeft -= 0.33f;
    }

}
