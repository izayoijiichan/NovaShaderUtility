// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Interface : INovaUberTintColor
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    using UnityEngine;

    /// <summary>
    /// NOVA Uber Shader Tint Color Interface
    /// </summary>
    public interface INovaUberTintColor
    {
        #region Properties

        /// <summary>Tint Area Mode</summary>
        NovaTintAreaMode TintAreaMode { get; set; }

        /// <summary>Tint Color Mode</summary>
        NovaTintColorMode TintColorMode { get; set; }

        /// <summary>Tint Color</summary>
        Color TintColor { get; set; }

        /// <summary>Tint Map 2D</summary>
        Texture2D? TintMap { get; set; }

        /// <summary>Tint Map 3D</summary>
        Texture3D? TintMap3D { get; set; }

        /// <summary>Tint Map 3D Progress</summary>
        float TintMap3DProgress { get; set; }

        /// <summary>Tint Map 3D Progress Coord</summary>
        NovaCustomCoord TintMap3DProgressCoord { get; set; }

        /// <summary>Tint Map Slice Count</summary>
        float TintMapSliceCount { get; set; }

        /// <summary>Tint Map Offset X Coord</summary>
        NovaCustomCoord TintMapOffsetXCoord { get; set; }

        /// <summary>Tint Map Offset Y Coord</summary>
        NovaCustomCoord TintMapOffsetYCoord { get; set; }

        /// <summary>Tint Blend Rate</summary>
        float TintBlendRate { get; set; }

        /// <summary>Tint Blend Rate Coord</summary>
        NovaCustomCoord TintBlendRateCoord { get; set; }

        /// <summary>Tint Rim Progress</summary>
        float TintRimProgress { get; set; }

        /// <summary>Tint Rim Progress Coord</summary>
        NovaCustomCoord TintRimProgressCoord { get; set; }

        /// <summary>Tint Rim Sharpness</summary>
        float TintRimSharpness { get; set; }

        /// <summary>Tint Rim Sharpness Coord</summary>
        NovaCustomCoord TintRimSharpnessCoord { get; set; }

        /// <summary>Inverse Tint Rim</summary>
        bool InverseTintRim { get; set; }

        #endregion
    }
}