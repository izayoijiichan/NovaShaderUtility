// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Class     : NovaUberVertexDeformation
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    using UnityEngine;

    /// <summary>
    /// NOVA Uber Shader Vertex Deformation
    /// </summary>
    public class NovaUberVertexDeformation : INovaUberVertexDeformation
    {
        #region Properties

        /// <summary>Vertex Deformation Enabled</summary>
        public bool VertexDeformationEnabled { get; set; }

        /// <summary>Vertex Deformation Map</summary>
        public Texture2D? VertexDeformationMap { get; set; }

        /// <summary>Vertex Deformation Map Offset X Coord</summary>
        public NovaCustomCoord VertexDeformationMapOffsetXCoord { get; set; }

        /// <summary>Vertex Deformation Map Offset Y Coord</summary>
        public NovaCustomCoord VertexDeformationMapOffsetYCoord { get; set; }

        /// <summary>Vertex Deformation Map Channel</summary>
        public NovaColorChannels VertexDeformationMapChannel { get; set; }

        /// <summary>Vertex Deformation Intensity</summary>
        public float VertexDeformationIntensity { get; set; }

        /// <summary>Vertex Deformation Intensity Coord</summary>
        public NovaCustomCoord VertexDeformationIntensityCoord { get; set; }

        #endregion
    }
}