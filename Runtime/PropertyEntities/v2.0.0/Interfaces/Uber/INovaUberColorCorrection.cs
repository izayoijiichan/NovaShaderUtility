// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Interface : INovaUberColorCorrection
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    using UnityEngine;

    /// <summary>
    /// NOVA Uber Shader Color Correction Interface
    /// </summary>
    public interface INovaUberColorCorrection
    {
        #region Properties

        /// <summary>Color Correction Mode</summary>
        NovaColorCorrectionMode ColorCorrectionMode { get; set; }

        /// <summary>Gradient Map</summary>
        Texture2D? GradientMap { get; set; }

        #endregion
    }
}