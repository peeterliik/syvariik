using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Game/CandidateList")]
public class CandidateList : ScriptableObject
{
    public CandidateData[] candidates;
}
