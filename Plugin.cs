using UnityEngine;
using BepInEx;

namespace OpGui
{
    [BepInPlugin("microsoft.op.ui", "microsoft.op.ui", "1.0.1")]
    public class GUI : BaseUnityPlugin
    {
        UnityEngine.GUI.color = Color.black;
        if (GUI.Button(new Rect(0f, 0f, 280f, 35f), "Lag All"))
        {
            Debug.Log("Button clicked!"); 
        }
    }
}
