﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using UnityEngine;

namespace ODFC
{
    class Log
    {
        [ConditionalAttribute("DEBUG")]
        internal static void dbg(string msg, params object[] @params)
        {
            if (0 != @params.Length) msg = string.Format(msg, @params);
            ScreenMessages.PostScreenMessage(msg, 1, ScreenMessageStyle.UPPER_CENTER, true);
            UnityEngine.Debug.Log("[ODFC TweakScale] " + msg);
        }
    }
}
