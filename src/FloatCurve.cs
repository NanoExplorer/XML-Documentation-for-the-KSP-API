// Type: FloatCurve
// Assembly: Assembly-CSharp, Version=1.0.0.0, Culture=neutral
// MVID: A420B99E-82C2-4667-B0ED-6D612B779462
// Assembly location: C:\KSP_DEV\KSP_Data\Managed\Assembly-CSharp.dll

/// <summary>
/// Represents a function of one variable. The function is interpolated from a 
/// given set of points, and optionally the tangents at those points can be 
/// specified. Uses splines to define the curve.
/// 
/// References:
/// http://forum.kerbalspaceprogram.com/threads/93332-INFO-KSP-floatCurves-and-you-the-magic-of-tangents
/// </summary>
public class FloatCurve : IConfigNode
{
    public int findCurveMinMaxInterations;
    public extern FloatCurve();
    public extern void Add(float time, float value);
    public extern void Add(float time, float value, float inTangent, float outTangent);

    /// <summary>
    /// Evaluate the function at a given value of the input parameter.
    /// 
    /// </summary>
    /// <param name="time">The input parameter (not necessarily a time).</param>
    /// <returns>
    /// The value of the function.
    /// </returns>
    public extern float Evaluate(float time);
    public extern void Load(ConfigNode node);
    public extern void Save(ConfigNode node);
    public extern void FindMinMaxValue(out float min, out float max);
    public extern float minTime { get; }
    public extern float maxTime { get; }
}
