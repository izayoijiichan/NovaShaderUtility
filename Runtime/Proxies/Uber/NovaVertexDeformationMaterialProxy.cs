// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.Proxies.Uber
// @Class     : NovaVertexDeformationMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.Proxies.Uber
{
    using Izayoi.NovaShader;
    using Izayoi.NovaShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// NOVA Shader Vertex Deformation Material Proxy
    /// </summary>
    /// <remarks>
    /// ParticlesUberLit.shader
    /// ParticlesUberUnlit.shader
    /// UIParticlesUberLit.shader
    /// UIParticlesUberUnlit.shader
    /// </remarks>
    public class NovaVertexDeformationMaterialProxy : NovaMaterialProxyBase
    {
        #region Constructors

        /// <summary>
        /// Create a new instance of NovaVertexDeformationMaterialProxy.
        /// </summary>
        /// <param name="material">The NOVA shader material.</param>
        public NovaVertexDeformationMaterialProxy(Material material) : base(material)
        {
        }

        #endregion

        #region Properties

        /// <summary>Vertex Deformation Enabled</summary>
        public bool VertexDeformationEnabled
        {
            get => _Material.GetSafeBool(PropertyNameID.VertexDeformationEnabled, false);
            set
            {
                _Material.SetSafeBool(PropertyNameID.VertexDeformationEnabled, value);

                _Material.SetSafeKeyword(Keyword.VertexDeformationEnabled, value);
            }
        }

        /// <summary>Vertex Deformation Map</summary>
        public Texture2D? VertexDeformationMap
        {
            get => _Material.GetSafeTexture(PropertyNameID.VertexDeformationMap);
            set => _Material.SetSafeTexture(PropertyNameID.VertexDeformationMap, value);
        }

        /// <summary>Vertex Deformation Map Offset X Coord</summary>
        public NovaCustomCoord VertexDeformationMapOffsetXCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.VertexDeformationMapOffsetXCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.VertexDeformationMapOffsetXCoord, (int)value);
        }

        /// <summary>Vertex Deformation Map Offset Y Coord</summary>
        public NovaCustomCoord VertexDeformationMapOffsetYCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.VertexDeformationMapOffsetYCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.VertexDeformationMapOffsetYCoord, (int)value);
        }

        /// <summary>Vertex Deformation Map Channel</summary>
        public NovaColorChannels VertexDeformationMapChannel
        {
            get => _Material.GetSafeEnum<NovaColorChannels>(PropertyNameID.VertexDeformationMapChannel, NovaColorChannels.Red);
            set => _Material.SetSafeInt(PropertyNameID.VertexDeformationMapChannel, (int)value);
        }

        /// <summary>Vertex Deformation Intensity</summary>
        public float VertexDeformationIntensity
        {
            get => _Material.GetSafeFloat(PropertyNameID.VertexDeformationIntensity, 0.1f);
            set => _Material.SetSafeFloat(PropertyNameID.VertexDeformationIntensity, value);
        }

        /// <summary>Vertex Deformation Intensity Coord</summary>
        public NovaCustomCoord VertexDeformationIntensityCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.VertexDeformationIntensityCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.VertexDeformationIntensityCoord, (int)value);
        }

        #endregion
    }
}
