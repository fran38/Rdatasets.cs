// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Possum Sites
    /// </summary>

    public class possumsites
    {
        public readonly string κ;
        public readonly double Longitude;
        public readonly double Latitude;
        public readonly int altitude;

        public possumsites(string κ, double Longitude, double Latitude, int altitude)
        {
            this.κ = κ;
            this.Longitude = Longitude;
            this.Latitude = Latitude;
            this.altitude = altitude;
        }

        public static IEnumerable<possumsites> Data
        {
            get
            {
                yield return new possumsites("Cambarville", 145.883333333333, -37.55, 800);
                yield return new possumsites("Bellbird", 148.8, -37.6166666666667, 300);
                yield return new possumsites("Allyn River", 151.466666666667, -32.1166666666667, 300);
                yield return new possumsites("Whian Whian", 153.333333333333, -28.6166666666667, 400);
                yield return new possumsites("Byrangery", 153.416666666667, -28.6166666666667, 200);
                yield return new possumsites("Conondale", 152.583333333333, -26.4333333333333, 400);
                yield return new possumsites("Bulburin", 151.466666666667, -24.55, 600);
            }
        }
    }
}
