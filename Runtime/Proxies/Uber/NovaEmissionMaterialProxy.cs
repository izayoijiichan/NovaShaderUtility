// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.Proxies.Uber
// @Class     : NovaEmissionMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.Proxies.Uber
{
    using Izayoi.NovaShader;
    using Izayoi.NovaShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// NOVA Shader Emission Material Proxy
    /// </summary>
    /// <remarks>
    /// ParticlesUberLit.shader
    /// ParticlesUberUnlit.shader
    /// UIParticlesUberLit.shader
    /// UIParticlesUberUnlit.shader
    /// </remarks>
    public class NovaEmissionMaterialProxy : NovaMaterialProxyBase
    {
        #region Constructors

        /// <summary>
        /// Create a new instance of NovaEmissionMaterialProxy.
        /// </summary>
        /// <param name="material">The NOVA shader material.</param>
        public NovaEmissionMaterialProxy(Material material) : base(material)
        {
        }

        #endregion

        #region Properties

        /// <summary>Emission Area Type</summary>
        public NovaEmissionAreaType EmissionAreaType
        {
            get => _Material.GetSafeEnum<NovaEmissionAreaType>(PropertyNameID.EmissionAreaType, NovaEmissionAreaType.None);
            set
            {
                _Material.SetSafeInt(PropertyNameID.EmissionAreaType, (int)value);

                _Material.SetSafeKeyword(Keyword.EmissionAreaAll, value == NovaEmissionAreaType.All);
                _Material.SetSafeKeyword(Keyword.EmissionAreaMap, value == NovaEmissionAreaType.ByTexture);
                _Material.SetSafeKeyword(Keyword.EmissionAreaAlpha, value == NovaEmissionAreaType.Edge);
            }
        }

        /// <summary>Emission Map Mode</summary>
        public NovaEmissionMapMode EmissionMapMode
        {
            get => _Material.GetSafeEnum<NovaEmissionMapMode>(PropertyNameID.EmissionMapMode, NovaEmissionMapMode.SingleTexture);
            set
            {
                _Material.SetSafeInt(PropertyNameID.EmissionMapMode, (int)value);

                SetEmissionMapMode2DKeyword(value, EmissionMap);
                SetEmissionMapMode2DArrayKeyword(value, EmissionMap2DArray);
                SetEmissionMapMode3DKeyword(value, EmissionMap3D);
            }
        }

        /// <summary>Emission Map 2D</summary>
        public Texture2D? EmissionMap
        {
            get => _Material.GetSafeTexture(PropertyNameID.EmissionMap);
            set
            {
                _Material.SetSafeTexture(PropertyNameID.EmissionMap, value);

                SetEmissionMapMode2DKeyword(EmissionMapMode, value);
            }
        }

        /// <summary>Emission Map 2D Array</summary>
        public Texture2DArray? EmissionMap2DArray
        {
            get => _Material.GetSafeTexture2DArray(PropertyNameID.EmissionMap2DArray);
            set
            {
                _Material.SetSafeTexture(PropertyNameID.EmissionMap2DArray, value);

                SetEmissionMapMode2DArrayKeyword(EmissionMapMode, value);
            }
        }

        /// <summary>Emission Map 3D</summary>
        public Texture3D? EmissionMap3D
        {
            get => _Material.GetSafeTexture3D(PropertyNameID.EmissionMap3D);
            set
            {
                _Material.SetSafeTexture(PropertyNameID.EmissionMap3D, value);

                SetEmissionMapMode3DKeyword(EmissionMapMode, value);
            }
        }

        /// <summary>Emission Map Progress</summary>
        public float EmissionMapProgress
        {
            get => _Material.GetSafeFloat(PropertyNameID.EmissionMapProgress, PropertyRange.EmissionMapProgress.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.EmissionMapProgress, PropertyRange.EmissionMapProgress, value);
        }

        /// <summary>Emission Map Progress Coord</summary>
        public NovaCustomCoord EmissionMapProgressCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.EmissionMapProgressCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.EmissionMapProgressCoord, (int)value);
        }

        /// <summary>Emission Map Offset X Coord</summary>
        public NovaCustomCoord EmissionMapOffsetXCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.EmissionMapOffsetXCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.EmissionMapOffsetXCoord, (int)value);
        }

        /// <summary>Emission Map Offset Y Coord</summary>
        public NovaCustomCoord EmissionMapOffsetYCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.EmissionMapOffsetYCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.EmissionMapOffsetYCoord, (int)value);
        }

        /// <summary>Emission Map Channels X</summary>
        public NovaColorChannels EmissionMapChannelsX
        {
            get => _Material.GetSafeEnum<NovaColorChannels>(PropertyNameID.EmissionMapChannelsX, NovaColorChannels.Red);
            set => _Material.SetSafeInt(PropertyNameID.EmissionMapChannelsX, (int)value);
        }

        /// <summary>Alpha Transition Map Slice Count</summary>
        public float EmissionMapSliceCount
        {
            get => _Material.GetSafeFloat(PropertyNameID.EmissionMapSliceCount, 4.0f);
            set => _Material.SetSafeFloat(PropertyNameID.EmissionMapSliceCount, value);
        }

        /// <summary>Emission Color Type</summary>
        public NovaEmissionColorType EmissionColorType
        {
            get => _Material.GetSafeEnum<NovaEmissionColorType>(PropertyNameID.EmissionColorType, NovaEmissionColorType.Color);
            set
            {
                _Material.SetSafeInt(PropertyNameID.EmissionColorType, (int)value);

                _Material.SetSafeKeyword(Keyword.EmissionColorColor, value == NovaEmissionColorType.Color);
                _Material.SetSafeKeyword(Keyword.EmissionColorBaseColor, value == NovaEmissionColorType.BaseColor);
                _Material.SetSafeKeyword(Keyword.EmissionColorMap, value == NovaEmissionColorType.GradientMap);
            }
        }

        /// <summary>Emission Color</summary>
        public Color EmissionColor
        {
            get => _Material.GetSafeColor(PropertyNameID.EmissionColor, Color.black);
            set => _Material.SetSafeColor(PropertyNameID.EmissionColor, value);
        }

        /// <summary>Emission Color Ramp</summary>
        public Texture2D? EmissionColorRamp
        {
            get => _Material.GetSafeTexture(PropertyNameID.EmissionColorRamp);
            set
            {
                _Material.SetSafeTexture(PropertyNameID.EmissionColorRamp, value);
            }
        }

        /// <summary>Emission Intensity</summary>
        public float EmissionIntensity
        {
            get => _Material.GetSafeFloat(PropertyNameID.EmissionIntensity, 1.0f);
            set => _Material.SetSafeFloat(PropertyNameID.EmissionIntensity, value);
        }

        /// <summary>Emission Intensity Coord</summary>
        public NovaCustomCoord EmissionIntensityCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.EmissionIntensityCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.EmissionIntensityCoord, (int)value);
        }

        /// <summary>Keep Edge Transparency</summary>
        public bool KeepEdgeTransparency
        {
            get => _Material.GetSafeBool(PropertyNameID.KeepEdgeTransparency, true);
            set => _Material.SetSafeBool(PropertyNameID.KeepEdgeTransparency, value);
        }

        #endregion

        #region Private Methods

        private void SetEmissionMapMode2DKeyword(NovaEmissionMapMode emissionMapMode, Texture2D? emissionMap2D)
        {
            bool enabled =
                (emissionMapMode == NovaEmissionMapMode.SingleTexture) &&
                (emissionMap2D != null);

            _Material.SetSafeKeyword(Keyword.EmissionMapMode2D, enabled);
        }

        private void SetEmissionMapMode2DArrayKeyword(NovaEmissionMapMode emissionMapMode, Texture2DArray? emissionMap2DArray)
        {
            bool enabled =
                (emissionMapMode == NovaEmissionMapMode.FlipBook) &&
                (emissionMap2DArray != null);

            _Material.SetSafeKeyword(Keyword.EmissionMapMode2DArray, enabled);
        }

        private void SetEmissionMapMode3DKeyword(NovaEmissionMapMode emissionMapMode, Texture3D? emissionMap3D)
        {
            bool enabled =
                (emissionMapMode == NovaEmissionMapMode.FlipBookBlending) &&
                (emissionMap3D != null);

            _Material.SetSafeKeyword(Keyword.EmissionMapMode3D, enabled);
        }

        #endregion
    }
}
