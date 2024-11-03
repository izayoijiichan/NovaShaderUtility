// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.Extensions
// @Class     : NovaShaderExtension
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.Extensions
{
    using UnityEngine;

    public static class NovaShaderExtension
    {
        #region Methods

        /// <summary>
        /// Get the NOVA property entity type from the shader name.
        /// </summary>
        /// <param name="shader">A shader.</param>
        /// <returns>The NOVA property entity type.</returns>
        public static NovaPropertyEntityType GetNovaPropertyEntityType(this Shader shader)
        {
            switch (shader.name)
            {
                case ShaderName.Nova_Particles_Distortion:
                    return NovaPropertyEntityType.Distortion;
                case ShaderName.Nova_Particles_UberLit:
                case ShaderName.Nova_UIParticles_UberLit:
                    return NovaPropertyEntityType.UberLit;
                case ShaderName.Nova_Particles_UberUnlit:
                case ShaderName.Nova_UIParticles_UberUnlit:
                    return NovaPropertyEntityType.UberUnlit;
                default:
                    return NovaPropertyEntityType.None;
            }
        }

        /// <summary>
        /// Check if it is NOVA distortion from the shader name.
        /// </summary>
        /// <param name="shader">A shader.</param>
        /// <returns>Returns true if NOVA distortion; false otherwise.</returns>
        public static bool IsNovaDistortion(this Shader shader)
        {
            return shader.name == ShaderName.Nova_Particles_Distortion;
        }

        /// <summary>
        /// Check if it is NOVA Lit from the shader name.
        /// </summary>
        /// <param name="shader">A shader.</param>
        /// <returns>Returns true if NOVA Lit; false otherwise.</returns>
        public static bool IsNovaLit(this Shader shader)
        {
            return
                (shader.name == ShaderName.Nova_Particles_UberLit) ||
                (shader.name == ShaderName.Nova_UIParticles_UberLit);
        }

        /// <summary>
        /// Check if it is NOVA Unlit from the shader name.
        /// </summary>
        /// <param name="shader">A shader.</param>
        /// <returns>Returns true if NOVA Unlit; false otherwise.</returns>
        public static bool IsNovaUnlit(this Shader shader)
        {
            return
                (shader.name == ShaderName.Nova_Particles_UberUnlit) ||
                (shader.name == ShaderName.Nova_UIParticles_UberUnlit);
        }

        /// <summary>
        /// Check if it is NOVA UI Particles from the shader name.
        /// </summary>
        /// <param name="shader">A shader.</param>
        /// <returns>Returns true if NOVA UI Particles; false otherwise.</returns>
        public static bool IsNovaUIParticles(this Shader shader)
        {
            return
                (shader.name == ShaderName.Nova_UIParticles_UberLit) ||
                (shader.name == ShaderName.Nova_UIParticles_UberUnlit);
        }

        #endregion
    }
}
