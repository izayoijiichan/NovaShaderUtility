// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader
// @Class     : NovaUtility
// ----------------------------------------------------------------------
#if !NOVA_SHADER_2_0_OR_NEWER
#define NOVA_SHADER_2_0_OR_NEWER
#endif
#nullable enable
namespace Izayoi.NovaShader
{
    using UnityEngine;

#if NOVA_SHADER_2_0_OR_NEWER
    using Izayoi.NovaShader.v2_0_0;
#endif

    /// <summary>
    /// NOVA Shader Utility
    /// </summary>
    public class NovaUtility
    {
        #region Fields

#pragma warning disable IDE0090
        /// <summary>A NOVA material getter.</summary>
        protected readonly NovaMaterialGetter _MaterialGetter = new NovaMaterialGetter();

        /// <summary>A NOVA material setter.</summary>
        protected readonly NovaMaterialSetter _MaterialSetter = new NovaMaterialSetter();
#pragma warning restore IDE0090

        #endregion

        #region Properties

        /// <summary>A NOVA material getter.</summary>
        public NovaMaterialGetter MaterialGetter => _MaterialGetter;

        /// <summary>A NOVA material setter.</summary>
        public NovaMaterialSetter MaterialSetter => _MaterialSetter;

        #endregion

        #region Methods

        /// <summary>
        /// Get the property values from the material.
        /// </summary>
        /// <param name="material">A NOVA material.</param>
        /// <returns>A Nova property container.</returns>
        public virtual NovaPropertyContainer GetPropertyValuesFromMaterial(Material material)
        {
            return _MaterialGetter.GetNovaPropertyContainer(material);
        }

        /// <summary>
        /// Set the property values to the material.
        /// </summary>
        /// <param name="material">A NOVA material.</param>
        /// <param name="propertyContainer">A NOVA property container.</param>
        public virtual void SetPropertyValuesToMaterial(Material material, NovaPropertyContainer propertyContainer)
        {
            _MaterialSetter.SetNovaPropertyValues(material, propertyContainer);
        }

        #endregion
    }
}