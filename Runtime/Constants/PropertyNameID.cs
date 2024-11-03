// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader
// @Enum      : PropertyNameID
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader
{
    using UnityEngine;

    /// <summary>
    /// Property Name ID
    /// </summary>
    public class PropertyNameID
    {
        #region Render Settings

        /// <summary>Render Type</summary>
        public static readonly int RenderType = Shader.PropertyToID(PropertyName.RenderType);

        /// <summary>Alpha Cutoff</summary>
        public static readonly int Cutoff = Shader.PropertyToID(PropertyName.Cutoff);

        /// <summary>Transparent Blend Mode</summary>
        public static readonly int TransparentBlendMode = Shader.PropertyToID(PropertyName.TransparentBlendMode);

        /// <summary>Cull</summary>
        public static readonly int Cull = Shader.PropertyToID(PropertyName.Cull);

        /// <summary>Queue Offset</summary>
        public static readonly int QueueOffset = Shader.PropertyToID(PropertyName.QueueOffset);

        /// <summary>Vertex Alpha Mode</summary>
        public static readonly int VertexAlphaMode = Shader.PropertyToID(PropertyName.VertexAlphaMode);

        /// <summary>Blend Src</summary>
        public static readonly int BlendSrc = Shader.PropertyToID(PropertyName.BlendSrc);

        /// <summary>Blend Dst</summary>
        public static readonly int BlendDst = Shader.PropertyToID(PropertyName.BlendDst);

        /// <summary>ZWrite</summary>
        public static readonly int ZWrite = Shader.PropertyToID(PropertyName.ZWrite);

        /// <summary>ZWrite Override</summary>
        public static readonly int ZWriteOverride = Shader.PropertyToID(PropertyName.ZWriteOverride);

        /// <summary>ZTest</summary>
        public static readonly int ZTest = Shader.PropertyToID(PropertyName.ZTest);

        /// <summary>Lit Workflow Mode</summary>
        public static readonly int LitWorkflowMode = Shader.PropertyToID(PropertyName.LitWorkflowMode);

        /// <summary>Lit Receive Shadows</summary>
        public static readonly int LitReceiveShadows = Shader.PropertyToID(PropertyName.LitReceiveShadows);

        /// <summary>Specular Highlights</summary>
        public static readonly int SpecularHighlights = Shader.PropertyToID(PropertyName.SpecularHighlights);

        /// <summary>Environment Reflections</summary>
        public static readonly int EnvironmentReflections = Shader.PropertyToID(PropertyName.EnvironmentReflections);

        #endregion

        #region Surface Maps

        /// <summary>Normal Map 2D</summary>
        public static readonly int NormalMap = Shader.PropertyToID(PropertyName.NormalMap);

        /// <summary>Normal Map 2D Array</summary>
        public static readonly int NormalMap2DArray = Shader.PropertyToID(PropertyName.NormalMap2DArray);

        /// <summary>Normal Map 3D</summary>
        public static readonly int NormalMap3D = Shader.PropertyToID(PropertyName.NormalMap3D);

        /// <summary>Normal Map Bump Scale</summary>
        public static readonly int NormalMapBumpScale = Shader.PropertyToID(PropertyName.NormalMapBumpScale);

        /// <summary>Specular Map 2D</summary>
        public static readonly int SpecularMap = Shader.PropertyToID(PropertyName.SpecularMap);

        /// <summary>Specular Map 2D Array</summary>
        public static readonly int SpecularMap2DArray = Shader.PropertyToID(PropertyName.SpecularMap2DArray);

        /// <summary>Specular Map 3D</summary>
        public static readonly int SpecularMap3D = Shader.PropertyToID(PropertyName.SpecularMap3D);

        /// <summary>Specular Color</summary>
        public static readonly int SpecularColor = Shader.PropertyToID(PropertyName.SpecularColor);

        /// <summary>Specular Map Channels X</summary>
        public static readonly int SpecularMapChannelsX = Shader.PropertyToID(PropertyName.SpecularMapChannelsX);

        /// <summary>Metallic Map 2D</summary>
        public static readonly int MetallicMap = Shader.PropertyToID(PropertyName.MetallicMap);

        /// <summary>Metallic Map 2D Array</summary>
        public static readonly int MetallicMap2DArray = Shader.PropertyToID(PropertyName.MetallicMap2DArray);

        /// <summary>Metallic Map 3D</summary>
        public static readonly int MetallicMap3D = Shader.PropertyToID(PropertyName.MetallicMap3D);

        /// <summary>Metallic</summary>
        public static readonly int Metallic = Shader.PropertyToID(PropertyName.Metallic);

        /// <summary>Metallic Map Channels X</summary>
        public static readonly int MetallicMapChannelsX = Shader.PropertyToID(PropertyName.MetallicMapChannelsX);

        /// <summary>Smoothness Map 2D</summary>
        public static readonly int SmoothnessMap = Shader.PropertyToID(PropertyName.SmoothnessMap);

        /// <summary>Smoothness Map 2D Array</summary>
        public static readonly int SmoothnessMap2DArray = Shader.PropertyToID(PropertyName.SmoothnessMap2DArray);

        /// <summary>Smoothness Map 3D</summary>
        public static readonly int SmoothnessMap3D = Shader.PropertyToID(PropertyName.SmoothnessMap3D);

        /// <summary>Smoothness</summary>
        public static readonly int Smoothness = Shader.PropertyToID(PropertyName.Smoothness);

        /// <summary>Smoothness Map Channels X</summary>
        public static readonly int SmoothnessMapChannelsX = Shader.PropertyToID(PropertyName.SmoothnessMapChannelsX);

        #endregion

        #region Base Map

        /// <summary>Base Map Mode</summary>
        public static readonly int BaseMapMode = Shader.PropertyToID(PropertyName.BaseMapMode);

        /// <summary>Base Map 2D</summary>
        public static readonly int BaseMap = Shader.PropertyToID(PropertyName.BaseMap);

        /// <summary>Base Map 2D Array</summary>
        public static readonly int BaseMap2DArray = Shader.PropertyToID(PropertyName.BaseMap2DArray);

        /// <summary>Base Map 3D</summary>
        public static readonly int BaseMap3D = Shader.PropertyToID(PropertyName.BaseMap3D);

        /// <summary>Base Map Progress</summary>
        public static readonly int BaseMapProgress = Shader.PropertyToID(PropertyName.BaseMapProgress);

        /// <summary>Base Map Progress Coord</summary>
        public static readonly int BaseMapProgressCoord = Shader.PropertyToID(PropertyName.BaseMapProgressCoord);

        /// <summary>Base Map Slice Count</summary>
        public static readonly int BaseMapSliceCount = Shader.PropertyToID(PropertyName.BaseMapSliceCount);

        /// <summary>Base Map Offset X Coord</summary>
        public static readonly int BaseMapOffsetXCoord = Shader.PropertyToID(PropertyName.BaseMapOffsetXCoord);

        /// <summary>Base Map Offset Y Coord</summary>
        public static readonly int BaseMapOffsetYCoord = Shader.PropertyToID(PropertyName.BaseMapOffsetYCoord);

        /// <summary>Base Map Channels X</summary>
        public static readonly int BaseMapChannelsX = Shader.PropertyToID(PropertyName.BaseMapChannelsX);

        /// <summary>Base Map Channels Y</summary>
        public static readonly int BaseMapChannelsY = Shader.PropertyToID(PropertyName.BaseMapChannelsY);

        /// <summary>Base Map Rotation</summary>
        public static readonly int BaseMapRotation = Shader.PropertyToID(PropertyName.BaseMapRotation);

        /// <summary>Base Map Rotation Coord</summary>
        public static readonly int BaseMapRotationCoord = Shader.PropertyToID(PropertyName.BaseMapRotationCoord);

        /// <summary>Base Map Rotation Offsets</summary>
        public static readonly int BaseMapRotationOffsets = Shader.PropertyToID(PropertyName.BaseMapRotationOffsets);

        /// <summary>Base Map Mirror Sampling</summary>
        public static readonly int BaseMapMirrorSampling = Shader.PropertyToID(PropertyName.BaseMapMirrorSampling);

        #endregion

        #region Tint Color

        /// <summary>Tint Area Mode</summary>
        public static readonly int TintAreaMode = Shader.PropertyToID(PropertyName.TintAreaMode);

        /// <summary>Tint Color Mode</summary>
        public static readonly int TintColorMode = Shader.PropertyToID(PropertyName.TintColorMode);

        /// <summary>Tint Color</summary>
        public static readonly int TintColor = Shader.PropertyToID(PropertyName.TintColor);

        /// <summary>Tint Map 2D</summary>
        public static readonly int TintMap = Shader.PropertyToID(PropertyName.TintMap);

        /// <summary>Tint Map 3D</summary>
        public static readonly int TintMap3D = Shader.PropertyToID(PropertyName.TintMap3D);

        /// <summary>Tint Map 3D Progress</summary>
        public static readonly int TintMap3DProgress = Shader.PropertyToID(PropertyName.TintMap3DProgress);

        /// <summary>Tint Map 3D Progress Coord</summary>
        public static readonly int TintMap3DProgressCoord = Shader.PropertyToID(PropertyName.TintMap3DProgressCoord);

        /// <summary>Tint Map Slice Count</summary>
        public static readonly int TintMapSliceCount = Shader.PropertyToID(PropertyName.TintMapSliceCount);

        /// <summary>Tint Map Offset X Coord</summary>
        public static readonly int TintMapOffsetXCoord = Shader.PropertyToID(PropertyName.TintMapOffsetXCoord);

        /// <summary>Tint Map Offset Y Coord</summary>
        public static readonly int TintMapOffsetYCoord = Shader.PropertyToID(PropertyName.TintMapOffsetYCoord);

        /// <summary>Tint Blend Rate</summary>
        public static readonly int TintBlendRate = Shader.PropertyToID(PropertyName.TintBlendRate);

        /// <summary>Tint Blend Rate Coord</summary>
        public static readonly int TintBlendRateCoord = Shader.PropertyToID(PropertyName.TintBlendRateCoord);

        /// <summary>Tint Rim Progress</summary>
        public static readonly int TintRimProgress = Shader.PropertyToID(PropertyName.TintRimProgress);

        /// <summary>Tint Rim Progress Coord</summary>
        public static readonly int TintRimProgressCoord = Shader.PropertyToID(PropertyName.TintRimProgressCoord);

        /// <summary>Tint Rim Sharpness</summary>
        public static readonly int TintRimSharpness = Shader.PropertyToID(PropertyName.TintRimSharpness);

        /// <summary>Tint Rim Sharpness Coord</summary>
        public static readonly int TintRimSharpnessCoord = Shader.PropertyToID(PropertyName.TintRimSharpnessCoord);

        /// <summary>Inverse Tint Rim</summary>
        public static readonly int InverseTintRim = Shader.PropertyToID(PropertyName.InverseTintRim);

        #endregion

        #region Flow Map

        /// <summary>Flow Map</summary>
        public static readonly int FlowMap = Shader.PropertyToID(PropertyName.FlowMap);

        /// <summary>Flow Map Offset X Coord</summary>
        public static readonly int FlowMapOffsetXCoord = Shader.PropertyToID(PropertyName.FlowMapOffsetXCoord);

        /// <summary>Flow Map Offset Y Coord</summary>
        public static readonly int FlowMapOffsetYCoord = Shader.PropertyToID(PropertyName.FlowMapOffsetYCoord);

        /// <summary>Flow Map Channels X</summary>
        public static readonly int FlowMapChannelsX = Shader.PropertyToID(PropertyName.FlowMapChannelsX);

        /// <summary>Flow Map Channels Y</summary>
        public static readonly int FlowMapChannelsY = Shader.PropertyToID(PropertyName.FlowMapChannelsY);

        /// <summary>Flow Intensity</summary>
        public static readonly int FlowIntensity = Shader.PropertyToID(PropertyName.FlowIntensity);

        /// <summary>Flow Intensity Coord</summary>
        public static readonly int FlowIntensityCoord = Shader.PropertyToID(PropertyName.FlowIntensityCoord);

        /// <summary>Flow Map Target</summary>
        public static readonly int FlowMapTarget = Shader.PropertyToID(PropertyName.FlowMapTarget);

        #endregion

        #region Parallax Map

        /// <summary>Parallax Map Mode</summary>
        public static readonly int ParallaxMapMode = Shader.PropertyToID(PropertyName.ParallaxMapMode);

        /// <summary>Parallax Map 2D</summary>
        public static readonly int ParallaxMap = Shader.PropertyToID(PropertyName.ParallaxMap);

        /// <summary>Parallax Map 2D Array</summary>
        public static readonly int ParallaxMap2DArray = Shader.PropertyToID(PropertyName.ParallaxMap2DArray);

        /// <summary>Parallax Map 3D</summary>
        public static readonly int ParallaxMap3D = Shader.PropertyToID(PropertyName.ParallaxMap3D);

        /// <summary>Parallax Map Progress</summary>
        public static readonly int ParallaxMapProgress = Shader.PropertyToID(PropertyName.ParallaxMapProgress);

        /// <summary>Parallax Map Progress Coord</summary>
        public static readonly int ParallaxMapProgressCoord = Shader.PropertyToID(PropertyName.ParallaxMapProgressCoord);

        /// <summary>Parallax Map Offset X Coord</summary>
        public static readonly int ParallaxMapOffsetXCoord = Shader.PropertyToID(PropertyName.ParallaxMapOffsetXCoord);

        /// <summary>Parallax Map Offset Y Coord</summary>
        public static readonly int ParallaxMapOffsetYCoord = Shader.PropertyToID(PropertyName.ParallaxMapOffsetYCoord);

        /// <summary>Parallax Map Slice Count</summary>
        public static readonly int ParallaxMapSliceCount = Shader.PropertyToID(PropertyName.ParallaxMapSliceCount);

        /// <summary>Parallax Map Channel</summary>
        public static readonly int ParallaxMapChannel = Shader.PropertyToID(PropertyName.ParallaxMapChannel);

        /// <summary>Parallax Strength</summary>
        public static readonly int ParallaxStrength = Shader.PropertyToID(PropertyName.ParallaxStrength);

        /// <summary>Parallax Map Target</summary>
        public static readonly int ParallaxMapTarget = Shader.PropertyToID(PropertyName.ParallaxMapTarget);

        #endregion

        #region Color Correction

        /// <summary>Color Correction Mode</summary>
        public static readonly int ColorCorrectionMode = Shader.PropertyToID(PropertyName.ColorCorrectionMode);

        /// <summary>Gradient Map</summary>
        public static readonly int GradientMap = Shader.PropertyToID(PropertyName.GradientMap);

        #endregion

        #region Alpha Transition

        /// <summary>Alpha Transition Mode</summary>
        public static readonly int AlphaTransitionMode = Shader.PropertyToID(PropertyName.AlphaTransitionMode);

        /// <summary>Alpha Transition Map Mode</summary>
        public static readonly int AlphaTransitionMapMode = Shader.PropertyToID(PropertyName.AlphaTransitionMapMode);

        /// <summary>Alpha Transition Map 2D</summary>
        public static readonly int AlphaTransitionMap = Shader.PropertyToID(PropertyName.AlphaTransitionMap);

        /// <summary>Alpha Transition Map 2D Array</summary>
        public static readonly int AlphaTransitionMap2DArray = Shader.PropertyToID(PropertyName.AlphaTransitionMap2DArray);

        /// <summary>Alpha Transition Map 3D</summary>
        public static readonly int AlphaTransitionMap3D = Shader.PropertyToID(PropertyName.AlphaTransitionMap3D);

        /// <summary>Alpha Transition Map Progress</summary>
        public static readonly int AlphaTransitionMapProgress = Shader.PropertyToID(PropertyName.AlphaTransitionMapProgress);

        /// <summary>Alpha Transition Map Progress Coord</summary>
        public static readonly int AlphaTransitionMapProgressCoord = Shader.PropertyToID(PropertyName.AlphaTransitionMapProgressCoord);

        /// <summary>Alpha Transition Map Offset X Coord</summary>
        public static readonly int AlphaTransitionMapOffsetXCoord = Shader.PropertyToID(PropertyName.AlphaTransitionMapOffsetXCoord);

        /// <summary>Alpha Transition Map Offset Y Coord</summary>
        public static readonly int AlphaTransitionMapOffsetYCoord = Shader.PropertyToID(PropertyName.AlphaTransitionMapOffsetYCoord);

        /// <summary>Alpha Transition Map Channels X</summary>
        public static readonly int AlphaTransitionMapChannelsX = Shader.PropertyToID(PropertyName.AlphaTransitionMapChannelsX);

        /// <summary>Alpha Transition Map Slice Count</summary>
        public static readonly int AlphaTransitionMapSliceCount = Shader.PropertyToID(PropertyName.AlphaTransitionMapSliceCount);

        /// <summary>Alpha Transition Progress</summary>
        public static readonly int AlphaTransitionProgress = Shader.PropertyToID(PropertyName.AlphaTransitionProgress);

        /// <summary>Alpha Transition Progress Coord</summary>
        public static readonly int AlphaTransitionProgressCoord = Shader.PropertyToID(PropertyName.AlphaTransitionProgressCoord);

        /// <summary>Dissolve Sharpness</summary>
        public static readonly int DissolveSharpness = Shader.PropertyToID(PropertyName.DissolveSharpness);

        /// <summary>Alpha Transition Second Texture Blend Mode</summary>
        public static readonly int AlphaTransitionSecondTextureBlendMode = Shader.PropertyToID(PropertyName.AlphaTransitionSecondTextureBlendMode);

        /// <summary>Alpha Transition Second Texture Map 2D</summary>
        public static readonly int AlphaTransitionMapSecondTexture = Shader.PropertyToID(PropertyName.AlphaTransitionMapSecondTexture);

        /// <summary>Alpha Transition Second Texture Map 2D Array</summary>
        public static readonly int AlphaTransitionMapSecondTexture2DArray = Shader.PropertyToID(PropertyName.AlphaTransitionMapSecondTexture2DArray);

        /// <summary>Alpha Transition Second Texture Map 3D</summary>
        public static readonly int AlphaTransitionMapSecondTexture3D = Shader.PropertyToID(PropertyName.AlphaTransitionMapSecondTexture3D);

        /// <summary>Alpha Transition Map Second Texture Progress</summary>
        public static readonly int AlphaTransitionMapSecondTextureProgress = Shader.PropertyToID(PropertyName.AlphaTransitionMapSecondTextureProgress);

        /// <summary>Alpha Transition Map Second Texture Progress Coord</summary>
        public static readonly int AlphaTransitionMapSecondTextureProgressCoord = Shader.PropertyToID(PropertyName.AlphaTransitionMapSecondTextureProgressCoord);

        /// <summary>Alpha Transition Second Texture Map Offset X Coord</summary>
        public static readonly int AlphaTransitionMapSecondTextureOffsetXCoord = Shader.PropertyToID(PropertyName.AlphaTransitionMapSecondTextureOffsetXCoord);

        /// <summary>Alpha Transition Second Texture Map Offset Y Coord</summary>
        public static readonly int AlphaTransitionMapSecondTextureOffsetYCoord = Shader.PropertyToID(PropertyName.AlphaTransitionMapSecondTextureOffsetYCoord);

        /// <summary>Alpha Transition Second Texture Map Channels X</summary>
        public static readonly int AlphaTransitionMapSecondTextureChannelsX = Shader.PropertyToID(PropertyName.AlphaTransitionMapSecondTextureChannelsX);

        /// <summary>Alpha Transition Map Second Texture Slice Count</summary>
        public static readonly int AlphaTransitionMapSecondTextureSliceCount = Shader.PropertyToID(PropertyName.AlphaTransitionMapSecondTextureSliceCount);

        /// <summary>Alpha Transition Second Texture Progress</summary>
        public static readonly int AlphaTransitionProgressSecondTexture = Shader.PropertyToID(PropertyName.AlphaTransitionProgressSecondTexture);

        /// <summary>Alpha Transition Second Texture Progress Coord</summary>
        public static readonly int AlphaTransitionProgressCoordSecondTexture = Shader.PropertyToID(PropertyName.AlphaTransitionProgressCoordSecondTexture);

        /// <summary>Second Texture Dissolve Sharpness</summary>
        public static readonly int DissolveSharpnessSecondTexture = Shader.PropertyToID(PropertyName.DissolveSharpnessSecondTexture);

        #endregion

        #region Emission

        /// <summary>Emission Area Type</summary>
        public static readonly int EmissionAreaType = Shader.PropertyToID(PropertyName.EmissionAreaType);

        /// <summary>Emission Map Mode</summary>
        public static readonly int EmissionMapMode = Shader.PropertyToID(PropertyName.EmissionMapMode);

        /// <summary>Emission Map 2D</summary>
        public static readonly int EmissionMap = Shader.PropertyToID(PropertyName.EmissionMap);

        /// <summary>Emission Map 2D Array</summary>
        public static readonly int EmissionMap2DArray = Shader.PropertyToID(PropertyName.EmissionMap2DArray);

        /// <summary>Emission Map 3D</summary>
        public static readonly int EmissionMap3D = Shader.PropertyToID(PropertyName.EmissionMap3D);

        /// <summary>Emission Map Progress</summary>
        public static readonly int EmissionMapProgress = Shader.PropertyToID(PropertyName.EmissionMapProgress);

        /// <summary>Emission Map Progress Coord</summary>
        public static readonly int EmissionMapProgressCoord = Shader.PropertyToID(PropertyName.EmissionMapProgressCoord);

        /// <summary>Emission Map Offset X Coord</summary>
        public static readonly int EmissionMapOffsetXCoord = Shader.PropertyToID(PropertyName.EmissionMapOffsetXCoord);

        /// <summary>Emission Map Offset Y Coord</summary>
        public static readonly int EmissionMapOffsetYCoord = Shader.PropertyToID(PropertyName.EmissionMapOffsetYCoord);

        /// <summary>Emission Map Channels X</summary>
        public static readonly int EmissionMapChannelsX = Shader.PropertyToID(PropertyName.EmissionMapChannelsX);

        /// <summary>Alpha Transition Map Slice Count</summary>
        public static readonly int EmissionMapSliceCount = Shader.PropertyToID(PropertyName.EmissionMapSliceCount);

        /// <summary>Emission Color Type</summary>
        public static readonly int EmissionColorType = Shader.PropertyToID(PropertyName.EmissionColorType);

        /// <summary>Emission Color</summary>
        public static readonly int EmissionColor = Shader.PropertyToID(PropertyName.EmissionColor);

        /// <summary>Emission Color Ramp</summary>
        public static readonly int EmissionColorRamp = Shader.PropertyToID(PropertyName.EmissionColorRamp);

        /// <summary>Emission Intensity</summary>
        public static readonly int EmissionIntensity = Shader.PropertyToID(PropertyName.EmissionIntensity);

        /// <summary>Emission Intensity Coord</summary>
        public static readonly int EmissionIntensityCoord = Shader.PropertyToID(PropertyName.EmissionIntensityCoord);

        /// <summary>Keep Edge Transparency</summary>
        public static readonly int KeepEdgeTransparency = Shader.PropertyToID(PropertyName.KeepEdgeTransparency);

        #endregion

        #region Transparency

        /// <summary>Rim Transparency Enabled</summary>
        public static readonly int RimTransparencyEnabled = Shader.PropertyToID(PropertyName.RimTransparencyEnabled);

        /// <summary>Rim Transparency Progress</summary>
        public static readonly int RimTransparencyProgress = Shader.PropertyToID(PropertyName.RimTransparencyProgress);

        /// <summary>Rim Transparency Progress Coord</summary>
        public static readonly int RimTransparencyProgressCoord = Shader.PropertyToID(PropertyName.RimTransparencyProgressCoord);

        /// <summary>Rim Transparency Sharpness</summary>
        public static readonly int RimTransparencySharpness = Shader.PropertyToID(PropertyName.RimTransparencySharpness);

        /// <summary>Rim Transparency Sharpness Coord</summary>
        public static readonly int RimTransparencySharpnessCoord = Shader.PropertyToID(PropertyName.RimTransparencySharpnessCoord);

        /// <summary>Inverse Rim Transparency</summary>
        public static readonly int InverseRimTransparency = Shader.PropertyToID(PropertyName.InverseRimTransparency);

        /// <summary>Luminance Transparency Enabled</summary>
        public static readonly int LuminanceTransparencyEnabled = Shader.PropertyToID(PropertyName.LuminanceTransparencyEnabled);

        /// <summary>Luminance Transparency Progress</summary>
        public static readonly int LuminanceTransparencyProgress = Shader.PropertyToID(PropertyName.LuminanceTransparencyProgress);

        /// <summary>Luminance Transparency Progress Coord</summary>
        public static readonly int LuminanceTransparencyProgressCoord = Shader.PropertyToID(PropertyName.LuminanceTransparencyProgressCoord);

        /// <summary>Luminance Transparency Sharpness</summary>
        public static readonly int LuminanceTransparencySharpness = Shader.PropertyToID(PropertyName.LuminanceTransparencySharpness);

        /// <summary>Luminance Transparency Sharpness Coord</summary>
        public static readonly int LuminanceTransparencySharpnessCoord = Shader.PropertyToID(PropertyName.LuminanceTransparencySharpnessCoord);

        /// <summary>Inverse Luminance Transparency</summary>
        public static readonly int InverseLuminanceTransparency = Shader.PropertyToID(PropertyName.InverseLuminanceTransparency);

        /// <summary>Soft Particles Enabled</summary>
        public static readonly int SoftParticlesEnabled = Shader.PropertyToID(PropertyName.SoftParticlesEnabled);

        /// <summary>Soft Particles Intensity</summary>
        public static readonly int SoftParticlesIntensity = Shader.PropertyToID(PropertyName.SoftParticlesIntensity);

        /// <summary>Depth Fade Enabled</summary>
        public static readonly int DepthFadeEnabled = Shader.PropertyToID(PropertyName.DepthFadeEnabled);

        /// <summary>Depth Fade Near</summary>
        public static readonly int DepthFadeNear = Shader.PropertyToID(PropertyName.DepthFadeNear);

        /// <summary>Depth Fade Far</summary>
        public static readonly int DepthFadeFar = Shader.PropertyToID(PropertyName.DepthFadeFar);

        /// <summary>Depth Fade Width</summary>
        public static readonly int DepthFadeWidth = Shader.PropertyToID(PropertyName.DepthFadeWidth);

        #endregion

        #region Distortion

        /// <summary>Distortion Intensity</summary>
        public static readonly int DistortionIntensity = Shader.PropertyToID(PropertyName.DistortionIntensity);

        /// <summary>Distortion Intensity Coord</summary>
        public static readonly int DistortionIntensityCoord = Shader.PropertyToID(PropertyName.DistortionIntensityCoord);

        #endregion

        #region Vertex Deformation

        /// <summary>Vertex Deformation Enabled</summary>
        public static readonly int VertexDeformationEnabled = Shader.PropertyToID(PropertyName.VertexDeformationEnabled);

        /// <summary>Vertex Deformation Map</summary>
        public static readonly int VertexDeformationMap = Shader.PropertyToID(PropertyName.VertexDeformationMap);

        /// <summary>Vertex Deformation Map Offset X Coord</summary>
        public static readonly int VertexDeformationMapOffsetXCoord = Shader.PropertyToID(PropertyName.VertexDeformationMapOffsetXCoord);

        /// <summary>Vertex Deformation Map Offset Y Coord</summary>
        public static readonly int VertexDeformationMapOffsetYCoord = Shader.PropertyToID(PropertyName.VertexDeformationMapOffsetYCoord);

        /// <summary>Vertex Deformation Map Channel</summary>
        public static readonly int VertexDeformationMapChannel = Shader.PropertyToID(PropertyName.VertexDeformationMapChannel);

        /// <summary>Vertex Deformation Intensity</summary>
        public static readonly int VertexDeformationIntensity = Shader.PropertyToID(PropertyName.VertexDeformationIntensity);

        /// <summary>Vertex Deformation Intensity Coord</summary>
        public static readonly int VertexDeformationIntensityCoord = Shader.PropertyToID(PropertyName.VertexDeformationIntensityCoord);

        #endregion

        #region Shadow Caster

        /// <summary>Shadow Caster Enabled</summary>
        public static readonly int ShadowCasterEnabled = Shader.PropertyToID(PropertyName.ShadowCasterEnabled);

        /// <summary>Shadow Caster Vertex Deformation Enabled</summary>
        public static readonly int ShadowCasterApplyVertexDeformation = Shader.PropertyToID(PropertyName.ShadowCasterApplyVertexDeformation);

        /// <summary>Shadow Caster Alpha Test Enabled</summary>
        public static readonly int ShadowCasterAlphaTestEnabled = Shader.PropertyToID(PropertyName.ShadowCasterAlphaTestEnabled);

        /// <summary>Shadow Caster Alpha Test Cutoff</summary>
        public static readonly int ShadowCasterAlphaCutoff = Shader.PropertyToID(PropertyName.ShadowCasterAlphaCutoff);

        /// <summary>Shadow Caster Alpha Effect by Tint Color</summary>
        public static readonly int ShadowCasterAlphaAffectedByTintColor = Shader.PropertyToID(PropertyName.ShadowCasterAlphaAffectedByTintColor);

        /// <summary>Shadow Caster Alpha Effect by Flow Map</summary>
        public static readonly int ShadowCasterAlphaAffectedByFlowMap = Shader.PropertyToID(PropertyName.ShadowCasterAlphaAffectedByFlowMap);

        /// <summary>Shadow Caster Alpha Effect by Alpha Transition Map</summary>
        public static readonly int ShadowCasterAlphaAffectedByAlphaTransitionMap = Shader.PropertyToID(PropertyName.ShadowCasterAlphaAffectedByAlphaTransitionMap);

        /// <summary>Shadow Caster Alpha Effect by Transparency Luminance</summary>
        public static readonly int ShadowCasterAlphaAffectedByTransparencyLuminance = Shader.PropertyToID(PropertyName.ShadowCasterAlphaAffectedByTransparencyLuminance);

        #endregion
    }
}
