// ----------------------------------------------------------------------
// @Namespace : Izayoi.NovaShader
// @Structure : IntRange
// ----------------------------------------------------------------------
#nullable enable
namespace Izayoi.NovaShader
{
    /// <summary>
    /// 
    /// </summary>
    public struct IntRange
    {
        /// <summary></summary>
        public int minValue;

        /// <summary></summary>
        public int maxValue;

        /// <summary>
        /// Create a new instance of IntRange.
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        public IntRange(int minValue, int maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }
    }
}