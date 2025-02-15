// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Maximum annual temperatures at Moorabbin Airport, Melbourne
    /// </summary>

    public class maxtemp
    {
        public readonly int κ;
        public readonly int time;
        public readonly double value;

        public maxtemp(int κ, int time, double value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<maxtemp> Data
        {
            get
            {
                yield return new maxtemp(1971, 1971, 34.6);
                yield return new maxtemp(1972, 1972, 39.3);
                yield return new maxtemp(1973, 1973, 40.5);
                yield return new maxtemp(1974, 1974, 36.8);
                yield return new maxtemp(1975, 1975, 39.7);
                yield return new maxtemp(1976, 1976, 40.5);
                yield return new maxtemp(1977, 1977, 41.5);
                yield return new maxtemp(1978, 1978, 38.2);
                yield return new maxtemp(1979, 1979, 41.4);
                yield return new maxtemp(1980, 1980, 41.5);
                yield return new maxtemp(1981, 1981, 41.9);
                yield return new maxtemp(1982, 1982, 43.5);
                yield return new maxtemp(1983, 1983, 43.2);
                yield return new maxtemp(1984, 1984, 35.1);
                yield return new maxtemp(1985, 1985, 42.1);
                yield return new maxtemp(1986, 1986, 38.1);
                yield return new maxtemp(1987, 1987, 39.6);
                yield return new maxtemp(1988, 1988, 39.9);
                yield return new maxtemp(1989, 1989, 37.8);
                yield return new maxtemp(1990, 1990, 39);
                yield return new maxtemp(1991, 1991, 41.3);
                yield return new maxtemp(1992, 1992, 38.7);
                yield return new maxtemp(1993, 1993, 37.8);
                yield return new maxtemp(1994, 1994, 38.9);
                yield return new maxtemp(1995, 1995, 39.7);
                yield return new maxtemp(1996, 1996, 36.1);
                yield return new maxtemp(1997, 1997, 41.3);
                yield return new maxtemp(1998, 1998, 40.6);
                yield return new maxtemp(1999, 1999, 37.5);
                yield return new maxtemp(2000, 2000, 39.6);
                yield return new maxtemp(2001, 2001, 38.8);
                yield return new maxtemp(2002, 2002, 36.6);
                yield return new maxtemp(2003, 2003, 44.3);
                yield return new maxtemp(2004, 2004, 39.7);
                yield return new maxtemp(2005, 2005, 43);
                yield return new maxtemp(2006, 2006, 43.1);
                yield return new maxtemp(2007, 2007, 41.5);
                yield return new maxtemp(2008, 2008, 40.5);
                yield return new maxtemp(2009, 2009, 46.7);
                yield return new maxtemp(2010, 2010, 43.9);
                yield return new maxtemp(2011, 2011, 39.5);
                yield return new maxtemp(2012, 2012, 39.7);
                yield return new maxtemp(2013, 2013, 41.5);
                yield return new maxtemp(2014, 2014, 43.7);
                yield return new maxtemp(2015, 2015, 42.7);
                yield return new maxtemp(2016, 2016, 42.9);
            }
        }
    }
}
