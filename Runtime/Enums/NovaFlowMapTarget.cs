// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader
// @Enum      : NovaFlowMapTarget
// ----------------------------------------------------------------------
namespace Izayoi.NovaShader
{
    using System;

    /// <summary>Flow Map Target</summary>
    [Flags]
    public enum NovaFlowMapTarget
    {
        None = 0,
        BaseMap = 1 << 0,
        TintMap = 1 << 1,
        AlphaTransitionMap = 1 << 2,
        EmissionMap = 1 << 3
    }

    /// <summary>FlowMap Target Distortion</summary>
    [Flags]
    public enum NovaFlowMapTargetDistortion
    {
        None = 0,
        BaseMap = 1 << 0,
        AlphaTransitionMap = 1 << 1,
    }
}