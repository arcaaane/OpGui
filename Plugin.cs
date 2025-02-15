using UnityEngine;
using BepInEx;

namespace OptimizeX
{
    [BepInPlugin("microsoft.optimize.x", "microsoft.optimize.x", "1.0.1")]
    public class GUI : BaseUnityPlugin
    {
        public static void TextureLimit()
        {
            QualitySettings.globalTextureMipmapLimit = 99999;
        }

        public static void DisableTextureLimit()
        {
            QualitySettings.globalTextureMipmapLimit = 1;
        }

        public static void LowerFps()
        {
            Application.targetFrameRate = 30;
        }
        
        UnityEngine.GUI.color = Color.black;
        if (GUI.Button(new Rect(0f, 0f, 280f, 35f), "Lag All"))
        {
            Debug.Log("Button clicked!"); 
        }
    }
}
