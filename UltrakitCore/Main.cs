using BepInEx;
using BepInEx.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTRAKIT.Core
{
    [BepInPlugin("ULTRAKIT.Core", "ULTRAKIT Core", "1.0.0")]
    public class Mod : BaseUnityPlugin
    {
        public static new ManualLogSource Logger { get; private set; }

        private void Awake()
        {
            AssetLoader.RegisterAssets();

            Logger = base.Logger;
            Logger.LogInfo("ULTRAKIT Module Loaded: Core Module");
        }
    }
}
