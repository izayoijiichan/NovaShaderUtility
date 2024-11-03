// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Interface : INovaUberShadowCaster
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    /// <summary>
    /// NOVA Uber Shader Shadow Caster Interface
    /// </summary>
    public interface INovaUberShadowCaster
    {
        #region Properties

        /// <summary>Shadow Caster Enabled</summary>
        bool ShadowCasterEnabled { get; set; }

        /// <summary>Shadow Caster Vertex Deformation Enabled</summary>
        bool ShadowCasterApplyVertexDeformation { get; set; }

        /// <summary>Shadow Caster Alpha Test Enabled</summary>
        bool ShadowCasterAlphaTestEnabled { get; set; }

        /// <summary>Shadow Caster Alpha Test Cutoff</summary>
        float ShadowCasterAlphaCutoff { get; set; }

        /// <summary>Shadow Caster Alpha Effect by Tint Color</summary>
        bool ShadowCasterAlphaAffectedByTintColor { get; set; }

        /// <summary>Shadow Caster Alpha Effect by Flow Map</summary>
        bool ShadowCasterAlphaAffectedByFlowMap { get; set; }

        /// <summary>Shadow Caster Alpha Effect by Alpha Transition Map</summary>
        bool ShadowCasterAlphaAffectedByAlphaTransitionMap { get; set; }

        /// <summary>Shadow Caster Alpha Effect by Transparency Luminance</summary>
        bool ShadowCasterAlphaAffectedByTransparencyLuminance { get; set; }

        #endregion
    }
}