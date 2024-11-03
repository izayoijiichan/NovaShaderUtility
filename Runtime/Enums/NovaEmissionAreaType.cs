// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader
// @Enum      : NovaEmissionAreaType
// ----------------------------------------------------------------------
namespace Izayoi.NovaShader
{
    using System;

    /// <summary>Emission Area Type</summary>
    public enum NovaEmissionAreaType
    {
        None,
        All,
        ByTexture,
        Edge,
    }

    public static class NovaEmissionAreaTypeExtension
    {
        public static string ToShaderKeyword(this NovaEmissionAreaType emissionAreaType)
        {
            switch (emissionAreaType)
            {
                case NovaEmissionAreaType.None:
                    return string.Empty;
                case NovaEmissionAreaType.All:
                    return Keyword.EmissionAreaAll;
                case NovaEmissionAreaType.ByTexture:
                    return Keyword.EmissionAreaMap;
                case NovaEmissionAreaType.Edge:
                    return Keyword.EmissionAreaAlpha;
                default:
                    throw new ArgumentOutOfRangeException(nameof(emissionAreaType), emissionAreaType, null);
            }
        }
    }
}