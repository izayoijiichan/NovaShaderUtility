// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader
// @Class     : NovaMaterialSetter
// ----------------------------------------------------------------------
#if !NOVA_SHADER_2_0_OR_NEWER
#define NOVA_SHADER_2_0_OR_NEWER
#endif
#nullable enable
namespace Izayoi.NovaShader
{
    using System;
    using UnityEngine;
    using Izayoi.NovaShader.Proxies;
    using Izayoi.NovaShader.Proxies.Uber;

#if NOVA_SHADER_2_0_OR_NEWER
    using Izayoi.NovaShader.v2_0_0;
#endif

    /// <summary>
    /// Nova Shader  Material Setter
    /// </summary>
    public class NovaMaterialSetter
    {
        #region Methods (Container)

        /// <summary>
        /// Set the NOVA shader property values to the material.
        /// </summary>
        /// <param name="material">A NOVA shader material.</param>
        /// <param name="propertyContainer">A NOVA shader property container.</param>
        public virtual void SetNovaPropertyValues(Material material, NovaPropertyContainer propertyContainer)
        {
            switch (propertyContainer.PropertyEntityType)
            {
                case NovaPropertyEntityType.UberLit:
                    SetNovaUberLitPropertyEntity(material, propertyContainer);
                    break;
                case NovaPropertyEntityType.UberUnlit:
                    SetNovaUberUnlitPropertyEntity(material, propertyContainer);
                    break;
                case NovaPropertyEntityType.Distortion:
                    SetNovaDistortionPropertyEntity(material, propertyContainer);
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        #endregion

        #region Methods (Entity)

        /// <summary>
        /// Set the NOVA uber lit property entity to the material.
        /// </summary>
        /// <param name="material">A NOVA uber lit material.</param>
        /// <param name="propertyContainer">A NOVA property container.</param>
        public virtual void SetNovaUberLitPropertyEntity(Material material, NovaPropertyContainer propertyContainer)
        {
            if (propertyContainer.UberLitProperty is null)
            {
                throw new Exception();
            }

            NovaUberLitPropertyEntity propertyEntity = propertyContainer.UberLitProperty;

            // Render Settings (Lit)
            SetNovaUberLitPropertyValues(material, propertyEntity.RenderSetting);

            // Surface Maps
            SetNovaUberLitPropertyValues(material, propertyEntity.SurfaceMap);

            // Base Map
            SetNovaUberPropertyValues(material, propertyEntity.BaseMap);

            // Tint Color
            SetNovaUberPropertyValues(material, propertyEntity.TintColor);

            // Flow Map
            SetNovaUberPropertyValues(material, propertyEntity.FlowMap);

            // Parallax Map
            SetNovaUberPropertyValues(material, propertyEntity.ParallaxMap);

            // Color Correction
            SetNovaUberPropertyValues(material, propertyEntity.ColorCorrection);

            // Alpha Transition
            SetNovaUberPropertyValues(material, propertyEntity.AlphaTransition);

            // Emission
            SetNovaUberPropertyValues(material, propertyEntity.Emission);

            // Transparency
            SetNovaUberPropertyValues(material, propertyEntity.Transparency);

            // Vertex Deformation
            SetNovaUberPropertyValues(material, propertyEntity.VertexDeformation);

            // Shadow Caster
            SetNovaUberPropertyValues(material, propertyEntity.ShadowCaster);
        }

        /// <summary>
        /// Set the NOVA uber unlit property entity to the material.
        /// </summary>
        /// <param name="material">A NOVA uber unlit material.</param>
        /// <param name="propertyContainer">A NOVA property container.</param>
        public virtual void SetNovaUberUnlitPropertyEntity(Material material, NovaPropertyContainer propertyContainer)
        {
            if (propertyContainer.UberUnlitProperty is null)
            {
                throw new Exception();
            }

            NovaUberUnlitPropertyEntity propertyEntity = propertyContainer.UberUnlitProperty;

            // Render Settings (Unlit)
            SetNovaUberUnlitPropertyValues(material, propertyEntity.RenderSetting);

            // Base Map
            SetNovaUberPropertyValues(material, propertyEntity.BaseMap);

            // Tint Color
            SetNovaUberPropertyValues(material, propertyEntity.TintColor);

            // Flow Map
            SetNovaUberPropertyValues(material, propertyEntity.FlowMap);

            // Parallax Map
            SetNovaUberPropertyValues(material, propertyEntity.ParallaxMap);

            // Color Correction
            SetNovaUberPropertyValues(material, propertyEntity.ColorCorrection);

            // Alpha Transition
            SetNovaUberPropertyValues(material, propertyEntity.AlphaTransition);

            // Emission
            SetNovaUberPropertyValues(material, propertyEntity.Emission);

            // Transparency
            SetNovaUberPropertyValues(material, propertyEntity.Transparency);

            // Vertex Deformation
            SetNovaUberPropertyValues(material, propertyEntity.VertexDeformation);

            // Shadow Caster
            SetNovaUberPropertyValues(material, propertyEntity.ShadowCaster);
        }

        /// <summary>
        /// Set the NOVA distortion property entity to the material.
        /// </summary>
        /// <param name="material">A NOVA distortion material.</param>
        /// <param name="propertyContainer">A NOVA property container.</param>
        public virtual void SetNovaDistortionPropertyEntity(Material material, NovaPropertyContainer propertyContainer)
        {
            if (propertyContainer.DistortionProperty is null)
            {
                throw new Exception();
            }

            NovaDistortionPropertyEntity propertyEntity = propertyContainer.DistortionProperty;

            // Render Settings (Distortion)
            SetNovaDistortionPropertyValues(material, propertyEntity.RenderSetting);

            // Distortion Map
            SetNovaDistortionPropertyValues(material, propertyEntity.DistortionMap);

            // Flow Map
            SetNovaDistortionPropertyValues(material, propertyEntity.FlowMap);

            // Alpha Transition
            SetNovaDistortionPropertyValues(material, propertyEntity.AlphaTransition);

            // Transparency
            SetNovaDistortionPropertyValues(material, propertyEntity.Transparency);
        }

        #endregion

        #region Methods (Block)

        #region Render Settings

        /// <summary>
        /// Set the render settings property values to the material.
        /// </summary>
        /// <param name="material">A NOVA uber lit material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetNovaUberLitPropertyValues(Material material, INovaUberLitRenderSetting? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new NovaRenderSettingMaterialProxy(material)
            {
                RenderType = propertyBlock.RenderType,
                Cutoff = propertyBlock.Cutoff,
                TransparentBlendMode = propertyBlock.TransparentBlendMode,
                Cull = propertyBlock.Cull,
                QueueOffset = propertyBlock.QueueOffset,
                VertexAlphaMode = propertyBlock.VertexAlphaMode,
                BlendSrc = propertyBlock.BlendSrc,
                BlendDst = propertyBlock.BlendDst,
                ZWrite = propertyBlock.ZWrite,
                ZWriteOverride = propertyBlock.ZWriteOverride,
                ZTest = propertyBlock.ZTest,

                LitWorkflowMode = propertyBlock.LitWorkflowMode,
                LitReceiveShadows = propertyBlock.LitReceiveShadows,
                SpecularHighlights = propertyBlock.SpecularHighlights,
                EnvironmentReflections = propertyBlock.EnvironmentReflections,
            };
        }

        /// <summary>
        /// Set the render settings property values to the material.
        /// </summary>
        /// <param name="material">A NOVA uber unlit material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetNovaUberUnlitPropertyValues(Material material, INovaUberUnlitRenderSetting? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new NovaRenderSettingMaterialProxy(material)
            {
                RenderType = propertyBlock.RenderType,
                Cutoff = propertyBlock.Cutoff,
                TransparentBlendMode = propertyBlock.TransparentBlendMode,
                Cull = propertyBlock.Cull,
                QueueOffset = propertyBlock.QueueOffset,
                VertexAlphaMode = propertyBlock.VertexAlphaMode,
                BlendSrc = propertyBlock.BlendSrc,
                BlendDst = propertyBlock.BlendDst,
                ZWrite = propertyBlock.ZWrite,
                ZWriteOverride = propertyBlock.ZWriteOverride,
                ZTest = propertyBlock.ZTest,
            };
        }

