// Type: CBAttributeMap
// Assembly: Assembly-CSharp, Version=1.0.0.0, Culture=neutral
// MVID: A420B99E-82C2-4667-B0ED-6D612B779462
// Assembly location: C:\KSP_DEV\KSP_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

/// <summary>
/// Contains the biome map and definitions for each biome for a celestial body
/// </summary>
public class CBAttributeMapSO : MapSO
{
    /// <summary>
    /// The biome map is stored as a 2d image, colors are used to define the biomes.
    /// </summary>
    public Texture2D Map;

    /// <summary>
    /// The list of biomes for this map
    /// </summary>
    public MapAttribute[] Attributes;
    public MapAttribute defaultAttribute;
    public bool exactSearch;

    /// <summary>
    /// (Guessing) the delta to use when comparing colors, nessary because they're stored as floats.
    /// </summary>
    public float nonExactThreshold;

    /// <summary>
    /// Gets the biome information for the passed latitude and longitude
    /// </summary>
    /// <param name="lat">Latitude (radians)</param>
    /// <param name="lon">Longitude (radians)</param>
    /// <returns></returns>
    public extern MapAttribute GetAtt(double lat, double lon);

    public class MapAttribute
    {
        /// <summary>
        /// Colors are used to deliniate different biomes
        /// </summary>
        public Color mapColor;
        /// <summary>
        /// Name of the biome
        /// </summary>
        public string name;

        public float value;
    }
}
