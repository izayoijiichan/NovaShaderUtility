// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Interface : INovaDistortionRenderSetting
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    /// <summary>
    /// NOVA Distortion Shader Render Settings Interface
    /// </summary>
    public interface INovaDistortionRenderSetting
    {
        #region Properties

        /// <summary>Cull</summary>
        NovaRenderFace Cull { get; set; }

        /// <summary>Z Test</summary>
        NovaZTest ZTest { get; set; }

        #endregion
    }
}