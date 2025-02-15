using UnityEngine;
using BepInEx;

namespace OpGui
{
    [BepInPlugin("Your.Name.Here", "Your.Name.Here", "1.0.0")]
    public class GUI : BaseUnityPlugin
    {
        UnityEngine.GUI.color = Color.black;
    }
}
