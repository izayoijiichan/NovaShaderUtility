// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Class     : NovaUberLitSurfaceMap
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    using UnityEngine;

    /// <summary>
    /// NOVA Uber Lit Shader Surface Maps
    /// </summary>
    public class NovaUberLitSurfaceMap : INovaUberLitSurfaceMap
    {
        #region Properties

        /// <summary>Normal Map 2D</summary>
        public Texture2D? NormalMap { get; set; }

        /// <summary>Normal Map 2D Array</summary>
        public Texture2DArray? NormalMap2DArray { get; set; }

        /// <summary>Normal Map 3D</summary>
        public Texture3D? NormalMap3D { get; set; }

        /// <summary>Normal Map Bump Scale</summary>
        public float NormalMapBumpScale { get; set; }

        /// <summary>Specular Map 2D</summary>
        public Texture2D? SpecularMap { get; set; }

        /// <summary>Specular Map 2D Array</summary>
        public Texture2DArray? SpecularMap2DArray { get; set; }

        /// <summary>Specular Map 3D</summary>
        public Texture3D? SpecularMap3D { get; set; }

        /// <summary>Specular Color</summary>
        public Color SpecularColor { get; set; }

        /// <summary>Specular Map Channels X</summary>
        public NovaColorChannels SpecularMapChannelsX { get; set; }

        /// <summary>Metallic Map 2D</summary>
        public Texture2D? MetallicMap { get; set; }

        /// <summary>Metallic Map 2D Array</summary>
        public Texture2DArray? MetallicMap2DArray { get; set; }

        /// <summary>Metallic Map 3D</summary>
        public Texture3D? MetallicMap3D { get; set; }

        /// <summary>Metallic</summary>
        public float Metallic { get; set; }

        /// <summary>Metallic Map Channels X</summary>
        public NovaColorChannels MetallicMapChannelsX { get; set; }

        /// <summary>Smoothness Map 2D</summary>
        public Texture2D? SmoothnessMap { get; set; }

        /// <summary>Smoothness Map 2D Array</summary>
        public Texture2DArray? SmoothnessMap2DArray { get; set; }

        /// <summary>Smoothness Map 3D</summary>
        public Texture3D? SmoothnessMap3D { get; set; }

        /// <summary>Smoothness</summary>
        public float Smoothness { get; set; }

        /// <summary>Smoothness Map Channels X</summary>
        public NovaColorChannels SmoothnessMapChannelsX { get; set; }

        #endregion
    }
}