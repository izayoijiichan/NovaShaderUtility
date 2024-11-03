// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader
// @Class     : Keyword
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader
{
    /// <summary>
    /// Keyword
    /// </summary>
    public class Keyword
    {
        #region Render Settings

        /// <summary>Vertex Alpha as Transition Progress</summary>
        public const string VertexAlphaAsTransitionProgress = "_VERTEX_ALPHA_AS_TRANSITION_PROGRESS";

        /// <summary>Alpha Modulate Enabled</summary>
        public const string AlphaModulateEnabled = "_ALPHAMODULATE_ENABLED";

        /// <summary>Alpha Test Enabled</summary>
        public const string AlphaTestEnabled = "_ALPHATEST_ENABLED";

        /// <summary>Receive Shadows Enabled</summary>
        public const string ReceiveShadowsEnabled = "_RECEIVE_SHADOWS_ENABLED";

        /// <summary>Specular Highlights Enabled</summary>
        public const string SpecularHighlightsEnabled = "_SPECULAR_HIGHLIGHTS_ENABLED";

        /// <summary>Environment Reflections Enabled</summary>
        public const string EnvironmentReflectionsEnabled = "_ENVIRONMENT_REFLECTIONS_ENABLED";

        /// <summary>Specular Setup</summary>
        public const string SpecularSetup = "_SPECULAR_SETUP";

        #endregion

        #region Base Color

        /// <summary>Base Map Rotation Enabled</summary>
        public const string BaseMapRotationEnabled = "_BASE_MAP_ROTATION_ENABLED";

        /// <summary>Base Map Rotation Mode 2D</summary>
        public const string BaseMapMode2D = "_BASE_MAP_MODE_2D";

        /// <summary>Base Map Rotation Mode 2D Array</summary>
        public const string BaseMapMode2DArray = "_BASE_MAP_MODE_2D_ARRAY";

        /// <summary>Base Map Rotation Mode 3D</summary>
        public const string BaseMapMode3D = "_BASE_MAP_MODE_3D";

        /// <summary>Base Sampler State Point Mirror</summary>
        public const string BaseSamplerStatePointMirror = "_BASE_SAMPLER_STATE_POINT_MIRROR";

        /// <summary>Base Sampler State Linear Mirror</summary>
        public const string BaseSamplerStateLinearMirror = "_BASE_SAMPLER_STATE_LINEAR_MIRROR";

        /// <summary>Base Sampler State Trilinear Mirror</summary>
        public const string BaseSamplerStateTrilinearMirror = "_BASE_SAMPLER_STATE_TRILINEAR_MIRROR";

        #endregion

        #region Surface maps

        /// <summary>Normal Map Enabled</summary>
        public const string NormalMapEnabled = "_NORMAL_MAP_ENABLED";

        /// <summary>Metallic Map Enabled</summary>
        public const string MetallicMapEnabled = "_METALLIC_MAP_ENABLED";

        /// <summary>Smoothness Map Enabled</summary>
        public const string SmoothnessMapEnabled = "_SMOOTHNESS_MAP_ENABLED";

        /// <summary>Specular Map Enabled</summary>
        public const string SpecularMapEnabled = "_SPECULAR_MAP_ENABLED";

        #endregion

        #region Tint Color

        /// <summary>Tint Area All</summary>
        public const string TintAreaAll = "_TINT_AREA_ALL";

        /// <summary>Tint Area Rim</summary>
        public const string TintAreaRim = "_TINT_AREA_RIM";

        /// <summary>Tint Color Enabled</summary>
        public const string TintColorEnabled = "_TINT_COLOR_ENABLED";

        /// <summary>Tint Map Enabled</summary>
        public const string TintMapEnabled = "_TINT_MAP_ENABLED";

        /// <summary>Tint Map 3D Enabled</summary>
        public const string TintMap3DEnabled = "_TINT_MAP_3D_ENABLED";

        /// <summary>Greyscale Enabled</summary>
        public const string GreyscaleEnabled = "_GREYSCALE_ENABLED";

        /// <summary>Gradient Map Enabled</summary>
        public const string GradientMapEnabled = "_GRADIENT_MAP_ENABLED";

        /// <summary>Flow Map Enabled</summary>
        public const string FlowMapEnabled = "_FLOW_MAP_ENABLED";

        /// <summary>Flow Map Target Base</summary>
        public const string FlowMapTargetBase = "_FLOW_MAP_TARGET_BASE";

        /// <summary>Flow Map Target Tint</summary>
        public const string FlowMapTargetTint = "_FLOW_MAP_TARGET_TINT";

        /// <summary>Flow Map Target Emission</summary>
        public const string FlowMapTargetEmission = "_FLOW_MAP_TARGET_EMISSION";

        /// <summary>Flow Map Target Alpha Transition</summary>
        public const string FlowMapTargetAlphaTransition = "_FLOW_MAP_TARGET_ALPHA_TRANSITION";

        #endregion

        #region Parallax Map


        /// <summary>Parallax Map Target Base</summary>
        public const string ParallaxMapTargetBase = "_PARALLAX_MAP_TARGET_BASE";

        /// <summary>Parallax Map Target Tint</summary>
        public const string ParallaxMapTargetTint = "_PARALLAX_MAP_TARGET_TINT";

        /// <summary>Parallax Map Target Emission</summary>
        public const string ParallaxMapTargetEmission = "_PARALLAX_MAP_TARGET_EMISSION";

        /// <summary>Parallax Map Mode 2D</summary>
        public const string ParallaxMapMode2D = "_PARALLAX_MAP_MODE_2D";

        /// <summary>Parallax Map Mode 2D Array</summary>
        public const string ParallaxMapMode2DArray = "_PARALLAX_MAP_MODE_2D_ARRAY";

        /// <summary>Parallax Map Mode 3D</summary>
        public const string ParallaxMapMode3D = "_PARALLAX_MAP_MODE_3D";

        #endregion

        #region Alpha Transition

        /// <summary>Fade Transition Enabled</summary>
        public const string FadeTransitionEnabled = "_FADE_TRANSITION_ENABLED";

        /// <summary>Dissolve Transition Enabled</summary>
        public const string DissolveTransitionEnabled = "_DISSOLVE_TRANSITION_ENABLED";

        /// <summary>Alpha Transition Map Mode 2D</summary>
        public const string AlphaTransitionMapMode2D = "_ALPHA_TRANSITION_MAP_MODE_2D";

        /// <summary>Alpha Transition Map Mode 2D Array</summary>
        public const string AlphaTransitionMapMode2DArray = "_ALPHA_TRANSITION_MAP_MODE_2D_ARRAY";

        /// <summary>Alpha Transition Map Mode 3D</summary>
        public const string AlphaTransitionMapMode3D = "_ALPHA_TRANSITION_MAP_MODE_3D";

        /// <summary>Alpha Transition Blend Second Tex Average</summary>
        public const string AlphaTransitionBlendSecondTexAverage = "_ALPHA_TRANSITION_BLEND_SECOND_TEX_AVERAGE";

        /// <summary>Alpha Transition Blend Second Tex Multiply</summary>
        public const string AlphaTransitionBlendSecondTexMultiply = "_ALPHA_TRANSITION_BLEND_SECOND_TEX_MULTIPLY";

        #endregion

        #region Emission

        /// <summary>Emission Area All</summary>
        public const string EmissionAreaAll = "_EMISSION_AREA_ALL";

        /// <summary>Emission Area Map</summary>
        public const string EmissionAreaMap = "_EMISSION_AREA_MAP";

        /// <summary>Emission Map Mode 2D</summary>
        public const string EmissionMapMode2D = "_EMISSION_MAP_MODE_2D";

        /// <summary>Emission Map Mode 2D Array</summary>
        public const string EmissionMapMode2DArray = "_EMISSION_MAP_MODE_2D_ARRAY";

        /// <summary>Emission Map Mode 3D</summary>
        public const string EmissionMapMode3D = "_EMISSION_MAP_MODE_3D";

        /// <summary>Emission Area Alpha</summary>
        public const string EmissionAreaAlpha = "_EMISSION_AREA_ALPHA";

        /// <summary>Emission Color Color</summary>
        public const string EmissionColorColor = "_EMISSION_COLOR_COLOR";

        /// <summary>Emission Color Base Color</summary>
        public const string EmissionColorBaseColor = "_EMISSION_COLOR_BASECOLOR";

        /// <summary>Emission Color Map</summary>
        public const string EmissionColorMap = "_EMISSION_COLOR_MAP";

        #endregion

        #region Transparency

        /// <summary>Transparency by Rim</summary>
        public const string TransparencyByRim = "_TRANSPARENCY_BY_RIM";

        /// <summary>Transparency by Luminance</summary>
        public const string TransparencyByLuminance = "_TRANSPARENCY_BY_LUMINANCE";

        /// <summary>Soft Particles Enabled</summary>
        public const string SoftParticlesEnabled = "_SOFT_PARTICLES_ENABLED";

        /// <summary>Depth Fade Enabled</summary>
        public const string DepthFadeEnabled = "_DEPTH_FADE_ENABLED";

        #endregion

        #region Vertex Deformation

        /// <summary>Vertex Deformation Enabled</summary>
        public const string VertexDeformationEnabled = "_VERTEX_DEFORMATION_ENABLED";

        #endregion

        #region Shadow Caster

        /// <summary>Shadow Caster Alpha Test Enabled</summary>
        public const string ShadowCasterAlphaTestEnabled = "_SHADOW_CASTER_ALPHA_TEST_ENABLED";

        #endregion
    }
}
