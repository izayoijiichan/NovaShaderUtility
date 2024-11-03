// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader
// @Enum      : NovaParallaxMapTarget
// ----------------------------------------------------------------------
namespace Izayoi.NovaShader
{
    using System;

    /// <summary>Parallax Map Target</summary>
    [Flags]
    public enum NovaParallaxMapTarget
    {
        None = 0,
        BaseMap = 1 << 0,
        TintMap = 1 << 1,
        EmissionMap = 1 << 2,
    }
}
