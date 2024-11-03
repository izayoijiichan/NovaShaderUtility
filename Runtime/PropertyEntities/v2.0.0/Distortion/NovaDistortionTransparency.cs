// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Class     : NovaDistortionTransparency
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    /// <summary>
    /// NOVA Distortion Shader Transparency
    /// </summary>
    public class NovaDistortionTransparency : INovaDistortionTransparency
    {
        #region Properties

        /// <summary>Soft Particles Enabled</summary>
        public bool SoftParticlesEnabled { get; set; }

        /// <summary>Soft Particles Intensity</summary>
        public float SoftParticlesIntensity { get; set; }

        /// <summary>Depth Fade Enabled</summary>
        public bool DepthFadeEnabled { get; set; }

        /// <summary>Depth Fade Near</summary>
        public float DepthFadeNear { get; set; }

        /// <summary>Depth Fade Far</summary>
        public float DepthFadeFar { get; set; }

        /// <summary>Depth Fade Width</summary>
        public float DepthFadeWidth { get; set; }

        #endregion
    }
}