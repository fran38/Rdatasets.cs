// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Putts2
    /// </summary>

    public class Putts2
    {
        public readonly int κ;
        public readonly int Length;
        public readonly int Made;
        public readonly int Missed;
        public readonly int Trials;

        public Putts2(int κ, int Length, int Made, int Missed, int Trials)
        {
            this.κ = κ;
            this.Length = Length;
            this.Made = Made;
            this.Missed = Missed;
            this.Trials = Trials;
        }

        public static IEnumerable<Putts2> Data
        {
            get
            {
                yield return new Putts2(1, 3, 84, 17, 101);
                yield return new Putts2(2, 4, 88, 31, 119);
                yield return new Putts2(3, 5, 61, 47, 108);
                yield return new Putts2(4, 6, 61, 64, 125);
                yield return new Putts2(5, 7, 44, 90, 134);
            }
        }
    }
}
