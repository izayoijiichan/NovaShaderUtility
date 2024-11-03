// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Interface : INovaUberVertexDeformation
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    using UnityEngine;

    /// <summary>
    /// NOVA Uber Shader Vertex Deformation Interface
    /// </summary>
    public interface INovaUberVertexDeformation
    {
        #region Properties

        /// <summary>Vertex Deformation Enabled</summary>
        bool VertexDeformationEnabled { get; set; }

        /// <summary>Vertex Deformation Map</summary>
        Texture2D? VertexDeformationMap { get; set; }

        /// <summary>Vertex Deformation Map Offset X Coord</summary>
        NovaCustomCoord VertexDeformationMapOffsetXCoord { get; set; }

        /// <summary>Vertex Deformation Map Offset Y Coord</summary>
        NovaCustomCoord VertexDeformationMapOffsetYCoord { get; set; }

        /// <summary>Vertex Deformation Map Channel</summary>
        NovaColorChannels VertexDeformationMapChannel { get; set; }

        /// <summary>Vertex Deformation Intensity</summary>
        float VertexDeformationIntensity { get; set; }

        /// <summary>Vertex Deformation Intensity Coord</summary>
        NovaCustomCoord VertexDeformationIntensityCoord { get; set; }

        #endregion
    }
}