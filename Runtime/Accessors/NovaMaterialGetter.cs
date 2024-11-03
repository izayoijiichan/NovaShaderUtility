// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader
// @Class     : NovaMaterialGetter
// ----------------------------------------------------------------------
#if !NOVA_SHADER_2_0_OR_NEWER
#define NOVA_SHADER_2_0_OR_NEWER
#endif
#nullable enable
namespace Izayoi.NovaShader
{
    using System;
    using UnityEngine;
    using Izayoi.NovaShader.Extensions;
    using Izayoi.NovaShader.Proxies;
    using Izayoi.NovaShader.Proxies.Uber;

#if NOVA_SHADER_2_0_OR_NEWER
    using Izayoi.NovaShader.v2_0_0;
#endif

    /// <summary>
    /// NOVA Shader Material Getter
    /// </summary>
    public class NovaMaterialGetter
    {
        #region Methods (Container)

        /// <summary>
        /// Get the NOVA shader property container from the material.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <returns>A NOVA Shader Property Container.</returns>
        public virtual NovaPropertyContainer GetNovaPropertyContainer(Material material)
        {
            NovaPropertyContainer propertyContainer;

            NovaPropertyEntityType propertyEntityType = material.shader.GetNovaPropertyEntityType();

            switch (propertyEntityType)
            {
                case NovaPropertyEntityType.UberLit:
                    propertyContainer = new NovaPropertyContainer
                    {
                        PropertyEntityType = propertyEntityType,
                        UberLitProperty = GetNovaUberLitPropertyEntity(material),
                    };
                    break;
                case NovaPropertyEntityType.UberUnlit:
                    propertyContainer = new NovaPropertyContainer
                    {
                        PropertyEntityType = propertyEntityType,
                        UberUnlitProperty = GetNovaUberUnlitPropertyEntity(material),
                    };
                    break;
                case NovaPropertyEntityType.Distortion:
                    propertyContainer = new NovaPropertyContainer
                    {
                        PropertyEntityType = propertyEntityType,
                        DistortionProperty = GetNovaDistortionPropertyEntity(material),
                    };
                    break;
                default:
                    throw new NotSupportedException(material.shader.name);
            }

            return propertyContainer;
        }

        #endregion

        #region Methods (Entity)

        /// <summary>
        /// Get the NOVA uber lit property entity from the material.
        /// </summary>
        /// <param name="material">A NOVA uber lit material.</param>
        /// <returns>A Nova uber lit property entity.</returns>
        public virtual NovaUberLitPropertyEntity GetNovaUberLitPropertyEntity(Material material)
        {
            return new NovaUberLitPropertyEntity
            {
                RenderSetting = GetNovaUberLitRenderSettingPropertyValues(material),
                SurfaceMap = GetNovaUberLitSurfaceMapPropertyValues(material),
                BaseMap = GetNovaUberBaseMapPropertyValues(material),
                TintColor = GetNovaUberTintColorPropertyValues(material),
                FlowMap = GetNovaUberFlowMapPropertyValues(material),
                ParallaxMap = GetNovaUberParallaxMapPropertyValues(material),
                ColorCorrection = GetNovaUberColorCorrectionPropertyValues(material),
                AlphaTransition = GetNovaUberAlphaTransitionPropertyValues(material),
                Emission = GetNovaUberEmissionPropertyValues(material),
                Transparency = GetNovaUberTransparencyPropertyValues(material),
                VertexDeformation = GetNovaUberVertexDeformationPropertyValues(material),
                ShadowCaster = GetNovaUberShadowCasterPropertyValues(material),
            };
        }

        /// <summary>
        /// Get the NOVA uber unlit property entity from the material.
        /// </summary>
        /// <param name="material">A NOVA uber unlit material.</param>
        /// <returns>A Nova uber unlit property entity.</returns>
        public virtual NovaUberUnlitPropertyEntity GetNovaUberUnlitPropertyEntity(Material material)
        {
            return new NovaUberUnlitPropertyEntity
            {
                RenderSetting = GetNovaUberUnlitRenderSettingPropertyValues(material),
                //SurfaceMap = GetNovaUberUnlitSurfaceMapPropertyValues(material),
                BaseMap = GetNovaUberBaseMapPropertyValues(material),
                TintColor = GetNovaUberTintColorPropertyValues(material),
                FlowMap = GetNovaUberFlowMapPropertyValues(material),
                ParallaxMap = GetNovaUberParallaxMapPropertyValues(material),
                ColorCorrection = GetNovaUberColorCorrectionPropertyValues(material),
                AlphaTransition = GetNovaUberAlphaTransitionPropertyValues(material),
                Emission = GetNovaUberEmissionPropertyValues(material),
                Transparency = GetNovaUberTransparencyPropertyValues(material),
                VertexDeformation = GetNovaUberVertexDeformationPropertyValues(material),
                ShadowCaster = GetNovaUberShadowCasterPropertyValues(material),
            };
        }

