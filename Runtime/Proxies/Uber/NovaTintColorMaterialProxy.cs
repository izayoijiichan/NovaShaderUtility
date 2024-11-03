// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.Proxies.Uber
// @Class     : NovaTintColorMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.Proxies.Uber
{
    using Izayoi.NovaShader;
    using Izayoi.NovaShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// NOVA Shader Tint Color Material Proxy
    /// </summary>
    /// <remarks>
    /// ParticlesUberLit.shader
    /// ParticlesUberUnlit.shader
    /// UIParticlesUberLit.shader
    /// UIParticlesUberUnlit.shader
    /// </remarks>
    public class NovaTintColorMaterialProxy : NovaMaterialProxyBase
    {
        #region Constructors

        /// <summary>
        /// Create a new instance of NovaTintColorMaterialProxy.
        /// </summary>
        /// <param name="material">The NOVA shader material.</param>
        public NovaTintColorMaterialProxy(Material material) : base(material)
        {
        }

        #endregion

        #region Properties

        /// <summary>Tint Area Mode</summary>
        public NovaTintAreaMode TintAreaMode
        {
            get => _Material.GetSafeEnum<NovaTintAreaMode>(PropertyNameID.TintAreaMode, NovaTintAreaMode.None);
            set
            {
                _Material.SetSafeInt(PropertyNameID.TintAreaMode, (int)value);

                _Material.SetSafeKeyword(Keyword.TintAreaAll, value == NovaTintAreaMode.All);
                _Material.SetSafeKeyword(Keyword.TintAreaRim, value == NovaTintAreaMode.Rim);
            }
        }

        /// <summary>Tint Color Mode</summary>
        public NovaTintColorMode TintColorMode
        {
            get => _Material.GetSafeEnum<NovaTintColorMode>(PropertyNameID.TintColorMode, NovaTintColorMode.SingleColor);
            set
            {
                _Material.SetSafeInt(PropertyNameID.TintColorMode, (int)value);

                _Material.SetSafeKeyword(Keyword.TintColorEnabled, value == NovaTintColorMode.SingleColor);

                SetTintMapKeyword(value, TintMap);
                SetTintMap3DKeyword(value, TintMap3D);
            }
        }

        /// <summary>Tint Color</summary>
        public Color TintColor
        {
            get => _Material.GetSafeColor(PropertyNameID.TintColor, Color.white);
            set => _Material.SetSafeColor(PropertyNameID.TintColor, value);
        }

        /// <summary>Tint Map 2D</summary>
        public Texture2D? TintMap
        {
            get => _Material.GetSafeTexture(PropertyNameID.TintMap);
            set
            {
                _Material.SetSafeTexture(PropertyNameID.TintMap, value);

                SetTintMapKeyword(TintColorMode, value);
            }
        }

        /// <summary>Tint Map 3D</summary>
        public Texture3D? TintMap3D
        {
            get => _Material.GetSafeTexture3D(PropertyNameID.TintMap3D);
            set
            {
                _Material.SetSafeTexture(PropertyNameID.TintMap3D, value);

                SetTintMap3DKeyword(TintColorMode, value);
            }
        }

        /// <summary>Tint Map 3D Progress</summary>
        public float TintMap3DProgress
        {
            get => _Material.GetSafeFloat(PropertyNameID.TintMap3DProgress, PropertyRange.TintMap3DProgress.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.TintMap3DProgress, PropertyRange.TintMap3DProgress, value);
        }

        /// <summary>Tint Map 3D Progress Coord</summary>
        public NovaCustomCoord TintMap3DProgressCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.TintMap3DProgressCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.TintMap3DProgressCoord, (int)value);
        }

        /// <summary>Tint Map Slice Count</summary>
        public float TintMapSliceCount
        {
            get => _Material.GetSafeFloat(PropertyNameID.TintMapSliceCount, 4.0f);
            set => _Material.SetSafeFloat(PropertyNameID.TintMapSliceCount, value);
        }

        /// <summary>Tint Map Offset X Coord</summary>
        public NovaCustomCoord TintMapOffsetXCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.TintMapOffsetXCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.TintMapOffsetXCoord, (int)value);
        }

        /// <summary>Tint Map Offset Y Coord</summary>
        public NovaCustomCoord TintMapOffsetYCoord
    {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.TintMapOffsetYCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.TintMapOffsetYCoord, (int)value);
        }

        /// <summary>Tint Blend Rate</summary>
        public float TintBlendRate
        {
            get => _Material.GetSafeFloat(PropertyNameID.TintBlendRate, PropertyRange.TintBlendRate.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.TintBlendRate, PropertyRange.TintBlendRate, value);
        }

        /// <summary>Tint Blend Rate Coord</summary>
        public NovaCustomCoord TintBlendRateCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.TintBlendRateCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.TintBlendRateCoord, (int)value);
        }

        /// <summary>Tint Rim Progress</summary>
        public float TintRimProgress
        {
            get => _Material.GetSafeFloat(PropertyNameID.TintRimProgress, PropertyRange.TintRimProgress.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.TintRimProgress, PropertyRange.TintRimProgress, value);
        }

        /// <summary>Tint Rim Progress Coord</summary>
        public NovaCustomCoord TintRimProgressCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.TintRimProgressCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.TintRimProgressCoord, (int)value);
        }

        /// <summary>Tint Rim Sharpness</summary>
        public float TintRimSharpness
        {
            get => _Material.GetSafeFloat(PropertyNameID.TintRimSharpness, PropertyRange.TintRimSharpness.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.TintRimSharpness, PropertyRange.TintRimSharpness, value);
        }

        /// <summary>Tint Rim Sharpness Coord</summary>
        public NovaCustomCoord TintRimSharpnessCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.TintRimSharpnessCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.TintRimSharpnessCoord, (int)value);
        }

        /// <summary>Inverse Tint Rim</summary>
        public bool InverseTintRim
        {
            get => _Material.GetSafeBool(PropertyNameID.InverseTintRim, false);
            set => _Material.SetSafeBool(PropertyNameID.InverseTintRim, value);
        }

        #endregion

        #region Private Methods

        private void SetTintMapKeyword(NovaTintColorMode tintColorMode, Texture2D? tintMap2D)
        {
            bool enabled =
                (tintColorMode == NovaTintColorMode.Texture2D) &&
                (tintMap2D != null);

            _Material.SetSafeKeyword(Keyword.TintMapEnabled, enabled);
        }

        private void SetTintMap3DKeyword(NovaTintColorMode tintColorMode, Texture3D? tintMap3D)
        {
            bool enabled =
                (tintColorMode == NovaTintColorMode.Texture3D) &&
                (tintMap3D != null);

            _Material.SetSafeKeyword(Keyword.TintMap3DEnabled, enabled);
        }

        #endregion
    }
}
