// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.Proxies.Uber
// @Class     : NovaColorCorrectionMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.Proxies.Uber
{
    using Izayoi.NovaShader;
    using Izayoi.NovaShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// NOVA Shader Color Correction Material Proxy
    /// </summary>
    /// <remarks>
    /// ParticlesUberLit.shader
    /// ParticlesUberUnlit.shader
    /// UIParticlesUberLit.shader
    /// UIParticlesUberUnlit.shader
    /// </remarks>
    public class NovaColorCorrectionMaterialProxy : NovaMaterialProxyBase
    {
        #region Constructors

        /// <summary>
        /// Create a new instance of NovaColorCorrectionMaterialProxy.
        /// </summary>
        /// <param name="material">The NOVA shader material.</param>
        public NovaColorCorrectionMaterialProxy(Material material) : base(material)
        {
        }

        #endregion

        #region Properties

        /// <summary>Color Correction Mode</summary>
        public NovaColorCorrectionMode ColorCorrectionMode
        {
            get => _Material.GetSafeEnum<NovaColorCorrectionMode>(PropertyNameID.ColorCorrectionMode, NovaColorCorrectionMode.None);
            set
            {
                _Material.SetSafeInt(PropertyNameID.ColorCorrectionMode, (int)value);

                _Material.SetSafeKeyword(Keyword.GreyscaleEnabled, value == NovaColorCorrectionMode.Greyscale);

                SetGradientMapKeyword(value, GradientMap);
            }
        }

        /// <summary>Gradient Map</summary>
        public Texture2D? GradientMap
        {
            get => _Material.GetSafeTexture(PropertyNameID.GradientMap);
            set
            {
                _Material.SetSafeTexture(PropertyNameID.GradientMap, value);

                SetGradientMapKeyword(ColorCorrectionMode, value);
            }
        }

        #endregion

        #region Private Methods

        private void SetGradientMapKeyword(NovaColorCorrectionMode colorCorrectionMode, Texture2D? gradientMap)
        {
            bool enabled = 
                (colorCorrectionMode == NovaColorCorrectionMode.GradientMap) && 
                (gradientMap != null);

            _Material.SetSafeKeyword(Keyword.GradientMapEnabled, enabled);
        }

        #endregion
    }
}
