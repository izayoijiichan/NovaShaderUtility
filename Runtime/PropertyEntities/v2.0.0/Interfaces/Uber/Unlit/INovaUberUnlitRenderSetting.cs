// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Interface : INovaUberUnlitRenderSetting
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    using UnityEngine.Rendering;

    /// <summary>
    /// NOVA Uber Unlit Shader Render Settings Interface
    /// </summary>
    public interface INovaUberUnlitRenderSetting
    {
        #region Properties

        /// <summary>Render Type</summary>
        NovaRenderType RenderType { get; set; }

        /// <summary>Alpha Cutoff</summary>
        float Cutoff { get; set; }

        /// <summary>Transparent Blend Mode</summary>
        NovaTransparentBlendMode TransparentBlendMode { get; set; }

        /// <summary>Cull</summary>
        NovaRenderFace Cull { get; set; }

        /// <summary>Queue Offset</summary>
        int QueueOffset { get; set; }

        /// <summary>Vertex Alpha Mode</summary>
        NovaVertexAlphaMode VertexAlphaMode { get; set; }

        /// <summary>Blend Src</summary>
        BlendMode BlendSrc { get; set; }

        /// <summary>Blend Dst</summary>
        BlendMode BlendDst { get; set; }

        /// <summary>Z Write</summary>
        bool ZWrite { get; set; }

        /// <summary>Z Write Override</summary>
        NovaZWriteOverride ZWriteOverride { get; set; }

        /// <summary>Z Test</summary>
        NovaZTest ZTest { get; set; }

        #endregion
    }
}