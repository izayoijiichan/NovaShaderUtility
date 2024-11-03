// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Class     : NovaDistortionPropertyEntity
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    /// <summary>
    /// NOVA Shader Distortion Property Entity
    /// </summary>
    /// <remarks>
    /// ParticlesDistortion.shader
    /// </remarks>
    public class NovaDistortionPropertyEntity //: NovaPropertyEntityBase
    {
        /// <summary>Render Settings</summary>
        public NovaDistortionRenderSetting? RenderSetting { get; set; }

        /// <summary>Distortion Map</summary>
        public NovaDistortionDistortionMap? DistortionMap { get; set; }

        /// <summary>Flow Map</summary>
        public NovaDistortionFlowMap? FlowMap { get; set; }

        /// <summary>Alpha Transition</summary>
        public NovaDistortionAlphaTransition? AlphaTransition { get; set; }

        /// <summary>Transparency</summary>
        public NovaDistortionTransparency? Transparency { get; set; }
    }
}