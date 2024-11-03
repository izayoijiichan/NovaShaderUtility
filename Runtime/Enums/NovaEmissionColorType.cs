// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader
// @Enum      : NovaEmissionColorType
// ----------------------------------------------------------------------
namespace Izayoi.NovaShader
{
    using System;

    /// <summary>Emission Color Type</summary>
    public enum NovaEmissionColorType
    {
        Color,
        BaseColor,
        GradientMap,
    }

    /// <summary></summary>
    public enum NovaEmissionColorTypeForAllArea
    {
        Color = NovaEmissionColorType.Color,
        BaseColor = NovaEmissionColorType.BaseColor,
    }

    public static class NovaEmissionColorTypeExtension
    {
        public static string ToShaderKeyword(this NovaEmissionColorType emissionColorType)
        {
            switch (emissionColorType)
            {
                case NovaEmissionColorType.Color:
                    return Keyword.EmissionColorColor;
                case NovaEmissionColorType.BaseColor:
                    return Keyword.EmissionColorBaseColor;
                case NovaEmissionColorType.GradientMap:
                    return Keyword.EmissionColorMap;
                default:
                    throw new ArgumentOutOfRangeException(nameof(emissionColorType), emissionColorType, null);
            }
        }
    }
}