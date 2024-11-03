// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader
// @Enum      : NovaAlphaTransitionMapMode
// ----------------------------------------------------------------------
namespace Izayoi.NovaShader
{
    using System;

    /// <summary>Alpha Transition Map Mode</summary>
    public enum NovaAlphaTransitionMapMode
    {
        SingleTexture,
        FlipBook,
        FlipBookBlending,
    }

    public static class NovaAlphaTransitionMapModeExtension
    {
        public static string ToShaderKeyword(this NovaAlphaTransitionMapMode alphaTransitionMapMode)
        {
            switch (alphaTransitionMapMode)
            {
                case NovaAlphaTransitionMapMode.SingleTexture:
                    return Keyword.AlphaTransitionMapMode2D;
                case NovaAlphaTransitionMapMode.FlipBook:
                    return Keyword.AlphaTransitionMapMode2DArray;
                case NovaAlphaTransitionMapMode.FlipBookBlending:
                    return Keyword.AlphaTransitionMapMode3D;
                default:
                    throw new ArgumentOutOfRangeException(nameof(alphaTransitionMapMode), alphaTransitionMapMode, null);
            }
        }
    }
}
