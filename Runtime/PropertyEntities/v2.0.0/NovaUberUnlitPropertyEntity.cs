// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Class     : NovaUberUnlitPropertyEntity
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    /// <summary>
    /// NOVA Shader Uber Unlit Property Entity
    /// </summary>
    /// <remarks>
    /// ParticlesUberUnlit.shader
    /// UIParticlesUberUnlit.shader
    /// </remarks>
    public class NovaUberUnlitPropertyEntity //: NovaPropertyEntityBase
    {
        /// <summary>Render Settings</summary>
        public NovaUberUnlitRenderSetting? RenderSetting { get; set; }

        /// <summary>Base Map</summary>
        public NovaUberBaseMap? BaseMap { get; set; }

        /// <summary>Tint Color</summary>
        public NovaUberTintColor? TintColor { get; set; }

        /// <summary>Flow Map</summary>
        public NovaUberFlowMap? FlowMap { get; set; }

        /// <summary>Parallax Map</summary>
        public NovaUberParallaxMap? ParallaxMap { get; set; }

        /// <summary>Color Correction</summary>
        public NovaUberColorCorrection? ColorCorrection { get; set; }

        /// <summary>Alpha Transition</summary>
        public NovaUberAlphaTransition? AlphaTransition { get; set; }

        /// <summary>Emission</summary>
        public NovaUberEmission? Emission { get; set; }

        /// <summary>Transparency</summary>
        public NovaUberTransparency? Transparency { get; set; }

        /// <summary>Vertex Deformation</summary>
        public NovaUberVertexDeformation? VertexDeformation { get; set; }

        /// <summary>Shadow Caster</summary>
        public NovaUberShadowCaster? ShadowCaster { get; set; }
    }
}