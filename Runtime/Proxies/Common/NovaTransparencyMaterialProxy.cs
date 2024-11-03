// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.Proxies
// @Class     : NovaTransparencyMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.Proxies
{
    using Izayoi.NovaShader;
    using Izayoi.NovaShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// NOVA Shader Transparency Material Proxy
    /// </summary>
    /// <remarks>
    /// ParticlesDistortion.shader
    /// ParticlesUberLit.shader
    /// ParticlesUberUnlit.shader
    /// UIParticlesUberLit.shader
    /// UIParticlesUberUnlit.shader
    /// </remarks>
    public class NovaTransparencyMaterialProxy : NovaMaterialProxyBase
    {
        #region Constructors

        /// <summary>
        /// Create a new instance of NovaTransparencyMaterialProxy.
        /// </summary>
        /// <param name="material">The NOVA shader material.</param>
        public NovaTransparencyMaterialProxy(Material material) : base(material)
        {
        }

        #endregion

        #region Properties

        /// <summary>Rim Transparency Enabled</summary>
        public bool RimTransparencyEnabled
        {
            get => _Material.GetSafeBool(PropertyNameID.RimTransparencyEnabled, false);
            set
            {
                _Material.SetSafeBool(PropertyNameID.RimTransparencyEnabled, value);

                _Material.SetSafeKeyword(Keyword.TransparencyByRim, value);
            }
        }

        /// <summary>Rim Transparency Progress</summary>
        public float RimTransparencyProgress
        {
            get => _Material.GetSafeFloat(PropertyNameID.RimTransparencyProgress, PropertyRange.RimTransparencyProgress.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.RimTransparencyProgress, PropertyRange.RimTransparencyProgress, value);
        }

        /// <summary>Rim Transparency Progress Coord</summary>
        public NovaCustomCoord RimTransparencyProgressCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.RimTransparencyProgressCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.RimTransparencyProgressCoord, (int)value);
        }

        /// <summary>Rim Transparency Sharpness</summary>
        public float RimTransparencySharpness
        {
            get => _Material.GetSafeFloat(PropertyNameID.RimTransparencySharpness, PropertyRange.RimTransparencySharpness.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.RimTransparencySharpness, PropertyRange.RimTransparencySharpness, value);
        }

        /// <summary>Rim Transparency Sharpness Coord</summary>
        public NovaCustomCoord RimTransparencySharpnessCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.RimTransparencySharpnessCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.RimTransparencySharpnessCoord, (int)value);
        }

        /// <summary>Inverse Rim Transparency</summary>
        public bool InverseRimTransparency
        {
            get => _Material.GetSafeBool(PropertyNameID.InverseRimTransparency, false);
            set => _Material.SetSafeBool(PropertyNameID.InverseRimTransparency, value);
        }

        /// <summary>Luminance Transparency Enabled</summary>
        public bool LuminanceTransparencyEnabled
        {
            get => _Material.GetSafeBool(PropertyNameID.LuminanceTransparencyEnabled, false);
            set
            {
                _Material.SetSafeBool(PropertyNameID.LuminanceTransparencyEnabled, value);

                _Material.SetSafeKeyword(Keyword.TransparencyByLuminance, value);
            }
        }

        /// <summary>Luminance Transparency Progress</summary>
        public float LuminanceTransparencyProgress
        {
            get => _Material.GetSafeFloat(PropertyNameID.LuminanceTransparencyProgress, PropertyRange.LuminanceTransparencyProgress.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.LuminanceTransparencyProgress, PropertyRange.LuminanceTransparencyProgress, value);
        }

        /// <summary>Luminance Transparency Progress Coord</summary>
        public NovaCustomCoord LuminanceTransparencyProgressCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.LuminanceTransparencyProgressCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.LuminanceTransparencyProgressCoord, (int)value);
        }

        /// <summary>Luminance Transparency Sharpness</summary>
        public float LuminanceTransparencySharpness
        {
            get => _Material.GetSafeFloat(PropertyNameID.LuminanceTransparencySharpness, PropertyRange.LuminanceTransparencySharpness.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.LuminanceTransparencySharpness, PropertyRange.LuminanceTransparencySharpness, value);
        }

        /// <summary>Luminance Transparency Sharpness Coord</summary>
        public NovaCustomCoord LuminanceTransparencySharpnessCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.LuminanceTransparencySharpnessCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.LuminanceTransparencySharpnessCoord, (int)value);
        }

        /// <summary>Inverse Luminance Transparency</summary>
        public bool InverseLuminanceTransparency
        {
            get => _Material.GetSafeBool(PropertyNameID.InverseLuminanceTransparency, false);
            set => _Material.SetSafeBool(PropertyNameID.InverseLuminanceTransparency, value);
        }

        /// <summary>Soft Particles Enabled</summary>
        public bool SoftParticlesEnabled
        {
            get => _Material.GetSafeBool(PropertyNameID.SoftParticlesEnabled, false);
            set
            {
                _Material.SetSafeBool(PropertyNameID.SoftParticlesEnabled, value);

                _Material.SetSafeKeyword(Keyword.SoftParticlesEnabled, value);
            }
        }

        /// <summary>Soft Particles Intensity</summary>
        public float SoftParticlesIntensity
        {
            get => _Material.GetSafeFloat(PropertyNameID.SoftParticlesIntensity, 1.0f);
            set => _Material.SetSafeFloat(PropertyNameID.SoftParticlesIntensity, value);
        }

        /// <summary>Depth Fade Enabled</summary>
        public bool DepthFadeEnabled
        {
            get => _Material.GetSafeBool(PropertyNameID.DepthFadeEnabled, false);
            set
            {
                _Material.SetSafeBool(PropertyNameID.DepthFadeEnabled, value);

                _Material.SetSafeKeyword(Keyword.DepthFadeEnabled, value);
            }
        }

        /// <summary>Depth Fade Near</summary>
        public float DepthFadeNear
        {
            get => _Material.GetSafeFloat(PropertyNameID.DepthFadeNear, 1.0f);
            set => _Material.SetSafeFloat(PropertyNameID.DepthFadeNear, value);
        }

        /// <summary>Depth Fade Far</summary>
        public float DepthFadeFar
        {
            get => _Material.GetSafeFloat(PropertyNameID.DepthFadeFar, 10.0f);
            set => _Material.SetSafeFloat(PropertyNameID.DepthFadeFar, value);
        }

        /// <summary>Depth Fade Width</summary>
        public float DepthFadeWidth
        {
            get => _Material.GetSafeFloat(PropertyNameID.DepthFadeWidth, 1.0f);
            set => _Material.SetSafeFloat(PropertyNameID.DepthFadeWidth, value);
        }

        #endregion
    }
}
