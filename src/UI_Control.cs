// Type: UI_Control
// Assembly: Assembly-CSharp, Version=1.0.0.0, Culture=neutral
// MVID: A420B99E-82C2-4667-B0ED-6D612B779462
// Assembly location: C:\KSP_DEV\KSP_Data\Managed\Assembly-CSharp.dll

using System;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Property)]
public abstract class UI_Control : Attribute
{
    public UI_Scene scene;
    public bool controlEnabled;
    protected BaseField field;
    public extern void Setup(BaseField field);
    public extern virtual void Load(ConfigNode node, object host);
    public extern virtual void Save(ConfigNode node, object host);
    protected extern static bool ParseEnabled(out bool value, ConfigNode node, string valueName, string FieldUIControlName);
    protected extern static bool ParseFloat(out float value, ConfigNode node, string valueName, string FieldUIControlName, string errorNoValue);
    protected extern static bool ParseString(out string value, ConfigNode node, string valueName, string FieldUIControlName, string errorNoValue);
}
