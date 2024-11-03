// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Interface : INovaUberTransparency
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    /// <summary>
    /// NOVA Uber Shader Transparency Interface
    /// </summary>
    public interface INovaUberTransparency
    {
        #region Properties

        /// <summary>Rim Transparency Enabled</summary>
        bool RimTransparencyEnabled { get; set; }

        /// <summary>Rim Transparency Progress</summary>
        float RimTransparencyProgress { get; set; }

        /// <summary>Rim Transparency Progress Coord</summary>
        NovaCustomCoord RimTransparencyProgressCoord { get; set; }

        /// <summary>Rim Transparency Sharpness</summary>
        float RimTransparencySharpness { get; set; }

        /// <summary>Rim Transparency Sharpness Coord</summary>
        NovaCustomCoord RimTransparencySharpnessCoord { get; set; }

        /// <summary>Inverse Rim Transparency</summary>
        bool InverseRimTransparency { get; set; }

        /// <summary>Luminance Transparency Enabled</summary>
        bool LuminanceTransparencyEnabled { get; set; }

        /// <summary>Luminance Transparency Progress</summary>
        float LuminanceTransparencyProgress { get; set; }

        /// <summary>Luminance Transparency Progress Coord</summary>
        NovaCustomCoord LuminanceTransparencyProgressCoord { get; set; }

        /// <summary>Luminance Transparency Sharpness</summary>
        float LuminanceTransparencySharpness { get; set; }

        /// <summary>Luminance Transparency Sharpness Coord</summary>
        NovaCustomCoord LuminanceTransparencySharpnessCoord { get; set; }

        /// <summary>Inverse Luminance Transparency</summary>
        bool InverseLuminanceTransparency { get; set; }

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