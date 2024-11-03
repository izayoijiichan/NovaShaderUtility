// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Interface : INovaDistortionFlowMap
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    using UnityEngine;

    /// <summary>
    /// NOVA Distortion Shader Flow Map Interface
    /// </summary>
    public interface INovaDistortionFlowMap
    {
        #region Properties

        /// <summary>Flow Map</summary>
        Texture2D? FlowMap { get; set; }

        /// <summary>Flow Map Offset X Coord</summary>
        NovaCustomCoord FlowMapOffsetXCoord { get; set; }

        /// <summary>Flow Map Offset Y Coord</summary>
        NovaCustomCoord FlowMapOffsetYCoord { get; set; }

        /// <summary>Flow Map Channels X</summary>
        NovaColorChannels FlowMapChannelsX { get; set; }

        /// <summary>Flow Map Channels Y</summary>
        NovaColorChannels FlowMapChannelsY { get; set; }

        /// <summary>Flow Intensity</summary>
        float FlowIntensity { get; set; }

        /// <summary>Flow Intensity Coord</summary>
        NovaCustomCoord FlowIntensityCoord { get; set; }

        /// <summary>Flow Map Target</summary>
        NovaFlowMapTargetDistortion FlowMapTarget { get; set; }

        #endregion
    }
}