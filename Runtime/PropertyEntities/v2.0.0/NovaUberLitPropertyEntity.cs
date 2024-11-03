// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Class     : NovaUberLitPropertyEntity
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    /// <summary>
    /// NOVA Shader Uber Lit Property Entity
    /// </summary>
    /// <remarks>
    /// ParticlesUberLit.shader
    /// UIParticlesUberLit.shader
    /// </remarks>
    public class NovaUberLitPropertyEntity //: NovaPropertyEntityBase
    {
        /// <summary>Render Settings</summary>
        public NovaUberLitRenderSetting? RenderSetting { get; set; }

        /// <summary>Surface Maps</summary>
        public NovaUberLitSurfaceMap? SurfaceMap { get; set; }

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