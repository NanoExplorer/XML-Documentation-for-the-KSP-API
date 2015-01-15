#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;

/// <summary>
/// Apply this attribute to a function in a PartModule to make it callable by the player via
/// the right click menu of the part, or from other plugin code via Part.SendEvent.
/// </summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class KSPEvent : Attribute
{
    /// <summary>
    /// Whether this event can be triggered through Part.SendEvent. Defaults to true.
    /// </summary>
    public bool active;

    /// <summary>
    /// Only has an effect if guiActiveUnfocused is true, then it controls 
    /// whether the event is active for nearby vessels or only for nearby EVAs. 
    /// The default value is true, which means that the event is only active 
    /// for nearby EVAs and not for nearby vessels.
    /// </summary>
    public bool externalToEVAOnly;

    /// <summary>
    /// Whether the event is shown as available in the right click menu during 
    /// flight (active must also be true).
    /// </summary>
    public bool guiActive;

    /// <summary>
    /// Whether the event is shown as available in the right click menu in the editor (active must also be true).
    /// </summary>
    public bool guiActiveEditor;

    /// <summary>
    /// Whether the event is shown as available in the right click menu even when
    /// the part is on a ship not currently being controlled by the player (but
    /// close enough to right click). For example during EVA.
    /// </summary>
    public bool guiActiveUnfocused;
    
    /// <summary>
    /// The name shown for the event in the right click menu. Defaults to an 
    /// empty string which will cause KSP to use the method name.
    /// </summary>
    public string guiName;
    
    /// <summary>
    /// The name of the event, which can be used to trigger the event using from plugin code using Part.SendEvent.
    /// </summary>
    public string name;

    /// <summary>
    /// When the part is on a ship not being controlled by the player,
    /// how close the player needs to be (in meters) in order for the event to 
    /// appear in the right click menu.
    /// </summary>
    public float unfocusedRange;

    //The following are unknown
    public string category;
    public string guiIcon;
    public bool isDefault;

    public extern KSPEvent();
}
