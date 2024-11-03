// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Interface : INovaUberBaseMap
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    using UnityEngine;

    /// <summary>
    /// NOVA Uber Shader Base Map Interface
    /// </summary>
    public interface INovaUberBaseMap
    {
        #region Properties

        /// <summary>Base Map Mode</summary>
        NovaBaseMapMode BaseMapMode { get; set; }

        /// <summary>Base Map 2D</summary>
        Texture2D? BaseMap { get; set; }

        /// <summary>Base Map 2D Array</summary>
        Texture2DArray? BaseMap2DArray { get; set; }

        /// <summary>Base Map 3D</summary>
        Texture3D? BaseMap3D { get; set; }

        /// <summary>Base Map Progress</summary>
        float BaseMapProgress { get; set; }

        /// <summary>Base Map Progress Coord</summary>
        NovaCustomCoord BaseMapProgressCoord { get; set; }

        /// <summary>Base Map Slice Count</summary>
        float BaseMapSliceCount { get; set; }

        /// <summary>Base Map Offset X Coord</summary>
        NovaCustomCoord BaseMapOffsetXCoord { get; set; }

        /// <summary>Base Map Offset Y Coord</summary>
        NovaCustomCoord BaseMapOffsetYCoord { get; set; }

        ///// <summary>Base Map Channels X</summary>
        ///// <summary>Base Map Channels Y</summary>

        /// <summary>Base Map Rotation</summary>
        float BaseMapRotation { get; set; }

        /// <summary>Base Map Rotation Coord</summary>
        NovaCustomCoord BaseMapRotationCoord { get; set; }

        /// <summary>Base Map Rotation Offsets</summary>
        Vector4 BaseMapRotationOffsets { get; set; }

        /// <summary>Base Map Mirror Sampling</summary>
        bool BaseMapMirrorSampling { get; set; }

        #endregion
    }
}