// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Education and Related Statistics for the U.S. States
    /// </summary>

    public class States
    {
        public readonly string κ;
        public readonly string region;
        public readonly int pop;
        public readonly int SATV;
        public readonly int SATM;
        public readonly int percent;
        public readonly double dollars;
        public readonly int pay;

        public States(string κ, string region, int pop, int SATV, int SATM, int percent, double dollars, int pay)
        {
            this.κ = κ;
            this.region = region;
            this.pop = pop;
            this.SATV = SATV;
            this.SATM = SATM;
            this.percent = percent;
            this.dollars = dollars;
            this.pay = pay;
        }

        public static IEnumerable<States> Data
        {
            get
            {
                yield return new States("AL", "ESC", 4041, 470, 514, 8, 3.648, 27);
                yield return new States("AK", "PAC", 550, 438, 476, 42, 7.887, 43);
                yield return new States("AZ", "MTN", 3665, 445, 497, 25, 4.231, 30);
                yield return new States("AR", "WSC", 2351, 470, 511, 6, 3.334, 23);
                yield return new States("CA", "PAC", 29760, 419, 484, 45, 4.826, 39);
                yield return new States("CO", "MTN", 3294, 456, 513, 28, 4.809, 31);
                yield return new States("CN", "NE", 3287, 430, 471, 74, 7.914, 43);
                yield return new States("DE", "SA", 666, 433, 470, 58, 6.016, 35);
                yield return new States("DC", "SA", 607, 409, 441, 68, 8.21, 39);
                yield return new States("FL", "SA", 12938, 418, 466, 44, 5.154, 30);
                yield return new States("GA", "SA", 6478, 401, 443, 57, 4.86, 29);
                yield return new States("HI", "PAC", 1108, 404, 481, 52, 5.008, 32);
                yield return new States("ID", "MTN", 1007, 466, 502, 17, 3.2, 25);
                yield return new States("IL", "ENC", 11431, 466, 528, 16, 5.062, 34);
                yield return new States("IN", "ENC", 5544, 408, 459, 54, 5.051, 32);
                yield return new States("IA", "WNC", 2777, 511, 577, 5, 4.839, 28);
                yield return new States("KS", "WNC", 2478, 492, 548, 10, 5.009, 29);
                yield return new States("KY", "ESC", 3685, 473, 521, 10, 4.39, 29);
                yield return new States("LA", "WSC", 4220, 476, 517, 9, 4.012, 26);
                yield return new States("ME", "NE", 1228, 423, 463, 60, 5.894, 28);
                yield return new States("MD", "SA", 4781, 430, 478, 59, 6.184, 38);
                yield return new States("MA", "NE", 6016, 427, 473, 72, 6.351, 36);
                yield return new States("MI", "ENC", 9295, 454, 514, 12, 5.257, 38);
                yield return new States("MN", "WNC", 4375, 477, 542, 14, 5.26, 33);
                yield return new States("MS", "ESC", 2573, 477, 519, 4, 3.322, 24);
                yield return new States("MO", "WNC", 5117, 473, 522, 12, 4.415, 28);
                yield return new States("MT", "MTN", 799, 464, 523, 20, 5.184, 26);
                yield return new States("NE", "WNC", 1578, 484, 546, 10, 4.381, 26);
                yield return new States("NV", "MTN", 1202, 434, 487, 24, 4.564, 32);
                yield return new States("NH", "NE", 1109, 442, 486, 67, 5.504, 31);
                yield return new States("NJ", "MA", 7730, 418, 473, 69, 9.159, 38);
                yield return new States("NM", "MTN", 1515, 480, 527, 12, 4.446, 26);
                yield return new States("NY", "MA", 17990, 412, 470, 70, 8.5, 42);
                yield return new States("NC", "SA", 6629, 401, 440, 55, 4.802, 29);
                yield return new States("ND", "WNC", 639, 505, 564, 6, 3.685, 23);
                yield return new States("OH", "ENC", 10847, 450, 499, 22, 5.639, 32);
                yield return new States("OK", "WSC", 3146, 478, 523, 9, 3.742, 24);
                yield return new States("OR", "PAC", 2842, 439, 484, 49, 5.291, 32);
                yield return new States("PA", "MA", 11882, 420, 463, 64, 6.534, 36);
                yield return new States("RI", "NE", 1003, 422, 461, 62, 6.989, 37);
                yield return new States("SC", "SA", 3487, 397, 437, 54, 4.327, 28);
                yield return new States("SD", "WNC", 696, 506, 555, 5, 3.73, 22);
                yield return new States("TN", "ESC", 4877, 483, 525, 12, 3.707, 28);
                yield return new States("TX", "WSC", 16987, 413, 461, 42, 4.238, 28);
                yield return new States("UT", "MTN", 1723, 492, 539, 5, 2.993, 25);
                yield return new States("VT", "NE", 563, 431, 466, 62, 5.74, 31);
                yield return new States("VA", "SA", 6187, 425, 470, 58, 5.36, 32);
                yield return new States("WA", "PAC", 4867, 437, 486, 44, 5.045, 33);
                yield return new States("WV", "SA", 1793, 443, 490, 15, 5.046, 26);
                yield return new States("WI", "ENC", 4892, 476, 543, 11, 5.946, 33);
                yield return new States("WY", "MTN", 454, 458, 519, 13, 5.255, 29);
            }
        }
    }
}
