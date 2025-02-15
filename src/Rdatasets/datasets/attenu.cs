// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// The Joyner-Boore Attenuation Data
    /// </summary>

    public class attenu
    {
        public readonly int κ;
        public readonly int @event;
        public readonly double mag;
        public readonly string station;
        public readonly double dist;
        public readonly double accel;

        public attenu(int κ, int @event, double mag, string station, double dist, double accel)
        {
            this.κ = κ;
            this.@event = @event;
            this.mag = mag;
            this.station = station;
            this.dist = dist;
            this.accel = accel;
        }

        public static IEnumerable<attenu> Data
        {
            get
            {
                yield return new attenu(1, 1, 7, "117", 12, 0.359);
                yield return new attenu(2, 2, 7.4, "1083", 148, 0.014);
                yield return new attenu(3, 2, 7.4, "1095", 42, 0.196);
                yield return new attenu(4, 2, 7.4, "283", 85, 0.135);
                yield return new attenu(5, 2, 7.4, "135", 107, 0.062);
                yield return new attenu(6, 2, 7.4, "475", 109, 0.054);
                yield return new attenu(7, 2, 7.4, "113", 156, 0.014);
                yield return new attenu(8, 2, 7.4, "1008", 224, 0.018);
                yield return new attenu(9, 2, 7.4, "1028", 293, 0.01);
                yield return new attenu(10, 2, 7.4, "2001", 359, 0.004);
                yield return new attenu(11, 2, 7.4, "117", 370, 0.004);
                yield return new attenu(12, 3, 5.3, "1117", 8, 0.127);
                yield return new attenu(13, 4, 6.1, "1438", 16.1, 0.411);
                yield return new attenu(14, 4, 6.1, "1083", 63.6, 0.018);
                yield return new attenu(15, 4, 6.1, "1013", 6.6, 0.509);
                yield return new attenu(16, 4, 6.1, "1014", 9.3, 0.467);
                yield return new attenu(17, 4, 6.1, "1015", 13, 0.279);
                yield return new attenu(18, 4, 6.1, "1016", 17.3, 0.072);
                yield return new attenu(19, 4, 6.1, "1095", 105, 0.012);
                yield return new attenu(20, 4, 6.1, "1011", 112, 0.006);
                yield return new attenu(21, 4, 6.1, "1028", 123, 0.003);
                yield return new attenu(22, 5, 6.6, "270", 105, 0.018);
                yield return new attenu(23, 5, 6.6, "280", 122, 0.048);
                yield return new attenu(24, 5, 6.6, "116", 141, 0.011);
                yield return new attenu(25, 5, 6.6, "266", 200, 0.007);
                yield return new attenu(26, 5, 6.6, "117", 45, 0.142);
                yield return new attenu(27, 5, 6.6, "113", 130, 0.031);
                yield return new attenu(28, 5, 6.6, "112", 147, 0.006);
                yield return new attenu(29, 5, 6.6, "130", 187, 0.01);
                yield return new attenu(30, 5, 6.6, "475", 197, 0.01);
                yield return new attenu(31, 5, 6.6, "269", 203, 0.006);
                yield return new attenu(32, 5, 6.6, "135", 211, 0.013);
                yield return new attenu(33, 6, 5.6, "1093", 62, 0.005);
                yield return new attenu(34, 7, 5.7, "1093", 62, 0.003);
                yield return new attenu(35, 8, 5.3, "111", 19, 0.086);
                yield return new attenu(36, 8, 5.3, "116", 21, 0.179);
                yield return new attenu(37, 8, 5.3, "290", 13, 0.205);
                yield return new attenu(38, 8, 5.3, "112", 22, 0.073);
                yield return new attenu(39, 8, 5.3, "113", 29, 0.045);
                yield return new attenu(40, 9, 6.6, "128", 17, 0.374);
                yield return new attenu(41, 9, 6.6, "126", 19.6, 0.2);
                yield return new attenu(42, 9, 6.6, "127", 20.2, 0.147);
                yield return new attenu(43, 9, 6.6, "141", 21.1, 0.188);
                yield return new attenu(44, 9, 6.6, "266", 21.9, 0.204);
                yield return new attenu(45, 9, 6.6, "110", 24.2, 0.335);
                yield return new attenu(46, 9, 6.6, "1027", 66, 0.057);
                yield return new attenu(47, 9, 6.6, "111", 87, 0.021);
                yield return new attenu(48, 9, 6.6, "125", 23.4, 0.152);
                yield return new attenu(49, 9, 6.6, "135", 24.6, 0.217);
                yield return new attenu(50, 9, 6.6, "475", 25.7, 0.114);
                yield return new attenu(51, 9, 6.6, "262", 28.6, 0.15);
                yield return new attenu(52, 9, 6.6, "269", 37.4, 0.148);
                yield return new attenu(53, 9, 6.6, "1052", 46.7, 0.112);
                yield return new attenu(54, 9, 6.6, "411", 56.9, 0.043);
                yield return new attenu(55, 9, 6.6, "290", 60.7, 0.057);
                yield return new attenu(56, 9, 6.6, "130", 61.4, 0.03);
                yield return new attenu(57, 9, 6.6, "272", 62, 0.027);
                yield return new attenu(58, 9, 6.6, "1096", 64, 0.028);
                yield return new attenu(59, 9, 6.6, "1102", 82, 0.034);
                yield return new attenu(60, 9, 6.6, "112", 88, 0.03);
                yield return new attenu(61, 9, 6.6, "113", 91, 0.039);
                yield return new attenu(62, 10, 5.3, "1028", 31, 0.03);
                yield return new attenu(63, 11, 7.7, "2714", 45, 0.11);
                yield return new attenu(64, 11, 7.7, "2708", 145, 0.01);
                yield return new attenu(65, 11, 7.7, "2715", 300, 0.01);
                yield return new attenu(66, 12, 6.2, "3501", 5, 0.39);
                yield return new attenu(67, 13, 5.6, "655", 50, 0.031);
                yield return new attenu(68, 13, 5.6, "272", 16, 0.13);
                yield return new attenu(69, 14, 5.2, "1032", 17, 0.011);
                yield return new attenu(70, 14, 5.2, "1377", 8, 0.12);
                yield return new attenu(71, 14, 5.2, "1028", 10, 0.17);
                yield return new attenu(72, 14, 5.2, "1250", 10, 0.14);
                yield return new attenu(73, 15, 6, "1051", 8, 0.11);
                yield return new attenu(74, 15, 6, "1293", 32, 0.04);
                yield return new attenu(75, 15, 6, "1291", 30, 0.07);
                yield return new attenu(76, 15, 6, "1292", 31, 0.08);
                yield return new attenu(77, 16, 5.1, "283", 2.9, 0.21);
                yield return new attenu(78, 16, 5.1, "885", 3.2, 0.39);
                yield return new attenu(79, 16, 5.1, null, 7.6, 0.28);
                yield return new attenu(80, 17, 7.6, "2734", 25.4, 0.16);
                yield return new attenu(81, 17, 7.6, null, 32.9, 0.064);
                yield return new attenu(82, 17, 7.6, "2728", 92.2, 0.09);
                yield return new attenu(83, 18, 5.8, "1413", 1.2, 0.42);
                yield return new attenu(84, 18, 5.8, "1445", 1.6, 0.23);
                yield return new attenu(85, 18, 5.8, "1408", 9.1, 0.13);
                yield return new attenu(86, 18, 5.8, "1411", 3.7, 0.26);
                yield return new attenu(87, 18, 5.8, "1410", 5.3, 0.27);
                yield return new attenu(88, 18, 5.8, "1409", 7.4, 0.26);
                yield return new attenu(89, 18, 5.8, "1377", 17.9, 0.11);
                yield return new attenu(90, 18, 5.8, "1492", 19.2, 0.12);
                yield return new attenu(91, 18, 5.8, "1251", 23.4, 0.038);
                yield return new attenu(92, 18, 5.8, "1422", 30, 0.044);
                yield return new attenu(93, 18, 5.8, "1376", 38.9, 0.046);
                yield return new attenu(94, 19, 6.5, null, 23.5, 0.17);
                yield return new attenu(95, 19, 6.5, "286", 26, 0.21);
                yield return new attenu(96, 19, 6.5, null, 0.5, 0.32);
                yield return new attenu(97, 19, 6.5, "5028", 0.6, 0.52);
                yield return new attenu(98, 19, 6.5, "942", 1.3, 0.72);
                yield return new attenu(99, 19, 6.5, null, 1.4, 0.32);
                yield return new attenu(100, 19, 6.5, "5054", 2.6, 0.81);
                yield return new attenu(101, 19, 6.5, "958", 3.8, 0.64);
                yield return new attenu(102, 19, 6.5, "952", 4, 0.56);
                yield return new attenu(103, 19, 6.5, "5165", 5.1, 0.51);
                yield return new attenu(104, 19, 6.5, "117", 6.2, 0.4);
                yield return new attenu(105, 19, 6.5, "955", 6.8, 0.61);
                yield return new attenu(106, 19, 6.5, "5055", 7.5, 0.26);
                yield return new attenu(107, 19, 6.5, null, 7.6, 0.24);
                yield return new attenu(108, 19, 6.5, null, 8.4, 0.46);
                yield return new attenu(109, 19, 6.5, "5060", 8.5, 0.22);
                yield return new attenu(110, 19, 6.5, "412", 8.5, 0.23);
                yield return new attenu(111, 19, 6.5, "5053", 10.6, 0.28);
                yield return new attenu(112, 19, 6.5, "5058", 12.6, 0.38);
                yield return new attenu(113, 19, 6.5, "5057", 12.7, 0.27);
                yield return new attenu(114, 19, 6.5, null, 12.9, 0.31);
                yield return new attenu(115, 19, 6.5, "5051", 14, 0.2);
                yield return new attenu(116, 19, 6.5, null, 15, 0.11);
                yield return new attenu(117, 19, 6.5, "5115", 16, 0.43);
                yield return new attenu(118, 19, 6.5, null, 17.7, 0.27);
                yield return new attenu(119, 19, 6.5, "931", 18, 0.15);
                yield return new attenu(120, 19, 6.5, "5056", 22, 0.15);
                yield return new attenu(121, 19, 6.5, "5059", 22, 0.15);
                yield return new attenu(122, 19, 6.5, "5061", 23, 0.13);
                yield return new attenu(123, 19, 6.5, null, 23.2, 0.19);
                yield return new attenu(124, 19, 6.5, "5062", 29, 0.13);
                yield return new attenu(125, 19, 6.5, "5052", 32, 0.066);
                yield return new attenu(126, 19, 6.5, null, 32.7, 0.35);
                yield return new attenu(127, 19, 6.5, "724", 36, 0.1);
                yield return new attenu(128, 19, 6.5, null, 43.5, 0.16);
                yield return new attenu(129, 19, 6.5, "5066", 49, 0.14);
                yield return new attenu(130, 19, 6.5, "5050", 60, 0.049);
                yield return new attenu(131, 19, 6.5, "2316", 64, 0.034);
                yield return new attenu(132, 20, 5, "5055", 7.5, 0.264);
                yield return new attenu(133, 20, 5, "942", 8.8, 0.263);
                yield return new attenu(134, 20, 5, "5028", 8.9, 0.23);
                yield return new attenu(135, 20, 5, "5165", 9.4, 0.147);
                yield return new attenu(136, 20, 5, "952", 9.7, 0.286);
                yield return new attenu(137, 20, 5, "958", 9.7, 0.157);
                yield return new attenu(138, 20, 5, "955", 10.5, 0.237);
                yield return new attenu(139, 20, 5, "117", 10.5, 0.133);
                yield return new attenu(140, 20, 5, "412", 12, 0.055);
                yield return new attenu(141, 20, 5, "5053", 12.2, 0.097);
                yield return new attenu(142, 20, 5, "5054", 12.8, 0.129);
                yield return new attenu(143, 20, 5, "5058", 14.6, 0.192);
                yield return new attenu(144, 20, 5, "5057", 14.9, 0.147);
                yield return new attenu(145, 20, 5, "5115", 17.6, 0.154);
                yield return new attenu(146, 20, 5, "5056", 23.9, 0.06);
                yield return new attenu(147, 20, 5, "5060", 25, 0.057);
                yield return new attenu(148, 21, 5.8, "1030", 10.8, 0.12);
                yield return new attenu(149, 21, 5.8, "1418", 15.7, 0.154);
                yield return new attenu(150, 21, 5.8, "1383", 16.7, 0.052);
                yield return new attenu(151, 21, 5.8, "1308", 20.8, 0.045);
                yield return new attenu(152, 21, 5.8, "1298", 28.5, 0.086);
                yield return new attenu(153, 21, 5.8, "1299", 33.1, 0.056);
                yield return new attenu(154, 21, 5.8, "1219", 40.3, 0.065);
                yield return new attenu(155, 22, 5.5, null, 4, 0.259);
                yield return new attenu(156, 22, 5.5, null, 10.1, 0.267);
                yield return new attenu(157, 22, 5.5, "1030", 11.1, 0.071);
                yield return new attenu(158, 22, 5.5, "1418", 17.7, 0.275);
                yield return new attenu(159, 22, 5.5, "1383", 22.5, 0.058);
                yield return new attenu(160, 22, 5.5, null, 26.5, 0.026);
                yield return new attenu(161, 22, 5.5, "1299", 29, 0.039);
                yield return new attenu(162, 22, 5.5, "1308", 30.9, 0.112);
                yield return new attenu(163, 22, 5.5, "1219", 37.8, 0.065);
                yield return new attenu(164, 22, 5.5, "1456", 48.3, 0.026);
                yield return new attenu(165, 23, 5.3, "5045", 5.8, 0.123);
                yield return new attenu(166, 23, 5.3, "5044", 12, 0.133);
                yield return new attenu(167, 23, 5.3, "5160", 12.1, 0.073);
                yield return new attenu(168, 23, 5.3, "5043", 20.5, 0.097);
                yield return new attenu(169, 23, 5.3, "5047", 20.5, 0.096);
                yield return new attenu(170, 23, 5.3, "c168", 25.3, 0.23);
                yield return new attenu(171, 23, 5.3, "5068", 35.9, 0.082);
                yield return new attenu(172, 23, 5.3, "c118", 36.1, 0.11);
                yield return new attenu(173, 23, 5.3, "5042", 36.3, 0.11);
                yield return new attenu(174, 23, 5.3, "5067", 38.5, 0.094);
                yield return new attenu(175, 23, 5.3, "5049", 41.4, 0.04);
                yield return new attenu(176, 23, 5.3, "c204", 43.6, 0.05);
                yield return new attenu(177, 23, 5.3, "5070", 44.4, 0.022);
                yield return new attenu(178, 23, 5.3, "c266", 46.1, 0.07);
                yield return new attenu(179, 23, 5.3, "c203", 47.1, 0.08);
                yield return new attenu(180, 23, 5.3, "5069", 47.7, 0.033);
                yield return new attenu(181, 23, 5.3, "5073", 49.2, 0.017);
                yield return new attenu(182, 23, 5.3, "5072", 53.1, 0.022);
            }
        }
    }
}
