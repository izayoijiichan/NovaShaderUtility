// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Class     : NovaUberUnlitRenderSetting
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    using UnityEngine.Rendering;

    /// <summary>
    /// NOVA Uber Unlit Shader Render Settings
    /// </summary>
    public class NovaUberUnlitRenderSetting : INovaUberUnlitRenderSetting
    {
        #region Properties

        /// <summary>Render Type</summary>
        public NovaRenderType RenderType { get; set; }

        /// <summary>Alpha Cutoff</summary>
        public float Cutoff { get; set; }

        /// <summary>Transparent Blend Mode</summary>
        public NovaTransparentBlendMode TransparentBlendMode { get; set; }

        /// <summary>Cull</summary>
        public NovaRenderFace Cull { get; set; }

        /// <summary>Queue Offset</summary>
        public int QueueOffset { get; set; }

        /// <summary>Vertex Alpha Mode</summary>
        public NovaVertexAlphaMode VertexAlphaMode { get; set; }

        /// <summary>Blend Src</summary>
        public BlendMode BlendSrc { get; set; }

        /// <summary>Blend Dst</summary>
        public BlendMode BlendDst { get; set; }

        /// <summary>Z Write</summary>
        public bool ZWrite { get; set; }

        /// <summary>Z Write Override</summary>
        public NovaZWriteOverride ZWriteOverride { get; set; }

        /// <summary>Z Test</summary>
        public NovaZTest ZTest { get; set; }

        #endregion
    }
}