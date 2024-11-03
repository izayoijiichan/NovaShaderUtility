// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader
// @Enum      : NovaTintColorMode
// ----------------------------------------------------------------------
namespace Izayoi.NovaShader
{
    using System;

    /// <summary>Tint Color Mode</summary>
    public enum NovaTintColorMode
    {
        SingleColor,
        Texture2D,
        Texture3D,
    }

    public static class NovaTintColorModeExtension
    {
        public static string ToShaderKeyword(this NovaTintColorMode tintColorMode)
        {
            switch (tintColorMode)
            {
                case NovaTintColorMode.SingleColor:
                    return Keyword.TintColorEnabled;
                case NovaTintColorMode.Texture2D:
                    return Keyword.TintMapEnabled;
                case NovaTintColorMode.Texture3D:
                    return Keyword.TintMap3DEnabled;
                default:
                    throw new ArgumentOutOfRangeException(nameof(tintColorMode), tintColorMode, null);
            }
        }
    }
}