// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Interface : INovaDistortionTransparency
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    /// <summary>
    /// NOVA Distortion Shader Transparency Interface
    /// </summary>
    public interface INovaDistortionTransparency
    {
        #region Properties

        /// <summary>Soft Particles Enabled</summary>
        bool SoftParticlesEnabled { get; set; }

        /// <summary>Soft Particles Intensity</summary>
        float SoftParticlesIntensity { get; set; }

        /// <summary>Depth Fade Enabled</summary>
        bool DepthFadeEnabled { get; set; }

        /// <summary>Depth Fade Near</summary>
        float DepthFadeNear { get; set; }

        /// <summary>Depth Fade Far</summary>
        float DepthFadeFar { get; set; }

        /// <summary>Depth Fade Width</summary>
        float DepthFadeWidth { get; set; }

        #endregion
    }
}