// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Class     : NovaUberBaseMap
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    using UnityEngine;

    /// <summary>
    /// NOVA Uber Shader Base Map
    /// </summary>
    public class NovaUberBaseMap : INovaUberBaseMap
    {
        #region Properties

        /// <summary>Base Map Mode</summary>
        public NovaBaseMapMode BaseMapMode { get; set; }

        /// <summary>Base Map 2D</summary>
        public Texture2D? BaseMap { get; set; }

        /// <summary>Base Map 2D Array</summary>
        public Texture2DArray? BaseMap2DArray { get; set; }

        /// <summary>Base Map 3D</summary>
        public Texture3D? BaseMap3D { get; set; }

        /// <summary>Base Map Progress</summary>
        public float BaseMapProgress { get; set; }

        /// <summary>Base Map Progress Coord</summary>
        public NovaCustomCoord BaseMapProgressCoord { get; set; }

        /// <summary>Base Map Slice Count</summary>
        public float BaseMapSliceCount { get; set; }

        /// <summary>Base Map Offset X Coord</summary>
        public NovaCustomCoord BaseMapOffsetXCoord { get; set; }

        /// <summary>Base Map Offset Y Coord</summary>
        public NovaCustomCoord BaseMapOffsetYCoord { get; set; }

        /// <summary>Base Map Rotation</summary>
        public float BaseMapRotation { get; set; }

        /// <summary>Base Map Rotation Coord</summary>
        public NovaCustomCoord BaseMapRotationCoord { get; set; }

        /// <summary>Base Map Rotation Offsets</summary>
        public Vector4 BaseMapRotationOffsets { get; set; }

        /// <summary>Base Map Mirror Sampling</summary>
        public bool BaseMapMirrorSampling { get; set; }

        #endregion
    }
}