// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Class     : NovaPropertyContainer
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    /// <summary>
    /// NOVA Shader Property Container
    /// </summary>
    public class NovaPropertyContainer : NovaPropertyContainerBase
    {
        /// <summary>Distortion Property Entity</summary>
        public NovaDistortionPropertyEntity? DistortionProperty { get; set; }

        /// <summary>Uber Lit Property Entity</summary>
        public NovaUberLitPropertyEntity? UberLitProperty { get; set; }

        /// <summary>Uber Unlit Property Entity</summary>
        public NovaUberUnlitPropertyEntity? UberUnlitProperty { get; set; }
    }
}