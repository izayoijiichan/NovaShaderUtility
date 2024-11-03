// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Class     : NovaDistortionRenderSetting
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    /// <summary>
    /// NOVA Distortion Shader Render Settings
    /// </summary>
    public class NovaDistortionRenderSetting : INovaDistortionRenderSetting
    {
        #region Properties

        /// <summary>Cull</summary>
        public NovaRenderFace Cull { get; set; }

        /// <summary>Z Test</summary>
        public NovaZTest ZTest { get; set; }

        #endregion
    }
}