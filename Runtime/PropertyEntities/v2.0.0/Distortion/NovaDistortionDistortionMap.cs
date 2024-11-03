// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Class     : NovaDistortionDistortionMap
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    using UnityEngine;

    /// <summary>
    /// NOVA Distortion Shader Distortion Map
    /// </summary>
    public class NovaDistortionDistortionMap : INovaDistortionDistortionMap
    {
        #region Properties

        /// <summary>Base Map 2D</summary>
        public Texture2D? BaseMap { get; set; }

        /// <summary>Base Map Offset X Coord</summary>
        public NovaCustomCoord BaseMapOffsetXCoord { get; set; }

        /// <summary>Base Map Offset Y Coord</summary>
        public NovaCustomCoord BaseMapOffsetYCoord { get; set; }

        /// <summary>Base Map Channels X</summary>
        public NovaColorChannels BaseMapChannelsX { get; set; }

        /// <summary>Base Map Channels Y</summary>
        public NovaColorChannels BaseMapChannelsY { get; set; }

        /// <summary>Base Map Rotation</summary>
        public float BaseMapRotation { get; set; }

        /// <summary>Base Map Rotation Coord</summary>
        public NovaCustomCoord BaseMapRotationCoord { get; set; }

        /// <summary>Base Map Rotation Offsets</summary>
        public Vector4 BaseMapRotationOffsets { get; set; }

        /// <summary>Base Map Mirror Sampling</summary>
        public bool BaseMapMirrorSampling { get; set; }

        /// <summary>Distortion Intensity</summary>
        public float DistortionIntensity { get; set; }

        /// <summary>Distortion Intensity Coord</summary>
        public NovaCustomCoord DistortionIntensityCoord { get; set; }

        #endregion
    }
}