// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// River Iron
    /// </summary>

    public class RiverIron
    {
        public readonly int κ;
        public readonly string River;
        public readonly string Site;
        public readonly int Iron;
        public readonly double LogIron;

        public RiverIron(int κ, string River, string Site, int Iron, double LogIron)
        {
            this.κ = κ;
            this.River = River;
            this.Site = Site;
            this.Iron = Iron;
            this.LogIron = LogIron;
        }

        public static IEnumerable<RiverIron> Data
        {
            get
            {
                yield return new RiverIron(1, "Grasse", "Upstream", 944, 2.975);
                yield return new RiverIron(2, "Grasse", "MidStream", 525, 2.7202);
                yield return new RiverIron(3, "Grasse", "DownStream", 327, 2.5145);
                yield return new RiverIron(4, "Oswegatchie", "Upstream", 860, 2.9345);
                yield return new RiverIron(5, "Oswegatchie", "MidStream", 229, 2.3598);
                yield return new RiverIron(6, "Oswegatchie", "DownStream", 130, 2.1139);
                yield return new RiverIron(7, "Raquette", "Upstream", 108, 2.0334);
                yield return new RiverIron(8, "Raquette", "MidStream", 36, 1.5563);
                yield return new RiverIron(9, "Raquette", "DownStream", 30, 1.4771);
                yield return new RiverIron(10, "St. Regis", "Upstream", 751, 2.8756);
                yield return new RiverIron(11, "St. Regis", "MidStream", 568, 2.7543);
                yield return new RiverIron(12, "St. Regis", "DownStream", 350, 2.5441);
            }
        }
    }
}
