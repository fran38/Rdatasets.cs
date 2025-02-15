// ReSharper disable All

namespace Rdatasets.Zelig
{
    using System.Collections.Generic;

    /// <summary>
    /// Simulation Data for model Two-Stage Least Square (twosls) that corresponds to method 2SLS of systemfit
    /// </summary>

    public class klein
    {
        public readonly int κ;
        public readonly int year;
        public readonly double C;
        public readonly double P;
        public readonly double P1;
        public readonly double Wtot;
        public readonly double Wp;
        public readonly double Wg;
        public readonly double I;
        public readonly double K1;
        public readonly double X;
        public readonly double G;
        public readonly double T;
        public readonly double X1;
        public readonly int Tm;

        public klein(int κ, int year, double C, double P, double P1, double Wtot, double Wp, double Wg, double I, double K1, double X, double G, double T, double X1, int Tm)
        {
            this.κ = κ;
            this.year = year;
            this.C = C;
            this.P = P;
            this.P1 = P1;
            this.Wtot = Wtot;
            this.Wp = Wp;
            this.Wg = Wg;
            this.I = I;
            this.K1 = K1;
            this.X = X;
            this.G = G;
            this.T = T;
            this.X1 = X1;
            this.Tm = Tm;
        }

        public static IEnumerable<klein> Data
        {
            get
            {
                yield return new klein(1, 1921, 41.9, 12.4, 12.7, 28.2, 25.5, 2.7, -0.2, 182.8, 45.6, 3.9, 7.7, 44.9, -10);
                yield return new klein(2, 1922, 45, 16.9, 12.4, 32.2, 29.3, 2.9, 1.9, 182.6, 50.1, 3.2, 3.9, 45.6, -9);
                yield return new klein(3, 1923, 49.2, 18.4, 16.9, 37, 34.1, 2.9, 5.2, 184.5, 57.2, 2.8, 4.7, 50.1, -8);
                yield return new klein(4, 1924, 50.6, 19.4, 18.4, 37, 33.9, 3.1, 3, 189.7, 57.1, 3.5, 3.8, 57.2, -7);
                yield return new klein(5, 1925, 52.6, 20.1, 19.4, 38.6, 35.4, 3.2, 5.1, 192.7, 61, 3.3, 5.5, 57.1, -6);
                yield return new klein(6, 1926, 55.1, 19.6, 20.1, 40.7, 37.4, 3.3, 5.6, 197.8, 64, 3.3, 7, 61, -5);
                yield return new klein(7, 1927, 56.2, 19.8, 19.6, 41.5, 37.9, 3.6, 4.2, 203.4, 64.4, 4, 6.7, 64, -4);
                yield return new klein(8, 1928, 57.3, 21.1, 19.8, 42.9, 39.2, 3.7, 3, 207.6, 64.5, 4.2, 4.2, 64.4, -3);
                yield return new klein(9, 1929, 57.8, 21.7, 21.1, 45.3, 41.3, 4, 5.1, 210.6, 67, 4.1, 4, 64.5, -2);
                yield return new klein(10, 1930, 55, 15.6, 21.7, 42.1, 37.9, 4.2, 1, 215.7, 61.2, 5.2, 7.7, 67, -1);
                yield return new klein(11, 1931, 50.9, 11.4, 15.6, 39.3, 34.5, 4.8, -3.4, 216.7, 53.4, 5.9, 7.5, 61.2, 0);
                yield return new klein(12, 1932, 45.6, 7, 11.4, 34.3, 29, 5.3, -6.2, 213.3, 44.3, 4.9, 8.3, 53.4, 1);
                yield return new klein(13, 1933, 46.5, 11.2, 7, 34.1, 28.5, 5.6, -5.1, 207.1, 45.1, 3.7, 5.4, 44.3, 2);
                yield return new klein(14, 1934, 48.7, 12.3, 11.2, 36.6, 30.6, 6, -3, 202, 49.7, 4, 6.8, 45.1, 3);
                yield return new klein(15, 1935, 51.3, 14, 12.3, 39.3, 33.2, 6.1, -1.3, 199, 54.4, 4.4, 7.2, 49.7, 4);
                yield return new klein(16, 1936, 57.7, 17.6, 14, 44.2, 36.8, 7.4, 2.1, 197.7, 62.7, 2.9, 8.3, 54.4, 5);
                yield return new klein(17, 1937, 58.7, 17.3, 17.6, 47.7, 41, 6.7, 2, 199.8, 65, 4.3, 6.7, 62.7, 6);
                yield return new klein(18, 1938, 57.5, 15.3, 17.3, 45.9, 38.2, 7.7, -1.9, 201.8, 60.9, 5.3, 7.4, 65, 7);
                yield return new klein(19, 1939, 61.6, 19, 15.3, 49.4, 41.6, 7.8, 1.3, 199.9, 69.5, 6.6, 8.9, 60.9, 8);
                yield return new klein(20, 1940, 65, 21.1, 19, 53, 45, 8, 3.3, 201.2, 75.7, 7.4, 9.6, 69.5, 9);
                yield return new klein(21, 1941, 69.7, 23.5, 21.1, 61.8, 53.3, 8.5, 4.9, 204.5, 88.4, 13.8, 11.6, 75.7, 10);
            }
        }
    }
}
