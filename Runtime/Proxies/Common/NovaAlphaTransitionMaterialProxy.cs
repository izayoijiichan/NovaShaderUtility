// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.Proxies
// @Class     : NovaAlphaTransitionMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.Proxies
{
    using Izayoi.NovaShader;
    using Izayoi.NovaShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// NOVA Shader Alpha Transition Material Proxy
    /// </summary>
    /// <remarks>
    /// ParticlesDistortion.shader
    /// ParticlesUberLit.shader
    /// ParticlesUberUnlit.shader
    /// UIParticlesUberLit.shader
    /// UIParticlesUberUnlit.shader
    /// </remarks>
    public class NovaAlphaTransitionMaterialProxy : NovaMaterialProxyBase
    {
        #region Constructors

        /// <summary>
        /// Create a new instance of NovaAlphaTransitionMaterialProxy.
        /// </summary>
        /// <param name="material">The NOVA shader material.</param>
        public NovaAlphaTransitionMaterialProxy(Material material) : base(material)
        {
        }

        #endregion

        #region Properties

        /// <summary>Alpha Transition Mode</summary>
        public NovaAlphaTransitionMode AlphaTransitionMode
        {
            get => _Material.GetSafeEnum<NovaAlphaTransitionMode>(PropertyNameID.AlphaTransitionMode, NovaAlphaTransitionMode.None);
            set
            {
                _Material.SetSafeInt(PropertyNameID.AlphaTransitionMode, (int)value);

                SetAlphaTransitionKeywords(value, AlphaTransitionMapMode, AlphaTransitionMap);
            }
        }

        /// <summary>Alpha Transition Mode</summary>
        /// <remarks>Distortion only</remarks>
        public NovaAlphaTransitionMode AlphaTransitionModeDistortion
        {
            get => _Material.GetSafeEnum<NovaAlphaTransitionMode>(PropertyNameID.AlphaTransitionMode, NovaAlphaTransitionMode.None);
            set
            {
                _Material.SetSafeInt(PropertyNameID.AlphaTransitionMode, (int)value);

                SetAlphaTransitionKeywordsDistortion(value, AlphaTransitionMap);
            }
        }

        /// <summary>Alpha Transition Map Mode</summary>
        public NovaAlphaTransitionMapMode AlphaTransitionMapMode
        {
            get => _Material.GetSafeEnum<NovaAlphaTransitionMapMode>(PropertyNameID.AlphaTransitionMapMode, NovaAlphaTransitionMapMode.SingleTexture);
            set
            {
                _Material.SetSafeInt(PropertyNameID.AlphaTransitionMapMode, (int)value);

                SetAlphaTransitionKeywords(AlphaTransitionMode, value, AlphaTransitionMap);

                SetAlphaTransitionMapMode2DKeyword(value, AlphaTransitionMap);
                SetAlphaTransitionMapMode2DArrayKeyword(value, AlphaTransitionMap2DArray);
                SetAlphaTransitionMapMode3DKeyword(value, AlphaTransitionMap3D);
            }
        }

        /// <summary>Alpha Transition Map 2D</summary>
        public Texture2D? AlphaTransitionMap
        {
            get => _Material.GetSafeTexture(PropertyNameID.AlphaTransitionMap);
            set
            {
                _Material.SetSafeTexture(PropertyNameID.AlphaTransitionMap, value);

                SetAlphaTransitionKeywords(AlphaTransitionMode, AlphaTransitionMapMode, value);

                SetAlphaTransitionMapMode2DKeyword(AlphaTransitionMapMode, value);
            }
        }

        /// <summary>Alpha Transition Map 2D</summary>
        /// <remarks>Distortion only</remarks>
        public Texture2D? AlphaTransitionMapDistortion
        {
            get => _Material.GetSafeTexture(PropertyNameID.AlphaTransitionMap);
            set
            {
                _Material.SetSafeTexture(PropertyNameID.AlphaTransitionMap, value);

                SetAlphaTransitionKeywordsDistortion(AlphaTransitionMode, value);

                //_Material.SetSafeKeyword(Keyword.AlphaTransitionMapMode2D, value != null);
            }
        }

        /// <summary>Alpha Transition Map 2D Array</summary>
        public Texture2DArray? AlphaTransitionMap2DArray
        {
            get => _Material.GetSafeTexture2DArray(PropertyNameID.AlphaTransitionMap2DArray);
            set
            {
                _Material.SetSafeTexture(PropertyNameID.AlphaTransitionMap2DArray, value);

                SetAlphaTransitionMapMode2DArrayKeyword(AlphaTransitionMapMode, value);
            }
        }

        /// <summary>Alpha Transition Map 3D</summary>
        public Texture3D? AlphaTransitionMap3D
        {
            get => _Material.GetSafeTexture3D(PropertyNameID.AlphaTransitionMap3D);
            set
            {
                _Material.SetSafeTexture(PropertyNameID.AlphaTransitionMap3D, value);

                SetAlphaTransitionMapMode3DKeyword(AlphaTransitionMapMode, value);
            }
        }

        /// <summary>Alpha Transition Map Progress</summary>
        public float AlphaTransitionMapProgress
        {
            get => _Material.GetSafeFloat(PropertyNameID.AlphaTransitionMapProgress, PropertyRange.AlphaTransitionMapProgress.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.AlphaTransitionMapProgress, PropertyRange.AlphaTransitionMapProgress, value);
        }

        /// <summary>Alpha Transition Map Progress Coord</summary>
        public NovaCustomCoord AlphaTransitionMapProgressCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.AlphaTransitionMapProgressCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.AlphaTransitionMapProgressCoord, (int)value);
        }

        /// <summary>Alpha Transition Map Offset X Coord</summary>
        public NovaCustomCoord AlphaTransitionMapOffsetXCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.AlphaTransitionMapOffsetXCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.AlphaTransitionMapOffsetXCoord, (int)value);
        }

        /// <summary>Alpha Transition Map Offset Y Coord</summary>
        public NovaCustomCoord AlphaTransitionMapOffsetYCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.AlphaTransitionMapOffsetYCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.AlphaTransitionMapOffsetYCoord, (int)value);
        }

        /// <summary>Alpha Transition Map Channels X</summary>
        public NovaColorChannels AlphaTransitionMapChannelsX
        {
            get => _Material.GetSafeEnum<NovaColorChannels>(PropertyNameID.AlphaTransitionMapChannelsX, NovaColorChannels.Red);
            set => _Material.SetSafeInt(PropertyNameID.AlphaTransitionMapChannelsX, (int)value);
        }

        /// <summary>Alpha Transition Map Slice Count</summary>
        public float AlphaTransitionMapSliceCount
        {
            get => _Material.GetSafeFloat(PropertyNameID.AlphaTransitionMapSliceCount, 4.0f);
            set => _Material.SetSafeFloat(PropertyNameID.AlphaTransitionMapSliceCount, value);
        }

        /// <summary>Alpha Transition Progress</summary>
        public float AlphaTransitionProgress
        {
            get => _Material.GetSafeFloat(PropertyNameID.AlphaTransitionProgress, PropertyRange.AlphaTransitionProgress.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.AlphaTransitionProgress, PropertyRange.AlphaTransitionProgress, value);
        }

        /// <summary>Alpha Transition Progress Coord</summary>
        public NovaCustomCoord AlphaTransitionProgressCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.AlphaTransitionProgressCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.AlphaTransitionProgressCoord, (int)value);
        }

        /// <summary>Dissolve Sharpness</summary>
        public float DissolveSharpness
        {
            get => _Material.GetSafeFloat(PropertyNameID.DissolveSharpness, PropertyRange.DissolveSharpness.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.DissolveSharpness, PropertyRange.DissolveSharpness, value);
        }

        /// <summary>Alpha Transition Second Texture BlendMode</summary>
        public NovaAlphaTransitionBlendMode AlphaTransitionSecondTextureBlendMode
        {
            get => _Material.GetSafeEnum<NovaAlphaTransitionBlendMode>(PropertyNameID.AlphaTransitionSecondTextureBlendMode, NovaAlphaTransitionBlendMode.None);
            set
            {
                _Material.SetSafeInt(PropertyNameID.AlphaTransitionSecondTextureBlendMode, (int)value);

                _Material.SetSafeKeyword(Keyword.AlphaTransitionBlendSecondTexAverage, value == NovaAlphaTransitionBlendMode.Average);
                _Material.SetSafeKeyword(Keyword.AlphaTransitionBlendSecondTexMultiply, value == NovaAlphaTransitionBlendMode.Multiply);
            }
        }

        /// <summary>Alpha Transition Second Texture Map 2D</summary>
        public Texture2D? AlphaTransitionMapSecondTexture
        {
            get => _Material.GetSafeTexture(PropertyNameID.AlphaTransitionMapSecondTexture);
            set => _Material.SetSafeTexture(PropertyNameID.AlphaTransitionMapSecondTexture, value);
        }

        /// <summary>Alpha Transition Second Texture Map 2D Array</summary>
        public Texture2DArray? AlphaTransitionMapSecondTexture2DArray
        {
            get => _Material.GetSafeTexture2DArray(PropertyNameID.AlphaTransitionMapSecondTexture2DArray);
            set => _Material.SetSafeTexture(PropertyNameID.AlphaTransitionMapSecondTexture2DArray, value);
        }

        /// <summary>Alpha Transition Second Texture Map 3D</summary>
        public Texture3D? AlphaTransitionMapSecondTexture3D
        {
            get => _Material.GetSafeTexture3D(PropertyNameID.AlphaTransitionMapSecondTexture3D);
            set => _Material.SetSafeTexture(PropertyNameID.AlphaTransitionMapSecondTexture3D, value);
        }

        /// <summary>Alpha Transition Map Second Texture Progress</summary>
        public float AlphaTransitionMapSecondTextureProgress
        {
            get => _Material.GetSafeFloat(PropertyNameID.AlphaTransitionMapSecondTextureProgress, PropertyRange.AlphaTransitionMapSecondTextureProgress.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.AlphaTransitionMapSecondTextureProgress, PropertyRange.AlphaTransitionMapSecondTextureProgress, value);
        }

        /// <summary>Alpha Transition Map Second Texture Progress Coord</summary>
        public NovaCustomCoord AlphaTransitionMapSecondTextureProgressCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.AlphaTransitionMapSecondTextureProgressCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.AlphaTransitionMapSecondTextureProgressCoord, (int)value);
        }

        /// <summary>Alpha Transition Second Texture Map Offset X Coord</summary>
        public NovaCustomCoord AlphaTransitionMapSecondTextureOffsetXCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.AlphaTransitionMapSecondTextureOffsetXCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.AlphaTransitionMapSecondTextureOffsetXCoord, (int)value);
        }

        /// <summary>Alpha Transition Second Texture Map Offset Y Coord</summary>
        public NovaCustomCoord AlphaTransitionMapSecondTextureOffsetYCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.AlphaTransitionMapSecondTextureOffsetYCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.AlphaTransitionMapSecondTextureOffsetYCoord, (int)value);
        }

        /// <summary>Alpha Transition Second Texture Map Channels X</summary>
        public NovaColorChannels AlphaTransitionMapSecondTextureChannelsX
        {
            get => _Material.GetSafeEnum<NovaColorChannels>(PropertyNameID.AlphaTransitionMapSecondTextureChannelsX, NovaColorChannels.Red);
            set => _Material.SetSafeInt(PropertyNameID.AlphaTransitionMapSecondTextureChannelsX, (int)value);
        }

        /// <summary>Alpha Transition Map Second Texture Slice Count</summary>
        public float AlphaTransitionMapSecondTextureSliceCount
        {
            get => _Material.GetSafeFloat(PropertyNameID.AlphaTransitionMapSecondTextureSliceCount, 4.0f);
            set => _Material.SetSafeFloat(PropertyNameID.AlphaTransitionMapSecondTextureSliceCount, value);
        }

        /// <summary>Alpha Transition Second Texture Progress</summary>
        public float AlphaTransitionProgressSecondTexture
        {
            get => _Material.GetSafeFloat(PropertyNameID.AlphaTransitionProgressSecondTexture, PropertyRange.AlphaTransitionProgressSecondTexture.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.AlphaTransitionProgressSecondTexture, PropertyRange.AlphaTransitionProgressSecondTexture, value);
        }

        /// <summary>Alpha Transition Second Texture Progress Coord</summary>
        public NovaCustomCoord AlphaTransitionProgressCoordSecondTexture
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.AlphaTransitionProgressCoordSecondTexture, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.AlphaTransitionProgressCoordSecondTexture, (int)value);
        }

        /// <summary>Second Texture Dissolve Sharpness</summary>
        public float DissolveSharpnessSecondTexture
        {
            get => _Material.GetSafeFloat(PropertyNameID.DissolveSharpnessSecondTexture, PropertyRange.DissolveSharpnessSecondTexture.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.DissolveSharpnessSecondTexture, PropertyRange.DissolveSharpnessSecondTexture, value);
        }

        #endregion

        #region Private Methods

        private void SetAlphaTransitionKeywords(
            NovaAlphaTransitionMode alphaTransitionMode,
            NovaAlphaTransitionMapMode alphaTransitionMapMode,
            Texture2D? alphaTransitionMap2D)
        {
            bool hasAlphaTransitionMap2D = alphaTransitionMap2D != null;

            bool fadeTransitionEnabled =
                (alphaTransitionMode == NovaAlphaTransitionMode.Fade) &&
                (alphaTransitionMapMode == NovaAlphaTransitionMapMode.SingleTexture) &&
                hasAlphaTransitionMap2D;

            bool dissolveTransitionEnabled =
                (alphaTransitionMode == NovaAlphaTransitionMode.Dissolve) &&
                (alphaTransitionMapMode == NovaAlphaTransitionMapMode.SingleTexture) &&
                hasAlphaTransitionMap2D;

            _Material.SetSafeKeyword(Keyword.FadeTransitionEnabled, fadeTransitionEnabled);

            _Material.SetSafeKeyword(Keyword.DissolveTransitionEnabled, dissolveTransitionEnabled);
        }

        private void SetAlphaTransitionKeywordsDistortion(
            NovaAlphaTransitionMode alphaTransitionMode,
            Texture2D? alphaTransitionMap2D)
        {
            bool hasAlphaTransitionMap2D = alphaTransitionMap2D != null;

            bool fadeTransitionEnabled =
                (alphaTransitionMode == NovaAlphaTransitionMode.Fade) &&
                hasAlphaTransitionMap2D;

            bool dissolveTransitionEnabled =
                (alphaTransitionMode == NovaAlphaTransitionMode.Dissolve) &&
                hasAlphaTransitionMap2D;

            _Material.SetSafeKeyword(Keyword.FadeTransitionEnabled, fadeTransitionEnabled);

            _Material.SetSafeKeyword(Keyword.DissolveTransitionEnabled, dissolveTransitionEnabled);
        }

        private void SetAlphaTransitionMapMode2DKeyword(
            NovaAlphaTransitionMapMode alphaTransitionMapMode,
            Texture2D? alphaTransitionMap2D)
        {
            bool enabled =
                (alphaTransitionMapMode == NovaAlphaTransitionMapMode.SingleTexture) &&
                (alphaTransitionMap2D != null);

            _Material.SetSafeKeyword(Keyword.AlphaTransitionMapMode2D, enabled);
        }

        private void SetAlphaTransitionMapMode2DArrayKeyword(
            NovaAlphaTransitionMapMode alphaTransitionMapMode,
            Texture2DArray? alphaTransitionMap2DArray)
        {
            bool enabled =
                (alphaTransitionMapMode == NovaAlphaTransitionMapMode.FlipBook) &&
                (alphaTransitionMap2DArray != null);

            _Material.SetSafeKeyword(Keyword.AlphaTransitionMapMode2DArray, enabled);
        }

        private void SetAlphaTransitionMapMode3DKeyword(
            NovaAlphaTransitionMapMode alphaTransitionMapMode,
            Texture3D? alphaTransitionMap3D)
        {
            bool enabled =
                (alphaTransitionMapMode == NovaAlphaTransitionMapMode.FlipBookBlending) &&
                (alphaTransitionMap3D != null);

            _Material.SetSafeKeyword(Keyword.AlphaTransitionMapMode3D, enabled);
        }

        #endregion
    }
}
