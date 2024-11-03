// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Class     : NovaUberAlphaTransition
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    using UnityEngine;

    /// <summary>
    /// NOVA Uber Shader Alpha Transition
    /// </summary>
    public class NovaUberAlphaTransition : INovaUberAlphaTransition
    {
        #region Properties

        /// <summary>Alpha Transition Mode</summary>
        public NovaAlphaTransitionMode AlphaTransitionMode { get; set; }

        /// <summary>Alpha Transition Map Mode</summary>
        public NovaAlphaTransitionMapMode AlphaTransitionMapMode { get; set; }

        /// <summary>Alpha Transition Map 2D</summary>
        public Texture2D? AlphaTransitionMap { get; set; }

        /// <summary>Alpha Transition Map 2D Array</summary>
        public Texture2DArray? AlphaTransitionMap2DArray { get; set; }

        /// <summary>Alpha Transition Map 3D</summary>
        public Texture3D? AlphaTransitionMap3D { get; set; }

        /// <summary>Alpha Transition Map Progress</summary>
        public float AlphaTransitionMapProgress { get; set; }

        /// <summary>Alpha Transition Map Progress Coord</summary>
        public NovaCustomCoord AlphaTransitionMapProgressCoord { get; set; }

        /// <summary>Alpha Transition Map Offset X Coord</summary>
        public NovaCustomCoord AlphaTransitionMapOffsetXCoord { get; set; }

        /// <summary>Alpha Transition Map Offset Y Coord</summary>
        public NovaCustomCoord AlphaTransitionMapOffsetYCoord { get; set; }

        /// <summary>Alpha Transition Map Channels X</summary>
        public NovaColorChannels AlphaTransitionMapChannelsX { get; set; }

        /// <summary>Alpha Transition Map Slice Count</summary>
        public float AlphaTransitionMapSliceCount { get; set; }

        /// <summary>Alpha Transition Progress</summary>
        public float AlphaTransitionProgress { get; set; }

        /// <summary>Alpha Transition Progress Coord</summary>
        public NovaCustomCoord AlphaTransitionProgressCoord { get; set; }

        /// <summary>Dissolve Sharpness</summary>
        public float DissolveSharpness { get; set; }

        /// <summary>Alpha Transition Second Texture BlendMode</summary>
        public NovaAlphaTransitionBlendMode AlphaTransitionSecondTextureBlendMode { get; set; }

        /// <summary>Alpha Transition Second Texture Map 2D</summary>
        public Texture2D? AlphaTransitionMapSecondTexture { get; set; }

        /// <summary>Alpha Transition Second Texture Map 2D Array</summary>
        public Texture2DArray? AlphaTransitionMapSecondTexture2DArray { get; set; }

        /// <summary>Alpha Transition Second Texture Map 3D</summary>
        public Texture3D? AlphaTransitionMapSecondTexture3D { get; set; }

        /// <summary>Alpha Transition Map Second Texture Progress</summary>
        public float AlphaTransitionMapSecondTextureProgress { get; set; }

        /// <summary>Alpha Transition Map Second Texture Progress Coord</summary>
        public NovaCustomCoord AlphaTransitionMapSecondTextureProgressCoord { get; set; }

        /// <summary>Alpha Transition Second Texture Map Offset X Coord</summary>
        public NovaCustomCoord AlphaTransitionMapSecondTextureOffsetXCoord { get; set; }

        /// <summary>Alpha Transition Second Texture Map Offset Y Coord</summary>
        public NovaCustomCoord AlphaTransitionMapSecondTextureOffsetYCoord { get; set; }

        /// <summary>Alpha Transition Second Texture Map Channels X</summary>
        public NovaColorChannels AlphaTransitionMapSecondTextureChannelsX { get; set; }

        /// <summary>Alpha Transition Map Second Texture Slice Count</summary>
        public float AlphaTransitionMapSecondTextureSliceCount { get; set; }

        /// <summary>Alpha Transition Second Texture Progress</summary>
        public float AlphaTransitionProgressSecondTexture { get; set; }

        /// <summary>Alpha Transition Second Texture Progress Coord</summary>
        public NovaCustomCoord AlphaTransitionProgressCoordSecondTexture { get; set; }

        /// <summary>Second Texture Dissolve Sharpness</summary>
        public float DissolveSharpnessSecondTexture { get; set; }

        #endregion
    }
}