        /// <summary>
        /// Set the render settings property values to the material.
        /// </summary>
        /// <param name="material">A NOVA distortion material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetNovaDistortionPropertyValues(Material material, INovaDistortionRenderSetting? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new NovaRenderSettingMaterialProxy(material)
            {
                Cull = propertyBlock.Cull,
                ZTest = propertyBlock.ZTest,
            };
        }

        #endregion

        #region Surface Maps

        /// <summary>
        /// Set the surface maps property values to the material.
        /// </summary>
        /// <param name="material">A NOVA uber lit material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetNovaUberLitPropertyValues(Material material, INovaUberLitSurfaceMap? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new NovaSurfaceMapMaterialProxy(material)
            {
                NormalMap = propertyBlock.NormalMap,
                NormalMap2DArray = propertyBlock.NormalMap2DArray,
                NormalMap3D = propertyBlock.NormalMap3D,
                NormalMapBumpScale = propertyBlock.NormalMapBumpScale,

                SpecularMap = propertyBlock.SpecularMap,
                SpecularMap2DArray = propertyBlock.SpecularMap2DArray,
                SpecularMap3D = propertyBlock.SpecularMap3D,
                SpecularColor = propertyBlock.SpecularColor,
                SpecularMapChannelsX = propertyBlock.SpecularMapChannelsX,

                MetallicMap = propertyBlock.MetallicMap,
                MetallicMap2DArray = propertyBlock.MetallicMap2DArray,
                MetallicMap3D = propertyBlock.MetallicMap3D,
                Metallic = propertyBlock.Metallic,
                MetallicMapChannelsX = propertyBlock.MetallicMapChannelsX,

                SmoothnessMap = propertyBlock.SmoothnessMap,
                SmoothnessMap2DArray = propertyBlock.SmoothnessMap2DArray,
                SmoothnessMap3D = propertyBlock.SmoothnessMap3D,
                Smoothness = propertyBlock.Smoothness,
                SmoothnessMapChannelsX = propertyBlock.SmoothnessMapChannelsX,
            };
        }

        #endregion

        #region Base Map

        /// <summary>
        /// Set the base map property values to the material.
        /// </summary>
        /// <param name="material">A NOVA uber material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetNovaUberPropertyValues(Material material, INovaUberBaseMap? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new NovaBaseMapMaterialProxy(material)
            {
                BaseMapMode = propertyBlock.BaseMapMode,

                BaseMap = propertyBlock.BaseMap,
                BaseMap2DArray = propertyBlock.BaseMap2DArray,
                BaseMap3D = propertyBlock.BaseMap3D,

                BaseMapProgress = propertyBlock.BaseMapProgress,
                BaseMapProgressCoord = propertyBlock.BaseMapProgressCoord,

                BaseMapSliceCount = propertyBlock.BaseMapSliceCount,

                BaseMapOffsetXCoord = propertyBlock.BaseMapOffsetXCoord,
                BaseMapOffsetYCoord = propertyBlock.BaseMapOffsetYCoord,

                BaseMapRotation = propertyBlock.BaseMapRotation,
                BaseMapRotationCoord = propertyBlock.BaseMapRotationCoord,
                BaseMapRotationOffsets = propertyBlock.BaseMapRotationOffsets,
                BaseMapMirrorSampling = propertyBlock.BaseMapMirrorSampling,
            };
        }

        #endregion

        #region Distortion Map

        /// <summary>
        /// Set the distortion map property values to the material.
        /// </summary>
        /// <param name="material">A NOVA distortion material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetNovaDistortionPropertyValues(Material material, INovaDistortionDistortionMap? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new NovaDistortionMapMaterialProxy(material)
            {
                BaseMap = propertyBlock.BaseMap,

                BaseMapOffsetXCoord = propertyBlock.BaseMapOffsetXCoord,
                BaseMapOffsetYCoord = propertyBlock.BaseMapOffsetYCoord,

                BaseMapChannelsX = propertyBlock.BaseMapChannelsX,
                BaseMapChannelsY = propertyBlock.BaseMapChannelsY,

                BaseMapRotation = propertyBlock.BaseMapRotation,
                BaseMapRotationCoord = propertyBlock.BaseMapRotationCoord,
                BaseMapRotationOffsets = propertyBlock.BaseMapRotationOffsets,

                BaseMapMirrorSampling = propertyBlock.BaseMapMirrorSampling,

                DistortionIntensity = propertyBlock.DistortionIntensity,
                DistortionIntensityCoord = propertyBlock.DistortionIntensityCoord,
            };
        }

        #endregion

        #region Tint Color

        /// <summary>
        /// Set the tint color property values to the material.
        /// </summary>
        /// <param name="material">A NOVA uber material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetNovaUberPropertyValues(Material material, INovaUberTintColor? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new NovaTintColorMaterialProxy(material)
            {
                TintAreaMode = propertyBlock.TintAreaMode,
                TintColorMode = propertyBlock.TintColorMode,
                TintColor = propertyBlock.TintColor,

                TintMap = propertyBlock.TintMap,
                TintMap3D = propertyBlock.TintMap3D,
                TintMap3DProgress = propertyBlock.TintMap3DProgress,
                TintMap3DProgressCoord = propertyBlock.TintMap3DProgressCoord,
                TintMapSliceCount = propertyBlock.TintMapSliceCount,
                TintMapOffsetXCoord = propertyBlock.TintMapOffsetXCoord,
                TintMapOffsetYCoord = propertyBlock.TintMapOffsetYCoord,

                TintBlendRate = propertyBlock.TintBlendRate,
                TintBlendRateCoord = propertyBlock.TintBlendRateCoord,

                TintRimProgress = propertyBlock.TintRimProgress,
                TintRimProgressCoord = propertyBlock.TintRimProgressCoord,
                TintRimSharpness = propertyBlock.TintRimSharpness,
                TintRimSharpnessCoord = propertyBlock.TintRimSharpnessCoord,
                InverseTintRim = propertyBlock.InverseTintRim,
            };
        }

        #endregion

        #region Flow Map

        /// <summary>
        /// Set the flow map property values to the material.
        /// </summary>
        /// <param name="material">A NOVA uber material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetNovaUberPropertyValues(Material material, INovaUberFlowMap? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new NovaFlowMapMaterialProxy(material)
            {
                FlowMap = propertyBlock.FlowMap,
                FlowMapOffsetXCoord = propertyBlock.FlowMapOffsetXCoord,
                FlowMapOffsetYCoord = propertyBlock.FlowMapOffsetYCoord,
                FlowMapChannelsX = propertyBlock.FlowMapChannelsX,
                FlowMapChannelsY = propertyBlock.FlowMapChannelsY,
                FlowIntensity = propertyBlock.FlowIntensity,
                FlowIntensityCoord = propertyBlock.FlowIntensityCoord,
                FlowMapTarget = propertyBlock.FlowMapTarget,
            };
        }

        /// <summary>
        /// Set the flow map property values to the material.
        /// </summary>
        /// <param name="material">A NOVA distortion material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetNovaDistortionPropertyValues(Material material, INovaDistortionFlowMap? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new NovaFlowMapMaterialProxy(material)
            {
                FlowMapDistortion = propertyBlock.FlowMap,  // @notice
                FlowMapOffsetXCoord = propertyBlock.FlowMapOffsetXCoord,
                FlowMapOffsetYCoord = propertyBlock.FlowMapOffsetYCoord,
                FlowMapChannelsX = propertyBlock.FlowMapChannelsX,
                FlowMapChannelsY = propertyBlock.FlowMapChannelsY,
                FlowIntensity = propertyBlock.FlowIntensity,
                FlowIntensityCoord = propertyBlock.FlowIntensityCoord,
                FlowMapTargetDistortion = propertyBlock.FlowMapTarget,  // @notice
            };
        }

        #endregion

        #region Parallax Map

        /// <summary>
        /// Set the parallax map property values to the material.
        /// </summary>
        /// <param name="material">A NOVA uber material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetNovaUberPropertyValues(Material material, INovaUberParallaxMap? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new NovaParallaxMapMaterialProxy(material)
            {
                ParallaxMapMode = propertyBlock.ParallaxMapMode,
                ParallaxMap = propertyBlock.ParallaxMap,
                ParallaxMap2DArray = propertyBlock.ParallaxMap2DArray,
                ParallaxMap3D = propertyBlock.ParallaxMap3D,
                ParallaxMapProgress = propertyBlock.ParallaxMapProgress,
                ParallaxMapProgressCoord = propertyBlock.ParallaxMapProgressCoord,
                ParallaxMapOffsetXCoord = propertyBlock.ParallaxMapOffsetXCoord,
                ParallaxMapOffsetYCoord = propertyBlock.ParallaxMapOffsetYCoord,
                ParallaxMapSliceCount = propertyBlock.ParallaxMapSliceCount,
                ParallaxMapChannel = propertyBlock.ParallaxMapChannel,
                ParallaxStrength = propertyBlock.ParallaxStrength,
                ParallaxMapTarget = propertyBlock.ParallaxMapTarget,
            };
        }

        #endregion

        #region Color Correction

        /// <summary>
        /// Set the color correction property values to the material.
        /// </summary>
        /// <param name="material">A NOVA uber material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetNovaUberPropertyValues(Material material, INovaUberColorCorrection? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new NovaColorCorrectionMaterialProxy(material)
            {
                ColorCorrectionMode = propertyBlock.ColorCorrectionMode,
                GradientMap = propertyBlock.GradientMap,
            };
        }

        #endregion

        #region Alpha Transition

        /// <summary>
        /// Set the alpha transition property values to the material.
        /// </summary>
        /// <param name="material">A NOVA uber material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetNovaUberPropertyValues(Material material, INovaUberAlphaTransition? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new NovaAlphaTransitionMaterialProxy(material)
            {
                AlphaTransitionMode = propertyBlock.AlphaTransitionMode,
                AlphaTransitionMapMode = propertyBlock.AlphaTransitionMapMode,
                AlphaTransitionMap = propertyBlock.AlphaTransitionMap,
                AlphaTransitionMap2DArray = propertyBlock.AlphaTransitionMap2DArray,
                AlphaTransitionMap3D = propertyBlock.AlphaTransitionMap3D,
                AlphaTransitionMapProgress = propertyBlock.AlphaTransitionMapProgress,
                AlphaTransitionMapProgressCoord = propertyBlock.AlphaTransitionMapProgressCoord,
                AlphaTransitionMapOffsetXCoord = propertyBlock.AlphaTransitionMapOffsetXCoord,
                AlphaTransitionMapOffsetYCoord = propertyBlock.AlphaTransitionMapOffsetYCoord,
                AlphaTransitionMapChannelsX = propertyBlock.AlphaTransitionMapChannelsX,
                AlphaTransitionMapSliceCount = propertyBlock.AlphaTransitionMapSliceCount,
                AlphaTransitionProgress = propertyBlock.AlphaTransitionProgress,
                AlphaTransitionProgressCoord = propertyBlock.AlphaTransitionProgressCoord,
                DissolveSharpness = propertyBlock.DissolveSharpness,

                AlphaTransitionSecondTextureBlendMode = propertyBlock.AlphaTransitionSecondTextureBlendMode,
                AlphaTransitionMapSecondTexture = propertyBlock.AlphaTransitionMapSecondTexture,
                AlphaTransitionMapSecondTexture2DArray = propertyBlock.AlphaTransitionMapSecondTexture2DArray,
                AlphaTransitionMapSecondTexture3D = propertyBlock.AlphaTransitionMapSecondTexture3D,
                AlphaTransitionMapSecondTextureProgress = propertyBlock.AlphaTransitionMapSecondTextureProgress,
                AlphaTransitionMapSecondTextureProgressCoord = propertyBlock.AlphaTransitionMapSecondTextureProgressCoord,
                AlphaTransitionMapSecondTextureOffsetXCoord = propertyBlock.AlphaTransitionMapSecondTextureOffsetXCoord,
                AlphaTransitionMapSecondTextureOffsetYCoord = propertyBlock.AlphaTransitionMapSecondTextureOffsetYCoord,
                AlphaTransitionMapSecondTextureChannelsX = propertyBlock.AlphaTransitionMapSecondTextureChannelsX,
                AlphaTransitionMapSecondTextureSliceCount = propertyBlock.AlphaTransitionMapSecondTextureSliceCount,
                AlphaTransitionProgressSecondTexture = propertyBlock.AlphaTransitionProgressSecondTexture,
                AlphaTransitionProgressCoordSecondTexture = propertyBlock.AlphaTransitionProgressCoordSecondTexture,
                DissolveSharpnessSecondTexture = propertyBlock.DissolveSharpnessSecondTexture,
            };
        }

        /// <summary>
        /// Set the alpha transition property values to the material.
        /// </summary>
        /// <param name="material">A NOVA distortion material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetNovaDistortionPropertyValues(Material material, INovaDistortionAlphaTransition? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new NovaAlphaTransitionMaterialProxy(material)
            {
                AlphaTransitionModeDistortion = propertyBlock.AlphaTransitionMode,  // @notice
                AlphaTransitionMapDistortion = propertyBlock.AlphaTransitionMap,    // @notice
                AlphaTransitionMapOffsetXCoord = propertyBlock.AlphaTransitionMapOffsetXCoord,
                AlphaTransitionMapOffsetYCoord = propertyBlock.AlphaTransitionMapOffsetYCoord,
                AlphaTransitionMapChannelsX = propertyBlock.AlphaTransitionMapChannelsX,
                AlphaTransitionProgress = propertyBlock.AlphaTransitionProgress,
                AlphaTransitionProgressCoord = propertyBlock.AlphaTransitionProgressCoord,
                DissolveSharpness = propertyBlock.DissolveSharpness,
            };
        }

        #endregion

        #region Emission

        /// <summary>
        /// Set the emission property values to the material.
        /// </summary>
        /// <param name="material">A NOVA uber material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetNovaUberPropertyValues(Material material, INovaUberEmission? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new NovaEmissionMaterialProxy(material)
            {
                EmissionAreaType = propertyBlock.EmissionAreaType,
                EmissionMapMode = propertyBlock.EmissionMapMode,
                EmissionMap = propertyBlock.EmissionMap,
                EmissionMap2DArray = propertyBlock.EmissionMap2DArray,
                EmissionMap3D = propertyBlock.EmissionMap3D,
                EmissionMapProgress = propertyBlock.EmissionMapProgress,
                EmissionMapProgressCoord = propertyBlock.EmissionMapProgressCoord,
                EmissionMapOffsetXCoord = propertyBlock.EmissionMapOffsetXCoord,
                EmissionMapOffsetYCoord = propertyBlock.EmissionMapOffsetYCoord,
                EmissionMapChannelsX = propertyBlock.EmissionMapChannelsX,
                EmissionMapSliceCount = propertyBlock.EmissionMapSliceCount,

                EmissionColorType = propertyBlock.EmissionColorType,
                EmissionColor = propertyBlock.EmissionColor,
                EmissionColorRamp = propertyBlock.EmissionColorRamp,

                EmissionIntensity = propertyBlock.EmissionIntensity,
                EmissionIntensityCoord = propertyBlock.EmissionIntensityCoord,
                KeepEdgeTransparency = propertyBlock.KeepEdgeTransparency,
            };
        }

        #endregion

        #region Transparency

        /// <summary>
        /// Set the transparency property values to the material.
        /// </summary>
        /// <param name="material">A NOVA uber material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetNovaUberPropertyValues(Material material, INovaUberTransparency? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new NovaTransparencyMaterialProxy(material)
            {
                RimTransparencyEnabled = propertyBlock.RimTransparencyEnabled,
                RimTransparencyProgress = propertyBlock.RimTransparencyProgress,
                RimTransparencyProgressCoord = propertyBlock.RimTransparencyProgressCoord,
                RimTransparencySharpness = propertyBlock.RimTransparencySharpness,
                RimTransparencySharpnessCoord = propertyBlock.RimTransparencySharpnessCoord,
                InverseRimTransparency = propertyBlock.InverseRimTransparency,

                LuminanceTransparencyEnabled = propertyBlock.LuminanceTransparencyEnabled,
                LuminanceTransparencyProgress = propertyBlock.LuminanceTransparencyProgress,
                LuminanceTransparencyProgressCoord = propertyBlock.LuminanceTransparencyProgressCoord,
                LuminanceTransparencySharpness = propertyBlock.LuminanceTransparencySharpness,
                LuminanceTransparencySharpnessCoord = propertyBlock.LuminanceTransparencySharpnessCoord,
                InverseLuminanceTransparency = propertyBlock.InverseLuminanceTransparency,

                SoftParticlesEnabled = propertyBlock.SoftParticlesEnabled,
                SoftParticlesIntensity = propertyBlock.SoftParticlesIntensity,

                DepthFadeEnabled = propertyBlock.DepthFadeEnabled,
                DepthFadeNear = propertyBlock.DepthFadeNear,
                DepthFadeFar = propertyBlock.DepthFadeFar,
                DepthFadeWidth = propertyBlock.DepthFadeWidth,
            };
        }

        /// <summary>
        /// Set the transparency property values to the material.
        /// </summary>
        /// <param name="material">A NOVA distortion material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetNovaDistortionPropertyValues(Material material, INovaDistortionTransparency? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new NovaTransparencyMaterialProxy(material)
            {
                SoftParticlesEnabled = propertyBlock.SoftParticlesEnabled,
                SoftParticlesIntensity = propertyBlock.SoftParticlesIntensity,

                DepthFadeEnabled = propertyBlock.DepthFadeEnabled,
                DepthFadeNear = propertyBlock.DepthFadeNear,
                DepthFadeFar = propertyBlock.DepthFadeFar,
                DepthFadeWidth = propertyBlock.DepthFadeWidth,
            };
        }

        #endregion

        #region Vertex Deformation

        /// <summary>
        /// Set the vertex deformation property values to the material.
        /// </summary>
        /// <param name="material">A NOVA uber material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetNovaUberPropertyValues(Material material, INovaUberVertexDeformation? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new NovaVertexDeformationMaterialProxy(material)
            {
                VertexDeformationEnabled = propertyBlock.VertexDeformationEnabled,

                VertexDeformationMap = propertyBlock.VertexDeformationMap,
                VertexDeformationMapOffsetXCoord = propertyBlock.VertexDeformationMapOffsetXCoord,
                VertexDeformationMapOffsetYCoord = propertyBlock.VertexDeformationMapOffsetYCoord,
                VertexDeformationMapChannel = propertyBlock.VertexDeformationMapChannel,

                VertexDeformationIntensity = propertyBlock.VertexDeformationIntensity,
                VertexDeformationIntensityCoord = propertyBlock.VertexDeformationIntensityCoord,
            };
        }

        #endregion

        #region Shadow Caster

        /// <summary>
        /// Set the shadow caster property values to the material.
        /// </summary>
        /// <param name="material">A NOVA uber material.</param>
        /// <param name="propertyBlock"></param>
        public virtual void SetNovaUberPropertyValues(Material material, INovaUberShadowCaster? propertyBlock)
        {
            if (propertyBlock is null)
            {
                return;
            }

            _ = new NovaShadowCasterMaterialProxy(material)
            {
                ShadowCasterEnabled = propertyBlock.ShadowCasterEnabled,
                ShadowCasterApplyVertexDeformation = propertyBlock.ShadowCasterApplyVertexDeformation,

                ShadowCasterAlphaTestEnabled = propertyBlock.ShadowCasterAlphaTestEnabled,
                ShadowCasterAlphaCutoff = propertyBlock.ShadowCasterAlphaCutoff,

                ShadowCasterAlphaAffectedByTintColor = propertyBlock.ShadowCasterAlphaAffectedByTintColor,
                ShadowCasterAlphaAffectedByFlowMap = propertyBlock.ShadowCasterAlphaAffectedByFlowMap,
                ShadowCasterAlphaAffectedByAlphaTransitionMap = propertyBlock.ShadowCasterAlphaAffectedByAlphaTransitionMap,
                ShadowCasterAlphaAffectedByTransparencyLuminance = propertyBlock.ShadowCasterAlphaAffectedByTransparencyLuminance,
            };
        }

        #endregion

        #endregion
    }
}