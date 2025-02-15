// ReSharper disable All

namespace Rdatasets.HistData
{
    using System.Collections.Generic;

    /// <summary>
    /// Michelson's Determinations of the Velocity of Light
    /// </summary>

    public class MichelsonSets
    {
        public readonly int κ;
        public readonly int ds12;
        public readonly int ds13;
        public readonly int ds14;
        public readonly int ds15;
        public readonly int ds16;

        public MichelsonSets(int κ, int ds12, int ds13, int ds14, int ds15, int ds16)
        {
            this.κ = κ;
            this.ds12 = ds12;
            this.ds13 = ds13;
            this.ds14 = ds14;
            this.ds15 = ds15;
            this.ds16 = ds16;
        }

        public static IEnumerable<MichelsonSets> Data
        {
            get
            {
                yield return new MichelsonSets(1, 850, 740, 900, 1070, 930);
                yield return new MichelsonSets(2, 850, 950, 980, 980, 880);
                yield return new MichelsonSets(3, 1000, 980, 930, 650, 760);
                yield return new MichelsonSets(4, 810, 1000, 1000, 960, 960);
                yield return new MichelsonSets(5, 960, 940, 960, 940, 880);
                yield return new MichelsonSets(6, 800, 850, 880, 900, 840);
                yield return new MichelsonSets(7, 830, 790, 810, 880, 880);
                yield return new MichelsonSets(8, 830, 800, 790, 760, 800);
                yield return new MichelsonSets(9, 880, 880, 880, 860, 720);
                yield return new MichelsonSets(10, 720, 620, 860, 970, 950);
                yield return new MichelsonSets(11, 880, 910, 850, 870, 840);
                yield return new MichelsonSets(12, 840, 850, 840, 840, 840);
                yield return new MichelsonSets(13, 890, 810, 810, 820, 800);
                yield return new MichelsonSets(14, 770, 760, 740, 750, 760);
                yield return new MichelsonSets(15, 910, 920, 890, 860, 880);
                yield return new MichelsonSets(16, 720, 840, 850, 850, 780);
                yield return new MichelsonSets(17, 890, 840, 780, 810, 760);
                yield return new MichelsonSets(18, 810, 790, 810, 820, 850);
                yield return new MichelsonSets(19, 870, 870, 810, 740, 810);
                yield return new MichelsonSets(20, 940, 950, 800, 810, 870);
            }
        }
    }
}
