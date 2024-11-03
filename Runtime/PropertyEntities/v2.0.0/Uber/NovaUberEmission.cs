// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Class     : NovaUberEmission
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    using UnityEngine;

    /// <summary>
    /// NOVA Uber Shader Emission
    /// </summary>
    public class NovaUberEmission : INovaUberEmission
    {
        #region Properties

        /// <summary>Emission Area Type</summary>
        public NovaEmissionAreaType EmissionAreaType { get; set; }

        /// <summary>Emission Map Mode</summary>
        public NovaEmissionMapMode EmissionMapMode { get; set; }

        /// <summary>Emission Map 2D</summary>
        public Texture2D? EmissionMap { get; set; }

        /// <summary>Emission Map 2D Array</summary>
        public Texture2DArray? EmissionMap2DArray { get; set; }

        /// <summary>Emission Map 3D</summary>
        public Texture3D? EmissionMap3D { get; set; }

        /// <summary>Emission Map Progress</summary>
        public float EmissionMapProgress { get; set; }

        /// <summary>Emission Map Progress Coord</summary>
        public NovaCustomCoord EmissionMapProgressCoord { get; set; }

        /// <summary>Emission Map Offset X Coord</summary>
        public NovaCustomCoord EmissionMapOffsetXCoord { get; set; }

        /// <summary>Emission Map Offset Y Coord</summary>
        public NovaCustomCoord EmissionMapOffsetYCoord { get; set; }

        /// <summary>Emission Map Channels X</summary>
        public NovaColorChannels EmissionMapChannelsX { get; set; }

        /// <summary>Alpha Transition Map Slice Count</summary>
        public float EmissionMapSliceCount { get; set; }

        /// <summary>Emission Color Type</summary>
        public NovaEmissionColorType EmissionColorType { get; set; }

        /// <summary>Emission Color</summary>
        public Color EmissionColor { get; set; }

        /// <summary>Emission Color Ramp</summary>
        public Texture2D? EmissionColorRamp { get; set; }

        /// <summary>Emission Intensity</summary>
        public float EmissionIntensity { get; set; }

        /// <summary>Emission Intensity Coord</summary>
        public NovaCustomCoord EmissionIntensityCoord { get; set; }

        /// <summary>Keep Edge Transparency</summary>
        public bool KeepEdgeTransparency { get; set; }

        #endregion
    }
}