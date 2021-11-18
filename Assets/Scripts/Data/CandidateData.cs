using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/CandidateData")]

public class CandidateData : ScriptableObject
{
    public static CandidateData Instance;
    
    public string candidateName;
    public Sprite image;

    //Stats (out of 10)
    [Range(1, 10)]
    public int pressCharisma = Mathf.Clamp(5,1,10);
    [Range(1, 10)]
    public int lobbySkill = Mathf.Clamp(5, 1, 10);
    [Range(1, 10)]
    public int familyRolemodel = Mathf.Clamp(5, 1, 10);
    [Range(1, 10)]
    public int confidence = Mathf.Clamp(5, 1, 10);

    //Political views (out of 10 = 0-left, 5-middel, 10-righ etc).    
    [Range(1, 10)]
    public int leftRight = Mathf.Clamp(5, 1, 10);
    [Range(1, 10)]
    public int consLib = Mathf.Clamp(5, 1, 10);

    //Reputation (out of 10)
    [Range(1, 10)]
    public int parliament = Mathf.Clamp(5, 1, 10);
    [Range(1, 10)]
    public int electoral = Mathf.Clamp(5, 1, 10);
    [Range(1, 10)]
    public int people = Mathf.Clamp(5, 1, 10);

    int modifier;



    private void Awake()
    {
        Instance = this;
    }

    public void SetReputationGood()
    {
        modifier = Random.Range(1, 10);
        Debug.Log("Value of the modifier is: "+modifier);
        if (modifier == 1)
        {
            parliament = Mathf.Clamp(parliament - 2,1,10);
        } else
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
