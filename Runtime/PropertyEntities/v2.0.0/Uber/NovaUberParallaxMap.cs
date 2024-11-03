// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Class     : NovaUberParallaxMap
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    using UnityEngine;

    /// <summary>
    /// NOVA Uber Shader Parallax Map
    /// </summary>
    public class NovaUberParallaxMap : INovaUberParallaxMap
    {
        #region Properties

        /// <summary>Parallax Map Mode</summary>
        public NovaParallaxMapMode ParallaxMapMode { get; set; }

        /// <summary>Parallax Map 2D</summary>
        public Texture2D? ParallaxMap { get; set; }

        /// <summary>Parallax Map 2D Array</summary>
        public Texture2DArray? ParallaxMap2DArray { get; set; }

        /// <summary>Parallax Map 3D</summary>
        public Texture3D? ParallaxMap3D { get; set; }

        /// <summary>Parallax Map Progress</summary>
        public float ParallaxMapProgress { get; set; }

        /// <summary>Parallax Map Progress Coord</summary>
        public NovaCustomCoord ParallaxMapProgressCoord { get; set; }

        /// <summary>Parallax Map Offset X Coord</summary>
        public NovaCustomCoord ParallaxMapOffsetXCoord { get; set; }

        /// <summary>Parallax Map Offset Y Coord</summary>
        public NovaCustomCoord ParallaxMapOffsetYCoord { get; set; }

        /// <summary>Parallax Map Slice Count</summary>
        public float ParallaxMapSliceCount { get; set; }

        /// <summary>Parallax Map Channel</summary>
        public NovaColorChannels ParallaxMapChannel { get; set; }

        /// <summary>Parallax Strength</summary>
        public float ParallaxStrength { get; set; }

        /// <summary>Parallax Map Target</summary>
        public NovaParallaxMapTarget ParallaxMapTarget { get; set; }

        #endregion
    }
}