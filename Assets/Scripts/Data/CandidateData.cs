using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/CandidateData")]

public class CandidateData : ScriptableObject
{
    public string candidateName;
    public Sprite image;
    
    //Stats (out of 10)
    public int pressCharisma;
    public int lobbySkill;
    public int familyRolemodel;
    public int confidence;

    //Political views (out of 10 = 0-left, 5-middel, 10-righ etc).    
    public int leftRight;
    public int consLib;

    //Reputation (out of 10)
    public int parliament;
    public int electoral;
    public int people;

  
}
