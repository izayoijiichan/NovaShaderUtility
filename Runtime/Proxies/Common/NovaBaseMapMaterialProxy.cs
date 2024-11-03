// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader.Proxies
// @Class     : NovaBaseMapMaterialProxy
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader.Proxies
{
    using Izayoi.NovaShader;
    using Izayoi.NovaShader.Extensions;
    using UnityEngine;

    /// <summary>
    /// NOVA Shader Base Map Material Proxy
    /// </summary>
    /// <remarks>
    /// ParticlesUberLit.shader
    /// ParticlesUberUnlit.shader
    /// UIParticlesUberLit.shader
    /// UIParticlesUberUnlit.shader
    /// </remarks>
    public class NovaBaseMapMaterialProxy : NovaMaterialProxyBase
    {
        #region Constructors

        /// <summary>
        /// Create a new instance of NovaBaseMapMaterialProxy.
        /// </summary>
        /// <param name="material">The NOVA shader material.</param>
        public NovaBaseMapMaterialProxy(Material material) : base(material)
        {
        }

        #endregion

        #region Properties

        /// <summary>Base Map Mode</summary>
        public NovaBaseMapMode BaseMapMode
        {
            get => _Material.GetSafeEnum<NovaBaseMapMode>(PropertyNameID.BaseMapMode, NovaBaseMapMode.SingleTexture);
            set
            {
                _Material.SetSafeInt(PropertyNameID.BaseMapMode, (int)value);

                SetBaseMapMode2DKeyword(value, BaseMap);
                SetBaseMapMode2DArrayKeyword(value, BaseMap2DArray);
                SetBaseMapMode3DKeyword(value, BaseMap3D);
            }
        }

        /// <summary>Base Map 2D</summary>
        public Texture2D? BaseMap
        {
            get => _Material.GetSafeTexture(PropertyNameID.BaseMap);
            set
            {
                _Material.SetSafeTexture(PropertyNameID.BaseMap, value);

                SetBaseMapMode2DKeyword(BaseMapMode, value);

                SetBaseSamplerStateKeywords(BaseMapMirrorSampling, BaseMap);
            }
        }

        /// <summary>Base Map 2D Array</summary>
        public Texture2DArray? BaseMap2DArray
        {
            get => _Material.GetSafeTexture2DArray(PropertyNameID.BaseMap2DArray);
            set
            {
                _Material.SetSafeTexture(PropertyNameID.BaseMap2DArray, value);

                SetBaseMapMode2DArrayKeyword(BaseMapMode, value);
            }
        }

        /// <summary>Base Map 3D</summary>
        public Texture3D? BaseMap3D
        {
            get => _Material.GetSafeTexture3D(PropertyNameID.BaseMap3D);
            set
            {
                _Material.SetSafeTexture(PropertyNameID.BaseMap3D, value);

                SetBaseMapMode3DKeyword(BaseMapMode, value);
            }
        }

        /// <summary>Base Map Progress</summary>
        public float BaseMapProgress
        {
            get => _Material.GetSafeFloat(PropertyNameID.BaseMapProgress, PropertyRange.BaseMapProgress.defaultValue);
            set => _Material.SetSafeFloat(PropertyNameID.BaseMapProgress, PropertyRange.BaseMapProgress, value);
        }

        /// <summary>Base Map Progress Coord</summary>
        public NovaCustomCoord BaseMapProgressCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.BaseMapProgressCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.BaseMapProgressCoord, (int)value);
        }

        /// <summary>Base Map Slice Count</summary>
        public float BaseMapSliceCount
        {
            get => _Material.GetSafeFloat(PropertyNameID.BaseMapSliceCount, 4.0f);
            set => _Material.SetSafeFloat(PropertyNameID.BaseMapSliceCount, value);
        }

        /// <summary>Base Map Offset X Coord</summary>
        public NovaCustomCoord BaseMapOffsetXCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.BaseMapOffsetXCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.BaseMapOffsetXCoord, (int)value);
        }

        /// <summary>Base Map Offset Y Coord</summary>
        public NovaCustomCoord BaseMapOffsetYCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.BaseMapOffsetYCoord, NovaCustomCoord.Unused);
            set => _Material.SetSafeInt(PropertyNameID.BaseMapOffsetYCoord, (int)value);
        }

        /// <summary>Base Map Channels X</summary>
        /// <remarks>distortion only</remarks>
        public NovaColorChannels BaseMapChannelsX
        {
            get => _Material.GetSafeEnum<NovaColorChannels>(PropertyNameID.BaseMapChannelsX, NovaColorChannels.Red);
            set => _Material.SetSafeInt(PropertyNameID.BaseMapChannelsX, (int)value);
        }

        /// <summary>Base Map Channels Y</summary>
        /// <remarks>distortion only</remarks>
        public NovaColorChannels BaseMapChannelsY
        {
            get => _Material.GetSafeEnum<NovaColorChannels>(PropertyNameID.BaseMapChannelsY, NovaColorChannels.Green);
            set => _Material.SetSafeInt(PropertyNameID.BaseMapChannelsY, (int)value);
        }

        /// <summary>Base Map Rotation</summary>
        public float BaseMapRotation
        {
            get => _Material.GetSafeFloat(PropertyNameID.BaseMapRotation, PropertyRange.BaseMapRotation.defaultValue);
            set
            {
                _Material.SetSafeFloat(PropertyNameID.BaseMapRotation, PropertyRange.BaseMapRotation, value);

                SetBaseMapRotationKeyword();
            }
        }

        /// <summary>Base Map Rotation Coord</summary>
        public NovaCustomCoord BaseMapRotationCoord
        {
            get => _Material.GetSafeEnum<NovaCustomCoord>(PropertyNameID.BaseMapRotationCoord, NovaCustomCoord.Unused);
            set
            {
                _Material.SetSafeInt(PropertyNameID.BaseMapRotationCoord, (int)value);

                SetBaseMapRotationKeyword();
            }
        }

        /// <summary>Base Map Rotation Offsets</summary>
        public Vector4 BaseMapRotationOffsets
        {
            get => _Material.GetSafeVector4(PropertyNameID.BaseMapRotationOffsets, Vector4.zero);
            set => _Material.SetSafeVector(PropertyNameID.BaseMapRotationOffsets, value);
        }

        /// <summary>Base Map Mirror Sampling</summary>
        public bool BaseMapMirrorSampling
        {
            get => _Material.GetSafeBool(PropertyNameID.BaseMapMirrorSampling, false);
            set
            {
                 _Material.SetSafeBool(PropertyNameID.BaseMapMirrorSampling, value);

                SetBaseSamplerStateKeywords(value, BaseMap);
            }
        }

        #endregion

        #region Private Methods

        private void SetBaseMapMode2DKeyword(NovaBaseMapMode baseMapMode, Texture2D? baseMap2D)
        {
            bool enabled =
                (baseMapMode == NovaBaseMapMode.SingleTexture) &&
                (baseMap2D != null);

            _Material.SetSafeKeyword(Keyword.BaseMapMode2D, enabled);
        }

        private void SetBaseMapMode2DArrayKeyword(NovaBaseMapMode baseMapMode, Texture2DArray? baseMap2DArray)
        {
            bool enabled =
                (baseMapMode == NovaBaseMapMode.FlipBook) &&
                (baseMap2DArray != null);

            _Material.SetSafeKeyword(Keyword.BaseMapMode2DArray, enabled);
        }

        private void SetBaseMapMode3DKeyword(NovaBaseMapMode baseMapMode, Texture3D? baseMap3D)
        {
            bool enabled =
                (baseMapMode == NovaBaseMapMode.FlipBookBlending) &&
                (baseMap3D != null);

            _Material.SetSafeKeyword(Keyword.BaseMapMode3D, enabled);
        }

        private void SetBaseMapRotationKeyword()
        {
            bool enabled =
                (BaseMapRotation != 0) ||
                (BaseMapRotationCoord != NovaCustomCoord.Unused);

            _Material.SetSafeKeyword(Keyword.BaseMapRotationEnabled, enabled);
        }

        private void SetBaseSamplerStateKeywords(bool baseMapMirrorSampling, Texture2D? baseMap)
        {
            bool pointMirrorEnabled = false;
            bool linearMirrorEnabled = false;
            bool trilinearMirrorEnabled = false;

            if (baseMapMirrorSampling)
            {
                if (baseMap != null)
                {
                    switch (baseMap.filterMode)
                    {
                        case FilterMode.Point:
                            pointMirrorEnabled = true;
                            break;
                        case FilterMode.Bilinear:
                            linearMirrorEnabled = true;
                            break;
                        case FilterMode.Trilinear:
                            trilinearMirrorEnabled = true;
                            break;
                        default:
                            break;
                    }

                }
            }

            _Material.SetSafeKeyword(Keyword.BaseSamplerStatePointMirror, pointMirrorEnabled);
            _Material.SetSafeKeyword(Keyword.BaseSamplerStateLinearMirror, linearMirrorEnabled);
            _Material.SetSafeKeyword(Keyword.BaseSamplerStateTrilinearMirror, trilinearMirrorEnabled);
        }

        #endregion
    }
}
