// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader
// @Class     : PropertyRange
// ----------------------------------------------------------------------
#nullable enable
#pragma warning disable IDE0090
namespace Izayoi.NovaShader
{
    /// <summary>
    /// Property Range
    /// </summary>
    public class PropertyRange
    {
        #region Render Settings

        /// <summary>Alpha Cutoff</summary>
        public static FloatRangeDefault Cutoff = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        #endregion

        #region Surface Maps

        /// <summary>Metallic</summary>
        public static FloatRangeDefault Metallic = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Smoothness</summary>
        public static FloatRangeDefault Smoothness = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        #endregion

        #region Base Map

        /// <summary>Base Map Progress</summary>
        public static FloatRangeDefault BaseMapProgress = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Base Map Rotation</summary>
        public static FloatRangeDefault BaseMapRotation = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        #endregion

        #region Tint Color

        /// <summary>Tint Map 3D Progress</summary>
        public static FloatRangeDefault TintMap3DProgress = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Tint Blend Rate</summary>
        public static FloatRangeDefault TintBlendRate = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Tint Rim Progress</summary>
        public static FloatRangeDefault TintRimProgress = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Tint Rim Sharpness</summary>
        public static FloatRangeDefault TintRimSharpness = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        #endregion

        #region Parallax Map

        /// <summary>Parallax Map Progress</summary>
        public static FloatRangeDefault ParallaxMapProgress = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Parallax Strength</summary>
        public static FloatRangeDefault ParallaxStrength = new FloatRangeDefault(0.0f, 1.0f, 0.3f);

        #endregion

        #region Alpha Transition

        /// <summary>Alpha Transition Map Progress</summary>
        public static FloatRangeDefault AlphaTransitionMapProgress = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Alpha Transition Progress</summary>
        public static FloatRangeDefault AlphaTransitionProgress = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Dissolve Sharpness</summary>
        public static FloatRangeDefault DissolveSharpness = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Alpha Transition Map Second Texture Progress</summary>
        public static FloatRangeDefault AlphaTransitionMapSecondTextureProgress = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Alpha Transition Second Texture Progress</summary>
        public static FloatRangeDefault AlphaTransitionProgressSecondTexture = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Second Texture Dissolve Sharpness</summary>
        public static FloatRangeDefault DissolveSharpnessSecondTexture = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        #endregion

        #region Emission

        /// <summary>Emission Map Progress</summary>
        public static FloatRangeDefault EmissionMapProgress = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        #endregion

        #region Transparency

        /// <summary>Rim Transparency Progress</summary>
        public static FloatRangeDefault RimTransparencyProgress = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Rim Transparency Sharpness</summary>
        public static FloatRangeDefault RimTransparencySharpness = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Luminance Transparency Progress</summary>
        public static FloatRangeDefault LuminanceTransparencyProgress = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Luminance Transparency Sharpness</summary>
        public static FloatRangeDefault LuminanceTransparencySharpness = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        #endregion

        #region Distortion

        /// <summary>Distortion Intensity</summary>
        public static FloatRangeDefault DistortionIntensity = new FloatRangeDefault(0.0f, 1.0f, 0.1f);

        /// <summary>LDistortion Intensity Coord</summary>
        public static FloatRangeDefault DistortionIntensityCoord = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        #endregion

        #region Shadow Caster

        /// <summary>Shadow Caster Alpha Test Cutoff</summary>
        public static FloatRangeDefault ShadowCasterAlphaCutoff = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        #endregion
    }
}
#pragma warning restore IDE0090
