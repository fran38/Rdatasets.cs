// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Leaf and Air Temperature Data
    /// </summary>

    public class leaftemp
    {
        public readonly int κ;
        public readonly string CO2level;
        public readonly double vapPress;
        public readonly double tempDiff;
        public readonly double BtempDiff;

        public leaftemp(int κ, string CO2level, double vapPress, double tempDiff, double BtempDiff)
        {
            this.κ = κ;
            this.CO2level = CO2level;
            this.vapPress = vapPress;
            this.tempDiff = tempDiff;
            this.BtempDiff = BtempDiff;
        }

        public static IEnumerable<leaftemp> Data
        {
            get
            {
                yield return new leaftemp(1, "high", 2.56, 1.5, 1.84);
                yield return new leaftemp(2, "low", 1.88, 1.36, 1.54);
                yield return new leaftemp(3, "medium", 2.38, 1.94, 1.96);
                yield return new leaftemp(4, "high", 2.55, 0.85, 0.93);
                yield return new leaftemp(5, "low", 2.2, 0.6, 0.68);
                yield return new leaftemp(6, "medium", 2.72, 0.83, 0.89);
                yield return new leaftemp(7, "high", 2.17, -0.04, 0.02);
                yield return new leaftemp(8, "medium", 2.21, -0.11, -0.06);
                yield return new leaftemp(9, "high", 1.64, 1.25, 1.1);
                yield return new leaftemp(10, "low", 1.75, 0.23, 0.5);
                yield return new leaftemp(11, "medium", 1.67, 0.85, 0.65);
                yield return new leaftemp(12, "high", 1.67, 1.64, 1.27);
                yield return new leaftemp(13, "low", 1.85, 0.48, 0.65);
                yield return new leaftemp(14, "medium", 1.67, 1.32, 1.05);
                yield return new leaftemp(15, "high", 1.81, 1.99, 1.72);
                yield return new leaftemp(16, "low", 1.69, 0.98, 0.9);
                yield return new leaftemp(17, "medium", 1.71, 1.76, 1.08);
                yield return new leaftemp(18, "high", 1.86, 1.9, 1.6);
                yield return new leaftemp(19, "low", 1.33, 0.98, 0.75);
                yield return new leaftemp(20, "medium", 1.8, 1.49, 0.99);
                yield return new leaftemp(21, "high", 1.58, 2.42, 1.89);
                yield return new leaftemp(22, "low", 2.07, 1.48, 1.15);
                yield return new leaftemp(23, "medium", 1.88, 1.64, 1.62);
                yield return new leaftemp(24, "high", 1.95, 3.2, 2.31);
                yield return new leaftemp(25, "low", 2.1, 2.16, 1.5);
                yield return new leaftemp(26, "medium", 1.75, 2.11, 2.18);
                yield return new leaftemp(27, "high", 1.38, 2.74, 2.01);
                yield return new leaftemp(28, "low", 2.17, 1.34, 0.82);
                yield return new leaftemp(29, "medium", 1.9, 1.94, 1.9);
                yield return new leaftemp(30, "high", 1.66, 3.22, 2.34);
                yield return new leaftemp(31, "low", 2.13, 1.61, 0.99);
                yield return new leaftemp(32, "medium", 1.81, 2.19, 2.05);
                yield return new leaftemp(33, "high", 2.16, 2.24, 1.71);
                yield return new leaftemp(34, "low", 2.26, 0.75, 0.6);
                yield return new leaftemp(35, "medium", 1.93, 1.61, 1.42);
                yield return new leaftemp(36, "high", 2.19, 1.62, 1.26);
                yield return new leaftemp(37, "low", 2.38, 0.75, 0.48);
                yield return new leaftemp(38, "medium", 2.45, 1.11, 1.03);
                yield return new leaftemp(39, "high", 2.29, 2.47, 1.97);
                yield return new leaftemp(40, "low", 1.93, 1.92, 1.89);
                yield return new leaftemp(41, "medium", 1.72, 2.34, 2.1);
                yield return new leaftemp(42, "high", 2.32, 1.59, 1.73);
                yield return new leaftemp(43, "low", 2.6, 1.51, 1.72);
                yield return new leaftemp(44, "medium", 2.49, 1.29, 1.02);
                yield return new leaftemp(45, "high", 2.7, 0, 0.13);
                yield return new leaftemp(46, "low", 2.48, 0, 0.01);
                yield return new leaftemp(47, "medium", 2.45, 0.11, 0.06);
                yield return new leaftemp(48, "high", 2.05, 2.85, 1.72);
                yield return new leaftemp(49, "low", 2.17, 1.26, 1.29);
                yield return new leaftemp(50, "medium", 1.86, 1.87, 1.18);
                yield return new leaftemp(51, "high", 2.56, 0.49, 0.44);
                yield return new leaftemp(52, "low", 2.38, 0.1, 0.19);
                yield return new leaftemp(53, "medium", 2.39, 0.44, 0.35);
                yield return new leaftemp(54, "high", 1.8, 2.09, 1.47);
                yield return new leaftemp(55, "low", 1.94, 0.72, 0.67);
                yield return new leaftemp(56, "medium", 1.43, 1.31, 0.91);
                yield return new leaftemp(57, "high", 1.82, 1.2, 1);
                yield return new leaftemp(58, "low", 1.78, 0.23, 0.12);
                yield return new leaftemp(59, "medium", 1.46, 0.89, 0.86);
                yield return new leaftemp(60, "high", 2.03, 1.94, 1.58);
                yield return new leaftemp(61, "low", 2.1, 0.67, 0.26);
                yield return new leaftemp(62, "medium", 2.11, 1.1, 1);
            }
        }
    }
}
