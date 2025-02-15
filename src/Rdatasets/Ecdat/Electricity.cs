// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Cost Function for Electricity Producers
    /// </summary>

    public class Electricity
    {
        public readonly int κ;
        public readonly double cost;
        public readonly double q;
        public readonly double pl;
        public readonly double sl;
        public readonly double pk;
        public readonly double sk;
        public readonly double pf;
        public readonly double sf;

        public Electricity(int κ, double cost, double q, double pl, double sl, double pk, double sk, double pf, double sf)
        {
            this.κ = κ;
            this.cost = cost;
            this.q = q;
            this.pl = pl;
            this.sl = sl;
            this.pk = pk;
            this.sk = sk;
            this.pf = pf;
            this.sf = sf;
        }

        public static IEnumerable<Electricity> Data
        {
            get
            {
                yield return new Electricity(1, 0.213, 8, 6869.47, 0.3291, 64.945, 0.4197, 18, 0.2512);
                yield return new Electricity(2, 3.0427, 869, 8372.96, 0.103, 68.227, 0.2913, 21.067, 0.6057);
                yield return new Electricity(3, 9.4059, 1412, 7960.9, 0.0891, 40.692, 0.1567, 41.53, 0.7542);
                yield return new Electricity(4, 0.7606, 65, 8971.89, 0.2802, 41.243, 0.1282, 28.539, 0.5916);
                yield return new Electricity(5, 2.2587, 295, 8218.4, 0.1772, 71.94, 0.1623, 39.2, 0.6606);
                yield return new Electricity(6, 1.3422, 183, 5063.49, 0.096, 74.43, 0.2629, 35.51, 0.6411);
                yield return new Electricity(7, 0.6159, 50, 9204.24, 0.2963, 90.47, 0.0981, 32.07, 0.6056);
                yield return new Electricity(8, 0.4887, 14, 5438.89, 0.2994, 86.11, 0.4571, 34.15, 0.2435);
                yield return new Electricity(9, 1.1474, 90, 7189.67, 0.2855, 79.101, 0.2073, 21.503, 0.5072);
                yield return new Electricity(10, 7.5492, 2969, 8183.34, 0.2397, 80.657, 0.3972, 9, 0.3631);
                yield return new Electricity(11, 2.0532, 374, 7884.94, 0.2054, 82.485, 0.1208, 26.3014, 0.6737);
                yield return new Electricity(12, 0.6363, 67, 6696.5, 0.2447, 58.258, 0.3674, 25.4, 0.3879);
                yield return new Electricity(13, 3.1504, 378, 7895.43, 0.098, 60.277, 0.1996, 42.4683, 0.7024);
                yield return new Electricity(14, 10.3136, 1886, 6833.93, 0.0826, 67.68, 0.407, 25.6, 0.5104);
                yield return new Electricity(15, 5.8488, 1025, 7093.32, 0.2164, 68.227, 0.2455, 22.2793, 0.5382);
                yield return new Electricity(16, 4.505, 467, 8410.34, 0.2474, 76.3, 0.1917, 26.85, 0.561);
                yield return new Electricity(17, 5.5971, 938, 7703.26, 0.1577, 77.197, 0.2342, 25.4, 0.608);
                yield return new Electricity(18, 3.7255, 643, 7332.13, 0.2666, 64.506, 0.2428, 21.1619, 0.4905);
                yield return new Electricity(19, 6.0065, 1328, 6680.77, 0.1082, 51.817, 0.2611, 25.2319, 0.6307);
                yield return new Electricity(20, 12.783, 2632, 8469.84, 0.08, 70.295, 0.2604, 30.971, 0.6596);
                yield return new Electricity(21, 6.6214, 856, 8033.72, 0.1463, 67.68, 0.2083, 39.5812, 0.6554);
                yield return new Electricity(22, 9.6429, 2689, 6364.4, 0.0829, 78.44, 0.2105, 23.4889, 0.7067);
                yield return new Electricity(23, 8.6852, 1627, 7912.4, 0.1105, 79.22, 0.2071, 31.6801, 0.6824);
                yield return new Electricity(24, 8.6372, 1090, 8507.92, 0.2399, 39.127, 0.1796, 33.9, 0.5805);
                yield return new Electricity(25, 11.2419, 2258, 6892.61, 0.0997, 81.096, 0.2309, 29.1, 0.6694);
                yield return new Electricity(26, 6.6221, 1500, 7588.7, 0.1221, 82.84, 0.3186, 21.3951, 0.5594);
                yield return new Electricity(27, 10.9665, 2506, 7412.36, 0.1164, 57.24, 0.2152, 27.4207, 0.6684);
                yield return new Electricity(28, 13.627, 2437, 7846.06, 0.121, 65.565, 0.2578, 30.6712, 0.6212);
                yield return new Electricity(29, 7.4395, 1293, 6821.09, 0.2031, 78.225, 0.3297, 21.4305, 0.4672);
                yield return new Electricity(30, 9.7843, 1627, 8355.75, 0.1494, 76.14, 0.236, 31.3374, 0.6146);
                yield return new Electricity(31, 20.8671, 3965, 8403.59, 0.1162, 74.48, 0.2151, 33.1992, 0.6687);
                yield return new Electricity(32, 19.7092, 2682, 9484.85, 0.1087, 81.75, 0.1958, 50.4516, 0.6955);
                yield return new Electricity(33, 14.0431, 2001, 8611.53, 0.0714, 74.025, 0.1618, 30.6446, 0.7668);
                yield return new Electricity(34, 10.1902, 2764, 6338, 0.1659, 66.232, 0.2312, 21.197, 0.6028);
                yield return new Electricity(35, 16.1764, 2487, 8088.45, 0.1371, 66.622, 0.1973, 32.6186, 0.6656);
                yield return new Electricity(36, 42.2514, 7320, 5879.51, 0.0864, 92.063, 0.2064, 39.2104, 0.7072);
                yield return new Electricity(37, 22.5612, 3571, 7297.71, 0.1142, 78.255, 0.1833, 41.5951, 0.7025);
                yield return new Electricity(38, 33.0175, 6837, 7310.15, 0.1187, 69.795, 0.2515, 28.4405, 0.6298);
                yield return new Electricity(39, 18.8963, 2020, 10806.2, 0.1797, 79.57, 0.1594, 46.9, 0.6609);
                yield return new Electricity(40, 13.2679, 2445, 8764.75, 0.1317, 76.14, 0.2411, 28.3648, 0.6271);
                yield return new Electricity(41, 21.5454, 3981, 8186.05, 0.1052, 75.082, 0.2299, 35.2049, 0.665);
                yield return new Electricity(42, 35.5303, 6770, 7798.26, 0.1108, 67.57, 0.2814, 29.825, 0.6078);
                yield return new Electricity(43, 29.8011, 4187, 7996.44, 0.1052, 74.12, 0.1824, 47.4257, 0.7125);
                yield return new Electricity(44, 30.8773, 5643, 10182.49, 0.1722, 61.04, 0.2204, 27.8498, 0.6074);
                yield return new Electricity(45, 24.3565, 6793, 6336.88, 0.1266, 70.295, 0.3253, 18.5909, 0.5481);
                yield return new Electricity(46, 17.4802, 4148, 7536.89, 0.1176, 74.025, 0.2035, 24.5837, 0.6789);
                yield return new Electricity(47, 19.9008, 5785, 7969.55, 0.1093, 71.91, 0.218, 22.2448, 0.6727);
                yield return new Electricity(48, 28.7861, 9660, 6686.73, 0.0697, 79.542, 0.2391, 20.263, 0.6913);
                yield return new Electricity(49, 27.0832, 7896, 7119.96, 0.1196, 74.513, 0.2484, 20.11, 0.632);
                yield return new Electricity(50, 22.4421, 5648, 8954.12, 0.0834, 78.44, 0.2111, 25.916, 0.7055);
                yield return new Electricity(51, 30.2067, 5286, 7084.1, 0.0884, 73.325, 0.1969, 38.3384, 0.7147);
                yield return new Electricity(52, 30.1678, 9602, 7054.18, 0.0928, 59.977, 0.2164, 20.201, 0.6908);
                yield return new Electricity(53, 32.584, 7930, 7119.01, 0.1209, 48.997, 0.2772, 22.838, 0.6018);
                yield return new Electricity(54, 47.3864, 9530, 7624.57, 0.1266, 83.88, 0.2106, 31.5825, 0.6628);
                yield return new Electricity(55, 24.2903, 5316, 9759.83, 0.1894, 74.025, 0.174, 27.838, 0.6366);
                yield return new Electricity(56, 31.2922, 7484, 8063.73, 0.1713, 67.68, 0.2535, 23.5267, 0.5752);
                yield return new Electricity(57, 31.9884, 10149, 6437.92, 0.1169, 73.14, 0.2367, 18.5343, 0.6464);
                yield return new Electricity(58, 41.9016, 12954, 6460.64, 0.0865, 62.33, 0.2194, 21.755, 0.6941);
                yield return new Electricity(59, 58.1154, 17875, 6288.41, 0.0658, 73.395, 0.2781, 20.6191, 0.6561);
                yield return new Electricity(60, 40.5281, 6891, 6769.55, 0.0895, 74.12, 0.2393, 35.9651, 0.6711);
                yield return new Electricity(61, 37.0666, 6754, 10177.89, 0.207, 77.197, 0.2363, 25.6208, 0.5566);
                yield return new Electricity(62, 25.1686, 6779, 7826.93, 0.1427, 74.2, 0.2662, 20.279, 0.3909);
                yield return new Electricity(63, 45.1827, 12936, 8320.06, 0.1027, 65.76, 0.1992, 22.033, 0.6981);
                yield return new Electricity(64, 55.1764, 10855, 8061.96, 0.1192, 71.49, 0.2362, 31.7601, 0.6445);
                yield return new Electricity(65, 41.1798, 9275, 8657.53, 0.1047, 76.14, 0.3287, 24.5804, 0.5666);
                yield return new Electricity(66, 80.3593, 16311, 7282.61, 0.0527, 81.55, 0.1337, 40.9692, 0.8136);
                yield return new Electricity(67, 68.48, 12542, 8142.84, 0.1336, 80.385, 0.1688, 35.7882, 0.6976);
                yield return new Electricity(68, 97.3859, 13846, 7786.37, 0.1003, 88.54, 0.2066, 44.1571, 0.6931);
                yield return new Electricity(69, 52.7634, 9145, 10373.5, 0.2027, 81.75, 0.1997, 35.8083, 0.5976);
                yield return new Electricity(70, 38.8472, 10057, 6035.95, 0.0844, 81.578, 0.2178, 25.824, 0.6978);
                yield return new Electricity(71, 48.1125, 11114, 8413.86, 0.1301, 69.975, 0.2969, 22.5536, 0.573);
                yield return new Electricity(72, 79.0705, 12706, 9282.51, 0.1108, 70.853, 0.2011, 37.2477, 0.688);
                yield return new Electricity(73, 111.8863, 23217, 6873.73, 0.0849, 83.88, 0.2007, 33.3944, 0.7144);
                yield return new Electricity(74, 77.8849, 13702, 7113.79, 0.1212, 70.85, 0.2121, 34.9616, 0.6667);
                yield return new Electricity(75, 87.1015, 27708, 6378.23, 0.106, 63.6, 0.2257, 20.3, 0.6683);
                yield return new Electricity(76, 57.7267, 10004, 6472.86, 0.1806, 76.3, 0.2362, 28.0959, 0.5832);
                yield return new Electricity(77, 90.7168, 17280, 9191.47, 0.0918, 72.967, 0.1795, 36.8816, 0.7287);
                yield return new Electricity(78, 183.2315, 27118, 9914.36, 0.128, 78.48, 0.2265, 41.7578, 0.6455);
                yield return new Electricity(79, 169.2354, 38343, 9117.16, 0.0663, 65.992, 0.2192, 31.5897, 0.7144);
                yield return new Electricity(80, 76.2528, 11667, 10436.32, 0.112, 80.66, 0.1708, 46.0701, 0.7172);
                yield return new Electricity(81, 134.2283, 19445, 9829.32, 0.1756, 67.58, 0.1834, 38.8027, 0.641);
                yield return new Electricity(82, 168.3777, 34212, 5683.83, 0.0651, 80.385, 0.1361, 40.5286, 0.7988);
                yield return new Electricity(83, 125.3356, 24001, 8047.35, 0.0998, 74.372, 0.2457, 33.0932, 0.6544);
                yield return new Electricity(84, 191.5625, 30958, 9810.1, 0.1636, 69.541, 0.1524, 36.3076, 0.684);
                yield return new Electricity(85, 240.5137, 29613, 9312.93, 0.1561, 81.75, 0.2017, 41.8872, 0.6422);
                yield return new Electricity(86, 0.1304, 4, 6009.7, 0.2001, 92.65, 0.1273, 33.199, 0.6725);
                yield return new Electricity(87, 0.7293, 60, 7972.71, 0.1478, 75.464, 0.2967, 33.707, 0.5555);
                yield return new Electricity(88, 1.7705, 153, 10963.9, 0.2555, 57.612, 0.1918, 46.16, 0.5527);
                yield return new Electricity(89, 2.2367, 198, 7046.5, 0.2169, 64.945, 0.1969, 38, 0.5861);
                yield return new Electricity(90, 2.5593, 243, 7000.81, 0.1727, 81.75, 0.1948, 33.436, 0.6325);
                yield return new Electricity(91, 2.0358, 617, 9547.72, 0.1194, 81.75, 0.3, 18.49, 0.5807);
                yield return new Electricity(92, 7.6236, 1340, 6438.42, 0.093, 79.22, 0.1877, 38.1483, 0.7193);
                yield return new Electricity(93, 11.1091, 1961, 6964.81, 0.1317, 82.485, 0.3176, 28.2634, 0.5507);
                yield return new Electricity(94, 9.4674, 2233, 6717.18, 0.0959, 59.957, 0.303, 22.6933, 0.6011);
                yield return new Electricity(95, 13.8262, 2582, 8334.89, 0.1022, 77.531, 0.2266, 34.1811, 0.6712);
                yield return new Electricity(96, 17.2895, 2763, 8058.91, 0.096, 80.66, 0.2023, 45.6636, 0.7018);
                yield return new Electricity(97, 16.1704, 2863, 7509.37, 0.1783, 81.55, 0.1992, 30.2374, 0.6225);
                yield return new Electricity(98, 24.3975, 3490, 8477.23, 0.1915, 75.42, 0.232, 38, 0.5765);
                yield return new Electricity(99, 27.2443, 4568, 9619.76, 0.1692, 76.14, 0.2316, 35.6645, 0.5992);
                yield return new Electricity(100, 29.487, 5292, 8176.33, 0.2233, 76.14, 0.2532, 22.8374, 0.5236);
                yield return new Electricity(101, 35.1091, 5699, 7988.48, 0.1269, 80.37, 0.214, 42.6351, 0.659);
                yield return new Electricity(102, 25.4814, 5702, 6947.11, 0.1833, 78.225, 0.2503, 24.2596, 0.5664);
                yield return new Electricity(103, 42.4117, 8650, 7146.67, 0.1462, 72.967, 0.2371, 27.8693, 0.6167);
                yield return new Electricity(104, 72.0355, 12724, 8037.84, 0.1259, 74.025, 0.197, 37.5174, 0.6771);
                yield return new Electricity(105, 146.989, 25147, 9900.76, 0.0857, 75.725, 0.3334, 33.4742, 0.5809);
                yield return new Electricity(106, 51.7415, 10361, 9578.63, 0.1913, 68.016, 0.2407, 28.1423, 0.568);
                yield return new Electricity(107, 21.5587, 3886, 9538.68, 0.1252, 63.569, 0.2033, 30.8894, 0.6715);
                yield return new Electricity(108, 14.271, 1901, 9822.64, 0.2144, 69.411, 0.1596, 36, 0.626);
                yield return new Electricity(109, 66.1032, 11837, 8709.43, 0.1627, 75.379, 0.2103, 31.3321, 0.6269);
                yield return new Electricity(110, 113.2555, 22522, 9500.78, 0.1961, 76.732, 0.2604, 25.0289, 0.5435);
                yield return new Electricity(111, 90.3718, 21956, 7954.47, 0.1169, 83.338, 0.2984, 22.9115, 0.5847);
                yield return new Electricity(112, 240.4858, 53918, 6068.87, 0.0966, 78.38, 0.1846, 31.1954, 0.7188);
                yield return new Electricity(113, 277.2965, 72247, 7419.92, 0.1081, 56.301, 0.2607, 25.0914, 0.6312);
                yield return new Electricity(114, 107.9776, 18455, 6690.23, 0.1513, 76.3, 0.2101, 32.9654, 0.6386);
                yield return new Electricity(115, 269.7728, 46870, 9761.38, 0.1594, 69.541, 0.2194, 33.1999, 0.6212);
                yield return new Electricity(116, 79.6207, 16508, 9404.97, 0.1501, 78.044, 0.1556, 42.2086, 0.6943);
                yield return new Electricity(117, 33.8814, 7382, 7512.72, 0.1393, 72.362, 0.2468, 25.9001, 0.614);
                yield return new Electricity(118, 14.9529, 2325, 8568.23, 0.1466, 53.89, 0.1269, 38.9161, 0.7265);
                yield return new Electricity(119, 33.9733, 5708, 10024.2, 0.0986, 78.102, 0.1826, 42.166, 0.7188);
                yield return new Electricity(120, 78.7028, 17132, 8160.8, 0.1604, 78.899, 0.2552, 25.5378, 0.5844);
                yield return new Electricity(121, 19.4391, 4560, 8558.37, 0.1531, 76.464, 0.2577, 23.7777, 0.5893);
                yield return new Electricity(122, 282.2479, 48240, 9673.38, 0.1405, 70.77, 0.1612, 36.51, 0.6983);
                yield return new Electricity(123, 282.9401, 53760, 9619.9, 0.1667, 73.46, 0.1977, 34.64, 0.6356);
                yield return new Electricity(124, 469.1852, 66490, 9138.03, 0.1353, 78.98, 0.2017, 41.01, 0.663);
                yield return new Electricity(125, 737.4088, 115500, 8438.8, 0.1347, 76.62, 0.2027, 38.85, 0.6626);
                yield return new Electricity(126, 20.8836, 6259, 6697.02, 0.0966, 69.764, 0.2164, 21.292, 0.687);
                yield return new Electricity(127, 21.7792, 6746, 9419.27, 0.1263, 49.778, 0.2418, 20.1, 0.6319);
                yield return new Electricity(128, 22.8436, 3789, 6429.54, 0.1088, 76.3, 0.2241, 34.259, 0.6671);
                yield return new Electricity(129, 31.6368, 4617, 6488.39, 0.1761, 70.806, 0.1633, 41.989, 0.6606);
                yield return new Electricity(130, 48.1678, 9326, 7131.92, 0.1565, 81.794, 0.245, 26.892, 0.5985);
                yield return new Electricity(131, 5.9281, 723, 6432.54, 0.2068, 62.086, 0.1218, 43.884, 0.6714);
                yield return new Electricity(132, 25.6094, 6604, 7714.34, 0.1261, 90.87, 0.2842, 21.269, 0.5896);
                yield return new Electricity(133, 17.463, 3972, 6446.05, 0.1212, 88.54, 0.3361, 23.469, 0.5426);
                yield return new Electricity(134, 1.3643, 154, 8290.99, 0.274, 87.465, 0.1638, 35.78, 0.5622);
                yield return new Electricity(135, 46.7988, 11226, 8885.39, 0.1171, 83.886, 0.1254, 23.626, 0.5875);
                yield return new Electricity(136, 50.2093, 13030, 6735, 0.1223, 55.92, 0.2386, 26.164, 0.6392);
                yield return new Electricity(137, 40.894, 9553, 7287.17, 0.1269, 61.335, 0.2552, 26.847, 0.6179);
                yield return new Electricity(138, 24.7234, 5331, 7861.41, 0.0459, 43.418, 0.387, 28.478, 0.567);
                yield return new Electricity(139, 30.224, 6904, 11145.22, 0.0932, 31.725, 0.3597, 25.18, 0.5471);
                yield return new Electricity(140, 31.2161, 9057, 10599.86, 0.1092, 31.725, 0.2989, 21.58, 0.5919);
                yield return new Electricity(141, 106.2729, 28372, 7502.93, 0.1204, 66.58, 0.2339, 24.443, 0.6457);
                yield return new Electricity(142, 55.3624, 13073, 7024.36, 0.1733, 76.32, 0.1735, 26.281, 0.6533);
                yield return new Electricity(143, 23.4787, 4906, 6738.3, 0.0832, 82.668, 0.2564, 28.716, 0.6604);
                yield return new Electricity(144, 22.2623, 5601, 7581.69, 0.0992, 68.858, 0.2074, 26.615, 0.6934);
                yield return new Electricity(145, 30.4707, 8060, 7000, 0.0576, 37.058, 0.1754, 30.77, 0.7669);
                yield return new Electricity(146, 113.591, 22277, 5571.05, 0.1022, 82.668, 0.1725, 36.037, 0.7254);
                yield return new Electricity(147, 88.0991, 26521, 6890.26, 0.1069, 68.644, 0.2296, 20.5168, 0.6635);
                yield return new Electricity(148, 111.9243, 31908, 6971.54, 0.0848, 75.218, 0.2286, 23.0916, 0.6866);
                yield return new Electricity(149, 119.3736, 33820, 7263.52, 0.0992, 70.808, 0.2286, 22.1481, 0.6722);
                yield return new Electricity(150, 12.3243, 2816, 13044, 0.0893, 58.86, 0.2946, 30.59, 0.6161);
                yield return new Electricity(151, 0.3158, 16.3, 7727.77, 0.17, 38.106, 0.1767, 33.46, 0.6533);
                yield return new Electricity(152, 10.5287, 1823, 10029.47, 0.0761, 69.76, 0.1724, 36, 0.7515);
                yield return new Electricity(153, 22.1998, 4800, 12742.47, 0.1239, 33.84, 0.1678, 32.25, 0.7083);
                yield return new Electricity(154, 6.8293, 946.6, 10642.16, 0.0883, 43.6, 0.1914, 51.463, 0.7203);
                yield return new Electricity(155, 3.7605, 377, 7432.24, 0.2117, 74.12, 0.2274, 33.436, 0.5609);
                yield return new Electricity(156, 3.9822, 391, 5826.04, 0.1926, 78.288, 0.0924, 44.633, 0.7151);
                yield return new Electricity(157, 30.188, 5317, 9586.63, 0.0845, 78.008, 0.2009, 41.84, 0.7147);
                yield return new Electricity(158, 67.8562, 15220, 6986.09, 0.1451, 74.025, 0.2596, 25.662, 0.5945);
            }
        }
    }
}