        /// <summary>
        /// Get the NOVA distortion property entity from the material.
        /// </summary>
        /// <param name="material">A NOVA distortion material.</param>
        /// <returns>A NOVA distortion property entity.</returns>
        public virtual NovaDistortionPropertyEntity GetNovaDistortionPropertyEntity(Material material)
        {
            return new NovaDistortionPropertyEntity
            {
                RenderSetting = GetNovaDistortionRenderSettingPropertyValues(material),
                DistortionMap = GetNovaDistortionMapPropertyValues(material),
                FlowMap = GetNovaDistortionFlowMapPropertyValues(material),
                AlphaTransition = GetNovaDistortionAlphaTransitionPropertyValues(material),
                Transparency = GetNovaDistortionTransparencyPropertyValues(material),
            };
        }

        #endregion

        #region Methods (Block)

        #region Render Settings

        /// <summary>
        /// Get the Render Settings property values from the material.
        /// </summary>
        /// <param name="material">A NOVA uber lit shader material.</param>
        /// <returns></returns>
        public virtual NovaUberLitRenderSetting GetNovaUberLitRenderSettingPropertyValues(Material material)
        {
            var materialProxy = new NovaRenderSettingMaterialProxy(material);

            return new NovaUberLitRenderSetting
            {
                RenderType = materialProxy.RenderType,
                Cutoff = materialProxy.Cutoff,
                TransparentBlendMode = materialProxy.TransparentBlendMode,
                Cull = materialProxy.Cull,
                QueueOffset = materialProxy.QueueOffset,
                VertexAlphaMode = materialProxy.VertexAlphaMode,
                BlendSrc = materialProxy.BlendSrc,
                BlendDst = materialProxy.BlendDst,
                ZWrite = materialProxy.ZWrite,
                ZWriteOverride = materialProxy.ZWriteOverride,
                ZTest = materialProxy.ZTest,

                LitWorkflowMode = materialProxy.LitWorkflowMode,
                LitReceiveShadows = materialProxy.LitReceiveShadows,
                SpecularHighlights = materialProxy.SpecularHighlights,
                EnvironmentReflections = materialProxy.EnvironmentReflections,
            };
        }

        /// <summary>
        /// Get the Render Settings property values from the material.
        /// </summary>
        /// <param name="material">A NOVA uber unlit shader material.</param>
        /// <returns></returns>
        public virtual NovaUberUnlitRenderSetting GetNovaUberUnlitRenderSettingPropertyValues(Material material)
        {
            var materialProxy = new NovaRenderSettingMaterialProxy(material);

            return new NovaUberUnlitRenderSetting
            {
                RenderType = materialProxy.RenderType,
                Cutoff = materialProxy.Cutoff,
                TransparentBlendMode = materialProxy.TransparentBlendMode,
                Cull = materialProxy.Cull,
                QueueOffset = materialProxy.QueueOffset,
                VertexAlphaMode = materialProxy.VertexAlphaMode,
                BlendSrc = materialProxy.BlendSrc,
                BlendDst = materialProxy.BlendDst,
                ZWrite = materialProxy.ZWrite,
                ZWriteOverride = materialProxy.ZWriteOverride,
                ZTest = materialProxy.ZTest,
            };
        }

        /// <summary>
        /// Get the Alpha Transition property values from the material.
        /// </summary>
        /// <param name="material">A NOVA distortion shader material.</param>
        /// <returns></returns>
        public virtual NovaDistortionRenderSetting GetNovaDistortionRenderSettingPropertyValues(Material material)
        {
            var materialProxy = new NovaRenderSettingMaterialProxy(material);

            return new NovaDistortionRenderSetting
            {
                Cull = materialProxy.Cull,
                ZTest = materialProxy.ZTest,
            };
        }

