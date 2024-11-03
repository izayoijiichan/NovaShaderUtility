// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Interface : INovaDistortionAlphaTransition
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    using UnityEngine;

    /// <summary>
    /// NOVA Distortion Shader Alpha Transition Interface
    /// </summary>
    public interface INovaDistortionAlphaTransition
    {
        #region Properties

        /// <summary>Alpha Transition Mode</summary>
        NovaAlphaTransitionMode AlphaTransitionMode { get; set; }

        /// <summary>Alpha Transition Map 2D</summary>
        Texture2D? AlphaTransitionMap { get; set; }

        /// <summary>Alpha Transition Map Offset X Coord</summary>
        NovaCustomCoord AlphaTransitionMapOffsetXCoord { get; set; }

        /// <summary>Alpha Transition Map Offset Y Coord</summary>
        NovaCustomCoord AlphaTransitionMapOffsetYCoord { get; set; }

        /// <summary>Alpha Transition Map Channels X</summary>
        NovaColorChannels AlphaTransitionMapChannelsX { get; set; }

        /// <summary>Alpha Transition Progress</summary>
        float AlphaTransitionProgress { get; set; }

        /// <summary>Alpha Transition Progress Coord</summary>
        NovaCustomCoord AlphaTransitionProgressCoord { get; set; }

        /// <summary>Dissolve Sharpness</summary>
        float DissolveSharpness { get; set; }

        #endregion
    }
}