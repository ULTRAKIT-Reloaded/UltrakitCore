﻿using BepInEx;
using BepInEx.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltrakitCore
{
    [BepInPlugin("ULTRAKIT.core", "ULTRAKIT Core", "1.0.0")]
    public class Mod : BaseUnityPlugin
    {
        public static new ManualLogSource Logger { get; private set; }

        private void Awake()
        {
            Logger = base.Logger;
        }
    }
}