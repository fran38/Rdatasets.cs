// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Klein's Model I
    /// </summary>

    public class Klein
    {
        public readonly int κ;
        public readonly double cons;
        public readonly double profit;
        public readonly double privwage;
        public readonly double inv;
        public readonly double lcap;
        public readonly double gnp;
        public readonly double pubwage;
        public readonly double govspend;
        public readonly double taxe;

        public Klein(int κ, double cons, double profit, double privwage, double inv, double lcap, double gnp, double pubwage, double govspend, double taxe)
        {
            this.κ = κ;
            this.cons = cons;
            this.profit = profit;
            this.privwage = privwage;
            this.inv = inv;
            this.lcap = lcap;
            this.gnp = gnp;
            this.pubwage = pubwage;
            this.govspend = govspend;
            this.taxe = taxe;
        }

        public static IEnumerable<Klein> Data
        {
            get
            {
                yield return new Klein(1, 39.8, 12.7, 28.8, 2.7, 180.1, 44.9, 2.2, 2.4, 3.4);
                yield return new Klein(2, 41.9, 12.4, 25.5, -0.2, 182.8, 45.6, 2.7, 3.9, 7.7);
                yield return new Klein(3, 45, 16.9, 29.3, 1.9, 182.6, 50.1, 2.9, 3.2, 3.9);
                yield return new Klein(4, 49.2, 18.4, 34.1, 5.2, 184.5, 57.2, 2.9, 2.8, 4.7);
                yield return new Klein(5, 50.6, 19.4, 33.9, 3, 189.7, 57.1, 3.1, 3.5, 3.8);
                yield return new Klein(6, 52.6, 20.1, 35.4, 5.1, 192.7, 61, 3.2, 3.3, 5.5);
                yield return new Klein(7, 55.1, 19.6, 37.4, 5.6, 197.8, 64, 3.3, 3.3, 7);
                yield return new Klein(8, 56.2, 19.8, 37.9, 4.2, 203.4, 64.4, 3.6, 4, 6.7);
                yield return new Klein(9, 57.3, 21.1, 39.2, 3, 207.6, 64.5, 3.7, 4.2, 4.2);
                yield return new Klein(10, 57.8, 21.7, 41.3, 5.1, 210.6, 67, 4, 4.1, 4);
                yield return new Klein(11, 55, 15.6, 37.9, 1, 215.7, 61.2, 4.2, 5.2, 7.7);
                yield return new Klein(12, 50.9, 11.4, 34.5, -3.4, 216.7, 53.4, 4.8, 5.9, 7.5);
                yield return new Klein(13, 45.6, 7, 29, -6.2, 213.3, 44.3, 5.3, 4.9, 8.3);
                yield return new Klein(14, 46.5, 11.2, 28.5, -5.1, 207.1, 45.1, 5.6, 3.7, 5.4);
                yield return new Klein(15, 48.7, 12.3, 30.6, -3, 202, 49.7, 6, 4, 6.8);
                yield return new Klein(16, 51.3, 14, 33.2, -1.3, 199, 54.4, 6.1, 4.4, 7.2);
                yield return new Klein(17, 57.7, 17.6, 36.8, 2.1, 197.7, 62.7, 7.4, 2.9, 8.3);
                yield return new Klein(18, 58.7, 17.3, 41, 2, 199.8, 65, 6.7, 4.3, 6.7);
                yield return new Klein(19, 57.5, 15.3, 38.2, -1.9, 201.8, 60.9, 7.7, 5.3, 7.4);
                yield return new Klein(20, 61.6, 19, 41.6, 1.3, 199.9, 69.5, 7.8, 6.6, 8.9);
                yield return new Klein(21, 65, 21.1, 45, 3.3, 201.2, 75.7, 8, 7.4, 9.6);
                yield return new Klein(22, 69.7, 23.5, 53.3, 4.9, 204.5, 88.4, 8.5, 13.8, 11.6);
            }
        }
    }
}
