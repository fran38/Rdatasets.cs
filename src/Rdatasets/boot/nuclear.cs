// ReSharper disable All

namespace Rdatasets.boot
{
    using System.Collections.Generic;

    /// <summary>
    /// Nuclear Power Station Construction Data
    /// </summary>

    public class nuclear
    {
        public readonly int κ;
        public readonly double cost;
        public readonly double date;
        public readonly int t1;
        public readonly int t2;
        public readonly int cap;
        public readonly int pr;
        public readonly int ne;
        public readonly int ct;
        public readonly int bw;
        public readonly int cum_n;
        public readonly int pt;

        public nuclear(int κ, double cost, double date, int t1, int t2, int cap, int pr, int ne, int ct, int bw, int cum_n, int pt)
        {
            this.κ = κ;
            this.cost = cost;
            this.date = date;
            this.t1 = t1;
            this.t2 = t2;
            this.cap = cap;
            this.pr = pr;
            this.ne = ne;
            this.ct = ct;
            this.bw = bw;
            this.cum_n = cum_n;
            this.pt = pt;
        }

        public static IEnumerable<nuclear> Data
        {
            get
            {
                yield return new nuclear(1, 460.05, 68.58, 14, 46, 687, 0, 1, 0, 0, 14, 0);
                yield return new nuclear(2, 452.99, 67.33, 10, 73, 1065, 0, 0, 1, 0, 1, 0);
                yield return new nuclear(3, 443.22, 67.33, 10, 85, 1065, 1, 0, 1, 0, 1, 0);
                yield return new nuclear(4, 652.32, 68, 11, 67, 1065, 0, 1, 1, 0, 12, 0);
                yield return new nuclear(5, 642.23, 68, 11, 78, 1065, 1, 1, 1, 0, 12, 0);
                yield return new nuclear(6, 345.39, 67.92, 13, 51, 514, 0, 1, 1, 0, 3, 0);
                yield return new nuclear(7, 272.37, 68.17, 12, 50, 822, 0, 0, 0, 0, 5, 0);
                yield return new nuclear(8, 317.21, 68.42, 14, 59, 457, 0, 0, 0, 0, 1, 0);
                yield return new nuclear(9, 457.12, 68.42, 15, 55, 822, 1, 0, 0, 0, 5, 0);
                yield return new nuclear(10, 690.19, 68.33, 12, 71, 792, 0, 1, 1, 1, 2, 0);
                yield return new nuclear(11, 350.63, 68.58, 12, 64, 560, 0, 0, 0, 0, 3, 0);
                yield return new nuclear(12, 402.59, 68.75, 13, 47, 790, 0, 1, 0, 0, 6, 0);
                yield return new nuclear(13, 412.18, 68.42, 15, 62, 530, 0, 0, 1, 0, 2, 0);
                yield return new nuclear(14, 495.58, 68.92, 17, 52, 1050, 0, 0, 0, 0, 7, 0);
                yield return new nuclear(15, 394.36, 68.92, 13, 65, 850, 0, 0, 0, 1, 16, 0);
                yield return new nuclear(16, 423.32, 68.42, 11, 67, 778, 0, 0, 0, 0, 3, 0);
                yield return new nuclear(17, 712.27, 69.5, 18, 60, 845, 0, 1, 0, 0, 17, 0);
                yield return new nuclear(18, 289.66, 68.42, 15, 76, 530, 1, 0, 1, 0, 2, 0);
                yield return new nuclear(19, 881.24, 69.17, 15, 67, 1090, 0, 0, 0, 0, 1, 0);
                yield return new nuclear(20, 490.88, 68.92, 16, 59, 1050, 1, 0, 0, 0, 8, 0);
                yield return new nuclear(21, 567.79, 68.75, 11, 70, 913, 0, 0, 1, 1, 15, 0);
                yield return new nuclear(22, 665.99, 70.92, 22, 57, 828, 1, 1, 0, 0, 20, 0);
                yield return new nuclear(23, 621.45, 69.67, 16, 59, 786, 0, 0, 1, 0, 18, 0);
                yield return new nuclear(24, 608.8, 70.08, 19, 58, 821, 1, 0, 0, 0, 3, 0);
                yield return new nuclear(25, 473.64, 70.42, 19, 44, 538, 0, 0, 1, 0, 19, 0);
                yield return new nuclear(26, 697.14, 71.08, 20, 57, 1130, 0, 0, 1, 0, 21, 0);
                yield return new nuclear(27, 207.51, 67.25, 13, 63, 745, 0, 0, 0, 0, 8, 1);
                yield return new nuclear(28, 288.48, 67.17, 9, 48, 821, 0, 0, 1, 0, 7, 1);
                yield return new nuclear(29, 284.88, 67.83, 12, 63, 886, 0, 0, 0, 1, 11, 1);
                yield return new nuclear(30, 280.36, 67.83, 12, 71, 886, 1, 0, 0, 1, 11, 1);
                yield return new nuclear(31, 217.38, 67.25, 13, 72, 745, 1, 0, 0, 0, 8, 1);
                yield return new nuclear(32, 270.71, 67.83, 7, 80, 886, 1, 0, 0, 1, 11, 1);
            }
        }
    }
}
