// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Interface : INovaUberEmission
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    using UnityEngine;

    /// <summary>
    /// NOVA Uber Shader Emission Interface
    /// </summary>
    public interface INovaUberEmission
    {
        #region Properties

        /// <summary>Emission Area Type</summary>
        NovaEmissionAreaType EmissionAreaType { get; set; }

        /// <summary>Emission Map Mode</summary>
        NovaEmissionMapMode EmissionMapMode { get; set; }

        /// <summary>Emission Map 2D</summary>
        Texture2D? EmissionMap { get; set; }

        /// <summary>Emission Map 2D Array</summary>
        Texture2DArray? EmissionMap2DArray { get; set; }

        /// <summary>Emission Map 3D</summary>
        Texture3D? EmissionMap3D { get; set; }

        /// <summary>Emission Map Progress</summary>
        float EmissionMapProgress { get; set; }

        /// <summary>Emission Map Progress Coord</summary>
        NovaCustomCoord EmissionMapProgressCoord { get; set; }

        /// <summary>Emission Map Offset X Coord</summary>
        NovaCustomCoord EmissionMapOffsetXCoord { get; set; }

        /// <summary>Emission Map Offset Y Coord</summary>
        NovaCustomCoord EmissionMapOffsetYCoord { get; set; }

        /// <summary>Emission Map Channels X</summary>
        NovaColorChannels EmissionMapChannelsX { get; set; }

        /// <summary>Alpha Transition Map Slice Count</summary>
        float EmissionMapSliceCount { get; set; }

        /// <summary>Emission Color Type</summary>
        NovaEmissionColorType EmissionColorType { get; set; }

        /// <summary>Emission Color</summary>
        Color EmissionColor { get; set; }

        /// <summary>Emission Color Ramp</summary>
        Texture2D? EmissionColorRamp { get; set; }

        /// <summary>Emission Intensity</summary>
        float EmissionIntensity { get; set; }

        /// <summary>Emission Intensity Coord</summary>
        NovaCustomCoord EmissionIntensityCoord { get; set; }

        /// <summary>Keep Edge Transparency</summary>
        bool KeepEdgeTransparency { get; set; }

        #endregion
    }
}