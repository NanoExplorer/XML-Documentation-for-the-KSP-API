// Type: UI_FloatRange
// Assembly: Assembly-CSharp, Version=1.0.0.0, Culture=neutral
// MVID: A420B99E-82C2-4667-B0ED-6D612B779462
// Assembly location: C:\KSP_DEV\KSP_Data\Managed\Assembly-CSharp.dll

using System;

/// <summary>
/// Adds a slider to the right-click UI
/// 
/// <para>
/// Example for a field:
/// [KSPField, UI_FloatRange(minValue = -14f, maxValue = 14f, stepIncrement = 1f)]
/// public float mySlider= 0;
/// </para>
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Property)]
public class UI_FloatRange : UI_Control
{
    /// <summary>
    /// Sets the minimum value. It can be negative
    /// </summary>
    public float minValue;

    /// <summary>
    /// Sets the maximum value.
    /// </summary>
    public float maxValue;

    /// <summary>
    /// Steps in which the slider will move
    /// </summary>
    public float stepIncrement;

    public extern UI_FloatRange();
    public extern override void Load(ConfigNode node, object host);
    public extern override void Save(ConfigNode node, object host);
}