        #endregion

        #region Surface Maps

        /// <summary>
        /// Get the Surface Map property values from the material.
        /// </summary>
        /// <param name="material">A NOVA uber lit shader material.</param>
        /// <returns></returns>
        public virtual NovaUberLitSurfaceMap GetNovaUberLitSurfaceMapPropertyValues(Material material)
        {
            var materialProxy = new NovaSurfaceMapMaterialProxy(material);

            return new NovaUberLitSurfaceMap
            {
                NormalMap = materialProxy.NormalMap,
                NormalMap2DArray = materialProxy.NormalMap2DArray,
                NormalMap3D = materialProxy.NormalMap3D,
                NormalMapBumpScale = materialProxy.NormalMapBumpScale,

                SpecularMap = materialProxy.SpecularMap,
                SpecularMap2DArray = materialProxy.SpecularMap2DArray,
                SpecularMap3D = materialProxy.SpecularMap3D,
                SpecularColor = materialProxy.SpecularColor,
                SpecularMapChannelsX = materialProxy.SpecularMapChannelsX,

                MetallicMap = materialProxy.MetallicMap,
                MetallicMap2DArray = materialProxy.MetallicMap2DArray,
                MetallicMap3D = materialProxy.MetallicMap3D,
                Metallic = materialProxy.Metallic,
                MetallicMapChannelsX = materialProxy.MetallicMapChannelsX,

                SmoothnessMap = materialProxy.SmoothnessMap,
                SmoothnessMap2DArray = materialProxy.SmoothnessMap2DArray,
                SmoothnessMap3D = materialProxy.SmoothnessMap3D,
                Smoothness = materialProxy.Smoothness,
                SmoothnessMapChannelsX = materialProxy.SmoothnessMapChannelsX,
            };
        }

        #endregion

        #region Base Map

        /// <summary>
        /// Get the Base Map property values from the material.
        /// </summary>
        /// <param name="material">A NOVA uber shader material.</param>
        /// <returns></returns>
        public virtual NovaUberBaseMap GetNovaUberBaseMapPropertyValues(Material material)
        {
            var materialProxy = new NovaBaseMapMaterialProxy(material);

            return new NovaUberBaseMap
            {
                BaseMapMode = materialProxy.BaseMapMode,

                BaseMap = materialProxy.BaseMap,
                BaseMap2DArray = materialProxy.BaseMap2DArray,
                BaseMap3D = materialProxy.BaseMap3D,

                BaseMapProgress = materialProxy.BaseMapProgress,
                BaseMapProgressCoord = materialProxy.BaseMapProgressCoord,

                BaseMapSliceCount = materialProxy.BaseMapSliceCount,

                BaseMapOffsetXCoord = materialProxy.BaseMapOffsetXCoord,
                BaseMapOffsetYCoord = materialProxy.BaseMapOffsetYCoord,

                BaseMapRotation = materialProxy.BaseMapRotation,
                BaseMapRotationCoord = materialProxy.BaseMapRotationCoord,
                BaseMapRotationOffsets = materialProxy.BaseMapRotationOffsets,
                BaseMapMirrorSampling = materialProxy.BaseMapMirrorSampling,
            };
        }

        #endregion

        #region Distortion Map

        /// <summary>
        /// Get the Distortion Map property values from the material.
        /// </summary>
        /// <param name="material">A NOVA uber shader material.</param>
        /// <returns></returns>
        public virtual NovaDistortionDistortionMap GetNovaDistortionMapPropertyValues(Material material)
        {
            var materialProxy = new NovaDistortionMapMaterialProxy(material);

            return new NovaDistortionDistortionMap
            {
                BaseMap = materialProxy.BaseMap,

                BaseMapOffsetXCoord = materialProxy.BaseMapOffsetXCoord,
                BaseMapOffsetYCoord = materialProxy.BaseMapOffsetYCoord,

                BaseMapChannelsX = materialProxy.BaseMapChannelsX,
                BaseMapChannelsY = materialProxy.BaseMapChannelsY,

                BaseMapRotation = materialProxy.BaseMapRotation,
                BaseMapRotationCoord = materialProxy.BaseMapRotationCoord,
                BaseMapRotationOffsets = materialProxy.BaseMapRotationOffsets,

                BaseMapMirrorSampling = materialProxy.BaseMapMirrorSampling,

                DistortionIntensity = materialProxy.DistortionIntensity,
                DistortionIntensityCoord = materialProxy.DistortionIntensityCoord,
            };
        }

