// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.Proxies.Uber
// @Class     : NovaShadowCasterMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.Proxies.Uber
{
    using Izayoi.NovaShader;
    using Izayoi.NovaShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// NOVA Shader Shadow Caster Material Proxy
    /// </summary>
    /// <remarks>
    /// ParticlesUberLit.shader
    /// ParticlesUberUnlit.shader
    /// UIParticlesUberLit.shader
    /// UIParticlesUberUnlit.shader
    /// </remarks>
    public class NovaShadowCasterMaterialProxy : NovaMaterialProxyBase
    {
        #region Constructors

        /// <summary>
        /// Create a new instance of NovaShadowCasterMaterialProxy.
        /// </summary>
        /// <param name="material">The NOVA shader material.</param>
        public NovaShadowCasterMaterialProxy(Material material) : base(material)
        {
        }

        #endregion

        #region Properties

        /// <summary>Shadow Caster Enabled</summary>
        public bool ShadowCasterEnabled
        {
            get => _Material.GetSafeBool(PropertyNameID.ShadowCasterEnabled, false);
            set =>  _Material.SetSafeBool(PropertyNameID.ShadowCasterEnabled, value);
        }

        /// <summary>Shadow Caster Vertex Deformation Enabled</summary>
        public bool ShadowCasterApplyVertexDeformation
        {
            get => _Material.GetSafeBool(PropertyNameID.ShadowCasterApplyVertexDeformation, false);
            set => _Material.SetSafeBool(PropertyNameID.ShadowCasterApplyVertexDeformation, value);
        }

        /// <summary>Shadow Caster Alpha Test Enabled</summary>
        public bool ShadowCasterAlphaTestEnabled
        {
            get => _Material.GetSafeBool(PropertyNameID.ShadowCasterAlphaTestEnabled, false);
            set
            {
                _Material.SetSafeBool(PropertyNameID.ShadowCasterAlphaTestEnabled, value);

                _Material.SetSafeKeyword(Keyword.ShadowCasterAlphaTestEnabled, value);
            }
        }

        /// <summary>Shadow Caster Alpha Test Cutoff</summary>
        public float ShadowCasterAlphaCutoff
        {
            get => _Material.GetSafeFloat(PropertyNameID.ShadowCasterAlphaCutoff, PropertyRange.ShadowCasterAlphaCutoff.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.ShadowCasterAlphaCutoff, PropertyRange.ShadowCasterAlphaCutoff, value);
        }

        /// <summary>Shadow Caster Alpha Effect by Tint Color</summary>
        public bool ShadowCasterAlphaAffectedByTintColor
        {
            get => _Material.GetSafeBool(PropertyNameID.ShadowCasterAlphaAffectedByTintColor, false);
            set => _Material.SetSafeBool(PropertyNameID.ShadowCasterAlphaAffectedByTintColor, value);
        }

        /// <summary>Shadow Caster Alpha Effect by Flow Map</summary>
        public bool ShadowCasterAlphaAffectedByFlowMap
        {
            get => _Material.GetSafeBool(PropertyNameID.ShadowCasterAlphaAffectedByFlowMap, false);
            set => _Material.SetSafeBool(PropertyNameID.ShadowCasterAlphaAffectedByFlowMap, value);
        }

        /// <summary>Shadow Caster Alpha Effect by Alpha Transition Map</summary>
        public bool ShadowCasterAlphaAffectedByAlphaTransitionMap
        {
            get => _Material.GetSafeBool(PropertyNameID.ShadowCasterAlphaAffectedByAlphaTransitionMap, false);
            set => _Material.SetSafeBool(PropertyNameID.ShadowCasterAlphaAffectedByAlphaTransitionMap, value);
        }

        /// <summary>Shadow Caster Alpha Effect by Transparency Luminance</summary>
        public bool ShadowCasterAlphaAffectedByTransparencyLuminance
        {
            get => _Material.GetSafeBool(PropertyNameID.ShadowCasterAlphaAffectedByTransparencyLuminance, false);
            set => _Material.SetSafeBool(PropertyNameID.ShadowCasterAlphaAffectedByTransparencyLuminance, value);
        }

        #endregion
    }
}
