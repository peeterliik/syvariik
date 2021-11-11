using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CandidateData heldur;

    public void SetReputationGood()
    {
        heldur.SetReputationGood();
    }

    public void SetReputationBad()
    {
        heldur.SetReputationBad();
    }

    public void SetReputationTrue()
    {
        heldur.SetReputationTrue();
    }
}