        #endregion

        #region Tint Color

        /// <summary>
        /// Get the Tint Color property values from the material.
        /// </summary>
        /// <param name="material">A NOVA uber shader material.</param>
        /// <returns></returns>
        public virtual NovaUberTintColor GetNovaUberTintColorPropertyValues(Material material)
        {
            var materialProxy = new NovaTintColorMaterialProxy(material);

            return new NovaUberTintColor
            {
                TintAreaMode = materialProxy.TintAreaMode,
                TintColorMode = materialProxy.TintColorMode,
                TintColor = materialProxy.TintColor,

                TintMap = materialProxy.TintMap,
                TintMap3D = materialProxy.TintMap3D,
                TintMap3DProgress = materialProxy.TintMap3DProgress,
                TintMap3DProgressCoord = materialProxy.TintMap3DProgressCoord,
                TintMapSliceCount = materialProxy.TintMapSliceCount,
                TintMapOffsetXCoord = materialProxy.TintMapOffsetXCoord,
                TintMapOffsetYCoord = materialProxy.TintMapOffsetYCoord,

                TintBlendRate = materialProxy.TintBlendRate,
                TintBlendRateCoord = materialProxy.TintBlendRateCoord,

                TintRimProgress = materialProxy.TintRimProgress,
                TintRimProgressCoord = materialProxy.TintRimProgressCoord,
                TintRimSharpness = materialProxy.TintRimSharpness,
                TintRimSharpnessCoord = materialProxy.TintRimSharpnessCoord,
                InverseTintRim = materialProxy.InverseTintRim,
            };
        }

        #endregion

        #region Flow Map

        /// <summary>
        /// Get the Flow Map property values from the material.
        /// </summary>
        /// <param name="material">A NOVA uber shader material.</param>
        /// <returns></returns>
        public virtual NovaUberFlowMap GetNovaUberFlowMapPropertyValues(Material material)
        {
            var materialProxy = new NovaFlowMapMaterialProxy(material);

            return new NovaUberFlowMap
            {
                FlowMap = materialProxy.FlowMap,
                FlowMapOffsetXCoord = materialProxy.FlowMapOffsetXCoord,
                FlowMapOffsetYCoord = materialProxy.FlowMapOffsetYCoord,
                FlowMapChannelsX = materialProxy.FlowMapChannelsX,
                FlowMapChannelsY = materialProxy.FlowMapChannelsY,
                FlowIntensity = materialProxy.FlowIntensity,
                FlowIntensityCoord = materialProxy.FlowIntensityCoord,
                FlowMapTarget = materialProxy.FlowMapTarget,
            };
        }

        /// <summary>
        /// Get the Flow Map property values from the material.
        /// </summary>
        /// <param name="material">A NOVA distortion shader material.</param>
        /// <returns></returns>
        public virtual NovaDistortionFlowMap GetNovaDistortionFlowMapPropertyValues(Material material)
        {
            var materialProxy = new NovaFlowMapMaterialProxy(material);

            return new NovaDistortionFlowMap
            {
                FlowMap = materialProxy.FlowMap,
                FlowMapOffsetXCoord = materialProxy.FlowMapOffsetXCoord,
                FlowMapOffsetYCoord = materialProxy.FlowMapOffsetYCoord,
                FlowMapChannelsX = materialProxy.FlowMapChannelsX,
                FlowMapChannelsY = materialProxy.FlowMapChannelsY,
                FlowIntensity = materialProxy.FlowIntensity,
                FlowIntensityCoord = materialProxy.FlowIntensityCoord,
                FlowMapTarget = materialProxy.FlowMapTargetDistortion,  // @notice
            };
        }

        #endregion

        #region Parallax Map

