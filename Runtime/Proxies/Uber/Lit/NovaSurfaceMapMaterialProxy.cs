// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.Proxies
// @Class     : NovaSurfaceMapMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.Proxies
{
    using Izayoi.NovaShader;
    using Izayoi.NovaShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// NOVA Shader Surface Maps Material Proxy
    /// </summary>
    /// <remarks>
    /// ParticlesUberLit.shader
    /// UIParticlesUberLit.shader
    /// </remarks>
    public class NovaSurfaceMapMaterialProxy : NovaMaterialProxyBase
    {
        #region Constructors

        /// <summary>
        /// Create a new instance of NovaSurfaceMaterialProxy.
        /// </summary>
        /// <param name="material">The NOVA shader material.</param>
        public NovaSurfaceMapMaterialProxy(Material material) : base(material)
        {
        }

        #endregion

        #region Properties

        /// <summary>Normal Map 2D</summary>
        public Texture2D? NormalMap
        {
            get => _Material.GetSafeTexture(PropertyNameID.NormalMap);
            set
            {
                _Material.SetSafeTexture(PropertyNameID.NormalMap, value);

                SetNormalMapKeyword();
            }
        }

        /// <summary>Normal Map 2D Array</summary>
        public Texture2DArray? NormalMap2DArray
        {
            get => _Material.GetSafeTexture2DArray(PropertyNameID.NormalMap2DArray);
            set
            {
                _Material.SetSafeTexture(PropertyNameID.NormalMap2DArray, value);

                SetNormalMapKeyword();
            }
        }

        /// <summary>Normal Map 3D</summary>
        public Texture3D? NormalMap3D
        {
            get => _Material.GetSafeTexture3D(PropertyNameID.NormalMap3D);
            set
            {
                _Material.SetSafeTexture(PropertyNameID.NormalMap3D, value);

                SetNormalMapKeyword();
            }
        }

        /// <summary>Normal Map Bump Scale</summary>
        public float NormalMapBumpScale
        {
            get => _Material.GetSafeFloat(PropertyNameID.NormalMapBumpScale, 1.0f);
            set => _Material.SetSafeFloat(PropertyNameID.NormalMapBumpScale, value);
        }

        /// <summary>Specular Map 2D</summary>
        public Texture2D? SpecularMap
        {
            get => _Material.GetSafeTexture(PropertyNameID.SpecularMap);
            set
            {
                _Material.SetSafeTexture(PropertyNameID.SpecularMap, value);

                SetSpecularMapKeyword();
            }
        }

        /// <summary>Specular Map 2D Array</summary>
        public Texture2DArray? SpecularMap2DArray
        {
            get => _Material.GetSafeTexture2DArray(PropertyNameID.SpecularMap2DArray);
            set
            {
                _Material.SetSafeTexture(PropertyNameID.SpecularMap2DArray, value);

                SetSpecularMapKeyword();
            }
        }

        /// <summary>Specular Map 3D</summary>
        public Texture3D? SpecularMap3D
        {
            get => _Material.GetSafeTexture3D(PropertyNameID.SpecularMap3D);
            set
            {
                _Material.SetSafeTexture(PropertyNameID.SpecularMap3D, value);

                SetSpecularMapKeyword();
            }
        }

        /// <summary>Specular Color</summary>
        public Color SpecularColor
        {
            get => _Material.GetSafeColor(PropertyNameID.SpecularColor, Color.white);
            set => _Material.SetSafeColor(PropertyNameID.SpecularColor, value);
        }

        /// <summary>Specular Map Channels X</summary>
        public NovaColorChannels SpecularMapChannelsX
        {
            get => _Material.GetSafeEnum<NovaColorChannels>(PropertyNameID.SpecularMapChannelsX, NovaColorChannels.Red);
            set => _Material.SetSafeInt(PropertyNameID.SpecularMapChannelsX, (int)value);
        }

        /// <summary>Metallic Map 2D</summary>
        public Texture2D? MetallicMap
        {
            get => _Material.GetSafeTexture(PropertyNameID.MetallicMap);
            set
            {
                _Material.SetSafeTexture(PropertyNameID.MetallicMap, value);

                SetMetallicMapKeyword();
            }
        }

        /// <summary>Metallic Map 2D Array</summary>
        public Texture2DArray? MetallicMap2DArray
        {
            get => _Material.GetSafeTexture2DArray(PropertyNameID.MetallicMap2DArray);
            set
            {
                _Material.SetSafeTexture(PropertyNameID.MetallicMap2DArray, value);

                SetMetallicMapKeyword();
            }
        }

        /// <summary>Metallic Map 3D</summary>
        public Texture3D? MetallicMap3D
        {
            get => _Material.GetSafeTexture3D(PropertyNameID.MetallicMap3D);
            set
            {
                _Material.SetSafeTexture(PropertyNameID.MetallicMap3D, value);

                SetMetallicMapKeyword();
            }
        }

        /// <summary>Metallic</summary>
        public float Metallic
        {
            get => _Material.GetSafeFloat(PropertyNameID.Metallic, PropertyRange.Metallic.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.Metallic, PropertyRange.Metallic, value);
        }

        /// <summary>Metallic Map Channels X</summary>
        public NovaColorChannels MetallicMapChannelsX
        {
            get => _Material.GetSafeEnum<NovaColorChannels>(PropertyNameID.MetallicMapChannelsX, NovaColorChannels.Red);
            set => _Material.SetSafeInt(PropertyNameID.MetallicMapChannelsX, (int)value);
        }

        /// <summary>Smoothness Map 2D</summary>
        public Texture2D? SmoothnessMap
        {
            get => _Material.GetSafeTexture(PropertyNameID.SmoothnessMap);
            set
            {
                _Material.SetSafeTexture(PropertyNameID.SmoothnessMap, value);

                SetSmoothnessMapKeyword();
            }
        }

        /// <summary>Smoothness Map 2D Array</summary>
        public Texture2DArray? SmoothnessMap2DArray
        {
            get => _Material.GetSafeTexture2DArray(PropertyNameID.SmoothnessMap2DArray);
            set
            {
                _Material.SetSafeTexture(PropertyNameID.SmoothnessMap2DArray, value);

                SetSmoothnessMapKeyword();
            }
        }

        /// <summary>Smoothness Map 3D</summary>
        public Texture3D? SmoothnessMap3D
        {
            get => _Material.GetSafeTexture3D(PropertyNameID.SmoothnessMap3D);
            set
            {
                _Material.SetSafeTexture(PropertyNameID.SmoothnessMap3D, value);

                SetSmoothnessMapKeyword();
            }
        }

        /// <summary>Smoothness</summary>
        public float Smoothness
        {
            get => _Material.GetSafeFloat(PropertyNameID.Smoothness, PropertyRange.Smoothness.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.Smoothness, PropertyRange.Smoothness, value);
        }

        /// <summary>Smoothness Map Channels X</summary>
        public NovaColorChannels SmoothnessMapChannelsX
        {
            get => _Material.GetSafeEnum<NovaColorChannels>(PropertyNameID.SmoothnessMapChannelsX, NovaColorChannels.Alpha);
            set => _Material.SetSafeInt(PropertyNameID.SmoothnessMapChannelsX, (int)value);
        }

        /// <summary>Base Map Mode</summary>
        private NovaBaseMapMode BaseMapMode
            => _Material.GetSafeEnum<NovaBaseMapMode>(PropertyNameID.BaseMapMode, NovaBaseMapMode.SingleTexture);

        #endregion

        #region Private Methods

        private void SetMetallicMapKeyword()
        {
            bool enabled = HasSurfaceMap(
                PropertyNameID.MetallicMap,
                PropertyNameID.MetallicMap2DArray,
                PropertyNameID.MetallicMap3D);

            _Material.SetSafeKeyword(Keyword.MetallicMapEnabled, enabled);
        }

        private void SetNormalMapKeyword()
        {
            bool enabled = HasSurfaceMap(
                PropertyNameID.NormalMap,
                PropertyNameID.NormalMap2DArray,
                PropertyNameID.NormalMap3D);

            _Material.SetSafeKeyword(Keyword.NormalMapEnabled, enabled);
        }

        private void SetSmoothnessMapKeyword()
        {
            bool enabled = HasSurfaceMap(
                PropertyNameID.SmoothnessMap,
                PropertyNameID.SmoothnessMap2DArray,
                PropertyNameID.SmoothnessMap3D);

            _Material.SetSafeKeyword(Keyword.SmoothnessMapEnabled, enabled);
        }

        private void SetSpecularMapKeyword()
        {
            bool enabled = HasSurfaceMap(
                PropertyNameID.SpecularMap,
                PropertyNameID.SpecularMap2DArray,
                PropertyNameID.SpecularMap3D);

            _Material.SetSafeKeyword(Keyword.SpecularMapEnabled, enabled);
        }

        private bool HasSurfaceMap(int map2DId, int map2DArrayId, int map3DId)
        {
            switch (BaseMapMode)
            {
                case NovaBaseMapMode.SingleTexture:
                    return _Material.GetSafeTexture(map2DId) != null;
                case NovaBaseMapMode.FlipBook:
                    return _Material.GetSafeTexture(map2DArrayId) != null;
                case NovaBaseMapMode.FlipBookBlending:
                    return _Material.GetSafeTexture(map3DId) != null;
                default:
                    return false;
            }
        }

        #endregion
    }
}
