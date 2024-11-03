// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader
// @Enum      : NovaTintAreaMode
// ----------------------------------------------------------------------
namespace Izayoi.NovaShader
{
    using System;

    /// <summary>Tint Area Mode</summary>
    public enum NovaTintAreaMode
    {
        None,
        All,
        Rim,
    }

    public static class NovaTintAreaModeExtension
    {
        public static string ToShaderKeyword(this NovaTintAreaMode tintAreaMode)
        {
            switch (tintAreaMode)
            {
                case NovaTintAreaMode.None:
                    return string.Empty;
                case NovaTintAreaMode.All:
                    return Keyword.TintAreaAll;
                case NovaTintAreaMode.Rim:
                    return Keyword.TintAreaRim;
                default:
                    throw new ArgumentOutOfRangeException(nameof(tintAreaMode), tintAreaMode, null);
            }
        }
    }
}