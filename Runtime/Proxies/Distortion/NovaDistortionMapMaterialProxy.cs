// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.Proxies
// @Class     : NovaDistortionMapMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.Proxies
{
    using Izayoi.NovaShader;
    using Izayoi.NovaShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// NOVA Shader Distortion Map Material Proxy
    /// </summary>
    /// <remarks>
    /// ParticlesDistortion.shader
    /// </remarks>
    public class NovaDistortionMapMaterialProxy : NovaBaseMapMaterialProxy
    {
        #region Constructors

        /// <summary>
        /// Create a new instance of NovaDistortionMaterialProxy.
        /// </summary>
        /// <param name="material">The NOVA shader material.</param>
        public NovaDistortionMapMaterialProxy(Material material) : base(material)
        {
        }

        #endregion

        #region Properties

        /// <summary>Distortion Intensity</summary>
        public float DistortionIntensity
        {
            get => _Material.GetSafeFloat(PropertyNameID.DistortionIntensity, PropertyRange.DistortionIntensity.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.DistortionIntensity, PropertyRange.DistortionIntensity, value);
        }

        /// <summary>Distortion Intensity Coord</summary>
        public NovaCustomCoord DistortionIntensityCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.DistortionIntensityCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.DistortionIntensityCoord, (int)value);
        }

        #endregion
    }
}
