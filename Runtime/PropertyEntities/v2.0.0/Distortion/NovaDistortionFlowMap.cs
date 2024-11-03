// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Class     : NovaDistortionFlowMap
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    using UnityEngine;

    /// <summary>
    /// NOVA Distortion Shader Flow Map
    /// </summary>
    public class NovaDistortionFlowMap : INovaDistortionFlowMap
    {
        #region Properties

        /// <summary>Flow Map</summary>
        public Texture2D? FlowMap { get; set; }

        /// <summary>Flow Map Offset X Coord</summary>
        public NovaCustomCoord FlowMapOffsetXCoord { get; set; }

        /// <summary>Flow Map Offset Y Coord</summary>
        public NovaCustomCoord FlowMapOffsetYCoord { get; set; }

        /// <summary>Flow Map Channels X</summary>
        public NovaColorChannels FlowMapChannelsX { get; set; }

        /// <summary>Flow Map Channels Y</summary>
        public NovaColorChannels FlowMapChannelsY { get; set; }

        /// <summary>Flow Intensity</summary>
        public float FlowIntensity { get; set; }

        /// <summary>Flow Intensity Coord</summary>
        public NovaCustomCoord FlowIntensityCoord { get; set; }

        /// <summary>Flow Map Target</summary>
        public NovaFlowMapTargetDistortion FlowMapTarget { get; set; }

        #endregion
    }
}