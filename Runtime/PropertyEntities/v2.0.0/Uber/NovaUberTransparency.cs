// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Class     : NovaUberTransparency
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    /// <summary>
    /// NOVA Uber Shader Transparency
    /// </summary>
    public class NovaUberTransparency : INovaUberTransparency
    {
        #region Properties

        /// <summary>Rim Transparency Enabled</summary>
        public bool RimTransparencyEnabled { get; set; }

        /// <summary>Rim Transparency Progress</summary>
        public float RimTransparencyProgress { get; set; }

        /// <summary>Rim Transparency Progress Coord</summary>
        public NovaCustomCoord RimTransparencyProgressCoord { get; set; }

        /// <summary>Rim Transparency Sharpness</summary>
        public float RimTransparencySharpness { get; set; }

        /// <summary>Rim Transparency Sharpness Coord</summary>
        public NovaCustomCoord RimTransparencySharpnessCoord { get; set; }

        /// <summary>Inverse Rim Transparency</summary>
        public bool InverseRimTransparency { get; set; }

        /// <summary>Luminance Transparency Enabled</summary>
        public bool LuminanceTransparencyEnabled { get; set; }

        /// <summary>Luminance Transparency Progress</summary>
        public float LuminanceTransparencyProgress { get; set; }

        /// <summary>Luminance Transparency Progress Coord</summary>
        public NovaCustomCoord LuminanceTransparencyProgressCoord { get; set; }

        /// <summary>Luminance Transparency Sharpness</summary>
        public float LuminanceTransparencySharpness { get; set; }

        /// <summary>Luminance Transparency Sharpness Coord</summary>
        public NovaCustomCoord LuminanceTransparencySharpnessCoord { get; set; }

        /// <summary>Inverse Luminance Transparency</summary>
        public bool InverseLuminanceTransparency { get; set; }

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