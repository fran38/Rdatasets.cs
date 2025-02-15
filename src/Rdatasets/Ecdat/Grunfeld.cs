// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Grunfeld Investment Data
    /// </summary>

    public class Grunfeld
    {
        public readonly int κ;
        public readonly int firm;
        public readonly int year;
        public readonly double inv;
        public readonly double value;
        public readonly double capital;

        public Grunfeld(int κ, int firm, int year, double inv, double value, double capital)
        {
            this.κ = κ;
            this.firm = firm;
            this.year = year;
            this.inv = inv;
            this.value = value;
            this.capital = capital;
        }

        public static IEnumerable<Grunfeld> Data
        {
            get
            {
                yield return new Grunfeld(1, 1, 1935, 317.6, 3078.5, 2.8);
                yield return new Grunfeld(2, 1, 1936, 391.8, 4661.7, 52.6);
                yield return new Grunfeld(3, 1, 1937, 410.6, 5387.1, 156.9);
                yield return new Grunfeld(4, 1, 1938, 257.7, 2792.2, 209.2);
                yield return new Grunfeld(5, 1, 1939, 330.8, 4313.2, 203.4);
                yield return new Grunfeld(6, 1, 1940, 461.2, 4643.9, 207.2);
                yield return new Grunfeld(7, 1, 1941, 512, 4551.2, 255.2);
                yield return new Grunfeld(8, 1, 1942, 448, 3244.1, 303.7);
                yield return new Grunfeld(9, 1, 1943, 499.6, 4053.7, 264.1);
                yield return new Grunfeld(10, 1, 1944, 547.5, 4379.3, 201.6);
                yield return new Grunfeld(11, 1, 1945, 561.2, 4840.9, 265);
                yield return new Grunfeld(12, 1, 1946, 688.1, 4900.9, 402.2);
                yield return new Grunfeld(13, 1, 1947, 568.9, 3526.5, 761.5);
                yield return new Grunfeld(14, 1, 1948, 529.2, 3254.7, 922.4);
                yield return new Grunfeld(15, 1, 1949, 555.1, 3700.2, 1020.1);
                yield return new Grunfeld(16, 1, 1950, 642.9, 3755.6, 1099);
                yield return new Grunfeld(17, 1, 1951, 755.9, 4833, 1207.7);
                yield return new Grunfeld(18, 1, 1952, 891.2, 4924.9, 1430.5);
                yield return new Grunfeld(19, 1, 1953, 1304.4, 6241.7, 1777.3);
                yield return new Grunfeld(20, 1, 1954, 1486.7, 5593.6, 2226.3);
                yield return new Grunfeld(21, 2, 1935, 209.9, 1362.4, 53.8);
                yield return new Grunfeld(22, 2, 1936, 355.3, 1807.1, 50.5);
                yield return new Grunfeld(23, 2, 1937, 469.9, 2676.3, 118.1);
                yield return new Grunfeld(24, 2, 1938, 262.3, 1801.9, 260.2);
                yield return new Grunfeld(25, 2, 1939, 230.4, 1957.3, 312.7);
                yield return new Grunfeld(26, 2, 1940, 361.6, 2202.9, 254.2);
                yield return new Grunfeld(27, 2, 1941, 472.8, 2380.5, 261.4);
                yield return new Grunfeld(28, 2, 1942, 445.6, 2168.6, 298.7);
                yield return new Grunfeld(29, 2, 1943, 361.6, 1985.1, 301.8);
                yield return new Grunfeld(30, 2, 1944, 288.2, 1813.9, 279.1);
                yield return new Grunfeld(31, 2, 1945, 258.7, 1850.2, 213.8);
                yield return new Grunfeld(32, 2, 1946, 420.3, 2067.7, 132.6);
                yield return new Grunfeld(33, 2, 1947, 420.5, 1796.7, 264.8);
                yield return new Grunfeld(34, 2, 1948, 494.5, 1625.8, 306.9);
                yield return new Grunfeld(35, 2, 1949, 405.1, 1667, 351.1);
                yield return new Grunfeld(36, 2, 1950, 418.8, 1677.4, 357.8);
                yield return new Grunfeld(37, 2, 1951, 588.2, 2289.5, 342.1);
                yield return new Grunfeld(38, 2, 1952, 645.5, 2159.4, 444.2);
                yield return new Grunfeld(39, 2, 1953, 641, 2031.3, 623.6);
                yield return new Grunfeld(40, 2, 1954, 459.3, 2115.5, 669.7);
                yield return new Grunfeld(41, 3, 1935, 33.1, 1170.6, 97.8);
                yield return new Grunfeld(42, 3, 1936, 45, 2015.8, 104.4);
                yield return new Grunfeld(43, 3, 1937, 77.2, 2803.3, 118);
                yield return new Grunfeld(44, 3, 1938, 44.6, 2039.7, 156.2);
                yield return new Grunfeld(45, 3, 1939, 48.1, 2256.2, 172.6);
                yield return new Grunfeld(46, 3, 1940, 74.4, 2132.2, 186.6);
                yield return new Grunfeld(47, 3, 1941, 113, 1834.1, 220.9);
                yield return new Grunfeld(48, 3, 1942, 91.9, 1588, 287.8);
                yield return new Grunfeld(49, 3, 1943, 61.3, 1749.4, 319.9);
                yield return new Grunfeld(50, 3, 1944, 56.8, 1687.2, 321.3);
                yield return new Grunfeld(51, 3, 1945, 93.6, 2007.7, 319.6);
                yield return new Grunfeld(52, 3, 1946, 159.9, 2208.3, 346);
                yield return new Grunfeld(53, 3, 1947, 147.2, 1656.7, 456.4);
                yield return new Grunfeld(54, 3, 1948, 146.3, 1604.4, 543.4);
                yield return new Grunfeld(55, 3, 1949, 98.3, 1431.8, 618.3);
                yield return new Grunfeld(56, 3, 1950, 93.5, 1610.5, 647.4);
                yield return new Grunfeld(57, 3, 1951, 135.2, 1819.4, 671.3);
                yield return new Grunfeld(58, 3, 1952, 157.3, 2079.7, 726.1);
                yield return new Grunfeld(59, 3, 1953, 179.5, 2371.6, 800.3);
                yield return new Grunfeld(60, 3, 1954, 189.6, 2759.9, 888.9);
                yield return new Grunfeld(61, 4, 1935, 40.29, 417.5, 10.5);
                yield return new Grunfeld(62, 4, 1936, 72.76, 837.8, 10.2);
                yield return new Grunfeld(63, 4, 1937, 66.26, 883.9, 34.7);
                yield return new Grunfeld(64, 4, 1938, 51.6, 437.9, 51.8);
                yield return new Grunfeld(65, 4, 1939, 52.41, 679.7, 64.3);
                yield return new Grunfeld(66, 4, 1940, 69.41, 727.8, 67.1);
                yield return new Grunfeld(67, 4, 1941, 68.35, 643.6, 75.2);
                yield return new Grunfeld(68, 4, 1942, 46.8, 410.9, 71.4);
                yield return new Grunfeld(69, 4, 1943, 47.4, 588.4, 67.1);
                yield return new Grunfeld(70, 4, 1944, 59.57, 698.4, 60.5);
                yield return new Grunfeld(71, 4, 1945, 88.78, 846.4, 54.6);
                yield return new Grunfeld(72, 4, 1946, 74.12, 893.8, 84.8);
                yield return new Grunfeld(73, 4, 1947, 62.68, 579, 96.8);
                yield return new Grunfeld(74, 4, 1948, 89.36, 694.6, 110.2);
                yield return new Grunfeld(75, 4, 1949, 78.98, 590.3, 147.4);
                yield return new Grunfeld(76, 4, 1950, 100.66, 693.5, 163.2);
                yield return new Grunfeld(77, 4, 1951, 160.62, 809, 203.5);
                yield return new Grunfeld(78, 4, 1952, 145, 727, 290.6);
                yield return new Grunfeld(79, 4, 1953, 174.93, 1001.5, 346.1);
                yield return new Grunfeld(80, 4, 1954, 172.49, 703.2, 414.9);
                yield return new Grunfeld(81, 5, 1935, 39.68, 157.7, 183.2);
                yield return new Grunfeld(82, 5, 1936, 50.73, 167.9, 204);
                yield return new Grunfeld(83, 5, 1937, 74.24, 192.9, 236);
                yield return new Grunfeld(84, 5, 1938, 53.51, 156.7, 291.7);
                yield return new Grunfeld(85, 5, 1939, 42.65, 191.4, 323.1);
                yield return new Grunfeld(86, 5, 1940, 46.48, 185.5, 344);
                yield return new Grunfeld(87, 5, 1941, 61.4, 199.6, 367.7);
                yield return new Grunfeld(88, 5, 1942, 39.67, 189.5, 407.2);
                yield return new Grunfeld(89, 5, 1943, 62.24, 151.2, 426.6);
                yield return new Grunfeld(90, 5, 1944, 52.32, 187.7, 470);
                yield return new Grunfeld(91, 5, 1945, 63.21, 214.7, 499.2);
                yield return new Grunfeld(92, 5, 1946, 59.37, 232.9, 534.6);
                yield return new Grunfeld(93, 5, 1947, 58.02, 249, 566.6);
                yield return new Grunfeld(94, 5, 1948, 70.34, 224.5, 595.3);
                yield return new Grunfeld(95, 5, 1949, 67.42, 237.3, 631.4);
                yield return new Grunfeld(96, 5, 1950, 55.74, 240.1, 662.3);
                yield return new Grunfeld(97, 5, 1951, 80.3, 327.3, 683.9);
                yield return new Grunfeld(98, 5, 1952, 85.4, 359.4, 729.3);
                yield return new Grunfeld(99, 5, 1953, 91.9, 398.4, 774.3);
                yield return new Grunfeld(100, 5, 1954, 81.43, 365.7, 804.9);
                yield return new Grunfeld(101, 6, 1935, 20.36, 197, 6.5);
                yield return new Grunfeld(102, 6, 1936, 25.98, 210.3, 15.8);
                yield return new Grunfeld(103, 6, 1937, 25.94, 223.1, 27.7);
                yield return new Grunfeld(104, 6, 1938, 27.53, 216.7, 39.2);
                yield return new Grunfeld(105, 6, 1939, 24.6, 286.4, 48.6);
                yield return new Grunfeld(106, 6, 1940, 28.54, 298, 52.5);
                yield return new Grunfeld(107, 6, 1941, 43.41, 276.9, 61.5);
                yield return new Grunfeld(108, 6, 1942, 42.81, 272.6, 80.5);
                yield return new Grunfeld(109, 6, 1943, 27.84, 287.4, 94.4);
                yield return new Grunfeld(110, 6, 1944, 32.6, 330.3, 92.6);
                yield return new Grunfeld(111, 6, 1945, 39.03, 324.4, 92.3);
                yield return new Grunfeld(112, 6, 1946, 50.17, 401.9, 94.2);
                yield return new Grunfeld(113, 6, 1947, 51.85, 407.4, 111.4);
                yield return new Grunfeld(114, 6, 1948, 64.03, 409.2, 127.4);
                yield return new Grunfeld(115, 6, 1949, 68.16, 482.2, 149.3);
                yield return new Grunfeld(116, 6, 1950, 77.34, 673.8, 164.4);
                yield return new Grunfeld(117, 6, 1951, 95.3, 676.9, 177.2);
                yield return new Grunfeld(118, 6, 1952, 99.49, 702, 200);
                yield return new Grunfeld(119, 6, 1953, 127.52, 793.5, 211.5);
                yield return new Grunfeld(120, 6, 1954, 135.72, 927.3, 238.7);
                yield return new Grunfeld(121, 7, 1935, 24.43, 138, 100.2);
                yield return new Grunfeld(122, 7, 1936, 23.21, 200.1, 125);
                yield return new Grunfeld(123, 7, 1937, 32.78, 210.1, 142.4);
                yield return new Grunfeld(124, 7, 1938, 32.54, 161.2, 165.1);
                yield return new Grunfeld(125, 7, 1939, 26.65, 161.7, 194.8);
                yield return new Grunfeld(126, 7, 1940, 33.71, 145.1, 222.9);
                yield return new Grunfeld(127, 7, 1941, 43.5, 110.6, 252.1);
                yield return new Grunfeld(128, 7, 1942, 34.46, 98.1, 276.3);
                yield return new Grunfeld(129, 7, 1943, 44.28, 108.8, 300.3);
                yield return new Grunfeld(130, 7, 1944, 70.8, 118.2, 318.2);
                yield return new Grunfeld(131, 7, 1945, 44.12, 126.5, 336.2);
                yield return new Grunfeld(132, 7, 1946, 48.98, 156.7, 351.2);
                yield return new Grunfeld(133, 7, 1947, 48.51, 119.4, 373.6);
                yield return new Grunfeld(134, 7, 1948, 50, 129.1, 389.4);
                yield return new Grunfeld(135, 7, 1949, 50.59, 134.8, 406.7);
                yield return new Grunfeld(136, 7, 1950, 42.53, 140.8, 429.5);
                yield return new Grunfeld(137, 7, 1951, 64.77, 179, 450.6);
                yield return new Grunfeld(138, 7, 1952, 72.68, 178.1, 466.9);
                yield return new Grunfeld(139, 7, 1953, 73.86, 186.8, 486.2);
                yield return new Grunfeld(140, 7, 1954, 89.51, 192.7, 511.3);
                yield return new Grunfeld(141, 8, 1935, 12.93, 191.5, 1.8);
                yield return new Grunfeld(142, 8, 1936, 25.9, 516, 0.8);
                yield return new Grunfeld(143, 8, 1937, 35.05, 729, 7.4);
                yield return new Grunfeld(144, 8, 1938, 22.89, 560.4, 18.1);
                yield return new Grunfeld(145, 8, 1939, 18.84, 519.9, 23.5);
                yield return new Grunfeld(146, 8, 1940, 28.57, 628.5, 26.5);
                yield return new Grunfeld(147, 8, 1941, 48.51, 537.1, 36.2);
                yield return new Grunfeld(148, 8, 1942, 43.34, 561.2, 60.8);
                yield return new Grunfeld(149, 8, 1943, 37.02, 617.2, 84.4);
                yield return new Grunfeld(150, 8, 1944, 37.81, 626.7, 91.2);
                yield return new Grunfeld(151, 8, 1945, 39.27, 737.2, 92.4);
                yield return new Grunfeld(152, 8, 1946, 53.46, 760.5, 86);
                yield return new Grunfeld(153, 8, 1947, 55.56, 581.4, 111.1);
                yield return new Grunfeld(154, 8, 1948, 49.56, 662.3, 130.6);
                yield return new Grunfeld(155, 8, 1949, 32.04, 583.8, 141.8);
                yield return new Grunfeld(156, 8, 1950, 32.24, 635.2, 136.7);
                yield return new Grunfeld(157, 8, 1951, 54.38, 723.8, 129.7);
                yield return new Grunfeld(158, 8, 1952, 71.78, 864.1, 145.5);
                yield return new Grunfeld(159, 8, 1953, 90.08, 1193.5, 174.8);
                yield return new Grunfeld(160, 8, 1954, 68.6, 1188.9, 213.5);
                yield return new Grunfeld(161, 9, 1935, 26.63, 290.6, 162);
                yield return new Grunfeld(162, 9, 1936, 23.39, 291.1, 174);
                yield return new Grunfeld(163, 9, 1937, 30.65, 335, 183);
                yield return new Grunfeld(164, 9, 1938, 20.89, 246, 198);
                yield return new Grunfeld(165, 9, 1939, 28.78, 356.2, 208);
                yield return new Grunfeld(166, 9, 1940, 26.93, 289.8, 223);
                yield return new Grunfeld(167, 9, 1941, 32.08, 268.2, 234);
                yield return new Grunfeld(168, 9, 1942, 32.21, 213.3, 248);
                yield return new Grunfeld(169, 9, 1943, 35.69, 348.2, 274);
                yield return new Grunfeld(170, 9, 1944, 62.47, 374.2, 282);
                yield return new Grunfeld(171, 9, 1945, 52.32, 387.2, 316);
                yield return new Grunfeld(172, 9, 1946, 56.95, 347.4, 302);
                yield return new Grunfeld(173, 9, 1947, 54.32, 291.9, 333);
                yield return new Grunfeld(174, 9, 1948, 40.53, 297.2, 359);
                yield return new Grunfeld(175, 9, 1949, 32.54, 276.9, 370);
                yield return new Grunfeld(176, 9, 1950, 43.48, 274.6, 376);
                yield return new Grunfeld(177, 9, 1951, 56.49, 339.9, 391);
                yield return new Grunfeld(178, 9, 1952, 65.98, 474.8, 414);
                yield return new Grunfeld(179, 9, 1953, 66.11, 496, 443);
                yield return new Grunfeld(180, 9, 1954, 49.34, 474.5, 468);
                yield return new Grunfeld(181, 10, 1935, 2.54, 70.91, 4.5);
                yield return new Grunfeld(182, 10, 1936, 2, 87.94, 4.71);
                yield return new Grunfeld(183, 10, 1937, 2.19, 82.2, 4.57);
                yield return new Grunfeld(184, 10, 1938, 1.99, 58.72, 4.56);
                yield return new Grunfeld(185, 10, 1939, 2.03, 80.54, 4.38);
                yield return new Grunfeld(186, 10, 1940, 1.81, 86.47, 4.21);
                yield return new Grunfeld(187, 10, 1941, 2.14, 77.68, 4.12);
                yield return new Grunfeld(188, 10, 1942, 1.86, 62.16, 3.83);
                yield return new Grunfeld(189, 10, 1943, 0.93, 62.24, 3.58);
                yield return new Grunfeld(190, 10, 1944, 1.18, 61.82, 3.41);
                yield return new Grunfeld(191, 10, 1945, 1.36, 65.85, 3.31);
                yield return new Grunfeld(192, 10, 1946, 2.24, 69.54, 3.23);
                yield return new Grunfeld(193, 10, 1947, 3.81, 64.97, 3.9);
                yield return new Grunfeld(194, 10, 1948, 5.66, 68, 5.38);
                yield return new Grunfeld(195, 10, 1949, 4.21, 71.24, 7.39);
                yield return new Grunfeld(196, 10, 1950, 3.42, 69.05, 8.74);
                yield return new Grunfeld(197, 10, 1951, 4.67, 83.04, 9.07);
                yield return new Grunfeld(198, 10, 1952, 6, 74.42, 9.93);
                yield return new Grunfeld(199, 10, 1953, 6.53, 63.51, 11.68);
                yield return new Grunfeld(200, 10, 1954, 5.12, 58.12, 14.33);
            }
        }
    }
}
