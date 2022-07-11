using System.Collections;
using System.Collections.Generic;
using PlasticGui.Help;
using UnityEngine;
using XDiffGui;

namespace WarSim
{
    public static class WarSimDebug
    {
        public static void Info(string msg)
        {
            Debug.Log(msg);
        }


        public static void Warning(string msg)
        {
            Debug.LogWarning(msg);
        }

        public static void Error(string msg)
        {
            Debug.LogError(msg);
        }

        public static void Assert(bool assertion, string msg)
        {
            if (!assertion)
            {
                Debug.LogError(msg);
            }
        }
        
    }

}
