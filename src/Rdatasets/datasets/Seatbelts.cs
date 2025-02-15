// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Road Casualties in Great Britain 1969-84
    /// </summary>

    public class Seatbelts
    {
        public readonly int κ;
        public readonly int DriversKilled;
        public readonly int drivers;
        public readonly int front;
        public readonly int rear;
        public readonly int kms;
        public readonly double PetrolPrice;
        public readonly int VanKilled;
        public readonly int law;

        public Seatbelts(int κ, int DriversKilled, int drivers, int front, int rear, int kms, double PetrolPrice, int VanKilled, int law)
        {
            this.κ = κ;
            this.DriversKilled = DriversKilled;
            this.drivers = drivers;
            this.front = front;
            this.rear = rear;
            this.kms = kms;
            this.PetrolPrice = PetrolPrice;
            this.VanKilled = VanKilled;
            this.law = law;
        }

        public static IEnumerable<Seatbelts> Data
        {
            get
            {
                yield return new Seatbelts(1, 107, 1687, 867, 269, 9059, 0.102971811805368, 12, 0);
                yield return new Seatbelts(2, 97, 1508, 825, 265, 7685, 0.102362995884646, 6, 0);
                yield return new Seatbelts(3, 102, 1507, 806, 319, 9963, 0.102062490635914, 12, 0);
                yield return new Seatbelts(4, 87, 1385, 814, 407, 10955, 0.100873300511862, 8, 0);
                yield return new Seatbelts(5, 119, 1632, 991, 454, 11823, 0.101019672891934, 10, 0);
                yield return new Seatbelts(6, 106, 1511, 945, 427, 12391, 0.10058119170287, 13, 0);
                yield return new Seatbelts(7, 110, 1559, 1004, 522, 13460, 0.103773981457839, 11, 0);
                yield return new Seatbelts(8, 106, 1630, 1091, 536, 14055, 0.104076403554621, 6, 0);
                yield return new Seatbelts(9, 107, 1579, 958, 405, 12106, 0.103773981457839, 10, 0);
                yield return new Seatbelts(10, 134, 1653, 850, 437, 11372, 0.103026401330572, 16, 0);
                yield return new Seatbelts(11, 147, 2152, 1109, 434, 9834, 0.102730112155946, 13, 0);
                yield return new Seatbelts(12, 180, 2148, 1113, 437, 9267, 0.101997191539847, 14, 0);
                yield return new Seatbelts(13, 125, 1752, 925, 316, 9130, 0.101274563494893, 14, 0);
                yield return new Seatbelts(14, 134, 1765, 903, 311, 8933, 0.10070397563972, 6, 0);
                yield return new Seatbelts(15, 110, 1717, 1006, 351, 11000, 0.100139606658898, 8, 0);
                yield return new Seatbelts(16, 102, 1558, 892, 362, 10733, 0.0986211043713023, 11, 0);
                yield return new Seatbelts(17, 103, 1575, 990, 486, 12912, 0.0983492854059603, 7, 0);
                yield return new Seatbelts(18, 111, 1520, 866, 429, 12926, 0.0980801772105387, 13, 0);
                yield return new Seatbelts(19, 120, 1805, 1095, 551, 13990, 0.0972792082183714, 13, 0);
                yield return new Seatbelts(20, 129, 1800, 1204, 646, 14926, 0.0974106238350488, 11, 0);
                yield return new Seatbelts(21, 122, 1719, 1029, 456, 12900, 0.0974252365245483, 11, 0);
                yield return new Seatbelts(22, 183, 2008, 1147, 475, 12034, 0.0963806330037465, 14, 0);
                yield return new Seatbelts(23, 169, 2242, 1171, 456, 10643, 0.0957389559626943, 16, 0);
                yield return new Seatbelts(24, 190, 2478, 1299, 468, 10742, 0.0951063062359475, 14, 0);
                yield return new Seatbelts(25, 134, 2030, 944, 356, 10266, 0.0967359671470176, 17, 0);
                yield return new Seatbelts(26, 108, 1655, 874, 271, 10281, 0.0961092224873678, 16, 0);
                yield return new Seatbelts(27, 104, 1693, 840, 354, 11527, 0.095367254851379, 15, 0);
                yield return new Seatbelts(28, 117, 1623, 893, 427, 12281, 0.0947095915871269, 13, 0);
                yield return new Seatbelts(29, 157, 1805, 1007, 465, 13587, 0.0941176202174608, 13, 0);
                yield return new Seatbelts(30, 148, 1746, 973, 440, 13049, 0.0935321548190638, 15, 0);
                yield return new Seatbelts(31, 130, 1795, 1097, 539, 16055, 0.0929540494377308, 12, 0);
                yield return new Seatbelts(32, 140, 1926, 1194, 646, 15220, 0.0928397862431927, 6, 0);
                yield return new Seatbelts(33, 136, 1619, 988, 457, 13824, 0.0927247362539862, 9, 0);
                yield return new Seatbelts(34, 140, 1992, 1077, 446, 12729, 0.0922696509793897, 13, 0);
                yield return new Seatbelts(35, 187, 2233, 1045, 402, 11467, 0.0917066851479679, 14, 0);
                yield return new Seatbelts(36, 150, 2192, 1115, 441, 11351, 0.0912620719433678, 15, 0);
                yield return new Seatbelts(37, 159, 2080, 1005, 359, 10803, 0.090711603254936, 14, 0);
                yield return new Seatbelts(38, 143, 1768, 857, 334, 10548, 0.090276328119195, 3, 0);
                yield return new Seatbelts(39, 114, 1835, 879, 312, 12368, 0.0899519176272147, 12, 0);
                yield return new Seatbelts(40, 127, 1569, 887, 427, 13311, 0.0890996386561615, 13, 0);
                yield return new Seatbelts(41, 159, 1976, 1075, 434, 13885, 0.0886791925043499, 12, 0);
                yield return new Seatbelts(42, 156, 1853, 1121, 486, 14088, 0.0881592888670634, 8, 0);
                yield return new Seatbelts(43, 138, 1965, 1190, 569, 16932, 0.0889020568552906, 8, 0);
                yield return new Seatbelts(44, 120, 1689, 1058, 523, 16164, 0.0881813314444876, 15, 0);
                yield return new Seatbelts(45, 117, 1778, 939, 418, 14883, 0.0889402929599117, 8, 0);
                yield return new Seatbelts(46, 170, 1976, 1074, 452, 13532, 0.0877266104275971, 5, 0);
                yield return new Seatbelts(47, 168, 2397, 1089, 462, 12220, 0.087428846437772, 17, 0);
                yield return new Seatbelts(48, 198, 2654, 1208, 497, 12025, 0.0870354301608856, 14, 0);
                yield return new Seatbelts(49, 144, 2097, 903, 354, 11692, 0.0864499193294655, 13, 0);
                yield return new Seatbelts(50, 146, 1963, 916, 347, 11081, 0.0858726409121568, 5, 0);
                yield return new Seatbelts(51, 109, 1677, 787, 276, 13745, 0.0853982218357345, 8, 0);
                yield return new Seatbelts(52, 131, 1941, 1114, 472, 14382, 0.083821981233605, 5, 0);
                yield return new Seatbelts(53, 151, 2003, 1014, 487, 14391, 0.0845907801489325, 12, 0);
                yield return new Seatbelts(54, 140, 1813, 1022, 505, 15597, 0.0841369037739444, 11, 0);
                yield return new Seatbelts(55, 153, 2012, 1114, 619, 16834, 0.0837784051341314, 13, 0);
                yield return new Seatbelts(56, 140, 1912, 1132, 640, 17282, 0.0835107427259604, 15, 0);
                yield return new Seatbelts(57, 161, 2084, 1111, 559, 15779, 0.0828063938633846, 11, 0);
                yield return new Seatbelts(58, 168, 2080, 1008, 453, 13946, 0.0811788933269884, 11, 0);
                yield return new Seatbelts(59, 152, 2118, 916, 418, 12701, 0.0828536069623417, 10, 0);
                yield return new Seatbelts(60, 136, 2150, 992, 419, 10431, 0.0941901186933595, 13, 0);
                yield return new Seatbelts(61, 113, 1608, 731, 262, 11616, 0.0923998429510411, 8, 0);
                yield return new Seatbelts(62, 100, 1503, 665, 299, 10808, 0.108161478199019, 6, 0);
                yield return new Seatbelts(63, 103, 1548, 724, 303, 12421, 0.10721168869023, 8, 0);
                yield return new Seatbelts(64, 103, 1382, 744, 401, 13605, 0.114042966782082, 14, 0);
                yield return new Seatbelts(65, 121, 1731, 910, 413, 14455, 0.112454115810183, 12, 0);
                yield return new Seatbelts(66, 134, 1798, 883, 426, 15019, 0.111316253290611, 14, 0);
                yield return new Seatbelts(67, 133, 1779, 900, 516, 15662, 0.11030125221242, 13, 0);
                yield return new Seatbelts(68, 129, 1887, 1057, 600, 16745, 0.108197177376865, 9, 0);
                yield return new Seatbelts(69, 144, 2004, 1076, 459, 14717, 0.107027443082328, 4, 0);
                yield return new Seatbelts(70, 154, 2077, 919, 443, 13756, 0.104946980916917, 13, 0);
                yield return new Seatbelts(71, 156, 2092, 920, 412, 12531, 0.119357749193208, 6, 0);
                yield return new Seatbelts(72, 163, 2051, 953, 400, 12568, 0.117621904277373, 15, 0);
                yield return new Seatbelts(73, 122, 1577, 664, 278, 11249, 0.133027420877451, 12, 0);
                yield return new Seatbelts(74, 92, 1356, 607, 302, 11096, 0.130845243689729, 16, 0);
                yield return new Seatbelts(75, 117, 1652, 777, 381, 12637, 0.128318477474772, 7, 0);
                yield return new Seatbelts(76, 95, 1382, 633, 279, 13018, 0.123547448292297, 12, 0);
                yield return new Seatbelts(77, 96, 1519, 791, 442, 15005, 0.118586811514179, 10, 0);
                yield return new Seatbelts(78, 108, 1421, 790, 409, 15235, 0.116337480161004, 9, 0);
                yield return new Seatbelts(79, 108, 1442, 803, 416, 15552, 0.11516147558196, 9, 0);
                yield return new Seatbelts(80, 106, 1543, 884, 511, 16905, 0.114501197216867, 6, 0);
                yield return new Seatbelts(81, 140, 1656, 769, 393, 14776, 0.113522979499817, 7, 0);
                yield return new Seatbelts(82, 114, 1561, 732, 345, 14104, 0.111930179432996, 13, 0);
                yield return new Seatbelts(83, 158, 1905, 859, 391, 12854, 0.110610528503361, 14, 0);
                yield return new Seatbelts(84, 161, 2199, 994, 470, 12956, 0.11527438914664, 13, 0);
                yield return new Seatbelts(85, 102, 1473, 704, 266, 12177, 0.113793485966034, 14, 0);
                yield return new Seatbelts(86, 127, 1655, 684, 312, 11918, 0.112349582098189, 11, 0);
                yield return new Seatbelts(87, 125, 1407, 671, 300, 13517, 0.111753469387189, 11, 0);
                yield return new Seatbelts(88, 101, 1395, 643, 373, 14417, 0.109642522576533, 10, 0);
                yield return new Seatbelts(89, 97, 1530, 771, 412, 15911, 0.10844089510559, 4, 0);
                yield return new Seatbelts(90, 112, 1309, 644, 322, 15589, 0.107884938936114, 8, 0);
                yield return new Seatbelts(91, 112, 1526, 828, 458, 16543, 0.109084769191454, 9, 0);
                yield return new Seatbelts(92, 113, 1327, 748, 427, 17925, 0.107571450111271, 10, 0);
                yield return new Seatbelts(93, 108, 1627, 767, 346, 15406, 0.106164022368002, 10, 0);
                yield return new Seatbelts(94, 128, 1748, 825, 421, 14601, 0.106299999323319, 5, 0);
                yield return new Seatbelts(95, 154, 1958, 810, 344, 13107, 0.104825313000088, 13, 0);
                yield return new Seatbelts(96, 162, 2274, 986, 370, 12268, 0.103451745711815, 12, 0);
                yield return new Seatbelts(97, 112, 1648, 714, 291, 11972, 0.101449920129493, 10, 0);
                yield return new Seatbelts(98, 79, 1401, 567, 224, 12028, 0.100402316427863, 9, 0);
                yield return new Seatbelts(99, 82, 1411, 616, 266, 14033, 0.098862033680192, 7, 0);
                yield return new Seatbelts(100, 127, 1403, 678, 338, 14244, 0.102496154313521, 5, 0);
                yield return new Seatbelts(101, 108, 1394, 742, 298, 15287, 0.103027431599736, 10, 0);
                yield return new Seatbelts(102, 110, 1520, 840, 386, 16954, 0.102178908220655, 5, 0);
                yield return new Seatbelts(103, 123, 1528, 888, 479, 17361, 0.0998366428726473, 6, 0);
                yield return new Seatbelts(104, 103, 1643, 852, 473, 17694, 0.0926366895833353, 8, 0);
                yield return new Seatbelts(105, 97, 1515, 774, 332, 16222, 0.0918149629077569, 6, 0);
                yield return new Seatbelts(106, 140, 1685, 831, 391, 14969, 0.090724303768407, 12, 0);
                yield return new Seatbelts(107, 165, 2000, 889, 370, 13624, 0.0900212072768793, 15, 0);
                yield return new Seatbelts(108, 183, 2215, 1046, 431, 13842, 0.0893307058230937, 7, 0);
                yield return new Seatbelts(109, 148, 1956, 889, 366, 12387, 0.0884427348717763, 14, 0);
                yield return new Seatbelts(110, 111, 1462, 626, 250, 11608, 0.0883525692744791, 4, 0);
                yield return new Seatbelts(111, 116, 1563, 808, 355, 15021, 0.0867573619308237, 10, 0);
                yield return new Seatbelts(112, 115, 1459, 746, 304, 14834, 0.0849952420449752, 8, 0);
                yield return new Seatbelts(113, 100, 1446, 754, 379, 16565, 0.0845679437213488, 7, 0);
                yield return new Seatbelts(114, 106, 1622, 865, 440, 16882, 0.0844318988774436, 11, 0);
                yield return new Seatbelts(115, 134, 1657, 980, 500, 18012, 0.0843508831482932, 3, 0);
                yield return new Seatbelts(116, 125, 1638, 959, 511, 18855, 0.0836009830491076, 5, 0);
                yield return new Seatbelts(117, 117, 1643, 856, 384, 17243, 0.0834172630524962, 11, 0);
                yield return new Seatbelts(118, 122, 1683, 798, 366, 16045, 0.0827451397987249, 10, 0);
                yield return new Seatbelts(119, 153, 2050, 942, 432, 14745, 0.0852352669035281, 10, 0);
                yield return new Seatbelts(120, 178, 2262, 1010, 390, 13726, 0.0847703028296526, 7, 0);
                yield return new Seatbelts(121, 114, 1813, 796, 306, 11196, 0.0844589214084587, 10, 0);
                yield return new Seatbelts(122, 94, 1445, 643, 232, 12105, 0.085352119244763, 11, 0);
                yield return new Seatbelts(123, 128, 1762, 794, 342, 14723, 0.0875592125175749, 9, 0);
                yield return new Seatbelts(124, 119, 1461, 750, 329, 15582, 0.0903829170614837, 7, 0);
                yield return new Seatbelts(125, 111, 1556, 809, 394, 16863, 0.0907832937355188, 8, 0);
                yield return new Seatbelts(126, 110, 1431, 716, 355, 16758, 0.108742780219868, 13, 0);
                yield return new Seatbelts(127, 114, 1427, 851, 385, 17434, 0.114142227335262, 8, 0);
                yield return new Seatbelts(128, 118, 1554, 931, 463, 18359, 0.112992933231466, 5, 0);
                yield return new Seatbelts(129, 115, 1645, 834, 453, 17189, 0.111320706029796, 8, 0);
                yield return new Seatbelts(130, 132, 1653, 762, 373, 16909, 0.109126229280665, 7, 0);
                yield return new Seatbelts(131, 153, 2016, 880, 401, 15380, 0.107698459343112, 12, 0);
                yield return new Seatbelts(132, 171, 2207, 1077, 466, 15161, 0.107601574334496, 10, 0);
                yield return new Seatbelts(133, 115, 1665, 748, 306, 14027, 0.103775019202843, 7, 0);
                yield return new Seatbelts(134, 95, 1361, 593, 263, 14478, 0.107114170431059, 4, 0);
                yield return new Seatbelts(135, 92, 1506, 720, 323, 16155, 0.107374774370757, 10, 0);
                yield return new Seatbelts(136, 100, 1360, 646, 310, 16585, 0.111695372689559, 4, 0);
                yield return new Seatbelts(137, 95, 1453, 765, 424, 18117, 0.110638184592354, 8, 0);
                yield return new Seatbelts(138, 114, 1522, 820, 403, 17552, 0.111855211329895, 8, 0);
                yield return new Seatbelts(139, 102, 1460, 807, 406, 18299, 0.109742342683337, 7, 0);
                yield return new Seatbelts(140, 104, 1552, 885, 466, 19361, 0.108193931510232, 10, 0);
                yield return new Seatbelts(141, 132, 1548, 803, 381, 17924, 0.106255362697951, 8, 0);
                yield return new Seatbelts(142, 136, 1827, 860, 369, 17872, 0.104193034427699, 14, 0);
                yield return new Seatbelts(143, 117, 1737, 825, 378, 16058, 0.101933972880902, 8, 0);
                yield return new Seatbelts(144, 137, 1941, 911, 392, 15746, 0.102793824574291, 9, 0);
                yield return new Seatbelts(145, 111, 1474, 704, 284, 15226, 0.10476034144929, 8, 0);
                yield return new Seatbelts(146, 106, 1458, 691, 316, 14932, 0.104002535534347, 6, 0);
                yield return new Seatbelts(147, 98, 1542, 688, 321, 16846, 0.116655515402424, 7, 0);
                yield return new Seatbelts(148, 84, 1404, 714, 358, 16854, 0.11516147558196, 6, 0);
                yield return new Seatbelts(149, 94, 1522, 814, 378, 18146, 0.112989543494316, 5, 0);
                yield return new Seatbelts(150, 105, 1385, 736, 382, 17559, 0.113860643932406, 4, 0);
                yield return new Seatbelts(151, 123, 1641, 876, 433, 18655, 0.119118081064489, 5, 0);
                yield return new Seatbelts(152, 109, 1510, 829, 506, 19453, 0.124489986005886, 10, 0);
                yield return new Seatbelts(153, 130, 1681, 818, 428, 17923, 0.123222945411622, 7, 0);
                yield return new Seatbelts(154, 153, 1938, 942, 479, 17915, 0.12067793212866, 10, 0);
                yield return new Seatbelts(155, 134, 1868, 782, 370, 16496, 0.121048982651421, 12, 0);
                yield return new Seatbelts(156, 99, 1726, 823, 349, 13544, 0.116968571491487, 7, 0);
                yield return new Seatbelts(157, 115, 1456, 595, 238, 13601, 0.112750259392875, 4, 0);
                yield return new Seatbelts(158, 104, 1445, 673, 285, 15667, 0.108079306704711, 5, 0);
                yield return new Seatbelts(159, 131, 1456, 660, 324, 17358, 0.108838515984019, 6, 0);
                yield return new Seatbelts(160, 108, 1365, 676, 346, 18112, 0.111291766408542, 4, 0);
                yield return new Seatbelts(161, 103, 1487, 755, 410, 18581, 0.111304009176187, 4, 0);
                yield return new Seatbelts(162, 115, 1558, 815, 411, 18759, 0.115454357532553, 8, 0);
                yield return new Seatbelts(163, 122, 1488, 867, 496, 20668, 0.114768296055692, 8, 0);
                yield return new Seatbelts(164, 122, 1684, 933, 534, 21040, 0.117207430931122, 3, 0);
                yield return new Seatbelts(165, 125, 1594, 798, 396, 18993, 0.119076397031248, 7, 0);
                yield return new Seatbelts(166, 137, 1850, 950, 470, 18668, 0.117965862171995, 12, 0);
                yield return new Seatbelts(167, 138, 1998, 825, 385, 16768, 0.117449127100423, 2, 0);
                yield return new Seatbelts(168, 152, 2079, 911, 411, 16551, 0.116988457838933, 7, 0);
                yield return new Seatbelts(169, 120, 1494, 619, 281, 16231, 0.11261053571781, 8, 0);
                yield return new Seatbelts(170, 95, 1057, 426, 300, 15511, 0.113657015681422, 3, 1);
                yield return new Seatbelts(171, 100, 1218, 475, 318, 18308, 0.113144445252379, 2, 1);
                yield return new Seatbelts(172, 89, 1168, 556, 391, 17793, 0.118495534815352, 6, 1);
                yield return new Seatbelts(173, 82, 1236, 559, 398, 19205, 0.117969401200945, 3, 1);
                yield return new Seatbelts(174, 89, 1076, 483, 337, 19162, 0.1176866141183, 7, 1);
                yield return new Seatbelts(175, 60, 1174, 587, 477, 20997, 0.120059238961094, 6, 1);
                yield return new Seatbelts(176, 84, 1139, 615, 422, 20705, 0.119437745680998, 8, 1);
                yield return new Seatbelts(177, 113, 1427, 618, 495, 18759, 0.118881271786551, 8, 1);
                yield return new Seatbelts(178, 126, 1487, 662, 471, 19240, 0.118462360710195, 4, 1);
                yield return new Seatbelts(179, 122, 1483, 519, 368, 17504, 0.118016598400236, 3, 1);
                yield return new Seatbelts(180, 118, 1513, 585, 345, 16591, 0.117706622543368, 5, 1);
                yield return new Seatbelts(181, 92, 1357, 483, 296, 16224, 0.117776089941536, 5, 1);
                yield return new Seatbelts(182, 86, 1165, 434, 319, 16670, 0.114796991716514, 3, 1);
                yield return new Seatbelts(183, 81, 1282, 513, 349, 18539, 0.11573525277085, 4, 1);
                yield return new Seatbelts(184, 84, 1110, 548, 375, 19759, 0.115356263024722, 3, 1);
                yield return new Seatbelts(185, 87, 1297, 586, 441, 19584, 0.114815360704668, 6, 1);
                yield return new Seatbelts(186, 90, 1185, 522, 465, 19976, 0.114777477886645, 6, 1);
                yield return new Seatbelts(187, 79, 1222, 601, 472, 21486, 0.114935980147534, 7, 1);
                yield return new Seatbelts(188, 96, 1284, 644, 521, 21626, 0.114796991716514, 5, 1);
                yield return new Seatbelts(189, 122, 1444, 643, 429, 20195, 0.114093156728444, 7, 1);
                yield return new Seatbelts(190, 120, 1575, 641, 408, 19928, 0.116465521799171, 7, 1);
                yield return new Seatbelts(191, 137, 1737, 711, 490, 18564, 0.116026113132354, 4, 1);
                yield return new Seatbelts(192, 154, 1763, 721, 491, 18149, 0.116066729379379, 7, 1);
            }
        }
    }
}
