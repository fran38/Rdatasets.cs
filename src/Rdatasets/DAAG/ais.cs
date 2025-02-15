// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Australian athletes data set
    /// </summary>

    public class ais
    {
        public readonly int κ;
        public readonly double rcc;
        public readonly double wcc;
        public readonly double hc;
        public readonly double hg;
        public readonly int ferr;
        public readonly double bmi;
        public readonly double ssf;
        public readonly double pcBfat;
        public readonly double lbm;
        public readonly double ht;
        public readonly double wt;
        public readonly string sex;
        public readonly string sport;

        public ais(int κ, double rcc, double wcc, double hc, double hg, int ferr, double bmi, double ssf, double pcBfat, double lbm, double ht, double wt, string sex, string sport)
        {
            this.κ = κ;
            this.rcc = rcc;
            this.wcc = wcc;
            this.hc = hc;
            this.hg = hg;
            this.ferr = ferr;
            this.bmi = bmi;
            this.ssf = ssf;
            this.pcBfat = pcBfat;
            this.lbm = lbm;
            this.ht = ht;
            this.wt = wt;
            this.sex = sex;
            this.sport = sport;
        }

        public static IEnumerable<ais> Data
        {
            get
            {
                yield return new ais(1, 3.96, 7.5, 37.5, 12.3, 60, 20.56, 109.1, 19.75, 63.32, 195.9, 78.9, "f", "B_Ball");
                yield return new ais(2, 4.41, 8.3, 38.2, 12.7, 68, 20.67, 102.8, 21.3, 58.55, 189.7, 74.4, "f", "B_Ball");
                yield return new ais(3, 4.14, 5, 36.4, 11.6, 21, 21.86, 104.6, 19.88, 55.36, 177.8, 69.1, "f", "B_Ball");
                yield return new ais(4, 4.11, 5.3, 37.3, 12.6, 69, 21.88, 126.4, 23.66, 57.18, 185, 74.9, "f", "B_Ball");
                yield return new ais(5, 4.45, 6.8, 41.5, 14, 29, 18.96, 80.3, 17.64, 53.2, 184.6, 64.6, "f", "B_Ball");
                yield return new ais(6, 4.1, 4.4, 37.4, 12.5, 42, 21.04, 75.2, 15.58, 53.77, 174, 63.7, "f", "B_Ball");
                yield return new ais(7, 4.31, 5.3, 39.6, 12.8, 73, 21.69, 87.2, 19.99, 60.17, 186.2, 75.2, "f", "B_Ball");
                yield return new ais(8, 4.42, 5.7, 39.9, 13.2, 44, 20.62, 97.9, 22.43, 48.33, 173.8, 62.3, "f", "B_Ball");
                yield return new ais(9, 4.3, 8.9, 41.1, 13.5, 41, 22.64, 75.1, 17.95, 54.57, 171.4, 66.5, "f", "B_Ball");
                yield return new ais(10, 4.51, 4.4, 41.6, 12.7, 44, 19.44, 65.1, 15.07, 53.42, 179.9, 62.9, "f", "B_Ball");
                yield return new ais(11, 4.71, 5.3, 41.4, 14, 38, 25.75, 171.1, 28.83, 68.53, 193.4, 96.3, "f", "B_Ball");
                yield return new ais(12, 4.62, 7.3, 43.8, 14.7, 26, 21.2, 76.8, 18.08, 61.85, 188.7, 75.5, "f", "B_Ball");
                yield return new ais(13, 4.35, 7.8, 41.4, 14.1, 30, 22.03, 117.8, 23.3, 48.32, 169.1, 63, "f", "B_Ball");
                yield return new ais(14, 4.26, 6.2, 41, 13.9, 48, 25.44, 90.2, 17.71, 66.24, 177.9, 80.5, "f", "Row");
                yield return new ais(15, 4.63, 6, 43.7, 14.7, 30, 22.63, 97.2, 18.77, 57.92, 177.5, 71.3, "f", "Row");
                yield return new ais(16, 4.36, 5.8, 40.3, 13.3, 29, 21.86, 99.9, 19.83, 56.52, 179.6, 70.5, "f", "Row");
                yield return new ais(17, 3.91, 7.3, 37.6, 12.9, 43, 22.27, 125.9, 25.16, 54.78, 181.3, 73.2, "f", "Row");
                yield return new ais(18, 4.51, 8.3, 43.7, 14.7, 34, 21.27, 69.9, 18.04, 56.31, 179.7, 68.7, "f", "Row");
                yield return new ais(19, 4.37, 8.1, 41.8, 14.3, 53, 23.47, 98, 21.79, 62.96, 185.2, 80.5, "f", "Row");
                yield return new ais(20, 4.9, 6.9, 44, 14.5, 59, 23.19, 96.8, 22.25, 56.68, 177.3, 72.9, "f", "Row");
                yield return new ais(21, 4.46, 5.7, 39.2, 13, 43, 23.17, 80.3, 16.25, 62.39, 179.3, 74.5, "f", "Row");
                yield return new ais(22, 3.95, 3.3, 36.9, 12.5, 40, 24.54, 74.9, 16.38, 63.05, 175.3, 75.4, "f", "Row");
                yield return new ais(23, 4.46, 9.5, 41.5, 14.5, 92, 22.96, 83, 19.35, 56.05, 174, 69.5, "f", "Row");
                yield return new ais(24, 5.02, 6.4, 44.8, 15.2, 48, 19.76, 91, 19.2, 53.65, 183.3, 66.4, "f", "Row");
                yield return new ais(25, 4.26, 5.8, 41.2, 14.1, 77, 23.36, 76.2, 17.89, 65.45, 184.7, 79.7, "f", "Row");
                yield return new ais(26, 4.46, 5.6, 41.1, 14.3, 71, 22.67, 52.6, 12.2, 64.62, 180.2, 73.6, "f", "Row");
                yield return new ais(27, 4.16, 5.8, 39.8, 13.3, 37, 24.24, 111.1, 23.7, 60.05, 180.2, 78.7, "f", "Row");
                yield return new ais(28, 4.49, 7.6, 41.8, 14.4, 71, 24.21, 110.7, 24.69, 56.48, 176, 75, "f", "Row");
                yield return new ais(29, 4.21, 7.5, 38.4, 13.2, 73, 20.46, 74.7, 16.58, 41.54, 156, 49.8, "f", "Row");
                yield return new ais(30, 4.57, 6.6, 42.8, 14.5, 85, 20.81, 113.5, 21.47, 52.78, 179.7, 67.2, "f", "Row");
                yield return new ais(31, 4.87, 6.4, 44.8, 15, 64, 20.17, 99.8, 20.12, 52.72, 180.9, 66, "f", "Row");
                yield return new ais(32, 4.44, 10.1, 42.7, 14, 19, 23.06, 80.3, 17.51, 61.29, 179.5, 74.3, "f", "Row");
                yield return new ais(33, 4.45, 6.6, 42.6, 14.1, 39, 24.4, 109.5, 23.7, 59.59, 178.9, 78.1, "f", "Row");
                yield return new ais(34, 4.41, 5.9, 41.1, 13.5, 41, 23.97, 123.6, 22.39, 61.7, 182.1, 79.5, "f", "Row");
                yield return new ais(35, 4.87, 7.3, 44.1, 14.8, 13, 22.62, 91.2, 20.43, 62.46, 186.3, 78.5, "f", "Row");
                yield return new ais(36, 4.56, 13.3, 42.2, 13.6, 20, 19.16, 49, 11.29, 53.14, 176.8, 59.9, "f", "Netball");
                yield return new ais(37, 4.15, 6, 38, 12.7, 59, 21.15, 110.2, 25.26, 47.09, 172.6, 63, "f", "Netball");
                yield return new ais(38, 4.16, 7.6, 37.5, 12.3, 22, 21.4, 89, 19.39, 53.44, 176, 66.3, "f", "Netball");
                yield return new ais(39, 4.32, 6.4, 37.7, 12.3, 30, 21.03, 98.3, 19.63, 48.78, 169.9, 60.7, "f", "Netball");
                yield return new ais(40, 4.06, 5.8, 38.7, 12.8, 78, 21.77, 122.1, 23.11, 56.05, 183, 72.9, "f", "Netball");
                yield return new ais(41, 4.12, 6.1, 36.6, 11.8, 21, 21.38, 90.4, 16.86, 56.45, 178.2, 67.9, "f", "Netball");
                yield return new ais(42, 4.17, 5, 37.4, 12.7, 109, 21.47, 106.9, 21.32, 53.11, 177.3, 67.5, "f", "Netball");
                yield return new ais(43, 3.8, 6.6, 36.5, 12.4, 102, 24.45, 156.6, 26.57, 54.41, 174.1, 74.1, "f", "Netball");
                yield return new ais(44, 3.96, 5.5, 36.3, 12.4, 71, 22.63, 101.1, 17.93, 55.97, 173.6, 68.2, "f", "Netball");
                yield return new ais(45, 4.44, 9.7, 41.4, 14.1, 64, 22.8, 126.4, 24.97, 51.62, 173.7, 68.8, "f", "Netball");
                yield return new ais(46, 4.27, 10.6, 37.7, 12.5, 68, 23.58, 114, 22.62, 58.27, 178.7, 75.3, "f", "Netball");
                yield return new ais(47, 3.9, 6.3, 35.9, 12.1, 78, 20.06, 70, 15.01, 57.28, 183.3, 67.4, "f", "Netball");
                yield return new ais(48, 4.02, 9.1, 37.7, 12.7, 107, 23.01, 77, 18.14, 57.3, 174.4, 70, "f", "Netball");
                yield return new ais(49, 4.39, 9.6, 38.3, 12.5, 39, 24.64, 148.9, 26.78, 54.18, 173.3, 74, "f", "Netball");
                yield return new ais(50, 4.52, 5.1, 38.8, 13.1, 58, 18.26, 80.1, 17.22, 42.96, 168.6, 51.9, "f", "Netball");
                yield return new ais(51, 4.25, 10.7, 39.5, 13.2, 127, 24.47, 156.6, 26.5, 54.46, 174, 74.1, "f", "Netball");
                yield return new ais(52, 4.46, 10.9, 39.7, 13.7, 102, 23.99, 115.9, 23.01, 57.2, 176, 74.3, "f", "Netball");
                yield return new ais(53, 4.4, 9.3, 40.4, 13.6, 86, 26.24, 181.7, 30.1, 54.38, 172.2, 77.8, "f", "Netball");
                yield return new ais(54, 4.83, 8.4, 41.8, 13.4, 40, 20.04, 71.6, 13.93, 57.58, 182.7, 66.9, "f", "Netball");
                yield return new ais(55, 4.23, 6.9, 38.3, 12.6, 50, 25.72, 143.5, 26.65, 61.46, 180.5, 83.8, "f", "Netball");
                yield return new ais(56, 4.24, 8.4, 37.6, 12.5, 58, 25.64, 200.8, 35.52, 53.46, 179.8, 82.9, "f", "Netball");
                yield return new ais(57, 3.95, 6.6, 38.4, 12.8, 33, 19.87, 68.9, 15.59, 54.11, 179.6, 64.1, "f", "Netball");
                yield return new ais(58, 4.03, 8.5, 37.7, 13, 51, 23.35, 103.6, 19.61, 55.35, 171.7, 68.8, "f", "Netball");
                yield return new ais(59, 4.36, 5.5, 41.4, 13.8, 82, 22.42, 71.3, 14.52, 55.39, 170, 64.8, "f", "Swim");
                yield return new ais(60, 4.07, 5.9, 39.5, 13.3, 25, 20.42, 54.6, 11.47, 52.23, 170, 59, "f", "Swim");
                yield return new ais(61, 4.17, 4.9, 38.9, 12.9, 86, 22.13, 88.2, 17.71, 59.33, 180.5, 72.1, "f", "Swim");
                yield return new ais(62, 4.23, 8.1, 38.2, 12.7, 22, 25.17, 95.4, 18.48, 61.63, 173.3, 75.6, "f", "Swim");
                yield return new ais(63, 4.46, 8.3, 42.2, 14.4, 30, 23.72, 47.5, 11.22, 63.39, 173.5, 71.4, "f", "Swim");
                yield return new ais(64, 4.38, 5.8, 42, 14, 27, 21.28, 55.6, 13.61, 60.22, 181, 69.7, "f", "Swim");
                yield return new ais(65, 4.31, 5.3, 41.1, 13.9, 60, 20.87, 62.9, 12.78, 55.73, 175, 63.9, "f", "Swim");
                yield return new ais(66, 4.51, 5.1, 40.9, 14, 115, 19, 52.5, 11.85, 48.57, 170.3, 55.1, "f", "Swim");
                yield return new ais(67, 4.13, 7, 39.7, 13.1, 124, 22.04, 62.6, 13.35, 51.99, 165, 60, "f", "Swim");
                yield return new ais(68, 4.48, 9.5, 36.5, 13.3, 54, 20.12, 49.9, 11.77, 51.17, 169.8, 58, "f", "Field");
                yield return new ais(69, 5.31, 9.5, 47.1, 15.9, 29, 21.35, 57.9, 11.07, 57.54, 174.1, 64.7, "f", "T_400m");
                yield return new ais(70, 4.58, 5.8, 42.1, 14.7, 164, 28.57, 109.6, 21.3, 68.86, 175, 87.5, "f", "Field");
                yield return new ais(71, 4.81, 6.8, 42.7, 15.3, 50, 26.95, 98.5, 20.1, 63.04, 171.1, 78.9, "f", "Field");
                yield return new ais(72, 4.51, 9, 39.7, 14.3, 36, 28.13, 136.3, 24.88, 63.03, 172.7, 83.9, "f", "Field");
                yield return new ais(73, 4.77, 7.1, 40.6, 14.6, 40, 26.85, 103.6, 19.26, 66.85, 175.6, 82.8, "f", "Field");
                yield return new ais(74, 5.33, 9.3, 47, 15, 62, 25.27, 102.8, 19.51, 59.89, 171.6, 74.4, "f", "Field");
                yield return new ais(75, 4.75, 7.5, 43.8, 15.2, 90, 31.93, 131.9, 23.01, 72.98, 172.3, 94.8, "f", "Field");
                yield return new ais(76, 4.11, 7.3, 38.7, 12.4, 12, 16.75, 33.8, 8.07, 45.23, 171.4, 49.2, "f", "T_400m");
                yield return new ais(77, 4.76, 7.6, 42.9, 13.4, 36, 19.54, 43.5, 11.05, 55.06, 178, 61.9, "f", "T_Sprnt");
                yield return new ais(78, 4.27, 6.9, 44.1, 14.7, 45, 20.42, 46.2, 12.39, 46.96, 162, 53.6, "f", "T_400m");
                yield return new ais(79, 4.44, 6.1, 42.6, 13.9, 43, 22.76, 73.9, 15.95, 53.54, 167.3, 63.7, "f", "T_400m");
                yield return new ais(80, 4.2, 6.5, 39.1, 13, 51, 20.12, 36.8, 9.91, 47.57, 162, 52.8, "f", "T_400m");
                yield return new ais(81, 4.71, 6.9, 43.5, 13.8, 22, 22.35, 67, 16.2, 54.63, 170.8, 65.2, "f", "T_400m");
                yield return new ais(82, 4.09, 6.4, 40.1, 13.2, 44, 19.16, 41.1, 9.02, 46.31, 163, 50.9, "f", "T_400m");
                yield return new ais(83, 4.24, 6.6, 38.2, 12.6, 26, 20.77, 59.4, 14.26, 49.13, 166.1, 57.3, "f", "T_400m");
                yield return new ais(84, 3.9, 6, 38.9, 13.5, 16, 19.37, 48.4, 10.48, 53.71, 176, 60, "f", "T_400m");
                yield return new ais(85, 4.82, 7.6, 43.2, 14.4, 58, 22.37, 50, 11.64, 53.11, 163.9, 60.1, "f", "T_Sprnt");
                yield return new ais(86, 4.32, 6.8, 40.6, 13.7, 46, 17.54, 54.6, 12.16, 46.12, 173, 52.5, "f", "T_400m");
                yield return new ais(87, 4.77, 7.2, 43.3, 14.8, 43, 19.06, 42.3, 10.53, 53.41, 177, 59.7, "f", "T_400m");
                yield return new ais(88, 5.16, 8.2, 45.3, 14.7, 34, 20.3, 46.1, 10.15, 51.48, 168, 57.3, "f", "T_Sprnt");
                yield return new ais(89, 4.97, 7.8, 44.7, 14.2, 41, 20.15, 46.3, 10.74, 53.2, 172, 59.6, "f", "T_Sprnt");
                yield return new ais(90, 4, 4.2, 36.6, 12, 57, 25.36, 109, 20.86, 56.58, 167.9, 71.5, "f", "Tennis");
                yield return new ais(91, 4.4, 4, 40.8, 13.9, 73, 22.12, 98.1, 19.64, 56.01, 177.5, 69.7, "f", "Tennis");
                yield return new ais(92, 4.38, 7.9, 39.8, 13.5, 88, 21.25, 80.6, 17.07, 46.52, 162.5, 56.1, "f", "Tennis");
                yield return new ais(93, 4.08, 6.6, 37.8, 12.1, 182, 20.53, 68.3, 15.31, 51.75, 172.5, 61.1, "f", "Tennis");
                yield return new ais(94, 4.98, 6.4, 44.8, 14.8, 80, 17.06, 47.6, 11.07, 42.15, 166.7, 47.4, "f", "Tennis");
                yield return new ais(95, 5.16, 7.2, 44.3, 14.5, 88, 18.29, 61.9, 12.92, 48.76, 175, 56, "f", "Tennis");
                yield return new ais(96, 4.66, 6.4, 40.9, 13.9, 109, 18.37, 38.2, 8.45, 41.93, 157.9, 45.8, "f", "Tennis");
                yield return new ais(97, 4.19, 9, 39, 13.4, 69, 18.93, 43.5, 10.16, 42.95, 158.9, 47.8, "f", "Gym");
                yield return new ais(98, 4.53, 5, 40.7, 14, 41, 17.79, 56.8, 12.55, 38.3, 156.9, 43.8, "f", "Gym");
                yield return new ais(99, 4.09, 4.9, 36, 12.5, 66, 17.05, 41.6, 9.1, 34.36, 148.9, 37.8, "f", "Gym");
                yield return new ais(100, 4.42, 6.4, 42.8, 14.5, 63, 20.31, 58.9, 13.46, 39.03, 149, 45.1, "f", "Gym");
                yield return new ais(101, 5.13, 7.1, 46.8, 15.9, 34, 22.46, 44.5, 8.47, 61, 172.7, 67, "m", "Swim");
                yield return new ais(102, 4.83, 7.6, 45.2, 15.2, 97, 23.88, 41.8, 7.68, 69, 176.5, 74.4, "m", "Swim");
                yield return new ais(103, 5.09, 4.7, 46.6, 15.9, 55, 23.68, 33.7, 6.16, 74, 183, 79.3, "m", "Swim");
                yield return new ais(104, 5.17, 4.1, 44.9, 15, 76, 23.15, 50.9, 8.56, 80, 194.4, 87.5, "m", "Swim");
                yield return new ais(105, 5.11, 6.7, 46.1, 15.6, 93, 22.32, 40.5, 6.86, 78, 193.4, 83.5, "m", "Swim");
                yield return new ais(106, 5.03, 7.1, 45.1, 15.2, 46, 24.02, 51.2, 9.4, 71, 180.2, 78, "m", "Swim");
                yield return new ais(107, 5.32, 6, 47.5, 16.3, 155, 23.29, 54.4, 9.17, 71, 183, 78, "m", "Swim");
                yield return new ais(108, 4.75, 8.6, 45.5, 15.2, 99, 25.11, 52.3, 8.54, 78, 184, 85, "m", "Swim");
                yield return new ais(109, 5.34, 6.6, 48.6, 16.5, 35, 22.81, 57, 9.2, 77, 192.7, 84.7, "m", "Swim");
                yield return new ais(110, 4.87, 4.8, 44.9, 15.4, 124, 26.25, 65.3, 11.72, 81, 187.2, 92, "m", "Swim");
                yield return new ais(111, 5.33, 5.2, 47.8, 16.1, 176, 21.38, 52, 8.44, 66, 183.9, 72.3, "m", "Swim");
                yield return new ais(112, 4.81, 6.2, 45.2, 15.3, 107, 22.52, 42.7, 7.19, 77, 192, 83, "m", "Swim");
                yield return new ais(113, 4.32, 4.3, 41.6, 14, 177, 26.73, 35.2, 6.46, 91, 190.4, 96.9, "m", "Swim");
                yield return new ais(114, 4.87, 8.2, 43.8, 15, 130, 23.57, 49.2, 9, 78, 190.7, 85.7, "m", "Row");
                yield return new ais(115, 5.04, 7.1, 44, 14.8, 64, 25.84, 61.8, 12.61, 75, 181.8, 85.4, "m", "Row");
                yield return new ais(116, 4.4, 5.3, 42.5, 14.5, 109, 24.06, 46.5, 9.03, 78, 188.3, 85.3, "m", "Row");
                yield return new ais(117, 4.95, 5.9, 45.4, 15.5, 125, 23.85, 34.8, 6.96, 87, 198, 93.5, "m", "Row");
                yield return new ais(118, 4.78, 9.3, 43, 14.7, 150, 25.09, 60.2, 10.05, 78, 186, 86.8, "m", "Row");
                yield return new ais(119, 5.21, 6.8, 44.5, 15.4, 115, 23.84, 48.1, 9.56, 79, 192, 87.9, "m", "Row");
                yield return new ais(120, 5.22, 8.4, 47.5, 16.2, 89, 25.31, 44.5, 9.36, 79, 185.6, 87.2, "m", "Row");
                yield return new ais(121, 5.18, 6.5, 45.4, 14.9, 93, 19.69, 54, 10.81, 48, 165.3, 53.8, "m", "Row");
                yield return new ais(122, 5.4, 6.8, 49.5, 17.3, 183, 26.07, 44.7, 8.61, 82, 185.6, 89.8, "m", "Row");
                yield return new ais(123, 4.92, 5.4, 46.2, 15.8, 84, 25.5, 64.9, 9.53, 82, 189, 91.1, "m", "Row");
                yield return new ais(124, 5.24, 7.5, 46.5, 15.5, 70, 23.69, 43.8, 7.42, 82, 193.4, 88.6, "m", "Row");
                yield return new ais(125, 5.09, 10.1, 44.9, 14.8, 118, 26.79, 58.3, 9.79, 83, 185.6, 92.3, "m", "Row");
                yield return new ais(126, 4.83, 5, 43.8, 15.1, 61, 25.61, 52.8, 8.97, 88, 194.6, 97, "m", "Row");
                yield return new ais(127, 5.22, 6, 46.6, 15.7, 72, 25.06, 43.1, 7.49, 83, 189, 89.5, "m", "Row");
                yield return new ais(128, 4.71, 8, 45.5, 15.6, 91, 24.93, 78, 11.95, 78, 188.1, 88.2, "m", "Row");
                yield return new ais(129, 5.24, 7.2, 46.6, 15.9, 58, 22.96, 40.8, 7.35, 85, 200.4, 92.2, "m", "B_Ball");
                yield return new ais(130, 4.54, 5.9, 44.4, 15.6, 97, 20.69, 41.5, 7.16, 73, 195.3, 78.9, "m", "B_Ball");
                yield return new ais(131, 5.13, 5.8, 46.1, 15.9, 110, 23.97, 50.9, 8.77, 82, 194.1, 90.3, "m", "B_Ball");
                yield return new ais(132, 5, 6.7, 45.3, 15.7, 72, 24.64, 49.6, 9.56, 79, 187.9, 87, "m", "B_Ball");
                yield return new ais(133, 5.17, 8, 47.9, 16.4, 36, 25.93, 88.9, 14.53, 97, 209.4, 113.7, "m", "B_Ball");
                yield return new ais(134, 4.89, 7.5, 41.6, 14.4, 53, 23.69, 48.3, 8.51, 90, 203.4, 98, "m", "B_Ball");
                yield return new ais(135, 4.5, 9.2, 40.7, 13.7, 72, 25.38, 61.8, 10.64, 90, 198.7, 100.2, "m", "B_Ball");
                yield return new ais(136, 4.84, 8.3, 46.3, 15.9, 39, 22.68, 43, 7.06, 74, 187.1, 79.4, "m", "B_Ball");
                yield return new ais(137, 4.13, 8.9, 40.3, 13.5, 61, 23.36, 61.1, 8.87, 82, 196.6, 90.3, "m", "B_Ball");
                yield return new ais(138, 4.87, 7.4, 43.5, 15, 49, 22.44, 43.8, 7.88, 72, 186.1, 77.7, "m", "B_Ball");
                yield return new ais(139, 4.82, 6.4, 44.3, 14.8, 35, 22.57, 54.2, 9.2, 76, 192.8, 83.9, "m", "B_Ball");
                yield return new ais(140, 4.73, 6.7, 42.8, 14.9, 8, 19.81, 41.8, 7.19, 70, 195.2, 75.5, "m", "B_Ball");
                yield return new ais(141, 4.55, 5.6, 42.6, 14.4, 106, 21.19, 34.1, 6.06, 57, 169.1, 60.6, "m", "T_400m");
                yield return new ais(142, 4.71, 7.2, 43.6, 14, 32, 20.39, 30.5, 5.63, 67, 186.6, 71, "m", "T_400m");
                yield return new ais(143, 4.93, 7.3, 46.2, 15.1, 41, 21.12, 34, 6.59, 67, 184.4, 71.8, "m", "T_400m");
                yield return new ais(144, 5.21, 7.5, 47.5, 16.5, 20, 21.89, 46.7, 9.5, 70, 187.3, 76.8, "m", "T_400m");
                yield return new ais(145, 5.09, 8.9, 46.3, 15.4, 44, 29.97, 71.1, 13.97, 88, 185.1, 102.7, "m", "Field");
                yield return new ais(146, 5.11, 9.6, 48.2, 16.7, 103, 27.39, 65.9, 11.66, 83, 185.5, 94.2, "m", "Field");
                yield return new ais(147, 4.94, 6.3, 45.7, 15.5, 50, 23.11, 34.3, 6.43, 74, 184.9, 79, "m", "Field");
                yield return new ais(148, 4.87, 6.3, 45.8, 16.1, 41, 21.75, 34.6, 6.99, 62, 175, 66.6, "m", "T_400m");
                yield return new ais(149, 4.41, 4.5, 44.2, 15, 101, 20.89, 31.8, 6, 67, 185.4, 71.8, "m", "T_400m");
                yield return new ais(150, 4.86, 3.9, 44.9, 15.4, 73, 22.83, 34.5, 6.56, 70, 181, 74.8, "m", "T_400m");
                yield return new ais(151, 4.91, 9, 46.3, 15.4, 56, 22.02, 31, 6.03, 64, 176, 68.2, "m", "T_400m");
                yield return new ais(152, 4.93, 7.3, 45.2, 15.8, 74, 20.07, 32.6, 6.33, 58, 176.2, 62.3, "m", "T_400m");
                yield return new ais(153, 4.2, 4.5, 41.2, 14.3, 58, 20.15, 31.5, 6.82, 57, 174, 61, "m", "T_400m");
                yield return new ais(154, 5.1, 6.1, 45.3, 14.9, 87, 21.24, 32.6, 6.2, 73, 191, 77.5, "m", "T_400m");
                yield return new ais(155, 4.5, 6.1, 42.2, 14.7, 139, 19.63, 31, 5.93, 54, 171, 57.4, "m", "T_400m");
                yield return new ais(156, 4.89, 5.8, 45.5, 15.6, 82, 23.58, 28, 5.8, 67, 174, 71.4, "m", "T_Sprnt");
                yield return new ais(157, 5.13, 4, 44.1, 15.2, 87, 21.65, 33.7, 6.56, 66, 180.2, 70.3, "m", "T_Sprnt");
                yield return new ais(158, 4.88, 4.3, 45.6, 15.5, 80, 25.17, 30.3, 6.76, 75, 178.5, 80.2, "m", "T_Sprnt");
                yield return new ais(159, 5, 8.2, 46.8, 14.7, 67, 23.25, 38, 7.22, 78, 190.3, 84.2, "m", "Field");
                yield return new ais(160, 5.48, 4.6, 49.4, 18, 132, 32.52, 55.7, 8.51, 102, 185, 111.3, "m", "Field");
                yield return new ais(161, 5.93, 6.4, 49.1, 16.1, 43, 22.59, 37.5, 7.72, 74, 189, 80.7, "m", "Field");
                yield return new ais(162, 5.01, 8.9, 46, 15.9, 212, 30.18, 112.5, 19.94, 78, 180.1, 97.9, "m", "Field");
                yield return new ais(163, 5.48, 6.2, 48.2, 16.3, 94, 34.42, 82.7, 13.91, 106, 189.2, 123.2, "m", "Field");
                yield return new ais(164, 5.16, 8.4, 44.4, 15.5, 213, 21.86, 29.7, 6.1, 68, 182.6, 72.9, "m", "T_Sprnt");
                yield return new ais(165, 4.64, 9, 42.9, 14.9, 122, 23.99, 38.9, 7.52, 77, 186, 83, "m", "T_Sprnt");
                yield return new ais(166, 6.72, 7.1, 59.7, 19.2, 76, 24.81, 44.8, 9.56, 69, 174.9, 75.9, "m", "T_Sprnt");
                yield return new ais(167, 4.83, 6.6, 43.8, 14.3, 53, 21.68, 30.9, 6.06, 66, 180.6, 70.7, "m", "T_400m");
                yield return new ais(168, 5.34, 7.6, 48.3, 16.2, 91, 21.04, 44, 7.35, 62, 178.6, 67.1, "m", "T_400m");
                yield return new ais(169, 5.13, 4.6, 45.3, 16.8, 36, 23.12, 37.5, 6, 65, 173, 69.2, "m", "T_400m");
                yield return new ais(170, 4.68, 4.8, 43, 14.8, 101, 20.76, 37.6, 6.92, 62, 179.7, 67.1, "m", "T_400m");
                yield return new ais(171, 5, 5.2, 45.1, 15.1, 184, 23.13, 31.7, 6.33, 66, 174.6, 70.5, "m", "T_Sprnt");
                yield return new ais(172, 4.99, 7.2, 41.4, 14.9, 44, 22.35, 36.6, 5.9, 67, 178, 70.8, "m", "T_Sprnt");
                yield return new ais(173, 5.49, 5.9, 47.7, 15.9, 66, 22.28, 48, 8.84, 65, 178.5, 71, "m", "T_400m");
                yield return new ais(174, 5.59, 7.9, 49.7, 17.2, 220, 23.55, 41.9, 8.94, 63, 171.3, 69.1, "m", "T_Sprnt");
                yield return new ais(175, 5.03, 6.6, 44.7, 15.9, 191, 19.85, 30.9, 6.53, 59, 178, 62.9, "m", "T_400m");
                yield return new ais(176, 5.5, 6.4, 48.1, 16.5, 40, 26.51, 52.8, 9.4, 86, 189.1, 94.8, "m", "T_Sprnt");
                yield return new ais(177, 5.11, 9.3, 45.4, 15.8, 189, 24.78, 43.2, 8.18, 87, 195.4, 94.6, "m", "Field");
                yield return new ais(178, 4.96, 8.3, 45.3, 15.7, 141, 33.73, 113.5, 17.41, 89, 179.1, 108.2, "m", "Field");
                yield return new ais(179, 5.01, 8.9, 46, 15.9, 212, 30.18, 96.9, 18.08, 80, 180.1, 97.9, "m", "Field");
                yield return new ais(180, 5.11, 8.7, 46.5, 16.3, 97, 23.31, 49.3, 9.86, 68, 179.6, 75.2, "m", "Field");
                yield return new ais(181, 5.69, 10.8, 50.5, 18.5, 53, 24.51, 42.3, 7.29, 69, 174.7, 74.8, "m", "T_Sprnt");
                yield return new ais(182, 4.63, 9.1, 42.1, 14.4, 126, 25.37, 96.3, 18.72, 77, 192.7, 94.2, "m", "W_Polo");
                yield return new ais(183, 4.91, 10.2, 45, 15.2, 234, 23.67, 56.5, 10.12, 68, 179.3, 76.1, "m", "W_Polo");
                yield return new ais(184, 4.95, 7.5, 44.5, 15, 50, 24.28, 105.7, 19.17, 77, 197.5, 94.7, "m", "W_Polo");
                yield return new ais(185, 5.34, 10, 46.8, 16.2, 94, 25.82, 100.7, 17.24, 71, 182.7, 86.2, "m", "W_Polo");
                yield return new ais(186, 5.16, 12.9, 47.6, 15.6, 156, 21.93, 56.8, 9.89, 72, 190.5, 79.6, "m", "W_Polo");
                yield return new ais(187, 5.29, 12.7, 48, 16.2, 124, 23.38, 75.9, 13.06, 74, 191, 85.3, "m", "W_Polo");
                yield return new ais(188, 5.02, 6.1, 43.6, 14.8, 87, 23.07, 52.8, 8.84, 68, 179.6, 74.4, "m", "W_Polo");
                yield return new ais(189, 5.01, 9.8, 46.5, 15.8, 97, 25.21, 47.8, 8.87, 85, 192.6, 93.5, "m", "W_Polo");
                yield return new ais(190, 5.03, 7.5, 43.6, 14.4, 102, 23.25, 76, 14.69, 75, 194.1, 87.6, "m", "W_Polo");
                yield return new ais(191, 5.25, 7.4, 47.3, 15.8, 55, 22.93, 61.2, 8.64, 78, 193, 85.4, "m", "W_Polo");
                yield return new ais(192, 5.08, 8.5, 46.3, 15.6, 117, 26.86, 75.6, 14.98, 86, 193.9, 101, "m", "W_Polo");
                yield return new ais(193, 5.04, 6, 45.9, 15, 52, 21.26, 43.3, 7.82, 69, 187.7, 74.9, "m", "W_Polo");
                yield return new ais(194, 4.63, 14.3, 44.8, 15, 133, 25.43, 49.5, 8.97, 79, 185.3, 87.3, "m", "W_Polo");
                yield return new ais(195, 5.11, 7, 47.7, 15.8, 214, 24.54, 70, 11.63, 80, 191.5, 90, "m", "W_Polo");
                yield return new ais(196, 5.34, 6.2, 49.8, 17.2, 143, 27.79, 75.7, 13.49, 82, 184.6, 94.7, "m", "W_Polo");
                yield return new ais(197, 4.86, 8.9, 46.9, 15.8, 65, 23.58, 57.7, 10.25, 68, 179.9, 76.3, "m", "W_Polo");
                yield return new ais(198, 4.9, 7.6, 45.6, 16, 90, 27.56, 67.2, 11.79, 82, 183.9, 93.2, "m", "W_Polo");
                yield return new ais(199, 5.66, 8.3, 50.2, 17.7, 38, 23.76, 56.5, 10.05, 72, 183.5, 80, "m", "Tennis");
                yield return new ais(200, 5.03, 6.4, 42.7, 14.3, 122, 22.01, 47.6, 8.51, 68, 183.1, 73.8, "m", "Tennis");
                yield return new ais(201, 4.97, 8.8, 43, 14.9, 233, 22.34, 60.4, 11.5, 63, 178.4, 71.1, "m", "Tennis");
                yield return new ais(202, 5.38, 6.3, 46, 15.7, 32, 21.07, 34.9, 6.26, 72, 190.8, 76.7, "m", "Tennis");
            }
        }
    }
}
