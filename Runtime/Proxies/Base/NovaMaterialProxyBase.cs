// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.Proxies
// @Class     : NovaMaterialProxyBase
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.Proxies
{
    using System;
    using UnityEngine;

    /// <summary>
    /// NOVA Shader Material Proxy Base
    /// </summary>
    public abstract class NovaMaterialProxyBase
    {
        #region Fields

        /// <summary></summary>
        protected readonly Material _Material;

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of NovaMaterialProxyBase.
        /// </summary>
        /// <param name="material">The NOVA shader material.</param>
        public NovaMaterialProxyBase(Material material)
        {
            if (material == null)
            {
                throw new ArgumentNullException(nameof(material));
            }

            if (material.shader == null)
            {
                throw new ArgumentException();
            }

            _Material = material;
        }

        #endregion
    }
}