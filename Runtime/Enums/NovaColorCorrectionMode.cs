// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader
// @Enum      : NovaColorCorrectionMode
// ----------------------------------------------------------------------
namespace Izayoi.NovaShader
{
    using System;

    /// <summary>Color Correction Mode</summary>
    public enum NovaColorCorrectionMode
    {
        None,
        Greyscale,
        GradientMap,
    }

    public static class NovaColorCorrectionModeExtension
    {
        public static string ToShaderKeyword(this NovaColorCorrectionMode colorCorrectionMode)
        {
            switch (colorCorrectionMode)
            {
                case NovaColorCorrectionMode.None:
                    return string.Empty;
                case NovaColorCorrectionMode.Greyscale:
                    return Keyword.GreyscaleEnabled;
                case NovaColorCorrectionMode.GradientMap:
                    return Keyword.GradientMapEnabled;
                default:
                    throw new ArgumentOutOfRangeException(nameof(colorCorrectionMode), colorCorrectionMode, null);
            }
        }
    }
}