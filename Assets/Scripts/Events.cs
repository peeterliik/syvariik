using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
/// <summary> All of the code here is placeholder, keeping it so I know how to start when we need to make events. </summary>
/// More on events - https://www.youtube.com/watch?v=k4JlFxPcqlg
/// C# events or unity events? - https://www.youtube.com/watch?v=oc3sQamIh-Q
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
