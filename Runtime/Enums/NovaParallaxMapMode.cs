// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader
// @Enum      : NovaParallaxMapMode
// ----------------------------------------------------------------------
namespace Izayoi.NovaShader
{
    using System;

    /// <summary>Parallax Map Mode</summary>
    public enum NovaParallaxMapMode
    {
        SingleTexture,
        FlipBook,
        FlipBookBlending,
    }
    public static class NovaParallaxMapModeExtension
    {
        public static string ToShaderKeyword(this NovaParallaxMapMode parallaxMapMode)
        {
            switch (parallaxMapMode)
            {
                case NovaParallaxMapMode.SingleTexture:
                    return Keyword.ParallaxMapMode2D;
                case NovaParallaxMapMode.FlipBook:
                    return Keyword.ParallaxMapMode2DArray;
                case NovaParallaxMapMode.FlipBookBlending:
                    return Keyword.ParallaxMapMode3D;
                default:
                    throw new ArgumentOutOfRangeException(nameof(parallaxMapMode), parallaxMapMode, null);
            }
        }
    }
}
