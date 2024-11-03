// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader
// @Class     : PropertyName
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader
{
    /// <summary>
    /// Property Name
    /// </summary>
    public class PropertyName
    {
        #region Render Settings

        /// <summary>Render Type</summary>
        public const string RenderType = "_RenderType";

        /// <summary>Alpha Cutoff</summary>
        public const string Cutoff = "_Cutoff";

        /// <summary>Transparent Blend Mode</summary>
        public const string TransparentBlendMode = "_TransparentBlendMode";

        /// <summary>Cull</summary>
        public const string Cull = "_Cull";

        /// <summary>Queue Offset</summary>
        public const string QueueOffset = "_QueueOffset";

        /// <summary>Vertex Alpha Mode</summary>
        public const string VertexAlphaMode = "_VertexAlphaMode";

        /// <summary>Blend Src</summary>
        public const string BlendSrc = "_BlendSrc";

        /// <summary>Blend Dst</summary>
        public const string BlendDst = "_BlendDst";

        /// <summary>ZWrite</summary>
        public const string ZWrite = "_ZWrite";

        /// <summary>ZWrite Override</summary>
        public const string ZWriteOverride = "_ZWriteOverride";

        /// <summary>ZTest</summary>
        public const string ZTest = "_ZTest";

        /// <summary>Lit Workflow Mode</summary>
        public const string LitWorkflowMode = "_LitWorkflowMode";

        /// <summary>Lit Receive Shadows</summary>
        public const string LitReceiveShadows = "_LitReceiveShadows";

        /// <summary>Specular Highlights</summary>
        public const string SpecularHighlights = "_SpecularHighlights";

        /// <summary>Environment Reflections</summary>
        public const string EnvironmentReflections = "_EnvironmentReflections";

        #endregion

        #region Surface Maps

        /// <summary>Normal Map 2D</summary>
        public const string NormalMap = "_NormalMap";

        /// <summary>Normal Map 2D Array</summary>
        public const string NormalMap2DArray = "_NormalMap2DArray";

        /// <summary>Normal Map 3D</summary>
        public const string NormalMap3D = "_NormalMap3D";

        /// <summary>Normal Map Bump Scale</summary>
        public const string NormalMapBumpScale = "_NormalMapBumpScale";

        /// <summary>Specular Map 2D</summary>
        public const string SpecularMap = "_SpecularMap";

        /// <summary>Specular Map 2D Array</summary>
        public const string SpecularMap2DArray = "_SpecularMap2DArray";

        /// <summary>Specular Map 3D</summary>
        public const string SpecularMap3D = "_SpecularMap3D";

        /// <summary>Specular Color</summary>
        public const string SpecularColor = "_SpecularColor";

        /// <summary>Specular Map Channels X</summary>
        public const string SpecularMapChannelsX = "_SpecularMapChannelsX";

        /// <summary>Metallic Map 2D</summary>
        public const string MetallicMap = "_MetallicMap";

        /// <summary>Metallic Map 2D Array</summary>
        public const string MetallicMap2DArray = "_MetallicMap2DArray";

        /// <summary>Metallic Map 3D</summary>
        public const string MetallicMap3D = "_MetallicMap3D";

        /// <summary>Metallic</summary>
        public const string Metallic = "_Metallic";

        /// <summary>Metallic Map Channels X</summary>
        public const string MetallicMapChannelsX = "_MetallicMapChannelsX";

        /// <summary>Smoothness Map 2D</summary>
        public const string SmoothnessMap = "_SmoothnessMap";

        /// <summary>Smoothness Map 2D Array</summary>
        public const string SmoothnessMap2DArray = "_SmoothnessMap2DArray";

        /// <summary>Smoothness Map 3D</summary>
        public const string SmoothnessMap3D = "_SmoothnessMap3D";

        /// <summary>Smoothness</summary>
        public const string Smoothness = "_Smoothness";

        /// <summary>Smoothness Map Channels X</summary>
        public const string SmoothnessMapChannelsX = "_SmoothnessMapChannelsX";

        #endregion

        #region Base Map

        /// <summary>Base Map Mode</summary>
        public const string BaseMapMode = "_BaseMapMode";

        /// <summary>Base Map 2D</summary>
        public const string BaseMap = "_BaseMap";

        /// <summary>Base Map 2D Array</summary>
        public const string BaseMap2DArray = "_BaseMap2DArray";

        /// <summary>Base Map 3D</summary>
        public const string BaseMap3D = "_BaseMap3D";

        /// <summary>Base Map Progress</summary>
        public const string BaseMapProgress = "_BaseMapProgress";

        /// <summary>Base Map Progress Coord</summary>
        public const string BaseMapProgressCoord = "_BaseMapProgressCoord";

        /// <summary>Base Map Slice Count</summary>
        public const string BaseMapSliceCount = "_BaseMapSliceCount";

        /// <summary>Base Map Offset X Coord</summary>
        public const string BaseMapOffsetXCoord = "_BaseMapOffsetXCoord";

        /// <summary>Base Map Offset Y Coord</summary>
        public const string BaseMapOffsetYCoord = "_BaseMapOffsetYCoord";

        /// <summary>Base Map Channels X</summary>
        public const string BaseMapChannelsX = "_BaseMapChannelsX";

        /// <summary>Base Map Channels Y</summary>
        public const string BaseMapChannelsY = "_BaseMapChannelsY";

        /// <summary>Base Map Rotation</summary>
        public const string BaseMapRotation = "_BaseMapRotation";

        /// <summary>Base Map Rotation Coord</summary>
        public const string BaseMapRotationCoord = "_BaseMapRotationCoord";

        /// <summary>Base Map Rotation Offsets</summary>
        public const string BaseMapRotationOffsets = "_BaseMapRotationOffsets";

        /// <summary>Base Map Mirror Sampling</summary>
        public const string BaseMapMirrorSampling = "_BaseMapMirrorSampling";

        #endregion

        #region Tint Color

        /// <summary>Tint Area Mode</summary>
        public const string TintAreaMode = "_TintAreaMode";

        /// <summary>Tint Color Mode</summary>
        public const string TintColorMode = "_TintColorMode";

        /// <summary>Tint Color</summary>
        public const string TintColor = "_TintColor";

        /// <summary>Tint Map 2D</summary>
        public const string TintMap = "_TintMap";

        /// <summary>Tint Map 3D</summary>
        public const string TintMap3D = "_TintMap3D";

        /// <summary>Tint Map 3D Progress</summary>
        public const string TintMap3DProgress = "_TintMap3DProgress";

        /// <summary>Tint Map 3D Progress Coord</summary>
        public const string TintMap3DProgressCoord = "_TintMap3DProgressCoord";

        /// <summary>Tint Map Slice Count</summary>
        public const string TintMapSliceCount = "_TintMapSliceCount";

        /// <summary>Tint Map Offset X Coord</summary>
        public const string TintMapOffsetXCoord = "_TintMapOffsetXCoord";

        /// <summary>Tint Map Offset Y Coord</summary>
        public const string TintMapOffsetYCoord = "_TintMapOffsetYCoord";

        /// <summary>Tint Blend Rate</summary>
        public const string TintBlendRate = "_TintBlendRate";
        //public const string TintMapBlendRate = "_TintBlendRate";

        /// <summary>Tint Blend Rate Coord</summary>
        public const string TintBlendRateCoord = "_TintBlendRateCoord";
        //public const string TintMapBlendRateCoord = "_TintBlendRateCoord";

        /// <summary>Tint Rim Progress</summary>
        public const string TintRimProgress = "_TintRimProgress";

        /// <summary>Tint Rim Progress Coord</summary>
        public const string TintRimProgressCoord = "_TintRimProgressCoord";

        /// <summary>Tint Rim Sharpness</summary>
        public const string TintRimSharpness = "_TintRimSharpness";

        /// <summary>Tint Rim Sharpness Coord</summary>
        public const string TintRimSharpnessCoord = "_TintRimSharpnessCoord";

        /// <summary>Inverse Tint Rim</summary>
        public const string InverseTintRim = "_InverseTintRim";

        #endregion

        #region Flow Map

        /// <summary>Flow Map</summary>
        public const string FlowMap = "_FlowMap";

        /// <summary>Flow Map Offset X Coord</summary>
        public const string FlowMapOffsetXCoord = "_FlowMapOffsetXCoord";

        /// <summary>Flow Map Offset Y Coord</summary>
        public const string FlowMapOffsetYCoord = "_FlowMapOffsetYCoord";

        /// <summary>Flow Map Channels X</summary>
        public const string FlowMapChannelsX = "_FlowMapChannelsX";

        /// <summary>Flow Map Channels Y</summary>
        public const string FlowMapChannelsY = "_FlowMapChannelsY";

        /// <summary>Flow Intensity</summary>
        public const string FlowIntensity = "_FlowIntensity";

        /// <summary>Flow Intensity Coord</summary>
        public const string FlowIntensityCoord = "_FlowIntensityCoord";

        /// <summary>Flow Map Target</summary>
        public const string FlowMapTarget = "_FlowMapTarget";

        #endregion

        #region Parallax Map

        /// <summary>Parallax Map Mode</summary>
        public const string ParallaxMapMode = "_ParallaxMapMode";

        /// <summary>Parallax Map 2D</summary>
        public const string ParallaxMap = "_ParallaxMap";

        /// <summary>Parallax Map 2D Array</summary>
        public const string ParallaxMap2DArray = "_ParallaxMap2DArray";

        /// <summary>Parallax Map 3D</summary>
        public const string ParallaxMap3D = "_ParallaxMap3D";

        /// <summary>Parallax Map Progress</summary>
        public const string ParallaxMapProgress = "_ParallaxMapProgress";

        /// <summary>Parallax Map Progress Coord</summary>
        public const string ParallaxMapProgressCoord = "_ParallaxMapProgressCoord";

        /// <summary>Parallax Map Offset X Coord</summary>
        public const string ParallaxMapOffsetXCoord = "_ParallaxMapOffsetXCoord";

        /// <summary>Parallax Map Offset Y Coord</summary>
        public const string ParallaxMapOffsetYCoord = "_ParallaxMapOffsetYCoord";

        /// <summary>Parallax Map Slice Count</summary>
        public const string ParallaxMapSliceCount = "_ParallaxMapSliceCount";

        /// <summary>Parallax Map Channel</summary>
        public const string ParallaxMapChannel = "_ParallaxMapChannel";

        /// <summary>Parallax Strength</summary>
        public const string ParallaxStrength = "_ParallaxStrength";

        /// <summary>Parallax Map Target</summary>
        public const string ParallaxMapTarget = "_ParallaxMapTarget";

        #endregion

        #region Color Correction

        /// <summary>Color Correction Mode</summary>
        public const string ColorCorrectionMode = "_ColorCorrectionMode";

        /// <summary>Gradient Map</summary>
        public const string GradientMap = "_GradientMap";

        #endregion

        #region Alpha Transition

        /// <summary>Alpha Transition Mode</summary>
        public const string AlphaTransitionMode = "_AlphaTransitionMode";

        /// <summary>Alpha Transition Map Mode</summary>
        public const string AlphaTransitionMapMode = "_AlphaTransitionMapMode";

        /// <summary>Alpha Transition Map 2D</summary>
        public const string AlphaTransitionMap = "_AlphaTransitionMap";

        /// <summary>Alpha Transition Map 2D Array</summary>
        public const string AlphaTransitionMap2DArray = "_AlphaTransitionMap2DArray";

        /// <summary>Alpha Transition Map 3D</summary>
        public const string AlphaTransitionMap3D = "_AlphaTransitionMap3D";

        /// <summary>Alpha Transition Map Progress</summary>
        public const string AlphaTransitionMapProgress = "_AlphaTransitionMapProgress";

        /// <summary>Alpha Transition Map Progress Coord</summary>
        public const string AlphaTransitionMapProgressCoord = "_AlphaTransitionMapProgressCoord";

        /// <summary>Alpha Transition Map Offset X Coord</summary>
        public const string AlphaTransitionMapOffsetXCoord = "_AlphaTransitionMapOffsetXCoord";

        /// <summary>Alpha Transition Map Offset Y Coord</summary>
        public const string AlphaTransitionMapOffsetYCoord = "_AlphaTransitionMapOffsetYCoord";

        /// <summary>Alpha Transition Map Channels X</summary>
        public const string AlphaTransitionMapChannelsX = "_AlphaTransitionMapChannelsX";

        /// <summary>Alpha Transition Map Slice Count</summary>
        public const string AlphaTransitionMapSliceCount = "_AlphaTransitionMapSliceCount";

        /// <summary>Alpha Transition Progress</summary>
        public const string AlphaTransitionProgress = "_AlphaTransitionProgress";

        /// <summary>Alpha Transition Progress Coord</summary>
        public const string AlphaTransitionProgressCoord = "_AlphaTransitionProgressCoord";

        /// <summary>Dissolve Sharpness</summary>
        public const string DissolveSharpness = "_DissolveSharpness";

        /// <summary>Alpha Transition Second Texture Blend Mode</summary>
        public const string AlphaTransitionSecondTextureBlendMode = "_AlphaTransitionSecondTextureBlendMode";

        /// <summary>Alpha Transition Second Texture Map 2D</summary>
        public const string AlphaTransitionMapSecondTexture = "_AlphaTransitionMapSecondTexture";

        /// <summary>Alpha Transition Second Texture Map 2D Array</summary>
        public const string AlphaTransitionMapSecondTexture2DArray = "_AlphaTransitionMapSecondTexture2DArray";

        /// <summary>Alpha Transition Second Texture Map 3D</summary>
        public const string AlphaTransitionMapSecondTexture3D = "_AlphaTransitionMapSecondTexture3D";

        /// <summary>Alpha Transition Map Second Texture Progress</summary>
        public const string AlphaTransitionMapSecondTextureProgress = "_AlphaTransitionMapSecondTextureProgress";

        /// <summary>Alpha Transition Map Second Texture Progress Coord</summary>
        public const string AlphaTransitionMapSecondTextureProgressCoord = "_AlphaTransitionMapSecondTextureProgressCoord";

        /// <summary>Alpha Transition Second Texture Map Offset X Coord</summary>
        public const string AlphaTransitionMapSecondTextureOffsetXCoord = "_AlphaTransitionMapSecondTextureOffsetXCoord";

        /// <summary>Alpha Transition Second Texture Map Offset Y Coord</summary>
        public const string AlphaTransitionMapSecondTextureOffsetYCoord = "_AlphaTransitionMapSecondTextureOffsetYCoord";

        /// <summary>Alpha Transition Second Texture Map Channels X</summary>
        public const string AlphaTransitionMapSecondTextureChannelsX = "_AlphaTransitionMapSecondTextureChannelsX";

        /// <summary>Alpha Transition Map Second Texture Slice Count</summary>
        public const string AlphaTransitionMapSecondTextureSliceCount = "_AlphaTransitionMapSecondTextureSliceCount";

        /// <summary>Alpha Transition Second Texture Progress</summary>
        public const string AlphaTransitionProgressSecondTexture = "_AlphaTransitionProgressSecondTexture";

        /// <summary>Alpha Transition Second Texture Progress Coord</summary>
        public const string AlphaTransitionProgressCoordSecondTexture = "_AlphaTransitionProgressCoordSecondTexture";

        /// <summary>Second Texture Dissolve Sharpness</summary>
        public const string DissolveSharpnessSecondTexture = "_DissolveSharpnessSecondTexture";

        #endregion

        #region Emission

        /// <summary>Emission Area Type</summary>
        public const string EmissionAreaType = "_EmissionAreaType";

        /// <summary>Emission Map Mode</summary>
        public const string EmissionMapMode = "_EmissionMapMode";

        /// <summary>Emission Map 2D</summary>
        public const string EmissionMap = "_EmissionMap";

        /// <summary>Emission Map 2D Array</summary>
        public const string EmissionMap2DArray = "_EmissionMap2DArray";

        /// <summary>Emission Map 3D</summary>
        public const string EmissionMap3D = "_EmissionMap3D";

        /// <summary>Emission Map Progress</summary>
        public const string EmissionMapProgress = "_EmissionMapProgress";

        /// <summary>Emission Map Progress Coord</summary>
        public const string EmissionMapProgressCoord = "_EmissionMapProgressCoord";

        /// <summary>Emission Map Offset X Coord</summary>
        public const string EmissionMapOffsetXCoord = "_EmissionMapOffsetXCoord";

        /// <summary>Emission Map Offset Y Coord</summary>
        public const string EmissionMapOffsetYCoord = "_EmissionMapOffsetYCoord";

        /// <summary>Emission Map Channels X</summary>
        public const string EmissionMapChannelsX = "_EmissionMapChannelsX";

        /// <summary>Alpha Transition Map Slice Count</summary>
        public const string EmissionMapSliceCount = "_EmissionMapSliceCount";

        /// <summary>Emission Color Type</summary>
        public const string EmissionColorType = "_EmissionColorType";

        /// <summary>Emission Color</summary>
        public const string EmissionColor = "_EmissionColor";

        /// <summary>Emission Color Ramp</summary>
        public const string EmissionColorRamp = "_EmissionColorRamp";

        /// <summary>Emission Intensity</summary>
        public const string EmissionIntensity = "_EmissionIntensity";

        /// <summary>Emission Intensity Coord</summary>
        public const string EmissionIntensityCoord = "_EmissionIntensityCoord";

        /// <summary>Keep Edge Transparency</summary>
        public const string KeepEdgeTransparency = "_KeepEdgeTransparency";

        #endregion

        #region Transparency

        /// <summary>Rim Transparency Enabled</summary>
        public const string RimTransparencyEnabled = "_RimTransparencyEnabled";

        /// <summary>Rim Transparency Progress</summary>
        public const string RimTransparencyProgress = "_RimTransparencyProgress";

        /// <summary>Rim Transparency Progress Coord</summary>
        public const string RimTransparencyProgressCoord = "_RimTransparencyProgressCoord";

        /// <summary>Rim Transparency Sharpness</summary>
        public const string RimTransparencySharpness = "_RimTransparencySharpness";

        /// <summary>Rim Transparency Sharpness Coord</summary>
        public const string RimTransparencySharpnessCoord = "_RimTransparencySharpnessCoord";

        /// <summary>Inverse Rim Transparency</summary>
        public const string InverseRimTransparency = "_InverseRimTransparency";

        /// <summary>Luminance Transparency Enabled</summary>
        public const string LuminanceTransparencyEnabled = "_LuminanceTransparencyEnabled";

        /// <summary>Luminance Transparency Progress</summary>
        public const string LuminanceTransparencyProgress = "_LuminanceTransparencyProgress";

        /// <summary>Luminance Transparency Progress Coord</summary>
        public const string LuminanceTransparencyProgressCoord = "_LuminanceTransparencyProgressCoord";

        /// <summary>Luminance Transparency Sharpness</summary>
        public const string LuminanceTransparencySharpness = "_LuminanceTransparencySharpness";

        /// <summary>Luminance Transparency Sharpness Coord</summary>
        public const string LuminanceTransparencySharpnessCoord = "_LuminanceTransparencySharpnessCoord";

        /// <summary>Inverse Luminance Transparency</summary>
        public const string InverseLuminanceTransparency = "_InverseLuminanceTransparency";

        /// <summary>Soft Particles Enabled</summary>
        public const string SoftParticlesEnabled = "_SoftParticlesEnabled";

        /// <summary>Soft Particles Intensity</summary>
        public const string SoftParticlesIntensity = "_SoftParticlesIntensity";

        /// <summary>Depth Fade Enabled</summary>
        public const string DepthFadeEnabled = "_DepthFadeEnabled";

        /// <summary>Depth Fade Near</summary>
        public const string DepthFadeNear = "_DepthFadeNear";

        /// <summary>Depth Fade Far</summary>
        public const string DepthFadeFar = "_DepthFadeFar";

        /// <summary>Depth Fade Width</summary>
        public const string DepthFadeWidth = "_DepthFadeWidth";

        #endregion

        #region Distortion

        /// <summary>Distortion Intensity</summary>
        public const string DistortionIntensity = "_DistortionIntensity";

        /// <summary>Distortion Intensity Coord</summary>
        public const string DistortionIntensityCoord = "_DistortionIntensityCoord";

        #endregion

        #region Vertex Deformation

        /// <summary>Vertex Deformation Enabled</summary>
        public const string VertexDeformationEnabled = "_VertexDeformationEnabled";

        /// <summary>Vertex Deformation Map</summary>
        public const string VertexDeformationMap = "_VertexDeformationMap";

        /// <summary>Vertex Deformation Map Offset X Coord</summary>
        public const string VertexDeformationMapOffsetXCoord = "_VertexDeformationMapOffsetXCoord";

        /// <summary>Vertex Deformation Map Offset Y Coord</summary>
        public const string VertexDeformationMapOffsetYCoord = "_VertexDeformationMapOffsetYCoord";

        /// <summary>Vertex Deformation Map Channel</summary>
        public const string VertexDeformationMapChannel = "_VertexDeformationMapChannel";

        /// <summary>Vertex Deformation Intensity</summary>
        public const string VertexDeformationIntensity = "_VertexDeformationIntensity";

        /// <summary>Vertex Deformation Intensity Coord</summary>
        public const string VertexDeformationIntensityCoord = "_VertexDeformationIntensityCoord";

        #endregion

        #region Shadow Caster

        /// <summary>Shadow Caster Enabled</summary>
        public const string ShadowCasterEnabled = "_ShadowCasterEnabled";

        /// <summary>Shadow Caster Vertex Deformation Enabled</summary>
        public const string ShadowCasterApplyVertexDeformation = "_ShadowCasterApplyVertexDeformation";

        /// <summary>Shadow Caster Alpha Test Enabled</summary>
        public const string ShadowCasterAlphaTestEnabled = "_ShadowCasterAlphaTestEnabled";

        /// <summary>Shadow Caster Alpha Test Cutoff</summary>
        public const string ShadowCasterAlphaCutoff = "_ShadowCasterAlphaCutoff";

        /// <summary>Shadow Caster Alpha Effect by Tint Color</summary>
        public const string ShadowCasterAlphaAffectedByTintColor = "_ShadowCasterAlphaAffectedByTintColor";

        /// <summary>Shadow Caster Alpha Effect by Flow Map</summary>
        public const string ShadowCasterAlphaAffectedByFlowMap = "_ShadowCasterAlphaAffectedByFlowMap";

        /// <summary>Shadow Caster Alpha Effect by Alpha Transition Map</summary>
        public const string ShadowCasterAlphaAffectedByAlphaTransitionMap = "_ShadowCasterAlphaAffectedByAlphaTransitionMap";

        /// <summary>Shadow Caster Alpha Effect by Transparency Luminance</summary>
        public const string ShadowCasterAlphaAffectedByTransparencyLuminance = "_ShadowCasterAlphaAffectedByTransparencyLuminance";

        #endregion
    }
}
