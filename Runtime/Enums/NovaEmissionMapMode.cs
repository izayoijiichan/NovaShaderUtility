// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader
// @Enum      : NovaEmissionMapMode
// ----------------------------------------------------------------------
namespace Izayoi.NovaShader
{
    using System;

    /// <summary>Emission Map Mode</summary>
    public enum NovaEmissionMapMode
    {
        SingleTexture,
        FlipBook,
        FlipBookBlending,
    }

    public static class NovaEmissionMapModeExtension
    {
        public static string ToShaderKeyword(this NovaEmissionMapMode emissionMapMode)
        {
            switch (emissionMapMode)
            {
                case NovaEmissionMapMode.SingleTexture:
                    return Keyword.EmissionMapMode2D;
                case NovaEmissionMapMode.FlipBook:
                    return Keyword.EmissionMapMode2DArray;
                case NovaEmissionMapMode.FlipBookBlending:
                    return Keyword.EmissionMapMode3D;
                default:
                    throw new ArgumentOutOfRangeException(nameof(emissionMapMode), emissionMapMode, null);
            }
        }
    }
}