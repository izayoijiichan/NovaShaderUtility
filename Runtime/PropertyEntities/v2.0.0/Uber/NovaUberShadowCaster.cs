// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Class     : NovaUberShadowCaster
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    /// <summary>
    /// NOVA Uber Shader Shadow Caster
    /// </summary>
    public class NovaUberShadowCaster : INovaUberShadowCaster
    {
        #region Properties

        /// <summary>Shadow Caster Enabled</summary>
        public bool ShadowCasterEnabled { get; set; }

        /// <summary>Shadow Caster Vertex Deformation Enabled</summary>
        public bool ShadowCasterApplyVertexDeformation { get; set; }

        /// <summary>Shadow Caster Alpha Test Enabled</summary>
        public bool ShadowCasterAlphaTestEnabled { get; set; }

        /// <summary>Shadow Caster Alpha Test Cutoff</summary>
        public float ShadowCasterAlphaCutoff { get; set; }

        /// <summary>Shadow Caster Alpha Effect by Tint Color</summary>
        public bool ShadowCasterAlphaAffectedByTintColor { get; set; }

        /// <summary>Shadow Caster Alpha Effect by Flow Map</summary>
        public bool ShadowCasterAlphaAffectedByFlowMap { get; set; }

        /// <summary>Shadow Caster Alpha Effect by Alpha Transition Map</summary>
        public bool ShadowCasterAlphaAffectedByAlphaTransitionMap { get; set; }

        /// <summary>Shadow Caster Alpha Effect by Transparency Luminance</summary>
        public bool ShadowCasterAlphaAffectedByTransparencyLuminance { get; set; }

        #endregion
    }
}