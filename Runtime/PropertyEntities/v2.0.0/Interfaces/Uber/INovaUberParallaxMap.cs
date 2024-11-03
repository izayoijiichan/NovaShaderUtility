// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Interface : INovaUberParallaxMap
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    using UnityEngine;

    /// <summary>
    /// NOVA Uber Shader Parallax Map Interface
    /// </summary>
    public interface INovaUberParallaxMap
    {
        #region Properties

        /// <summary>Parallax Map Mode</summary>
        NovaParallaxMapMode ParallaxMapMode { get; set; }

        /// <summary>Parallax Map 2D</summary>
        Texture2D? ParallaxMap { get; set; }

        /// <summary>Parallax Map 2D Array</summary>
        Texture2DArray? ParallaxMap2DArray { get; set; }

        /// <summary>Parallax Map 3D</summary>
        Texture3D? ParallaxMap3D { get; set; }

        /// <summary>Parallax Map Progress</summary>
        float ParallaxMapProgress { get; set; }

        /// <summary>Parallax Map Progress Coord</summary>
        NovaCustomCoord ParallaxMapProgressCoord { get; set; }

        /// <summary>Parallax Map Offset X Coord</summary>
        NovaCustomCoord ParallaxMapOffsetXCoord { get; set; }

        /// <summary>Parallax Map Offset Y Coord</summary>
        NovaCustomCoord ParallaxMapOffsetYCoord { get; set; }

        /// <summary>Parallax Map Slice Count</summary>
        float ParallaxMapSliceCount { get; set; }

        /// <summary>Parallax Map Channel</summary>
        NovaColorChannels ParallaxMapChannel { get; set; }

        /// <summary>Parallax Strength</summary>
        float ParallaxStrength { get; set; }

        /// <summary>Parallax Map Target</summary>
        NovaParallaxMapTarget ParallaxMapTarget { get; set; }

        #endregion
    }
}