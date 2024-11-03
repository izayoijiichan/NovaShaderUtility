// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.Proxies.Uber
// @Class     : NovaParallaxMapMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.Proxies.Uber
{
    using Izayoi.NovaShader;
    using Izayoi.NovaShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// NOVA Shader Parallax Map Material Proxy
    /// </summary>
    /// <remarks>
    /// ParticlesUberLit.shader
    /// ParticlesUberUnlit.shader
    /// UIParticlesUberLit.shader
    /// UIParticlesUberUnlit.shader
    /// </remarks>
    public class NovaParallaxMapMaterialProxy : NovaMaterialProxyBase
    {
        #region Constructors

        /// <summary>
        /// Create a new instance of NovaParallaxMapMaterialProxy.
        /// </summary>
        /// <param name="material">The NOVA shader material.</param>
        public NovaParallaxMapMaterialProxy(Material material) : base(material)
        {
        }

        #endregion

        #region Properties

        /// <summary>Parallax Map Mode</summary>
        public NovaParallaxMapMode ParallaxMapMode
        {
            get => _Material.GetSafeEnum<NovaParallaxMapMode>(PropertyNameID.ParallaxMapMode, NovaParallaxMapMode.SingleTexture);
            set
            {
                _Material.SetSafeInt(PropertyNameID.ParallaxMapMode, (int)value);

                SetParallaxMapMode2DKeyword(value, ParallaxMap);
                SetParallaxMapMode2DArrayKeyword(value, ParallaxMap2DArray);
                SetParallaxMapMode3DKeyword(value, ParallaxMap3D);
            }
        }

        /// <summary>Parallax Map 2D</summary>
        public Texture2D? ParallaxMap
        {
            get => _Material.GetSafeTexture(PropertyNameID.ParallaxMap);
            set
            {
                _Material.SetSafeTexture(PropertyNameID.ParallaxMap, value);

                SetParallaxMapMode2DKeyword(ParallaxMapMode, value);
            }
        }

        /// <summary>Parallax Map 2D Array</summary>
        public Texture2DArray? ParallaxMap2DArray
        {
            get => _Material.GetSafeTexture2DArray(PropertyNameID.ParallaxMap2DArray);
            set
            {
                _Material.SetSafeTexture(PropertyNameID.ParallaxMap2DArray, value);

                SetParallaxMapMode2DArrayKeyword(ParallaxMapMode, value);
            }
        }

        /// <summary>Parallax Map 3D</summary>
        public Texture3D? ParallaxMap3D
        {
            get => _Material.GetSafeTexture3D(PropertyNameID.ParallaxMap3D);
            set
            {
                _Material.SetSafeTexture(PropertyNameID.ParallaxMap3D, value);

                SetParallaxMapMode3DKeyword(ParallaxMapMode, value);
            }
        }

        /// <summary>Parallax Map Progress</summary>
        public float ParallaxMapProgress
        {
            get => _Material.GetSafeFloat(PropertyNameID.ParallaxMapProgress, PropertyRange.ParallaxMapProgress.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.ParallaxMapProgress, PropertyRange.ParallaxMapProgress, value);
        }

        /// <summary>Parallax Map Progress Coord</summary>
        public NovaCustomCoord ParallaxMapProgressCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.ParallaxMapProgressCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.ParallaxMapProgressCoord, (int)value);
        }

        /// <summary>Parallax Map Offset X Coord</summary>
        public NovaCustomCoord ParallaxMapOffsetXCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.ParallaxMapOffsetXCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.ParallaxMapOffsetXCoord, (int)value);
        }

        /// <summary>Parallax Map Offset Y Coord</summary>
        public NovaCustomCoord ParallaxMapOffsetYCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.ParallaxMapOffsetYCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.ParallaxMapOffsetYCoord, (int)value);
        }

        /// <summary>Parallax Map Slice Count</summary>
        public float ParallaxMapSliceCount
        {
            get => _Material.GetSafeFloat(PropertyNameID.ParallaxMapSliceCount, 4.0f);
            set => _Material.SetSafeFloat(PropertyNameID.ParallaxMapSliceCount, value);
        }

        /// <summary>Parallax Map Channel</summary>
        public NovaColorChannels ParallaxMapChannel
        {
            get => _Material.GetSafeEnum<NovaColorChannels>(PropertyNameID.ParallaxMapChannel, NovaColorChannels.Red);
            set => _Material.SetSafeInt(PropertyNameID.ParallaxMapChannel, (int)value);
        }

        /// <summary>Parallax Strength</summary>
        public float ParallaxStrength
        {
            get => _Material.GetSafeFloat(PropertyNameID.ParallaxStrength, PropertyRange.ParallaxStrength.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.ParallaxStrength, PropertyRange.ParallaxStrength, value);
        }

        /// <summary>Parallax Map Target</summary>
        public NovaParallaxMapTarget ParallaxMapTarget
        {
            get => _Material.GetSafeEnum<NovaParallaxMapTarget>(PropertyNameID.ParallaxMapTarget, NovaParallaxMapTarget.BaseMap);
            set
            {
                _Material.SetSafeInt(PropertyNameID.ParallaxMapTarget, (int)value);

                _Material.SetSafeKeyword(Keyword.ParallaxMapTargetBase, value.HasFlag(NovaFlowMapTarget.BaseMap));
                _Material.SetSafeKeyword(Keyword.ParallaxMapTargetTint, value.HasFlag(NovaFlowMapTarget.TintMap));
                _Material.SetSafeKeyword(Keyword.ParallaxMapTargetEmission, value.HasFlag(NovaFlowMapTarget.EmissionMap));
            }
        }

        #endregion

        #region Private Methods

        private void SetParallaxMapMode2DKeyword(NovaParallaxMapMode parallaxMapMode, Texture2D? parallaxMap2D)
        {
            bool enabled = 
                (parallaxMapMode == NovaParallaxMapMode.SingleTexture) && 
                (parallaxMap2D != null);

            _Material.SetSafeKeyword(Keyword.ParallaxMapMode2D, enabled);
        }

        private void SetParallaxMapMode2DArrayKeyword(NovaParallaxMapMode parallaxMapMode, Texture2DArray? parallaxMap2DArray)
        {
            bool enabled = 
                (parallaxMapMode == NovaParallaxMapMode.FlipBook) &&
                (parallaxMap2DArray != null);

            _Material.SetSafeKeyword(Keyword.ParallaxMapMode2DArray, enabled);
        }

        private void SetParallaxMapMode3DKeyword(NovaParallaxMapMode parallaxMapMode, Texture3D? parallaxMap3D)
        {
            bool enabled =
                (parallaxMapMode == NovaParallaxMapMode.FlipBookBlending) &&
                (parallaxMap3D != null);

            _Material.SetSafeKeyword(Keyword.ParallaxMapMode3D, enabled);
        }

        #endregion
    }
}
