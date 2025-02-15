// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// sorption data set
    /// </summary>

    public class sorption
    {
        public readonly int κ;
        public readonly double? m5;
        public readonly double m10;
        public readonly double? m30;
        public readonly double? m60;
        public readonly double? m90;
        public readonly double? m120;
        public readonly double ct;
        public readonly string Cultivar;
        public readonly int Dose;
        public readonly int rep;
        public readonly int year;
        public readonly string year_rep;
        public readonly string gp;
        public readonly int inyear;

        public sorption(int κ, double? m5, double m10, double? m30, double? m60, double? m90, double? m120, double ct, string Cultivar, int Dose, int rep, int year, string year_rep, string gp, int inyear)
        {
            this.κ = κ;
            this.m5 = m5;
            this.m10 = m10;
            this.m30 = m30;
            this.m60 = m60;
            this.m90 = m90;
            this.m120 = m120;
            this.ct = ct;
            this.Cultivar = Cultivar;
            this.Dose = Dose;
            this.rep = rep;
            this.year = year;
            this.year_rep = year_rep;
            this.gp = gp;
            this.inyear = inyear;
        }

        public static IEnumerable<sorption> Data
        {
            get
            {
                yield return new sorption(1, 7.8, 8.04, 8.89, 8.05, 7.89, 5.08, 15.5941666666667, "ROYAL", 5, 1, 1988, "1988:1", "ROYAL1", 1);
                yield return new sorption(2, 10, 10.69, 9.56, 9.9, 10.78, 9.84, 20.2604166666667, "ROYAL", 8, 1, 1988, "1988:1", "ROYAL1", 2);
                yield return new sorption(3, 15.72, 16.17, 14.26, 14.13, 13.7, 13.65, 28.6029166666667, "ROYAL", 12, 1, 1988, "1988:1", "ROYAL1", 3);
                yield return new sorption(4, 18.4, 18.48, 16.04, 15.93, 15.88, 15.8, 32.6883333333333, "ROYAL", 16, 1, 1988, "1988:1", "ROYAL1", 4);
                yield return new sorption(5, 25.33, 24.96, 21.92, 22.58, 22.12, 22.31, 45.4270833333333, "ROYAL", 20, 1, 1988, "1988:1", "ROYAL1", 5);
                yield return new sorption(6, 25.13, 22.66, 22.49, 23.7, 21.89, 21.66, 45.4429166666667, "ROYAL", 24, 1, 1988, "1988:1", "ROYAL1", 6);
                yield return new sorption(7, 8.3, 7.86, 7.88, 7.98, 8.37, 8.5, 16.2583333333333, "ROYAL", 5, 2, 1988, "1988:2", "ROYAL2", 1);
                yield return new sorption(8, 10.74, 11.93, 11.08, 12.07, 14.49, 13.81, 25.1770833333333, "ROYAL", 8, 2, 1988, "1988:2", "ROYAL2", 2);
                yield return new sorption(9, 15.79, 16.26, 17.83, 16.13, 15.92, 15.87, 32.7829166666667, "ROYAL", 12, 2, 1988, "1988:2", "ROYAL2", 3);
                yield return new sorption(10, 20.26, 20.19, 20.12, 19.62, 20.31, 20.33, 40.1695833333333, "ROYAL", 16, 2, 1988, "1988:2", "ROYAL2", 4);
                yield return new sorption(11, 23.08, 21.64, 22.8, 22.66, 22.535, 22.41, 45.0933333333333, "ROYAL", 20, 2, 1988, "1988:2", "ROYAL2", 5);
                yield return new sorption(12, 26.79, 25.48, 28.2, 26.8, 26.605, 26.41, 53.7120833333333, "ROYAL", 24, 2, 1988, "1988:2", "ROYAL2", 6);
                yield return new sorption(13, 12.24, 11.27, 11.82, 10.82, 11.01, 10.66, 22.3829166666667, "BRAEBURN", 8, 1, 1988, "1988:1", "BRAEBURN1", 1);
                yield return new sorption(14, 11.62, 13.89, 12.09, 12.6, 13.24, 13.23, 25.61125, "BRAEBURN", 12, 1, 1988, "1988:1", "BRAEBURN1", 2);
                yield return new sorption(15, 16.06, 16.86, 16.65, 16.52, 16.39, 16.59, 33.06, "BRAEBURN", 16, 1, 1988, "1988:1", "BRAEBURN1", 3);
                yield return new sorption(16, 26.3641763606749, 26.51, 25.04, 26.36, 23.97, 23.83, 50.3742720450844, "BRAEBURN", 20, 1, 1988, "1988:1", "BRAEBURN1", 4);
                yield return new sorption(17, 28.07, 28.03, 26.95, 26.35, 26.59, 24.8, 53.2475, "BRAEBURN", 24, 1, 1988, "1988:1", "BRAEBURN1", 5);
                yield return new sorption(18, 30.94, 29.66, 29.49, 30.71, 28.95, 27.67, 59.0816666666667, "BRAEBURN", 30, 1, 1988, "1988:1", "BRAEBURN1", 6);
                yield return new sorption(19, 12.12, 11.77, 11.29, 11.99, 11.74, 11.45, 23.39875, "BRAEBURN", 8, 2, 1988, "1988:2", "BRAEBURN2", 1);
                yield return new sorption(20, 17.22, 16.96, 16.05, 16.49, 16.54, 16.16, 32.9283333333333, "BRAEBURN", 12, 2, 1988, "1988:2", "BRAEBURN2", 2);
                yield return new sorption(21, 20.2, 19.82, 19.64, 19.4, 20.29, 19.04, 39.4425, "BRAEBURN", 16, 2, 1988, "1988:2", "BRAEBURN2", 3);
                yield return new sorption(22, 23.22, 24.05, 23.68, 23.46, 24.19, 23.02, 47.3595833333333, "BRAEBURN", 20, 2, 1988, "1988:2", "BRAEBURN2", 4);
                yield return new sorption(23, 27.6, 26.55, 27.6, 27.1, 27.28, 27.46, 54.53625, "BRAEBURN", 24, 2, 1988, "1988:2", "BRAEBURN2", 5);
                yield return new sorption(24, 30.27, 30.41, 30.93, 30.22, 29.85, 29.84, 60.5016666666667, "BRAEBURN", 30, 2, 1988, "1988:2", "BRAEBURN2", 6);
                yield return new sorption(25, 14.61, 14.6, 14.44, 14.27, 15.65, 14.13, 29.3770833333333, "Fuji", 8, 1, 1988, "1988:1", "Fuji1", 1);
                yield return new sorption(26, 15.72, 17.2, 17.23, 16.03, 15.78, 16.39, 32.73, "Fuji", 12, 1, 1988, "1988:1", "Fuji1", 2);
                yield return new sorption(27, 19.62, 20.43, 19.61, 19.68, 19.34, 19.21, 39.1920833333333, "Fuji", 16, 1, 1988, "1988:1", "Fuji1", 3);
                yield return new sorption(28, 21.66, 22.56, 22.61, 20.68, 20.95, 20.74, 42.8283333333333, "Fuji", 20, 1, 1988, "1988:1", "Fuji1", 4);
                yield return new sorption(29, 26.77, 26.25, 26.25, 25.38, 25.73, 24.7, 51.4825, "Fuji", 24, 1, 1988, "1988:1", "Fuji1", 5);
                yield return new sorption(30, 30.64, 30.51, 31.62, 29.29, 29.29, 30.23, 60.20875, "Fuji", 30, 1, 1988, "1988:1", "Fuji1", 6);
                yield return new sorption(31, 12.62, 12.74, 12.43, 13.15, 12.63, 12.31, 25.3783333333333, "Fuji", 8, 2, 1988, "1988:2", "Fuji2", 1);
                yield return new sorption(32, 15.44, 15.7, 19.17, 16.76, 15.74, 15.63, 33.3458333333333, "Fuji", 12, 2, 1988, "1988:2", "Fuji2", 2);
                yield return new sorption(33, 19.17, 20.63, 20.45, 20.44, 19.24, 20.01, 40.0575, "Fuji", 16, 2, 1988, "1988:2", "Fuji2", 3);
                yield return new sorption(34, 23.76, 24.5, 24.4, 24.11, 23.33, 22.55, 47.5983333333333, "Fuji", 20, 2, 1988, "1988:2", "Fuji2", 4);
                yield return new sorption(35, 27.46, 26.93, 27.11, 27.03, 27.07, 26.23, 53.94625, "Fuji", 24, 2, 1988, "1988:2", "Fuji2", 5);
                yield return new sorption(36, 32.17, 32.01, 31.06, 31.15, 29.85, 31.06, 61.8966666666667, "Fuji", 30, 2, 1988, "1988:2", "Fuji2", 6);
                yield return new sorption(37, 13.4150854912908, 14, 13.58, 13.49, 13.7, 14.2, 27.3968856864114, "GRANNY", 8, 1, 1988, "1988:1", "GRANNY1", 1);
                yield return new sorption(38, 15.64, 16.32, 16.12, 16.32, 17.73, 16.04, 33.1066666666667, "GRANNY", 12, 1, 1988, "1988:1", "GRANNY1", 2);
                yield return new sorption(39, 19.99, 20.7, 20.31, 19.72, 20.04, 19.9, 40.12875, "GRANNY", 16, 1, 1988, "1988:1", "GRANNY1", 3);
                yield return new sorption(40, 23.96, 25.31, 24.34, 24.06, 23.67, 21.67, 47.6920833333333, "GRANNY", 20, 1, 1988, "1988:1", "GRANNY1", 4);
                yield return new sorption(41, 27.67, 26.9, 26.69, 28.38, 27.5, 26.62, 54.77875, "GRANNY", 24, 1, 1988, "1988:1", "GRANNY1", 5);
                yield return new sorption(42, 31.82, 32.88, 32.12, 31.75, 31.05, 30.49, 63.2333333333333, "GRANNY", 30, 1, 1988, "1988:1", "GRANNY1", 6);
                yield return new sorption(43, 13.88, 13.92, 14.36, 13.08, 13.52, 13.5, 27.2933333333333, "GRANNY", 8, 2, 1988, "1988:2", "GRANNY2", 1);
                yield return new sorption(44, 15.54, 16.78, 17.36, 16.65, 15.94, 15.84, 32.9266666666667, "GRANNY", 12, 2, 1988, "1988:2", "GRANNY2", 2);
                yield return new sorption(45, 19.83, 20.84, 21.17, 20.08, 19.425, 18.77, 40.08625, "GRANNY", 16, 2, 1988, "1988:2", "GRANNY2", 3);
                yield return new sorption(46, 23.76, 24.29, 24.1, 24.7, 23.69, 22.68, 47.9370833333333, "GRANNY", 20, 2, 1988, "1988:2", "GRANNY2", 4);
                yield return new sorption(47, 28.64, 27.77, 27.49, 26.3, 26.19, 25.81, 53.5170833333333, "GRANNY", 24, 2, 1988, "1988:2", "GRANNY2", 5);
                yield return new sorption(48, 32.04, 32.15, 30.55, 30.6, 30.65, 30.61, 61.7095833333333, "GRANNY", 30, 2, 1988, "1988:2", "GRANNY2", 6);
                yield return new sorption(49, 14.37, 14.65, 14.03, 13.84, 14.05, 13.92, 28.1191666666667, "Red Delicious", 8, 1, 1988, "1988:1", "Red Delicious1", 1);
                yield return new sorption(50, 15.69, 15.84, 15.785, 15.73, 15.23, 14.93, 31.0508333333333, "Red Delicious", 12, 1, 1988, "1988:1", "Red Delicious1", 2);
                yield return new sorption(51, 19.28, 20.3, 20.43, 19.47, 18.51, 18.36, 38.7316666666667, "Red Delicious", 16, 1, 1988, "1988:1", "Red Delicious1", 3);
                yield return new sorption(52, 23.7251648717449, 23.83, 22.86, 23.55, 23.19, 22.64, 46.4852289423014, "Red Delicious", 20, 1, 1988, "1988:1", "Red Delicious1", 4);
                yield return new sorption(53, 26.49, 26.14, 27.18, 25.76, 25.26, 24.72, 51.7720833333333, "Red Delicious", 24, 1, 1988, "1988:1", "Red Delicious1", 5);
                yield return new sorption(54, 32.68, 33.51, 33.48, 33.45, 31.11, 29.83, 64.75375, "Red Delicious", 30, 1, 1988, "1988:1", "Red Delicious1", 6);
                yield return new sorption(55, 15.54, 14.66, 14.01, 13.88, 14.51, 14.15, 28.5666666666667, "Red Delicious", 8, 2, 1988, "1988:2", "Red Delicious2", 1);
                yield return new sorption(56, 16.29, 15.96, 16.195, 16.43, 15.9, 15.69, 32.1966666666667, "Red Delicious", 12, 2, 1988, "1988:2", "Red Delicious2", 2);
                yield return new sorption(57, 19.49, 21.2, 20.695, 20.19, 18.27, 18.83, 39.4133333333333, "Red Delicious", 16, 2, 1988, "1988:2", "Red Delicious2", 3);
                yield return new sorption(58, 26.1, 26.9, 27.39, 27.88, 26.23, 25.39, 53.6816666666667, "Red Delicious", 20, 2, 1988, "1988:2", "Red Delicious2", 4);
                yield return new sorption(59, 27.5582568478733, 27.26, 27.92, 27.06, 26.49, 26.02, 54.0372821059842, "Red Delicious", 24, 2, 1988, "1988:2", "Red Delicious2", 5);
                yield return new sorption(60, 32.52, 32.14, 32.29, 31.01, 30.41, 29.94, 62.41, "Red Delicious", 30, 2, 1988, "1988:2", "Red Delicious2", 6);
                yield return new sorption(61, 13.13, 13.4, 13.25, 13.19, 13, 12.4, 26.14875, "Red Delicious", 8, 3, 1988, "1988:3", "Red Delicious3", 1);
                yield return new sorption(62, 15.32, 16.14, 15.41, 16.84, 15.54, 15.55, 31.7758333333333, "Red Delicious", 12, 3, 1988, "1988:3", "Red Delicious3", 2);
                yield return new sorption(63, 20.12, 21.11, 21.21, 20.69, 18.76, 19.65, 40.3879166666667, "Red Delicious", 16, 3, 1988, "1988:3", "Red Delicious3", 3);
                yield return new sorption(64, 23.24, 25.22, 23.81, 23.4, 22.71, 23.81, 47.0875, "Red Delicious", 20, 3, 1988, "1988:3", "Red Delicious3", 4);
                yield return new sorption(65, 28.85, 27.08, 27.95, 26.48, 26.38, 25.78, 53.76875, "Red Delicious", 24, 3, 1988, "1988:3", "Red Delicious3", 5);
                yield return new sorption(66, 32.95, 32.53, 33.59, 33.21, 31.29, 30.41, 64.7441666666667, "Red Delicious", 30, 3, 1988, "1988:3", "Red Delicious3", 6);
                yield return new sorption(67, 13.72, 13.85, 13.38, 13.09, 13.51, 13.04, 26.7354166666667, "Gala", 8, 1, 1989, "1989:1", "Gala4", 1);
                yield return new sorption(68, 15.82, 17.66, 16.03, 16.05, 15.79, 15.39, 32.1033333333333, "Gala", 12, 1, 1989, "1989:1", "Gala4", 2);
                yield return new sorption(69, 20.35, 21.1, 20.85, 20.3, 20.08, 20.66, 40.9820833333333, "Gala", 16, 1, 1989, "1989:1", "Gala4", 3);
                yield return new sorption(70, 23.96, 24.05, 24.26, 26.23, 23.4, 23.07, 48.69625, "Gala", 20, 1, 1989, "1989:1", "Gala4", 4);
                yield return new sorption(71, 27.39, 26.65, 27.14, 26.79, 26.3, 25.95, 53.3166666666667, "Gala", 24, 1, 1989, "1989:1", "Gala4", 5);
                yield return new sorption(72, 33.18, 33.06, 32.88, 33.03, 31.65, 31.68, 64.995, "Gala", 30, 1, 1989, "1989:1", "Gala4", 6);
                yield return new sorption(73, 13.09, 15.48, 14.6, 12.6, 13.26, null, 27.1040984981597, "Gala", 8, 2, 1989, "1989:2", "Gala5", 1);
                yield return new sorption(74, null, 16.49, 17.1, 16.22, null, 16.46, 33.1152541053518, "Gala", 12, 2, 1989, "1989:2", "Gala5", 2);
                yield return new sorption(75, 20.12, 22.33, 20.63, 20.17, null, 19.62, 40.7106708886953, "Gala", 16, 2, 1989, "1989:2", "Gala5", 3);
                yield return new sorption(76, 24.12, 23.26, 23.39, 22.93, null, 22.25, 45.9823271577513, "Gala", 20, 2, 1989, "1989:2", "Gala5", 4);
                yield return new sorption(77, 26.56, 27.12, 28.32, 26.73, null, 25.81, 53.682656056134, "Gala", 24, 2, 1989, "1989:2", "Gala5", 5);
                yield return new sorption(78, 32.33, 32.19, 31.87, null, null, 30.24, 62.5694727533174, "Gala", 30, 2, 1989, "1989:2", "Gala5", 6);
                yield return new sorption(79, 14.66, 14.86, 14.04, null, 14.69, 14.77, 29.0990103044695, "Red Delicious", 8, 1, 1989, "1989:1", "Red Delicious4", 1);
                yield return new sorption(80, 16.55, 17.67, 17.69, null, 16.08, 17.06, 33.9473321403348, "Red Delicious", 12, 1, 1989, "1989:1", "Red Delicious4", 2);
                yield return new sorption(81, 20.76, 21.85, 21.16, null, 20.05, 21, 41.7075945998572, "Red Delicious", 16, 1, 1989, "1989:1", "Red Delicious4", 3);
                yield return new sorption(82, 24.86, 24.99, 25.77, null, 23.9, 24.5, 49.5625684076822, "Red Delicious", 20, 1, 1989, "1989:1", "Red Delicious4", 4);
                yield return new sorption(83, 28.57, 27.66, 26.95, null, 27.31, 26.15, 54.326580708295, "Red Delicious", 24, 1, 1989, "1989:1", "Red Delicious4", 5);
                yield return new sorption(84, 32.92, 33.9, 31.55, null, 31.71, 32.1, 64.32503985641, "Red Delicious", 30, 1, 1989, "1989:1", "Red Delicious4", 6);
                yield return new sorption(85, 15.21, 14.99, 14.37, 15.5, 15.31, 14.75, 30.1041666666667, "Red Delicious", 8, 2, 1989, "1989:2", "Red Delicious5", 1);
                yield return new sorption(86, 18.13, 19.42, 18.93, 19.03, 18.8, 19, 37.8645833333333, "Red Delicious", 12, 2, 1989, "1989:2", "Red Delicious5", 2);
                yield return new sorption(87, 20.24, 21.75, 21.26, 21.08, 20.8, 20.72, 42.0395833333333, "Red Delicious", 16, 2, 1989, "1989:2", "Red Delicious5", 3);
                yield return new sorption(88, 24.22, 25.59, 24.9, 25.01, 24.56, 24.65, 49.68125, "Red Delicious", 20, 2, 1989, "1989:2", "Red Delicious5", 4);
                yield return new sorption(89, 28.4, 27.28, 28.1, 28.31, 28.07, 28.29, 56.2041666666667, "Red Delicious", 24, 2, 1989, "1989:2", "Red Delicious5", 5);
                yield return new sorption(90, 31.71, 32.38, 31.17, 31.66, 32.44, 30.99, 63.4945833333333, "Red Delicious", 30, 2, 1989, "1989:2", "Red Delicious5", 6);
                yield return new sorption(91, 14.31, 14.65, 13.83, 13.29, 14.01, 13.82, 27.7083333333333, "Splendour", 8, 1, 1989, "1989:1", "Splendour4", 1);
                yield return new sorption(92, 16.34, 18.26, 18.12, 17.28, 16.76, 16.68, 34.5866666666667, "Splendour", 12, 1, 1989, "1989:1", "Splendour4", 2);
                yield return new sorption(93, 20.43, 21.61, 20.81, 20.07, 19.69, 19.16, 40.3966666666667, "Splendour", 16, 1, 1989, "1989:1", "Splendour4", 3);
                yield return new sorption(94, 24.58, 25.36, 24.28, 22.87, 22.31, 22.02, 46.5675, "Splendour", 20, 1, 1989, "1989:1", "Splendour4", 4);
                yield return new sorption(95, 28.31, 27.56, 26.95, 25.44, 25.16, 24.47, 51.9270833333333, "Splendour", 24, 1, 1989, "1989:1", "Splendour4", 5);
                yield return new sorption(96, 32.16, 33.27, 29.91, 32.1, 30.93, 30.36, 62.51875, "Splendour", 30, 1, 1989, "1989:1", "Splendour4", 6);
                yield return new sorption(97, 14.66, 14.87, 14.14, 13.2, 14.18, 13.98, 28.0070833333333, "Splendour", 8, 2, 1989, "1989:2", "Splendour5", 1);
                yield return new sorption(98, 16.93, 18.38, 17.91, 17.78, 16.93, 16.64, 34.9229166666667, "Splendour", 12, 2, 1989, "1989:2", "Splendour5", 2);
                yield return new sorption(99, 21.63, 22.56, 22.06, 21.04, 20.66, 20.27, 42.5129166666667, "Splendour", 16, 2, 1989, "1989:2", "Splendour5", 3);
                yield return new sorption(100, 28.02, 29.29, 27.73, 26.29, 28.06, 25.32, 54.66375, "Splendour", 23, 2, 1989, "1989:2", "Splendour5", 4);
                yield return new sorption(101, 29.56, 28.76, 27.86, 26.17, 26.27, 25.42, 53.87, "Splendour", 24, 2, 1989, "1989:2", "Splendour5", 5);
                yield return new sorption(102, 33.51, 34.5, 30.93, 32.31, 31.89, 31.08, 64.13375, "Splendour", 30, 2, 1989, "1989:2", "Splendour5", 6);
                yield return new sorption(103, 9.6, 9.6, null, null, null, 8.8, 18.5824855991612, "Pacific Rose", 8, 1, 1998, "1998:1", "Pacific Rose6", 1);
                yield return new sorption(104, 14.7, 14.9, null, null, null, 13.9, 28.8606229093761, "Pacific Rose", 12, 1, 1998, "1998:1", "Pacific Rose6", 2);
                yield return new sorption(105, 20.2, 19.9, null, null, null, 18.6, 38.7428915347084, "Pacific Rose", 16, 1, 1998, "1998:1", "Pacific Rose6", 3);
                yield return new sorption(106, 23.1, 21.9, null, null, null, 21.4, 44.005165828454, "Pacific Rose", 20, 1, 1998, "1998:1", "Pacific Rose6", 4);
                yield return new sorption(107, 27.6, 27.5, null, null, null, 25.5, 53.0718948475477, "Pacific Rose", 24, 1, 1998, "1998:1", "Pacific Rose6", 5);
                yield return new sorption(108, 34.6, 34.4, null, null, null, 31.2, 65.5943521904179, "Pacific Rose", 30, 1, 1998, "1998:1", "Pacific Rose6", 6);
                yield return new sorption(109, 9.6, 9.2, null, null, null, 8.7, 18.2871215937773, "Pacific Rose", 8, 2, 1998, "1998:2", "Pacific Rose7", 1);
                yield return new sorption(110, 14.6, 14.6, null, null, null, 13.6, 28.3505741615298, "Pacific Rose", 12, 2, 1998, "1998:2", "Pacific Rose7", 2);
                yield return new sorption(111, 20.1, 19.9, null, null, null, 18.2, 38.2645874114604, "Pacific Rose", 16, 2, 1998, "1998:2", "Pacific Rose7", 3);
                yield return new sorption(112, 23.6, 23.4, null, null, null, 21.5, 45.0371825321677, "Pacific Rose", 20, 2, 1998, "1998:2", "Pacific Rose7", 4);
                yield return new sorption(113, 26.6, 26.7, null, null, null, 24.2, 50.8430244635861, "Pacific Rose", 24, 2, 1998, "1998:2", "Pacific Rose7", 5);
                yield return new sorption(114, 33.8, 32.7, null, null, null, 30, 63.142408296645, "Pacific Rose", 30, 2, 1998, "1998:2", "Pacific Rose7", 6);
                yield return new sorption(115, 9.8, 9.9, null, null, null, 8.9, 18.920169740748, "Pacific Rose", 8, 3, 1998, "1998:3", "Pacific Rose8", 1);
                yield return new sorption(116, 15.7, 15.3, null, null, null, 13.7, 29.2759022524363, "Pacific Rose", 12, 3, 1998, "1998:3", "Pacific Rose8", 2);
                yield return new sorption(117, 21.2, 21, null, null, null, 18.8, 39.9190586607558, "Pacific Rose", 16, 3, 1998, "1998:3", "Pacific Rose8", 3);
                yield return new sorption(118, 24.3, 24.3, null, null, null, 22.2, 46.528539080176, "Pacific Rose", 20, 3, 1998, "1998:3", "Pacific Rose8", 4);
                yield return new sorption(119, 28.9, 28.1, null, null, null, 25.3, 53.7142087099033, "Pacific Rose", 24, 3, 1998, "1998:3", "Pacific Rose8", 5);
                yield return new sorption(120, 35.7, 35.4, null, null, null, 31, 66.33453532942, "Pacific Rose", 30, 3, 1998, "1998:3", "Pacific Rose8", 6);
                yield return new sorption(121, 14.4, 13.3, 12.9, 14.2, 13.6, 13.6, 27.2458333333333, "Fuji", 8, 1, 1998, "1998:1", "Fuji6", 1);
                yield return new sorption(122, 14.8, 16.2, 15.5, 16, 16, 15.9, 31.6583333333333, "Fuji", 12, 1, 1998, "1998:1", "Fuji6", 2);
                yield return new sorption(123, 21, 22, 21.6, 21.4, 21.5, 21.5, 43.0333333333333, "Fuji", 16, 1, 1998, "1998:1", "Fuji6", 3);
                yield return new sorption(124, 23.8, 24.4, 24.3, 24.1, 24, 23.7, 48.1583333333333, "Fuji", 20, 1, 1998, "1998:1", "Fuji6", 4);
                yield return new sorption(125, 27.7, 27.1, 28, 27.7, 27.6, 27.4, 55.275, "Fuji", 24, 1, 1998, "1998:1", "Fuji6", 5);
                yield return new sorption(126, 33, 30.2, 33, 32.6, 32.4, 32.3, 64.7416666666667, "Fuji", 30, 1, 1998, "1998:1", "Fuji6", 6);
                yield return new sorption(127, 12.2, 12.6, 12.7, 12.4, 12.5, 12.2, 24.9416666666667, "Fuji", 8, 2, 1998, "1998:2", "Fuji7", 1);
                yield return new sorption(128, 16.4, 17.5, 16.6, 16.7, 16.4, 16.5, 33.2875, "Fuji", 12, 2, 1998, "1998:2", "Fuji7", 2);
                yield return new sorption(129, 20.4, 21.1, 20.4, 20.3, 20.4, 20.3, 40.8708333333333, "Fuji", 16, 2, 1998, "1998:2", "Fuji7", 3);
                yield return new sorption(130, 24.1, 24.9, 23.9, 24, 23.9, 23.8, 48.0583333333333, "Fuji", 20, 2, 1998, "1998:2", "Fuji7", 4);
                yield return new sorption(131, 26.8, 27.7, 27.9, 26.9, 27.3, 26.8, 54.5458333333333, "Fuji", 24, 2, 1998, "1998:2", "Fuji7", 5);
                yield return new sorption(132, 32.8, 34.1, 35.2, 32.9, 32.7, 32.8, 66.8708333333333, "Fuji", 30, 2, 1998, "1998:2", "Fuji7", 6);
                yield return new sorption(133, 13.1, 13.1, 13, 13.7, 13.6, 13.7, 26.8583333333333, "Fuji", 8, 3, 1998, "1998:3", "Fuji8", 1);
                yield return new sorption(134, 16.1, 17.2, 16.9, 17.3, 17.2, 17.2, 34.1875, "Fuji", 12, 3, 1998, "1998:3", "Fuji8", 2);
                yield return new sorption(135, 21.6, 22, 21.8, 21.6, 21.6, 21.4, 43.3166666666667, "Fuji", 16, 3, 1998, "1998:3", "Fuji8", 3);
                yield return new sorption(136, 24.3, 24.8, 24.6, 24.7, 24.3, 24.3, 49.0291666666667, "Fuji", 20, 3, 1998, "1998:3", "Fuji8", 4);
                yield return new sorption(137, 27.4, 27.1, 27.8, 27.7, 27.6, 27.4, 55.1541666666667, "Fuji", 24, 3, 1998, "1998:3", "Fuji8", 5);
                yield return new sorption(138, 33.6, 33.8, 33.5, 32.9, 33, 32.9, 66.375, "Fuji", 30, 3, 1998, "1998:3", "Fuji8", 6);
                yield return new sorption(139, 12.8, 13.4, 12.7, 13.4, 13.4, 13.4, 26.4333333333333, "Red Delicious", 8, 1, 1998, "1998:1", "Red Delicious6", 1);
                yield return new sorption(140, 15.1, 16, 15.4, 15.7, 20.4, 15.9, 33.6625, "Red Delicious", 12, 1, 1998, "1998:1", "Red Delicious6", 2);
                yield return new sorption(141, 20.2, 21, 20.7, 20.4, 20.3, 20.2, 40.925, "Red Delicious", 16, 1, 1998, "1998:1", "Red Delicious6", 3);
                yield return new sorption(142, 23.9, 25.2, 24.7, 24.5, 24.4, 24.3, 49.0541666666667, "Red Delicious", 20, 1, 1998, "1998:1", "Red Delicious6", 4);
                yield return new sorption(143, 27.7, 27, 27.9, 27.4, 27.2, 27.5, 54.8875, "Red Delicious", 24, 1, 1998, "1998:1", "Red Delicious6", 5);
                yield return new sorption(144, 34, 33.8, 33.7, 33.4, 33.1, 32.7, 66.7583333333333, "Red Delicious", 30, 1, 1998, "1998:1", "Red Delicious6", 6);
                yield return new sorption(145, 12.4, 12.6, 12.2, 13, 13.1, 13.1, 25.5833333333333, "Red Delicious", 8, 2, 1998, "1998:2", "Red Delicious7", 1);
                yield return new sorption(146, 14.8, 16, 15.4, 15.8, 15.9, 15.9, 31.425, "Red Delicious", 12, 2, 1998, "1998:2", "Red Delicious7", 2);
                yield return new sorption(147, 19.7, 20.4, 20, 19.9, 19.9, 19.8, 39.8958333333333, "Red Delicious", 16, 2, 1998, "1998:2", "Red Delicious7", 3);
                yield return new sorption(148, 23.2, 24.5, 23.9, 23.8, 23.8, 23.8, 47.7125, "Red Delicious", 20, 2, 1998, "1998:2", "Red Delicious7", 4);
                yield return new sorption(149, 27, 26.3, 27.4, 27, 26.7, 26.7, 53.7958333333333, "Red Delicious", 24, 2, 1998, "1998:2", "Red Delicious7", 5);
                yield return new sorption(150, 32.9, 32.9, 32.8, 32.5, 32.1, 31.9, 64.9083333333333, "Red Delicious", 30, 2, 1998, "1998:2", "Red Delicious7", 6);
                yield return new sorption(151, 12.6, 12.9, 12.4, 13.2, 13.3, 13.2, 25.9791666666667, "Red Delicious", 8, 3, 1998, "1998:3", "Red Delicious8", 1);
                yield return new sorption(152, 15.8, 17, 16, 16.5, 16.5, 16.5, 32.8083333333333, "Red Delicious", 12, 3, 1998, "1998:3", "Red Delicious8", 2);
                yield return new sorption(153, 20.7, 26.7, 22.3, 20.4, 20.2, 20.1, 42.7666666666667, "Red Delicious", 16, 3, 1998, "1998:3", "Red Delicious8", 3);
                yield return new sorption(154, 27.4, 24.9, 24.3, 24.1, 24.1, 23.8, 48.7875, "Red Delicious", 20, 3, 1998, "1998:3", "Red Delicious8", 4);
                yield return new sorption(155, 28.3, 27.2, 28.1, 27.7, 27.5, 27.4, 55.3625, "Red Delicious", 24, 3, 1998, "1998:3", "Red Delicious8", 5);
                yield return new sorption(156, 33.6, 33.6, 33.2, 32.6, 32.4, 32.2, 65.5833333333333, "Red Delicious", 30, 3, 1998, "1998:3", "Red Delicious8", 6);
                yield return new sorption(157, 12.1, 12.3, 10.9, 11.9, 11.7, 11.1, 23.1916666666667, "Pacific Rose", 8, 1, 1999, "1999:1", "Pacific Rose9", 1);
                yield return new sorption(158, 17.5, 16.8, 17.5, 15.6, 16.8, 15.7, 33.1041666666667, "Pacific Rose", 12, 1, 1999, "1999:1", "Pacific Rose9", 2);
                yield return new sorption(159, 21.5, 23.3, 22.8, 21.5, 20.2, 20.3, 42.9666666666667, "Pacific Rose", 16, 1, 1999, "1999:1", "Pacific Rose9", 3);
                yield return new sorption(160, 23, 23.8, 24.1, 23.1, 22.2, 22.3, 46.1, "Pacific Rose", 20, 1, 1999, "1999:1", "Pacific Rose9", 4);
                yield return new sorption(161, 26.5, 28.1, 27.8, 26.5, 24.9, 26.3, 53.025, "Pacific Rose", 24, 1, 1999, "1999:1", "Pacific Rose9", 5);
                yield return new sorption(162, 33.7, 33.8, 31.8, 32.2, 29.8, 31.1, 63.2791666666667, "Pacific Rose", 30, 1, 1999, "1999:1", "Pacific Rose9", 6);
                yield return new sorption(163, 12, 12, 12.4, 11.6, 10.9, 10.9, 23.1416666666667, "Pacific Rose", 8, 2, 1999, "1999:2", "Pacific Rose10", 1);
                yield return new sorption(164, 14.6, 17.2, 16.5, 15.9, 15.2, 14.4, 31.4333333333333, "Pacific Rose", 12, 2, 1999, "1999:2", "Pacific Rose10", 2);
                yield return new sorption(165, 22.5, 22.8, 21.5, 20.6, 20, 19.4, 41.6708333333333, "Pacific Rose", 16, 2, 1999, "1999:2", "Pacific Rose10", 3);
                yield return new sorption(166, 24.5, 23.4, 23.5, 23.4, 22.2, 21.8, 45.9791666666667, "Pacific Rose", 20, 2, 1999, "1999:2", "Pacific Rose10", 4);
                yield return new sorption(167, 29.8, 29.4, 28.9, 26.4, 26.7, 25.5, 54.8166666666667, "Pacific Rose", 24, 2, 1999, "1999:2", "Pacific Rose10", 5);
                yield return new sorption(168, 33.2, 34.7, 31.7, 32.9, 31.5, 28.5, 63.9125, "Pacific Rose", 30, 2, 1999, "1999:2", "Pacific Rose10", 6);
                yield return new sorption(169, 12.6, 12.6, 12.1, 12, 11.9, 11.6, 24.0916666666667, "Fuji", 8, 1, 1999, "1999:1", "Fuji9", 1);
                yield return new sorption(170, 16.4, 16.8, 15.8, 15.3, 14.6, 15.2, 30.8833333333333, "Fuji", 12, 1, 1999, "1999:1", "Fuji9", 2);
                yield return new sorption(171, 21.5, 21.8, 21.1, 20.4, 20.3, 19.4, 41.2208333333333, "Fuji", 16, 1, 1999, "1999:1", "Fuji9", 3);
                yield return new sorption(172, 21.9, 23.3, 22.9, 22, 21.4, 21.9, 44.3083333333333, "Fuji", 20, 1, 1999, "1999:1", "Fuji9", 4);
                yield return new sorption(173, 28.2, 28.5, 28.3, 26.5, 26.5, 26.1, 54.2791666666667, "Fuji", 24, 1, 1999, "1999:1", "Fuji9", 5);
                yield return new sorption(174, 32.6, 32.2, 32.2, 31.6, 31.5, 30.8, 63.45, "Fuji", 30, 1, 1999, "1999:1", "Fuji9", 6);
                yield return new sorption(175, 12.3, 12.2, 12.3, 11.5, 11.3, 10.3, 23.1791666666667, "Fuji", 8, 2, 1999, "1999:2", "Fuji10", 1);
                yield return new sorption(176, 17.7, 17.7, 17.4, 16.6, 16.1, 14.9, 33.225, "Fuji", 12, 2, 1999, "1999:2", "Fuji10", 2);
                yield return new sorption(177, 22.4, 23.1, 22.7, 22.1, null, 21.5, 44.4141337728627, "Fuji", 16, 2, 1999, "1999:2", "Fuji10", 3);
                yield return new sorption(178, 24.9, 24.7, 23.9, 22.4, 22.5, 21.4, 46.0166666666667, "Fuji", 20, 2, 1999, "1999:2", "Fuji10", 4);
                yield return new sorption(179, 31.1, 30.8, 27.7, 26.9, 25.4, 26.2, 54.5458333333333, "Fuji", 24, 2, 1999, "1999:2", "Fuji10", 5);
                yield return new sorption(180, 34.6, 32.7, 32.2, 31.7, 33, 30.5, 64.5291666666667, "Fuji", 30, 2, 1999, "1999:2", "Fuji10", 6);
                yield return new sorption(181, 12.1, 12.5, 12.6, 11.9, 11.5, 11.2, 23.8666666666667, "Red Delicious", 8, 1, 1999, "1999:1", "Red Del9", 1);
                yield return new sorption(182, 18, 17.9, 17.2, 17.5, 16.8, 16, 34.2958333333333, "Red Delicious", 12, 1, 1999, "1999:1", "Red Del9", 2);
                yield return new sorption(183, 23.7, 23.2, 22.7, 21.7, 22.2, 21.7, 44.6291666666667, "Red Delicious", 16, 1, 1999, "1999:1", "Red Del9", 3);
                yield return new sorption(184, 26.2, 26.7, 25.6, 24.4, 23.8, 23.4, 49.4541666666667, "Red Delicious", 20, 1, 1999, "1999:1", "Red Del9", 4);
                yield return new sorption(185, 29.9, 28.5, 29.2, 28.2, 29.1, 27.1, 57.2666666666667, "Red Delicious", 24, 1, 1999, "1999:1", "Red Del9", 5);
                yield return new sorption(186, 33.2, 34.9, 33.6, 31.8, 32.7, 31.6, 65.5708333333333, "Red Delicious", 30, 1, 1999, "1999:1", "Red Del9", 6);
                yield return new sorption(187, 12, 12, 12.1, 11.5, 11.1, 10.7, 23.0166666666667, "Red Delicious", 8, 2, 1999, "1999:2", "Red Del10", 1);
                yield return new sorption(188, 16.2, 16.9, 16.4, 15.6, 15.7, 14.9, 31.7541666666667, "Red Delicious", 12, 2, 1999, "1999:2", "Red Del10", 2);
                yield return new sorption(189, 22, 21.6, 21.2, 20.6, 19.9, 19, 41.0833333333333, "Red Delicious", 16, 2, 1999, "1999:2", "Red Del10", 3);
                yield return new sorption(190, 23.8, 24.9, 23.7, 23.8, 21.7, 22.6, 46.4375, "Red Delicious", 20, 2, 1999, "1999:2", "Red Del10", 4);
                yield return new sorption(191, 29.7, 29.4, 27.8, 27.9, 25.7, 25.6, 54.6208333333333, "Red Delicious", 24, 2, 1999, "1999:2", "Red Del10", 5);
                yield return new sorption(192, 37, 34.3, 33.5, 32.9, 30.7, 31, 65.2791666666667, "Red Delicious", 30, 2, 1999, "1999:2", "Red Del10", 6);
            }
        }
    }
}
