// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader
// @Enum      : NovaVertexAlphaMode
// ----------------------------------------------------------------------
#nullable enable
#if false
namespace Izayoi.NovaShader
{
    using System;

    /// <summary></summary>
    public static class ShaderKeywords
    {
        // Render Settings
        public const string VertexAlphaAsTransitionProgress = "_VERTEX_ALPHA_AS_TRANSITION_PROGRESS";
        public const string AlphaModulateEnabled = "_ALPHAMODULATE_ENABLED";
        public const string AlphaTestEnabled = "_ALPHATEST_ENABLED";
        public const string ReceiveShadowsEnabled = "_RECEIVE_SHADOWS_ENABLED";
        public const string SpecularHighlightsEnabled = "_SPECULAR_HIGHLIGHTS_ENABLED";
        public const string EnvironmentReflectionsEnabled = "_ENVIRONMENT_REFLECTIONS_ENABLED";

        public const string SpecularSetup = "_SPECULAR_SETUP";

        // Base Color
        public const string BaseMapRotationEnabled = "_BASE_MAP_ROTATION_ENABLED";
        public const string BaseMapMode2D = "_BASE_MAP_MODE_2D";
        public const string BaseMapMode2DArray = "_BASE_MAP_MODE_2D_ARRAY";
        public const string BaseMapMode3D = "_BASE_MAP_MODE_3D";
        public const string BaseSamplerStatePointMirror = "_BASE_SAMPLER_STATE_POINT_MIRROR";
        public const string BaseSamplerStateLinearMirror = "_BASE_SAMPLER_STATE_LINEAR_MIRROR";
        public const string BaseSamplerStateTrilinearMirror = "_BASE_SAMPLER_STATE_TRILINEAR_MIRROR";

        // Surface maps
        public const string NormalMapEnabled = "_NORMAL_MAP_ENABLED";
        public const string MetallicMapEnabled = "_METALLIC_MAP_ENABLED";
        public const string SmoothnessMapEnabled = "_SMOOTHNESS_MAP_ENABLED";
        public const string SpecularMapEnabled = "_SPECULAR_MAP_ENABLED";

        // Tint Color
        public const string TintAreaAll = "_TINT_AREA_ALL";
        public const string TintAreaRim = "_TINT_AREA_RIM";
        public const string TintColorEnabled = "_TINT_COLOR_ENABLED";
        public const string TintMapEnabled = "_TINT_MAP_ENABLED";
        public const string TintMap3DEnabled = "_TINT_MAP_3D_ENABLED";
        public const string GreyscaleEnabled = "_GREYSCALE_ENABLED";
        public const string GradientMapEnabled = "_GRADIENT_MAP_ENABLED";
        public const string FlowMapEnabled = "_FLOW_MAP_ENABLED";
        public const string FlowMapTargetBase = "_FLOW_MAP_TARGET_BASE";
        public const string FlowMapTargetTint = "_FLOW_MAP_TARGET_TINT";
        public const string FlowMapTargetEmission = "_FLOW_MAP_TARGET_EMISSION";
        public const string FlowMapTargetAlphaTransition = "_FLOW_MAP_TARGET_ALPHA_TRANSITION";

        // Parallax Map
        public const string ParallaxMapTargetBase = "_PARALLAX_MAP_TARGET_BASE";
        public const string ParallaxMapTargetTint = "_PARALLAX_MAP_TARGET_TINT";
        public const string ParallaxMapTargetEmission = "_PARALLAX_MAP_TARGET_EMISSION";
        public const string ParallaxMapMode2D = "_PARALLAX_MAP_MODE_2D";
        public const string ParallaxMapMode2DArray = "_PARALLAX_MAP_MODE_2D_ARRAY";
        public const string ParallaxMapMode3D = "_PARALLAX_MAP_MODE_3D";

        // Alpha Transition
        public const string FadeTransitionEnabled = "_FADE_TRANSITION_ENABLED";
        public const string DissolveTransitionEnabled = "_DISSOLVE_TRANSITION_ENABLED";
        public const string AlphaTransitionMapMode2D = "_ALPHA_TRANSITION_MAP_MODE_2D";
        public const string AlphaTransitionMapMode2DArray = "_ALPHA_TRANSITION_MAP_MODE_2D_ARRAY";
        public const string AlphaTransitionMapMode3D = "_ALPHA_TRANSITION_MAP_MODE_3D";
        public const string AlphaTransitionBlendSecondTexAverage = "_ALPHA_TRANSITION_BLEND_SECOND_TEX_AVERAGE";
        public const string AlphaTransitionBlendSecondTexMultiply = "_ALPHA_TRANSITION_BLEND_SECOND_TEX_MULTIPLY";

        // Emission
        public const string EmissionAreaAll = "_EMISSION_AREA_ALL";
        public const string EmissionAreaMap = "_EMISSION_AREA_MAP";
        public const string EmissionMapMode2D = "_EMISSION_MAP_MODE_2D";
        public const string EmissionMapMode2DArray = "_EMISSION_MAP_MODE_2D_ARRAY";
        public const string EmissionMapMode3D = "_EMISSION_MAP_MODE_3D";
        public const string EmissionAreaAlpha = "_EMISSION_AREA_ALPHA";
        public const string EmissionColorColor = "_EMISSION_COLOR_COLOR";
        public const string EmissionColorBaseColor = "_EMISSION_COLOR_BASECOLOR";
        public const string EmissionColorMap = "_EMISSION_COLOR_MAP";

