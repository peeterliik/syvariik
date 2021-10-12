using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class Events
{
    public static event Action<int> OnSetScore;

    public static void SetScore(int value) => OnSetScore?.Invoke(value); //OnSetScore? checks if null or not

    public static event Func<int> OnRequestScore;
    public static int RequestScore() => OnRequestScore?.Invoke() ?? 0; //?? 0 default value


    // - Or alternatively -
    /*public static void SetScore(int value)
    //{
        if (OnSetScore!=null) {

        }
        //OnSetScore.Invoke();
    //} */

}
