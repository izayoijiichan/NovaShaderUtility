// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Interface : INovaDistortionDistortionMap
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    using UnityEngine;

    /// <summary>
    /// NOVA Distortion Shader Distortion Map Interface
    /// </summary>
    public interface INovaDistortionDistortionMap
    {
        #region Properties

        /// <summary>Base Map 2D</summary>
        Texture2D? BaseMap { get; set; }

        /// <summary>Base Map Offset X Coord</summary>
        NovaCustomCoord BaseMapOffsetXCoord { get; set; }

        /// <summary>Base Map Offset Y Coord</summary>
        NovaCustomCoord BaseMapOffsetYCoord { get; set; }

        /// <summary>Base Map Channels X</summary>
        NovaColorChannels BaseMapChannelsX { get; set; }

        /// <summary>Base Map Channels Y</summary>
        NovaColorChannels BaseMapChannelsY { get; set; }

        /// <summary>Base Map Rotation</summary>
        float BaseMapRotation { get; set; }

        /// <summary>Base Map Rotation Coord</summary>
        NovaCustomCoord BaseMapRotationCoord { get; set; }

        /// <summary>Base Map Rotation Offsets</summary>
        Vector4 BaseMapRotationOffsets { get; set; }

        /// <summary>Base Map Mirror Sampling</summary>
        bool BaseMapMirrorSampling { get; set; }

        /// <summary>Distortion Intensity</summary>
        float DistortionIntensity { get; set; }

        /// <summary>Distortion Intensity Coord</summary>
        NovaCustomCoord DistortionIntensityCoord { get; set; }

        #endregion
    }
}