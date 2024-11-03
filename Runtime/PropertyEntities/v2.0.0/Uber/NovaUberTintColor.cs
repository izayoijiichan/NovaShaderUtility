// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Class     : NovaUberTintColor
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    using UnityEngine;

    /// <summary>
    /// NOVA Uber Shader Tint Color
    /// </summary>
    public class NovaUberTintColor : INovaUberTintColor
    {
        #region Properties

        /// <summary>Tint Area Mode</summary>
        public NovaTintAreaMode TintAreaMode { get; set; }

        /// <summary>Tint Color Mode</summary>
        public NovaTintColorMode TintColorMode { get; set; }

        /// <summary>Tint Color</summary>
        public Color TintColor { get; set; }

        /// <summary>Tint Map 2D</summary>
        public Texture2D? TintMap { get; set; }

        /// <summary>Tint Map 3D</summary>
        public Texture3D? TintMap3D { get; set; }

        /// <summary>Tint Map 3D Progress</summary>
        public float TintMap3DProgress { get; set; }

        /// <summary>Tint Map 3D Progress Coord</summary>
        public NovaCustomCoord TintMap3DProgressCoord { get; set; }

        /// <summary>Tint Map Slice Count</summary>
        public float TintMapSliceCount { get; set; }

        /// <summary>Tint Map Offset X Coord</summary>
        public NovaCustomCoord TintMapOffsetXCoord { get; set; }

        /// <summary>Tint Map Offset Y Coord</summary>
        public NovaCustomCoord TintMapOffsetYCoord { get; set; }

        /// <summary>Tint Blend Rate</summary>
        public float TintBlendRate { get; set; }

        /// <summary>Tint Blend Rate Coord</summary>
        public NovaCustomCoord TintBlendRateCoord { get; set; }

        /// <summary>Tint Rim Progress</summary>
        public float TintRimProgress { get; set; }

        /// <summary>Tint Rim Progress Coord</summary>
        public NovaCustomCoord TintRimProgressCoord { get; set; }

        /// <summary>Tint Rim Sharpness</summary>
        public float TintRimSharpness { get; set; }

        /// <summary>Tint Rim Sharpness Coord</summary>
        public NovaCustomCoord TintRimSharpnessCoord { get; set; }

        /// <summary>Inverse Tint Rim</summary>
        public bool InverseTintRim { get; set; }

        #endregion
    }
}