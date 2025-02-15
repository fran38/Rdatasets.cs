// ReSharper disable All

namespace Rdatasets.survival
{
    using System.Collections.Generic;

    /// <summary>
    /// Tobin's Tobit data
    /// </summary>

    public class tobin
    {
        public readonly int κ;
        public readonly double durable;
        public readonly double age;
        public readonly int quant;

        public tobin(int κ, double durable, double age, int quant)
        {
            this.κ = κ;
            this.durable = durable;
            this.age = age;
            this.quant = quant;
        }

        public static IEnumerable<tobin> Data
        {
            get
            {
                yield return new tobin(1, 0, 57.7, 236);
                yield return new tobin(2, 0.7, 50.9, 283);
                yield return new tobin(3, 0, 48.5, 207);
                yield return new tobin(4, 0, 41.7, 220);
                yield return new tobin(5, 0, 47.7, 238);
                yield return new tobin(6, 0, 59.8, 216);
                yield return new tobin(7, 0, 44.3, 284);
                yield return new tobin(8, 3.7, 45.1, 221);
                yield return new tobin(9, 0, 51.7, 275);
                yield return new tobin(10, 3, 50, 269);
                yield return new tobin(11, 10.4, 46.8, 207);
                yield return new tobin(12, 0, 58, 249);
                yield return new tobin(13, 0, 58.9, 246);
                yield return new tobin(14, 0, 40, 277);
                yield return new tobin(15, 1.5, 34.1, 231);
                yield return new tobin(16, 0, 39.9, 219);
                yield return new tobin(17, 0, 33.4, 240);
                yield return new tobin(18, 3.5, 48.1, 266);
                yield return new tobin(19, 6.1, 46.6, 214);
                yield return new tobin(20, 0, 53.1, 251);
            }
        }
    }
}
