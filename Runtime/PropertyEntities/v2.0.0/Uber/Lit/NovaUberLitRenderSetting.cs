// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.v2_0_0
// @Class     : NovaUberLitRenderSetting
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.v2_0_0
{
    using UnityEngine.Rendering;

    /// <summary>
    /// NOVA Uber Lit Shader Render Settings
    /// </summary>
    public class NovaUberLitRenderSetting : INovaUberLitRenderSetting
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

        /// <summary>Lit Workflow Mode</summary>
        /// <remarks>Lit only</remarks>
        public NovaLitWorkflowMode LitWorkflowMode { get; set; }

        /// <summary>Lit Receive Shadows</summary>
        /// <remarks>Lit only</remarks>
        public bool LitReceiveShadows { get; set; }

        /// <summary>Specular Highlights</summary>
        /// <remarks>Lit only</remarks>
        public bool SpecularHighlights { get; set; }

        /// <summary>Environment Reflections</summary>
        /// <remarks>Lit only</remarks>
        public bool EnvironmentReflections { get; set; }

        #endregion
    }
}