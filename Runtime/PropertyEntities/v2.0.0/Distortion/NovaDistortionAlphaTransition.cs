// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0.Distortion
// @Class     : NovaDistortionAlphaTransition
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    using UnityEngine;

    /// <summary>
    /// NOVA Distortion Shader Alpha Transition
    /// </summary>
    public class NovaDistortionAlphaTransition : INovaDistortionAlphaTransition
    {
        #region Properties

        /// <summary>Alpha Transition Mode</summary>
        public NovaAlphaTransitionMode AlphaTransitionMode { get; set; }

        /// <summary>Alpha Transition Map 2D</summary>
        public Texture2D? AlphaTransitionMap { get; set; }

        /// <summary>Alpha Transition Map Offset X Coord</summary>
        public NovaCustomCoord AlphaTransitionMapOffsetXCoord { get; set; }

        /// <summary>Alpha Transition Map Offset Y Coord</summary>
        public NovaCustomCoord AlphaTransitionMapOffsetYCoord { get; set; }

        /// <summary>Alpha Transition Map Channels X</summary>
        public NovaColorChannels AlphaTransitionMapChannelsX { get; set; }

        /// <summary>Alpha Transition Progress</summary>
        public float AlphaTransitionProgress { get; set; }

        /// <summary>Alpha Transition Progress Coord</summary>
        public NovaCustomCoord AlphaTransitionProgressCoord { get; set; }

        /// <summary>Dissolve Sharpness</summary>
        public float DissolveSharpness { get; set; }

        #endregion
    }
}