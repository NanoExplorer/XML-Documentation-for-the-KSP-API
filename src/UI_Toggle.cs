// Type: UI_Toggle
// Assembly: Assembly-CSharp, Version=1.0.0.0, Culture=neutral
// MVID: A420B99E-82C2-4667-B0ED-6D612B779462
// Assembly location: C:\KSP_DEV\KSP_Data\Managed\Assembly-CSharp.dll

using System;

/// <summary>
/// Adds a toggleable button to the right-click UI
/// 
/// <para>
/// Example for a field:
/// [KSPField, UI_Toggle(disabledText="Disabled", enabledText="Enabled")]
///	public bool myBool = true;
/// </para>
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Property)]
public class UI_Toggle : UI_Control
{
    /// <summary>
    /// Text to show when enabled
    /// </summary>
    public string enabledText;

    /// <summary>
    /// Text to show when disabled
    /// </summary>
    public string disabledText;

    public override extern void Load(ConfigNode node, object host);
    public override extern void Save(ConfigNode node, object host);
}