        /// <summary>
        /// Get the Parallax Map property values from the material.
        /// </summary>
        /// <param name="material">A NOVA uber shader material.</param>
        /// <returns></returns>
        public virtual NovaUberParallaxMap GetNovaUberParallaxMapPropertyValues(Material material)
        {
            var materialProxy = new NovaParallaxMapMaterialProxy(material);

            return new NovaUberParallaxMap
            {
                ParallaxMapMode = materialProxy.ParallaxMapMode,
                ParallaxMap = materialProxy.ParallaxMap,
                ParallaxMap2DArray = materialProxy.ParallaxMap2DArray,
                ParallaxMap3D = materialProxy.ParallaxMap3D,
                ParallaxMapProgress = materialProxy.ParallaxMapProgress,
                ParallaxMapProgressCoord = materialProxy.ParallaxMapProgressCoord,
                ParallaxMapOffsetXCoord = materialProxy.ParallaxMapOffsetXCoord,
                ParallaxMapOffsetYCoord = materialProxy.ParallaxMapOffsetYCoord,
                ParallaxMapSliceCount = materialProxy.ParallaxMapSliceCount,
                ParallaxMapChannel = materialProxy.ParallaxMapChannel,
                ParallaxStrength = materialProxy.ParallaxStrength,
                ParallaxMapTarget = materialProxy.ParallaxMapTarget,
            };
        }

        #endregion

        #region Color Correction

        /// <summary>
        /// Get the Color Correction property values from the material.
        /// </summary>
        /// <param name="material">A NOVA uber shader material.</param>
        /// <returns></returns>
        public virtual NovaUberColorCorrection GetNovaUberColorCorrectionPropertyValues(Material material)
        {
            var materialProxy = new NovaColorCorrectionMaterialProxy(material);

            return new NovaUberColorCorrection
            {
                ColorCorrectionMode = materialProxy.ColorCorrectionMode,
                GradientMap = materialProxy.GradientMap,
            };
        }

        #endregion

        #region Alpha Transition

        /// <summary>
        /// Get the Alpha Transition property values from the material.
        /// </summary>
        /// <param name="material">A NOVA uber shader material.</param>
        /// <returns></returns>
        public virtual NovaUberAlphaTransition GetNovaUberAlphaTransitionPropertyValues(Material material)
        {
            var materialProxy = new NovaAlphaTransitionMaterialProxy(material);

            return new NovaUberAlphaTransition
            {
                AlphaTransitionMode = materialProxy.AlphaTransitionMode,
                AlphaTransitionMapMode = materialProxy.AlphaTransitionMapMode,
                AlphaTransitionMap = materialProxy.AlphaTransitionMap,
                AlphaTransitionMap2DArray = materialProxy.AlphaTransitionMap2DArray,
                AlphaTransitionMap3D = materialProxy.AlphaTransitionMap3D,
                AlphaTransitionMapProgress = materialProxy.AlphaTransitionMapProgress,
                AlphaTransitionMapProgressCoord = materialProxy.AlphaTransitionMapProgressCoord,
                AlphaTransitionMapOffsetXCoord = materialProxy.AlphaTransitionMapOffsetXCoord,
                AlphaTransitionMapOffsetYCoord = materialProxy.AlphaTransitionMapOffsetYCoord,
                AlphaTransitionMapChannelsX = materialProxy.AlphaTransitionMapChannelsX,
                AlphaTransitionMapSliceCount = materialProxy.AlphaTransitionMapSliceCount,
                AlphaTransitionProgress = materialProxy.AlphaTransitionProgress,
                AlphaTransitionProgressCoord = materialProxy.AlphaTransitionProgressCoord,
                DissolveSharpness = materialProxy.DissolveSharpness,

                AlphaTransitionSecondTextureBlendMode = materialProxy.AlphaTransitionSecondTextureBlendMode,
                AlphaTransitionMapSecondTexture = materialProxy.AlphaTransitionMapSecondTexture,
                AlphaTransitionMapSecondTexture2DArray = materialProxy.AlphaTransitionMapSecondTexture2DArray,
                AlphaTransitionMapSecondTexture3D = materialProxy.AlphaTransitionMapSecondTexture3D,
                AlphaTransitionMapSecondTextureProgress = materialProxy.AlphaTransitionMapSecondTextureProgress,
                AlphaTransitionMapSecondTextureProgressCoord = materialProxy.AlphaTransitionMapSecondTextureProgressCoord,
                AlphaTransitionMapSecondTextureOffsetXCoord = materialProxy.AlphaTransitionMapSecondTextureOffsetXCoord,
                AlphaTransitionMapSecondTextureOffsetYCoord = materialProxy.AlphaTransitionMapSecondTextureOffsetYCoord,
                AlphaTransitionMapSecondTextureChannelsX = materialProxy.AlphaTransitionMapSecondTextureChannelsX,
                AlphaTransitionMapSecondTextureSliceCount = materialProxy.AlphaTransitionMapSecondTextureSliceCount,
                AlphaTransitionProgressSecondTexture = materialProxy.AlphaTransitionProgressSecondTexture,
                AlphaTransitionProgressCoordSecondTexture = materialProxy.AlphaTransitionProgressCoordSecondTexture,
                DissolveSharpnessSecondTexture = materialProxy.DissolveSharpnessSecondTexture,
            };
        }

