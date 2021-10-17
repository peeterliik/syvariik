using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
/// More on events - https://www.youtube.com/watch?v=k4JlFxPcqlg
/// C# events or unity events? - https://www.youtube.com/watch?v=oc3sQamIh-Q
public static class Events
{
        // Event to invoke everytime a turn passes.
        public static event Action OnTurnPass;
        public static void TurnPass() => OnTurnPass.Invoke();
}
