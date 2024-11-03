// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader
// @Enum      : NovaBaseMapMode
// ----------------------------------------------------------------------
namespace Izayoi.NovaShader
{
    using System;

    /// <summary>Base Map Mode</summary>
    public enum NovaBaseMapMode
    {
        SingleTexture,
        FlipBook,
        FlipBookBlending,
    }

    public static class NovaBaseMapModeExtension
    {
        public static string ToShaderKeyword(this NovaBaseMapMode baseMapMode)
        {
            switch (baseMapMode)
            {
                case NovaBaseMapMode.SingleTexture:
                    return Keyword.BaseMapMode2D;
                case NovaBaseMapMode.FlipBook:
                    return Keyword.BaseMapMode2DArray;
                case NovaBaseMapMode.FlipBookBlending:
                    return Keyword.BaseMapMode3D;
                default:
                    throw new ArgumentOutOfRangeException(nameof(baseMapMode), baseMapMode, null);
            }
        }
    }
}