        /// <summary>
        /// Get the Alpha Transition property values from the material.
        /// </summary>
        /// <param name="material">A NOVA distortion shader material.</param>
        /// <returns></returns>
        public virtual NovaDistortionAlphaTransition GetNovaDistortionAlphaTransitionPropertyValues(Material material)
        {
            var materialProxy = new NovaAlphaTransitionMaterialProxy(material);

            return new NovaDistortionAlphaTransition
            {
                AlphaTransitionMode = materialProxy.AlphaTransitionMode,
                AlphaTransitionMap = materialProxy.AlphaTransitionMap,
                AlphaTransitionMapOffsetXCoord = materialProxy.AlphaTransitionMapOffsetXCoord,
                AlphaTransitionMapOffsetYCoord = materialProxy.AlphaTransitionMapOffsetYCoord,
                AlphaTransitionMapChannelsX = materialProxy.AlphaTransitionMapChannelsX,
                AlphaTransitionProgress = materialProxy.AlphaTransitionProgress,
                AlphaTransitionProgressCoord = materialProxy.AlphaTransitionProgressCoord,
                DissolveSharpness = materialProxy.DissolveSharpness,
            };
        }

        #endregion

        #region Emission

        /// <summary>
        /// Get the Emission property values from the material.
        /// </summary>
        /// <param name="material">A NOVA uber shader material.</param>
        /// <returns></returns>
        public virtual NovaUberEmission GetNovaUberEmissionPropertyValues(Material material)
        {
            var materialProxy = new NovaEmissionMaterialProxy(material);

            return new NovaUberEmission
            {
                EmissionAreaType = materialProxy.EmissionAreaType,
                EmissionMapMode = materialProxy.EmissionMapMode,
                EmissionMap = materialProxy.EmissionMap,
                EmissionMap2DArray = materialProxy.EmissionMap2DArray,
                EmissionMap3D = materialProxy.EmissionMap3D,
                EmissionMapProgress = materialProxy.EmissionMapProgress,
                EmissionMapProgressCoord = materialProxy.EmissionMapProgressCoord,
                EmissionMapOffsetXCoord = materialProxy.EmissionMapOffsetXCoord,
                EmissionMapOffsetYCoord = materialProxy.EmissionMapOffsetYCoord,
                EmissionMapChannelsX = materialProxy.EmissionMapChannelsX,
                EmissionMapSliceCount = materialProxy.EmissionMapSliceCount,

                EmissionColorType = materialProxy.EmissionColorType,
                EmissionColor = materialProxy.EmissionColor,
                EmissionColorRamp = materialProxy.EmissionColorRamp,

                EmissionIntensity = materialProxy.EmissionIntensity,
                EmissionIntensityCoord = materialProxy.EmissionIntensityCoord,
                KeepEdgeTransparency = materialProxy.KeepEdgeTransparency,
            };
        }

        #endregion

        #region Transparency

        /// <summary>
        /// Get the Transparency property values from the material.
        /// </summary>
        /// <param name="material">A NOVA uber shader material.</param>
        /// <returns></returns>
        public virtual NovaUberTransparency GetNovaUberTransparencyPropertyValues(Material material)
        {
            var materialProxy = new NovaTransparencyMaterialProxy(material);

            return new NovaUberTransparency
            {
                RimTransparencyEnabled = materialProxy.RimTransparencyEnabled,
                RimTransparencyProgress = materialProxy.RimTransparencyProgress,
                RimTransparencyProgressCoord = materialProxy.RimTransparencyProgressCoord,
                RimTransparencySharpness = materialProxy.RimTransparencySharpness,
                RimTransparencySharpnessCoord = materialProxy.RimTransparencySharpnessCoord,
                InverseRimTransparency = materialProxy.InverseRimTransparency,

                LuminanceTransparencyEnabled = materialProxy.LuminanceTransparencyEnabled,
                LuminanceTransparencyProgress = materialProxy.LuminanceTransparencyProgress,
                LuminanceTransparencyProgressCoord = materialProxy.LuminanceTransparencyProgressCoord,
                LuminanceTransparencySharpness = materialProxy.LuminanceTransparencySharpness,
                LuminanceTransparencySharpnessCoord = materialProxy.LuminanceTransparencySharpnessCoord,
                InverseLuminanceTransparency = materialProxy.InverseLuminanceTransparency,

                SoftParticlesEnabled = materialProxy.SoftParticlesEnabled,
                SoftParticlesIntensity = materialProxy.SoftParticlesIntensity,

                DepthFadeEnabled = materialProxy.DepthFadeEnabled,
                DepthFadeNear = materialProxy.DepthFadeNear,
                DepthFadeFar = materialProxy.DepthFadeFar,
                DepthFadeWidth = materialProxy.DepthFadeWidth,
            };
        }

