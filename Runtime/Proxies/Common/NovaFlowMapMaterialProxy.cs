// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.Proxies
// @Class     : NovaFlowMapMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.Proxies
{
    using Izayoi.NovaShader;
    using Izayoi.NovaShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// NOVA Shader Flow Map Material Proxy
    /// </summary>
    /// <remarks>
    /// ParticlesDistortion.shader
    /// ParticlesUberLit.shader
    /// ParticlesUberUnlit.shader
    /// UIParticlesUberLit.shader
    /// UIParticlesUberUnlit.shader
    /// </remarks>
    public class NovaFlowMapMaterialProxy : NovaMaterialProxyBase
    {
        #region Constructors

        /// <summary>
        /// Create a new instance of NovaFlowMapMaterialProxy.
        /// </summary>
        /// <param name="material">The NOVA shader material.</param>
        public NovaFlowMapMaterialProxy(Material material) : base(material)
        {
        }

        #endregion

        #region Properties

        /// <summary>Flow Map</summary>
        public Texture2D? FlowMap
        {
            get => _Material.GetSafeTexture(PropertyNameID.FlowMap);
            set
            {
                _Material.SetSafeTexture(PropertyNameID.FlowMap, value);

                _Material.SetSafeKeyword(Keyword.FlowMapEnabled, value != null);

                SetFlowMapTargetKeywords(FlowMapTarget, value);
            }
        }

        /// <summary>Flow Map</summary>
        /// <remarks>distortion only</remarks>
        public Texture2D? FlowMapDistortion
        {
            get => _Material.GetSafeTexture(PropertyNameID.FlowMap);
            set
            {
                _Material.SetSafeTexture(PropertyNameID.FlowMap, value);

                _Material.SetSafeKeyword(Keyword.FlowMapEnabled, value != null);

                SetFlowMapTargetKeywords(FlowMapTargetDistortion, value);
            }
        }

        /// <summary>Flow Map Offset X Coord</summary>
        public NovaCustomCoord FlowMapOffsetXCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.FlowMapOffsetXCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.FlowMapOffsetXCoord, (int)value);
        }

        /// <summary>Flow Map Offset Y Coord</summary>
        public NovaCustomCoord FlowMapOffsetYCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.FlowMapOffsetYCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.FlowMapOffsetYCoord, (int)value);
        }

        /// <summary>Flow Map Channels X</summary>
        public NovaColorChannels FlowMapChannelsX
        {
            get => _Material.GetSafeEnum<NovaColorChannels>(PropertyNameID.FlowMapChannelsX, NovaColorChannels.Red);
            set => _Material.SetSafeInt(PropertyNameID.FlowMapChannelsX, (int)value);
        }

        /// <summary>Flow Map Channels Y</summary>
        public NovaColorChannels FlowMapChannelsY
        {
            get => _Material.GetSafeEnum<NovaColorChannels>(PropertyNameID.FlowMapChannelsY, NovaColorChannels.Red);
            set => _Material.SetSafeInt(PropertyNameID.FlowMapChannelsY, (int)value);
        }

        /// <summary>Flow Intensity</summary>
        public float FlowIntensity
        {
            get => _Material.GetSafeFloat(PropertyNameID.FlowIntensity, 0.0f);
            set => _Material.SetSafeFloat(PropertyNameID.FlowIntensity, value);
        }

        /// <summary>Flow Intensity Coord</summary>
        public NovaCustomCoord FlowIntensityCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.FlowIntensityCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.FlowIntensityCoord, (int)value);
        }

        /// <summary>Flow Map Target</summary>
        public NovaFlowMapTarget FlowMapTarget
        {
            get => _Material.GetSafeEnum<NovaFlowMapTarget>(PropertyNameID.FlowMapTarget, NovaFlowMapTarget.BaseMap);
            set
            {
                _Material.SetSafeInt(PropertyNameID.FlowMapTarget, (int)value);

                SetFlowMapTargetKeywords(value, FlowMap);
            }
        }

        /// <summary>Flow Map Target for Distortion</summary>
        /// <remarks>distortion only</remarks>
        public NovaFlowMapTargetDistortion FlowMapTargetDistortion
        {
            get => _Material.GetSafeEnum<NovaFlowMapTargetDistortion>(PropertyNameID.FlowMapTarget, NovaFlowMapTargetDistortion.BaseMap);
            set
            {
                _Material.SetSafeInt(PropertyNameID.FlowMapTarget, (int)value);

                SetFlowMapTargetKeywords(value, FlowMap);
            }
        }

        #endregion

        #region Private Methods

        private void SetFlowMapTargetKeywords(NovaFlowMapTarget flowMapTarget, Texture2D? flowMap)
        {
            bool hasFlowMap = flowMap != null;

            bool baseEnabled = hasFlowMap && flowMapTarget.HasFlag(NovaFlowMapTarget.BaseMap);
            bool tintEnabled = hasFlowMap && flowMapTarget.HasFlag(NovaFlowMapTarget.TintMap);
            bool emissionEnabled = hasFlowMap && flowMapTarget.HasFlag(NovaFlowMapTarget.EmissionMap);
            bool alphaTransitionEnabled = hasFlowMap && flowMapTarget.HasFlag(NovaFlowMapTarget.AlphaTransitionMap);

            _Material.SetSafeKeyword(Keyword.FlowMapTargetBase, baseEnabled);
            _Material.SetSafeKeyword(Keyword.FlowMapTargetTint, tintEnabled);
            _Material.SetSafeKeyword(Keyword.FlowMapTargetEmission, emissionEnabled);
            _Material.SetSafeKeyword(Keyword.FlowMapTargetAlphaTransition, alphaTransitionEnabled);
        }

        private void SetFlowMapTargetKeywords(NovaFlowMapTargetDistortion flowMapTarget, Texture2D? flowMap)
        {
            bool hasFlowMap = flowMap != null;

            bool baseEnabled = hasFlowMap && flowMapTarget.HasFlag(NovaFlowMapTargetDistortion.BaseMap);
            bool alphaTransitionEnabled = hasFlowMap && flowMapTarget.HasFlag(NovaFlowMapTargetDistortion.AlphaTransitionMap);

            _Material.SetSafeKeyword(Keyword.FlowMapTargetBase, baseEnabled);
            _Material.SetSafeKeyword(Keyword.FlowMapTargetAlphaTransition, alphaTransitionEnabled);
        }

        #endregion
    }
}
