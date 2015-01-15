#region Assembly Assembly-CSharp.dll, v2.0.50727
// C:\greg\games\KSP 0.18.2\KSP_Data\Managed\Assembly-CSharp.dll
#endregion

using System;

/// <summary>
/// Apply this attribute to a function to allow it to be called via action groups.
/// </summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class KSPAction : Attribute
{
    /// <summary>
    /// Which action groups this action is currently a part of? Probably you can test
    /// whether this action is part of a given action group (say, the Abort group) with
    /// 
    /// <para><code>if((actionGroup &amp; KSPActionGroup.Abort) != 0)</code></para>
    /// </summary>
    public KSPActionGroup actionGroup;
    /// <summary>
    /// The name of this action as it appears in the action group editor.
    /// </summary>
    public string guiName;

    /// <summary>
    /// Apply this attribute to a function to allow it to be called via action groups.
    /// </summary>
    /// <param name="guiName">The name to show for the action.</param>
    public extern KSPAction(string guiName);
    /// <summary>
    /// Apply this attribute to a function to allow it to be called via action groups.
    /// </summary>
    /// <param name="guiName">The name to show for the action.</param>
    /// <param name="actionGroup">Automatically adds the action to the specified 
    /// Action Group when adding the part to your vessel. Defaults to KSPActionGroup.None.</param>
    public extern KSPAction(string guiName, KSPActionGroup actionGroup);
}
