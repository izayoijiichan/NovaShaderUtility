// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Interface : INovaUberAlphaTransition
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    using UnityEngine;

    /// <summary>
    /// NOVA Uber Shader Alpha Transition Interface
    /// </summary>
    public interface INovaUberAlphaTransition
    {
        #region Properties

        /// <summary>Alpha Transition Mode</summary>
        NovaAlphaTransitionMode AlphaTransitionMode { get; set; }

        /// <summary>Alpha Transition Map Mode</summary>
        NovaAlphaTransitionMapMode AlphaTransitionMapMode { get; set; }

        /// <summary>Alpha Transition Map 2D</summary>
        Texture2D? AlphaTransitionMap { get; set; }

        /// <summary>Alpha Transition Map 2D Array</summary>
        Texture2DArray? AlphaTransitionMap2DArray { get; set; }

        /// <summary>Alpha Transition Map 3D</summary>
        Texture3D? AlphaTransitionMap3D { get; set; }

        /// <summary>Alpha Transition Map Progress</summary>
        float AlphaTransitionMapProgress { get; set; }

        /// <summary>Alpha Transition Map Progress Coord</summary>
        NovaCustomCoord AlphaTransitionMapProgressCoord { get; set; }

        /// <summary>Alpha Transition Map Offset X Coord</summary>
        NovaCustomCoord AlphaTransitionMapOffsetXCoord { get; set; }

        /// <summary>Alpha Transition Map Offset Y Coord</summary>
        NovaCustomCoord AlphaTransitionMapOffsetYCoord { get; set; }

        /// <summary>Alpha Transition Map Channels X</summary>
        NovaColorChannels AlphaTransitionMapChannelsX { get; set; }

        /// <summary>Alpha Transition Map Slice Count</summary>
        float AlphaTransitionMapSliceCount { get; set; }

        /// <summary>Alpha Transition Progress</summary>
        float AlphaTransitionProgress { get; set; }

        /// <summary>Alpha Transition Progress Coord</summary>
        NovaCustomCoord AlphaTransitionProgressCoord { get; set; }

        /// <summary>Dissolve Sharpness</summary>
        float DissolveSharpness { get; set; }

        /// <summary>Alpha Transition Second Texture BlendMode</summary>
        NovaAlphaTransitionBlendMode AlphaTransitionSecondTextureBlendMode { get; set; }

        /// <summary>Alpha Transition Second Texture Map 2D</summary>
        Texture2D? AlphaTransitionMapSecondTexture { get; set; }

        /// <summary>Alpha Transition Second Texture Map 2D Array</summary>
        Texture2DArray? AlphaTransitionMapSecondTexture2DArray { get; set; }

        /// <summary>Alpha Transition Second Texture Map 3D</summary>
        Texture3D? AlphaTransitionMapSecondTexture3D { get; set; }

        /// <summary>Alpha Transition Map Second Texture Progress</summary>
        float AlphaTransitionMapSecondTextureProgress { get; set; }

        /// <summary>Alpha Transition Map Second Texture Progress Coord</summary>
        NovaCustomCoord AlphaTransitionMapSecondTextureProgressCoord { get; set; }

        /// <summary>Alpha Transition Second Texture Map Offset X Coord</summary>
        NovaCustomCoord AlphaTransitionMapSecondTextureOffsetXCoord { get; set; }

        /// <summary>Alpha Transition Second Texture Map Offset Y Coord</summary>
        NovaCustomCoord AlphaTransitionMapSecondTextureOffsetYCoord { get; set; }

        /// <summary>Alpha Transition Second Texture Map Channels X</summary>
        NovaColorChannels AlphaTransitionMapSecondTextureChannelsX { get; set; }

        /// <summary>Alpha Transition Map Second Texture Slice Count</summary>
        float AlphaTransitionMapSecondTextureSliceCount { get; set; }

        /// <summary>Alpha Transition Second Texture Progress</summary>
        float AlphaTransitionProgressSecondTexture { get; set; }

        /// <summary>Alpha Transition Second Texture Progress Coord</summary>
        NovaCustomCoord AlphaTransitionProgressCoordSecondTexture { get; set; }

        /// <summary>Second Texture Dissolve Sharpness</summary>
        float DissolveSharpnessSecondTexture { get; set; }

        #endregion
    }
}