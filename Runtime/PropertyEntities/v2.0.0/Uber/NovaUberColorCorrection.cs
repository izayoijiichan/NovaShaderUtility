// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Class     : NovaUberColorCorrection
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    using UnityEngine;

    /// <summary>
    /// NOVA Uber Shader Color Correction
    /// </summary>
    public class NovaUberColorCorrection : INovaUberColorCorrection
    {
        #region Properties

        /// <summary>Color Correction Mode</summary>
        public NovaColorCorrectionMode ColorCorrectionMode { get; set; }

        /// <summary>Gradient Map</summary>
        public Texture2D? GradientMap { get; set; }

        #endregion
    }
}