        // Transparency
        public const string TransparencyByRim = "_TRANSPARENCY_BY_RIM";
        public const string TransparencyByLuminance = "_TRANSPARENCY_BY_LUMINANCE";
        public const string SoftParticlesEnabled = "_SOFT_PARTICLES_ENABLED";
        public const string DepthFadeEnabled = "_DEPTH_FADE_ENABLED";

        // Vertex Deformation
        public const string VertexDeformationEnabled = "_VERTEX_DEFORMATION_ENABLED";

        // Shadow Caster
        public const string ShadowCasterAlphaTestEnable = "_SHADOW_CASTER_ALPHA_TEST_ENABLED";

        public static string GetShaderKeyword(this NovaBaseMapMode baseMapMode)
        {
            switch (baseMapMode)
            {
                case NovaBaseMapMode.SingleTexture:
                    return BaseMapMode2D;
                case NovaBaseMapMode.FlipBook:
                    return BaseMapMode2DArray;
                case NovaBaseMapMode.FlipBookBlending:
                    return BaseMapMode3D;
                default:
                    throw new ArgumentOutOfRangeException(nameof(baseMapMode), baseMapMode, null);
            }
        }

        public static string GetShaderKeyword(this NovaAlphaTransitionMapMode alphaTransitionMapMode)
        {
            switch (alphaTransitionMapMode)
            {
                case NovaAlphaTransitionMapMode.SingleTexture:
                    return AlphaTransitionMapMode2D;
                case NovaAlphaTransitionMapMode.FlipBook:
                    return AlphaTransitionMapMode2DArray;
                case NovaAlphaTransitionMapMode.FlipBookBlending:
                    return AlphaTransitionMapMode3D;
                default:
                    throw new ArgumentOutOfRangeException(nameof(alphaTransitionMapMode), alphaTransitionMapMode, null);
            }
        }

        public static string GetShaderKeyword(this NovaEmissionMapMode emissionMapMode)
        {
            switch (emissionMapMode)
            {
                case NovaEmissionMapMode.SingleTexture:
                    return EmissionMapMode2D;
                case NovaEmissionMapMode.FlipBook:
                    return EmissionMapMode2DArray;
                case NovaEmissionMapMode.FlipBookBlending:
                    return EmissionMapMode3D;
                default:
                    throw new ArgumentOutOfRangeException(nameof(emissionMapMode), emissionMapMode, null);
            }
        }

        public static string GetShaderKeyword(this NovaEmissionAreaType emissionAreaType)
        {
            switch (emissionAreaType)
            {
                case NovaEmissionAreaType.None:
                    return string.Empty;
                case NovaEmissionAreaType.All:
                    return EmissionAreaAll;
                case NovaEmissionAreaType.ByTexture:
                    return EmissionAreaMap;
                case NovaEmissionAreaType.Edge:
                    return EmissionAreaAlpha;
                default:
                    throw new ArgumentOutOfRangeException(nameof(emissionAreaType), emissionAreaType, null);
            }
        }

        public static string GetShaderKeyword(this NovaTintAreaMode tintAreaMode)
        {
            switch (tintAreaMode)
            {
                case NovaTintAreaMode.None:
                    return string.Empty;
                case NovaTintAreaMode.All:
                    return TintAreaAll;
                case NovaTintAreaMode.Rim:
                    return TintAreaRim;
                default:
                    throw new ArgumentOutOfRangeException(nameof(tintAreaMode), tintAreaMode, null);
            }
        }

        public static string GetShaderKeyword(this NovaTintColorMode tintColorMode)
        {
            switch (tintColorMode)
            {
                case NovaTintColorMode.SingleColor:
                    return TintColorEnabled;
                case NovaTintColorMode.Texture2D:
                    return TintMapEnabled;
                case NovaTintColorMode.Texture3D:
                    return TintMap3DEnabled;
                default:
                    throw new ArgumentOutOfRangeException(nameof(tintColorMode), tintColorMode, null);
            }
        }

        public static string GetShaderKeyword(this NovaEmissionColorType emissionColorType)
        {
            switch (emissionColorType)
            {
                case NovaEmissionColorType.Color:
                    return EmissionColorColor;
                case NovaEmissionColorType.BaseColor:
                    return EmissionColorBaseColor;
                case NovaEmissionColorType.GradientMap:
                    return EmissionColorMap;
                default:
                    throw new ArgumentOutOfRangeException(nameof(emissionColorType), emissionColorType, null);
            }
        }

        public static string GetShaderKeyword(this NovaColorCorrectionMode colorCorrectionMode)
        {
            switch (colorCorrectionMode)
            {
                case NovaColorCorrectionMode.None:
                    return string.Empty;
                case NovaColorCorrectionMode.Greyscale:
                    return GreyscaleEnabled;
                case NovaColorCorrectionMode.GradientMap:
                    return GradientMapEnabled;
                default:
                    throw new ArgumentOutOfRangeException(nameof(colorCorrectionMode), colorCorrectionMode, null);
            }
        }

        public static string GetShaderKeyword(this NovaParallaxMapMode parallaxMapMode)
        {
            switch (parallaxMapMode)
            {
                case NovaParallaxMapMode.SingleTexture:
                    return ParallaxMapMode2D;
                case NovaParallaxMapMode.FlipBook:
                    return ParallaxMapMode2DArray;
                case NovaParallaxMapMode.FlipBookBlending:
                    return ParallaxMapMode3D;
                default:
                    throw new ArgumentOutOfRangeException(nameof(parallaxMapMode), parallaxMapMode, null);
            }
        }
    }
}
#endif