        /// <summary>
        /// Get the Distortion Transparency property values from the material.
        /// </summary>
        /// <param name="material">A NOVA distortion shader material.</param>
        /// <returns></returns>
        public virtual NovaDistortionTransparency GetNovaDistortionTransparencyPropertyValues(Material material)
        {
            var materialProxy = new NovaTransparencyMaterialProxy(material);

            return new NovaDistortionTransparency
            {
                SoftParticlesEnabled = materialProxy.SoftParticlesEnabled,
                SoftParticlesIntensity = materialProxy.SoftParticlesIntensity,

                DepthFadeEnabled = materialProxy.DepthFadeEnabled,
                DepthFadeNear = materialProxy.DepthFadeNear,
                DepthFadeFar = materialProxy.DepthFadeFar,
                DepthFadeWidth = materialProxy.DepthFadeWidth,
            };
        }

        #endregion

        #region Vertex Deformation

        /// <summary>
        /// Get the Vertex Deformation property values from the material.
        /// </summary>
        /// <param name="material">A NOVA uber shader material.</param>
        /// <returns></returns>
        public virtual NovaUberVertexDeformation GetNovaUberVertexDeformationPropertyValues(Material material)
        {
            var materialProxy = new NovaVertexDeformationMaterialProxy(material);

            return new NovaUberVertexDeformation
            {
                VertexDeformationEnabled = materialProxy.VertexDeformationEnabled,

                VertexDeformationMap = materialProxy.VertexDeformationMap,
                VertexDeformationMapOffsetXCoord = materialProxy.VertexDeformationMapOffsetXCoord,
                VertexDeformationMapOffsetYCoord = materialProxy.VertexDeformationMapOffsetYCoord,
                VertexDeformationMapChannel = materialProxy.VertexDeformationMapChannel,

                VertexDeformationIntensity = materialProxy.VertexDeformationIntensity,
                VertexDeformationIntensityCoord = materialProxy.VertexDeformationIntensityCoord,
            };
        }

        #endregion

        #region Shadow Caster

        /// <summary>
        /// Get the Shadow Caster property values from the material.
        /// </summary>
        /// <param name="material">A NOVA uber shader material.</param>
        /// <returns></returns>
        public virtual NovaUberShadowCaster GetNovaUberShadowCasterPropertyValues(Material material)
        {
            var materialProxy = new NovaShadowCasterMaterialProxy(material);

            return new NovaUberShadowCaster
            {
                ShadowCasterEnabled = materialProxy.ShadowCasterEnabled,
                ShadowCasterApplyVertexDeformation = materialProxy.ShadowCasterApplyVertexDeformation,

                ShadowCasterAlphaTestEnabled = materialProxy.ShadowCasterAlphaTestEnabled,
                ShadowCasterAlphaCutoff = materialProxy.ShadowCasterAlphaCutoff,

                ShadowCasterAlphaAffectedByTintColor = materialProxy.ShadowCasterAlphaAffectedByTintColor,
                ShadowCasterAlphaAffectedByFlowMap = materialProxy.ShadowCasterAlphaAffectedByFlowMap,
                ShadowCasterAlphaAffectedByAlphaTransitionMap = materialProxy.ShadowCasterAlphaAffectedByAlphaTransitionMap,
                ShadowCasterAlphaAffectedByTransparencyLuminance = materialProxy.ShadowCasterAlphaAffectedByTransparencyLuminance,
            };
        }

        #endregion

        #endregion
    }
}