// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.Proxies
// @Class     : NovaRenderSettingMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.Proxies
{
    using Izayoi.NovaShader;
    using Izayoi.NovaShader.Extensions;
    using UnityEngine;
    using UnityEngine.Rendering;

    /// <summary>
    /// NOVA Shader Render Setting Material Proxy
    /// </summary>
    /// <remarks>
    /// ParticlesDistortion.shader
    /// ParticlesUberLit.shader
    /// ParticlesUberUnlit.shader
    /// UIParticlesUberLit.shader
    /// UIParticlesUberUnlit.shader
    /// </remarks>
    public class NovaRenderSettingMaterialProxy : NovaMaterialProxyBase
    {
        #region Constructors

        /// <summary>
        /// Create a new instance of NovaRenderSettingMaterialProxy.
        /// </summary>
        /// <param name="material">The NOVA shader material.</param>
        public NovaRenderSettingMaterialProxy(Material material) : base(material)
        {
        }

        #endregion

        #region Properties

        /// <summary>Render Type</summary>
        public NovaRenderType RenderType
        {
            get => _Material.GetSafeEnum<NovaRenderType>(PropertyNameID.RenderType, NovaRenderType.Transparent);
            set
            {
                _Material.SetSafeInt(PropertyNameID.RenderType, (int)value);

                SetupRenderAndBlend(value, TransparentBlendMode, QueueOffset, ZWriteOverride);
            }
        }

        /// <summary>Alpha Cutoff</summary>
        public float Cutoff
        {
            get => _Material.GetSafeFloat(PropertyNameID.Cutoff, PropertyRange.Cutoff.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.Cutoff, PropertyRange.Cutoff, value);
        }

        /// <summary>Transparent Blend Mode</summary>
        public NovaTransparentBlendMode TransparentBlendMode
        {
            get => _Material.GetSafeEnum<NovaTransparentBlendMode>(PropertyNameID.TransparentBlendMode, NovaTransparentBlendMode.Alpha);
            set
            {
                _Material.SetSafeInt(PropertyNameID.TransparentBlendMode, (int)value);

                SetupRenderAndBlend(RenderType, value, QueueOffset, ZWriteOverride);
            }
        }

        /// <summary>Cull</summary>
        public NovaRenderFace Cull
        {
            get => _Material.GetSafeEnum<NovaRenderFace>(PropertyNameID.Cull, NovaRenderFace.Front);
            set
            {
                _Material.SetSafeInt(PropertyNameID.Cull, (int)value);

                _Material.doubleSidedGI = value != NovaRenderFace.Front;
            }
        }

        /// <summary>Queue Offset</summary>
        public int QueueOffset
        {
            get => _Material.GetSafeInt(PropertyNameID.QueueOffset, 0);
            set
            {
                _Material.SetSafeInt(PropertyNameID.QueueOffset, value);

                SetupRenderAndBlend(RenderType, TransparentBlendMode, value, ZWriteOverride);
            }
        }

        /// <summary>Vertex Alpha Mode</summary>
        public NovaVertexAlphaMode VertexAlphaMode
        {
            get => _Material.GetSafeEnum<NovaVertexAlphaMode>(PropertyNameID.VertexAlphaMode, NovaVertexAlphaMode.Alpha);
            set
            {
                _Material.SetSafeInt(PropertyNameID.VertexAlphaMode, (int)value);

                _Material.SetSafeKeyword(Keyword.VertexAlphaAsTransitionProgress, value == NovaVertexAlphaMode.TransitionProgress);
            }
        }

        /// <summary>Blend Src</summary>
        public BlendMode BlendSrc
        {
            get => _Material.GetSafeEnum<BlendMode>(PropertyNameID.BlendSrc, BlendMode.One);
            set => _Material.SetSafeInt(PropertyNameID.BlendSrc, (int)value);
        }

        /// <summary>Blend Dst</summary>
        public BlendMode BlendDst
        {
            get => _Material.GetSafeEnum<BlendMode>(PropertyNameID.BlendDst, BlendMode.Zero);
            set => _Material.SetSafeInt(PropertyNameID.BlendDst, (int)value);
        }

        /// <summary>Z Write</summary>
        public bool ZWrite
        {
            get => _Material.GetSafeBool(PropertyNameID.ZWrite, true);
            set => _Material.SetSafeBool(PropertyNameID.ZWrite, value);
        }

        /// <summary>Z Write Override</summary>
        public NovaZWriteOverride ZWriteOverride
        {
            get => _Material.GetSafeEnum<NovaZWriteOverride>(PropertyNameID.ZWriteOverride, NovaZWriteOverride.Auto);
            set
            {
                _Material.SetSafeInt(PropertyNameID.ZWriteOverride, (int)value);

                SetupRenderAndBlend(RenderType, TransparentBlendMode, QueueOffset, value);
            }
        }

        /// <summary>Z Test</summary>
        public NovaZTest ZTest
        {
            get => _Material.GetSafeEnum<NovaZTest>(PropertyNameID.ZTest, NovaZTest.LessEqual);
            set => _Material.SetSafeInt(PropertyNameID.ZTest, (int)value);
        }

        /// <summary>Lit Workflow Mode</summary>
        /// <remarks>Lit only</remarks>
        public NovaLitWorkflowMode LitWorkflowMode
        {
            get => _Material.GetSafeEnum<NovaLitWorkflowMode>(PropertyNameID.LitWorkflowMode, NovaLitWorkflowMode.Specular);
            set
            {
                _Material.SetSafeInt(PropertyNameID.LitWorkflowMode, (int)value);

                // @notice
                _Material.SetSafeKeyword(Keyword.SpecularSetup, value == NovaLitWorkflowMode.Specular);
            }
        }

        /// <summary>Lit Receive Shadows</summary>
        /// <remarks>Lit only</remarks>
        public bool LitReceiveShadows
        {
            get => _Material.GetSafeBool(PropertyNameID.LitReceiveShadows, false);
            set
            {
                _Material.SetSafeBool(PropertyNameID.LitReceiveShadows, value);

                _Material.SetSafeKeyword(Keyword.ReceiveShadowsEnabled, value);
            }
        }

        /// <summary>Specular Highlights</summary>
        /// <remarks>Lit only</remarks>
        public bool SpecularHighlights
        {
            get => _Material.GetSafeBool(PropertyNameID.SpecularHighlights, false);
            set
            {
                _Material.SetSafeBool(PropertyNameID.SpecularHighlights, value);

                _Material.SetSafeKeyword(Keyword.SpecularHighlightsEnabled, value);
            }
        }

        /// <summary>Environment Reflections</summary>
        /// <remarks>Lit only</remarks>
        public bool EnvironmentReflections
        {
            get => _Material.GetSafeBool(PropertyNameID.EnvironmentReflections, true);
            set
            {
                _Material.SetSafeBool(PropertyNameID.EnvironmentReflections, value);

                _Material.SetSafeKeyword(Keyword.EnvironmentReflectionsEnabled, value);
            }
        }

        #endregion

        #region Public Methods

        public void SetupRenderAndBlend()
        {
            SetupRenderAndBlend(RenderType, TransparentBlendMode, QueueOffset, ZWriteOverride);
        }

        #endregion

        #region Private Methods

        private void SetupRenderAndBlend(NovaRenderType renderType, NovaTransparentBlendMode blendMode, int queueOffset, NovaZWriteOverride zWriteOverride)
        {
            if (renderType == NovaRenderType.Opaque)
            {
                _Material.SetOverrideTag(Tag.RenderType, RenderTypeValue.Opaque);

                _Material.renderQueue = (int)RenderQueue.Geometry;
                _Material.renderQueue += queueOffset;

                BlendSrc = BlendMode.One;
                BlendDst = BlendMode.Zero;

                ZWrite = GetZWriteValue(zWriteOverride, true);
            }
            else if (renderType == NovaRenderType.Cutout)
            {
                _Material.SetOverrideTag(Tag.RenderType, RenderTypeValue.TransparentCutout);

                _Material.renderQueue = (int)RenderQueue.AlphaTest;
                _Material.renderQueue += queueOffset;

                BlendSrc = BlendMode.One;
                BlendDst = BlendMode.Zero;

                ZWrite = GetZWriteValue(zWriteOverride, true);
            }
            else if (renderType == NovaRenderType.Transparent)
            {
                _Material.SetOverrideTag(Tag.RenderType, RenderTypeValue.Transparent);

                _Material.renderQueue = (int)RenderQueue.Transparent;
                _Material.renderQueue += queueOffset;

                switch (blendMode)
                {
                    case NovaTransparentBlendMode.Alpha:
                        BlendSrc = BlendMode.SrcAlpha;
                        BlendDst = BlendMode.OneMinusSrcAlpha;
                        break;
                    case NovaTransparentBlendMode.Additive:
                        BlendSrc = BlendMode.SrcAlpha;
                        BlendDst = BlendMode.One;
                        break;
                    case NovaTransparentBlendMode.Multiply:
                        BlendSrc = BlendMode.DstColor;
                        BlendDst = BlendMode.Zero;
                        break;
                }

                ZWrite = GetZWriteValue(zWriteOverride, false);
            }

            _Material.SetSafeKeyword(Keyword.AlphaTestEnabled, (renderType == NovaRenderType.Cutout));

            _Material.SetSafeKeyword(Keyword.AlphaModulateEnabled,
                (renderType == NovaRenderType.Transparent) && (blendMode == NovaTransparentBlendMode.Multiply));
        }

        private bool GetZWriteValue(NovaZWriteOverride zWriteOverride, bool defaultValue)
        {
            switch (zWriteOverride)
            {
                case NovaZWriteOverride.On:
                    return true;
                case NovaZWriteOverride.Off:
                    return false;
                case NovaZWriteOverride.Auto:
                default:
                    return defaultValue;
            }
        }

        #endregion
    }
}
