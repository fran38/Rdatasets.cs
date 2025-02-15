// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Daily pageviews for the Hyndsight blog. 30 April 2014 to 29 April 2015.
    /// </summary>

    public class hyndsight
    {
        public readonly int κ;
        public readonly double time;
        public readonly int value;

        public hyndsight(int κ, double time, int value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<hyndsight> Data
        {
            get
            {
                yield return new hyndsight(1, 1.42857142857143, 1157);
                yield return new hyndsight(2, 1.57142857142857, 1118);
                yield return new hyndsight(3, 1.71428571428571, 1310);
                yield return new hyndsight(4, 1.85714285714286, 874);
                yield return new hyndsight(5, 2, 890);
                yield return new hyndsight(6, 2.14285714285714, 1437);
                yield return new hyndsight(7, 2.28571428571429, 1263);
                yield return new hyndsight(8, 2.42857142857143, 1187);
                yield return new hyndsight(9, 2.57142857142857, 1506);
                yield return new hyndsight(10, 2.71428571428571, 1448);
                yield return new hyndsight(11, 2.85714285714286, 1054);
                yield return new hyndsight(12, 3, 663);
                yield return new hyndsight(13, 3.14285714285714, 988);
                yield return new hyndsight(14, 3.28571428571429, 1241);
                yield return new hyndsight(15, 3.42857142857143, 1207);
                yield return new hyndsight(16, 3.57142857142857, 1288);
                yield return new hyndsight(17, 3.71428571428571, 1045);
                yield return new hyndsight(18, 3.85714285714286, 842);
                yield return new hyndsight(19, 4, 687);
                yield return new hyndsight(20, 4.14285714285714, 1136);
                yield return new hyndsight(21, 4.28571428571429, 1348);
                yield return new hyndsight(22, 4.42857142857143, 1241);
                yield return new hyndsight(23, 4.57142857142857, 1164);
                yield return new hyndsight(24, 4.71428571428571, 1029);
                yield return new hyndsight(25, 4.85714285714286, 909);
                yield return new hyndsight(26, 5, 650);
                yield return new hyndsight(27, 5.14285714285714, 1275);
                yield return new hyndsight(28, 5.28571428571429, 1203);
                yield return new hyndsight(29, 5.42857142857143, 1233);
                yield return new hyndsight(30, 5.57142857142857, 1014);
                yield return new hyndsight(31, 5.71428571428571, 1040);
                yield return new hyndsight(32, 5.85714285714286, 825);
                yield return new hyndsight(33, 6, 593);
                yield return new hyndsight(34, 6.14285714285714, 875);
                yield return new hyndsight(35, 6.28571428571429, 1096);
                yield return new hyndsight(36, 6.42857142857143, 1059);
                yield return new hyndsight(37, 6.57142857142857, 1105);
                yield return new hyndsight(38, 6.71428571428571, 949);
                yield return new hyndsight(39, 6.85714285714286, 652);
                yield return new hyndsight(40, 7, 546);
                yield return new hyndsight(41, 7.14285714285714, 762);
                yield return new hyndsight(42, 7.28571428571429, 1082);
                yield return new hyndsight(43, 7.42857142857143, 1305);
                yield return new hyndsight(44, 7.57142857142857, 1232);
                yield return new hyndsight(45, 7.71428571428571, 1089);
                yield return new hyndsight(46, 7.85714285714286, 735);
                yield return new hyndsight(47, 8, 775);
                yield return new hyndsight(48, 8.14285714285714, 1381);
                yield return new hyndsight(49, 8.28571428571428, 1320);
                yield return new hyndsight(50, 8.42857142857143, 1398);
                yield return new hyndsight(51, 8.57142857142857, 991);
                yield return new hyndsight(52, 8.71428571428571, 1052);
                yield return new hyndsight(53, 8.85714285714286, 669);
                yield return new hyndsight(54, 9, 422);
                yield return new hyndsight(55, 9.14285714285714, 779);
                yield return new hyndsight(56, 9.28571428571428, 1150);
                yield return new hyndsight(57, 9.42857142857143, 1001);
                yield return new hyndsight(58, 9.57142857142857, 1582);
                yield return new hyndsight(59, 9.71428571428571, 847);
                yield return new hyndsight(60, 9.85714285714286, 721);
                yield return new hyndsight(61, 10, 541);
                yield return new hyndsight(62, 10.1428571428571, 710);
                yield return new hyndsight(63, 10.2857142857143, 1649);
                yield return new hyndsight(64, 10.4285714285714, 919);
                yield return new hyndsight(65, 10.5714285714286, 1008);
                yield return new hyndsight(66, 10.7142857142857, 1000);
                yield return new hyndsight(67, 10.8571428571429, 465);
                yield return new hyndsight(68, 11, 448);
                yield return new hyndsight(69, 11.1428571428571, 721);
                yield return new hyndsight(70, 11.2857142857143, 1030);
                yield return new hyndsight(71, 11.4285714285714, 915);
                yield return new hyndsight(72, 11.5714285714286, 870);
                yield return new hyndsight(73, 11.7142857142857, 795);
                yield return new hyndsight(74, 11.8571428571429, 667);
                yield return new hyndsight(75, 12, 487);
                yield return new hyndsight(76, 12.1428571428571, 741);
                yield return new hyndsight(77, 12.2857142857143, 1030);
                yield return new hyndsight(78, 12.4285714285714, 1287);
                yield return new hyndsight(79, 12.5714285714286, 1061);
                yield return new hyndsight(80, 12.7142857142857, 971);
                yield return new hyndsight(81, 12.8571428571429, 549);
                yield return new hyndsight(82, 13, 509);
                yield return new hyndsight(83, 13.1428571428571, 1046);
                yield return new hyndsight(84, 13.2857142857143, 1514);
                yield return new hyndsight(85, 13.4285714285714, 1655);
                yield return new hyndsight(86, 13.5714285714286, 1489);
                yield return new hyndsight(87, 13.7142857142857, 1352);
                yield return new hyndsight(88, 13.8571428571429, 828);
                yield return new hyndsight(89, 14, 591);
                yield return new hyndsight(90, 14.1428571428571, 820);
                yield return new hyndsight(91, 14.2857142857143, 1409);
                yield return new hyndsight(92, 14.4285714285714, 1819);
                yield return new hyndsight(93, 14.5714285714286, 1243);
                yield return new hyndsight(94, 14.7142857142857, 1157);
                yield return new hyndsight(95, 14.8571428571429, 626);
                yield return new hyndsight(96, 15, 437);
                yield return new hyndsight(97, 15.1428571428571, 842);
                yield return new hyndsight(98, 15.2857142857143, 1118);
                yield return new hyndsight(99, 15.4285714285714, 985);
                yield return new hyndsight(100, 15.5714285714286, 983);
                yield return new hyndsight(101, 15.7142857142857, 871);
                yield return new hyndsight(102, 15.8571428571429, 591);
                yield return new hyndsight(103, 16, 533);
                yield return new hyndsight(104, 16.1428571428571, 937);
                yield return new hyndsight(105, 16.2857142857143, 1312);
                yield return new hyndsight(106, 16.4285714285714, 1412);
                yield return new hyndsight(107, 16.5714285714286, 1183);
                yield return new hyndsight(108, 16.7142857142857, 955);
                yield return new hyndsight(109, 16.8571428571429, 629);
                yield return new hyndsight(110, 17, 561);
                yield return new hyndsight(111, 17.1428571428571, 833);
                yield return new hyndsight(112, 17.2857142857143, 1067);
                yield return new hyndsight(113, 17.4285714285714, 987);
                yield return new hyndsight(114, 17.5714285714286, 976);
                yield return new hyndsight(115, 17.7142857142857, 1218);
                yield return new hyndsight(116, 17.8571428571429, 853);
                yield return new hyndsight(117, 18, 432);
                yield return new hyndsight(118, 18.1428571428571, 869);
                yield return new hyndsight(119, 18.2857142857143, 1152);
                yield return new hyndsight(120, 18.4285714285714, 944);
                yield return new hyndsight(121, 18.5714285714286, 947);
                yield return new hyndsight(122, 18.7142857142857, 847);
                yield return new hyndsight(123, 18.8571428571429, 626);
                yield return new hyndsight(124, 19, 558);
                yield return new hyndsight(125, 19.1428571428571, 2300);
                yield return new hyndsight(126, 19.2857142857143, 2469);
                yield return new hyndsight(127, 19.4285714285714, 1411);
                yield return new hyndsight(128, 19.5714285714286, 1178);
                yield return new hyndsight(129, 19.7142857142857, 1111);
                yield return new hyndsight(130, 19.8571428571429, 641);
                yield return new hyndsight(131, 20, 867);
                yield return new hyndsight(132, 20.1428571428571, 1359);
                yield return new hyndsight(133, 20.2857142857143, 1730);
                yield return new hyndsight(134, 20.4285714285714, 1529);
                yield return new hyndsight(135, 20.5714285714286, 1168);
                yield return new hyndsight(136, 20.7142857142857, 1222);
                yield return new hyndsight(137, 20.8571428571429, 889);
                yield return new hyndsight(138, 21, 648);
                yield return new hyndsight(139, 21.1428571428571, 1023);
                yield return new hyndsight(140, 21.2857142857143, 1453);
                yield return new hyndsight(141, 21.4285714285714, 1260);
                yield return new hyndsight(142, 21.5714285714286, 1190);
                yield return new hyndsight(143, 21.7142857142857, 1207);
                yield return new hyndsight(144, 21.8571428571429, 706);
                yield return new hyndsight(145, 22, 929);
                yield return new hyndsight(146, 22.1428571428571, 1879);
                yield return new hyndsight(147, 22.2857142857143, 1579);
                yield return new hyndsight(148, 22.4285714285714, 1389);
                yield return new hyndsight(149, 22.5714285714286, 1352);
                yield return new hyndsight(150, 22.7142857142857, 1118);
                yield return new hyndsight(151, 22.8571428571429, 944);
                yield return new hyndsight(152, 23, 734);
                yield return new hyndsight(153, 23.1428571428571, 1048);
                yield return new hyndsight(154, 23.2857142857143, 1431);
                yield return new hyndsight(155, 23.4285714285714, 1296);
                yield return new hyndsight(156, 23.5714285714286, 1126);
                yield return new hyndsight(157, 23.7142857142857, 1158);
                yield return new hyndsight(158, 23.8571428571429, 872);
                yield return new hyndsight(159, 24, 756);
                yield return new hyndsight(160, 24.1428571428571, 1221);
                yield return new hyndsight(161, 24.2857142857143, 1620);
                yield return new hyndsight(162, 24.4285714285714, 1528);
                yield return new hyndsight(163, 24.5714285714286, 1486);
                yield return new hyndsight(164, 24.7142857142857, 1639);
                yield return new hyndsight(165, 24.8571428571429, 1114);
                yield return new hyndsight(166, 25, 874);
                yield return new hyndsight(167, 25.1428571428571, 1161);
                yield return new hyndsight(168, 25.2857142857143, 1557);
                yield return new hyndsight(169, 25.4285714285714, 1740);
                yield return new hyndsight(170, 25.5714285714286, 1598);
                yield return new hyndsight(171, 25.7142857142857, 1397);
                yield return new hyndsight(172, 25.8571428571429, 1153);
                yield return new hyndsight(173, 26, 797);
                yield return new hyndsight(174, 26.1428571428571, 1320);
                yield return new hyndsight(175, 26.2857142857143, 1747);
                yield return new hyndsight(176, 26.4285714285714, 1944);
                yield return new hyndsight(177, 26.5714285714286, 1664);
                yield return new hyndsight(178, 26.7142857142857, 1516);
                yield return new hyndsight(179, 26.8571428571429, 1077);
                yield return new hyndsight(180, 27, 777);
                yield return new hyndsight(181, 27.1428571428571, 1139);
                yield return new hyndsight(182, 27.2857142857143, 1671);
                yield return new hyndsight(183, 27.4285714285714, 1590);
                yield return new hyndsight(184, 27.5714285714286, 1491);
                yield return new hyndsight(185, 27.7142857142857, 1438);
                yield return new hyndsight(186, 27.8571428571429, 1060);
                yield return new hyndsight(187, 28, 789);
                yield return new hyndsight(188, 28.1428571428571, 1270);
                yield return new hyndsight(189, 28.2857142857143, 1384);
                yield return new hyndsight(190, 28.4285714285714, 1490);
                yield return new hyndsight(191, 28.5714285714286, 1554);
                yield return new hyndsight(192, 28.7142857142857, 1569);
                yield return new hyndsight(193, 28.8571428571429, 1422);
                yield return new hyndsight(194, 29, 888);
                yield return new hyndsight(195, 29.1428571428571, 1276);
                yield return new hyndsight(196, 29.2857142857143, 1650);
                yield return new hyndsight(197, 29.4285714285714, 1699);
                yield return new hyndsight(198, 29.5714285714286, 1464);
                yield return new hyndsight(199, 29.7142857142857, 1495);
                yield return new hyndsight(200, 29.8571428571429, 1030);
                yield return new hyndsight(201, 30, 812);
                yield return new hyndsight(202, 30.1428571428571, 1231);
                yield return new hyndsight(203, 30.2857142857143, 1465);
                yield return new hyndsight(204, 30.4285714285714, 1707);
                yield return new hyndsight(205, 30.5714285714286, 1678);
                yield return new hyndsight(206, 30.7142857142857, 1632);
                yield return new hyndsight(207, 30.8571428571429, 1678);
                yield return new hyndsight(208, 31, 958);
                yield return new hyndsight(209, 31.1428571428571, 1529);
                yield return new hyndsight(210, 31.2857142857143, 2368);
                yield return new hyndsight(211, 31.4285714285714, 1811);
                yield return new hyndsight(212, 31.5714285714286, 1558);
                yield return new hyndsight(213, 31.7142857142857, 1239);
                yield return new hyndsight(214, 31.8571428571429, 995);
                yield return new hyndsight(215, 32, 1009);
                yield return new hyndsight(216, 32.1428571428571, 1313);
                yield return new hyndsight(217, 32.2857142857143, 1544);
                yield return new hyndsight(218, 32.4285714285714, 2422);
                yield return new hyndsight(219, 32.5714285714286, 1621);
                yield return new hyndsight(220, 32.7142857142857, 1512);
                yield return new hyndsight(221, 32.8571428571429, 1278);
                yield return new hyndsight(222, 33, 955);
                yield return new hyndsight(223, 33.1428571428571, 1384);
                yield return new hyndsight(224, 33.2857142857143, 2569);
                yield return new hyndsight(225, 33.4285714285714, 2140);
                yield return new hyndsight(226, 33.5714285714286, 2235);
                yield return new hyndsight(227, 33.7142857142857, 1719);
                yield return new hyndsight(228, 33.8571428571429, 1143);
                yield return new hyndsight(229, 34, 955);
                yield return new hyndsight(230, 34.1428571428571, 1412);
                yield return new hyndsight(231, 34.2857142857143, 1965);
                yield return new hyndsight(232, 34.4285714285714, 1789);
                yield return new hyndsight(233, 34.5714285714286, 2198);
                yield return new hyndsight(234, 34.7142857142857, 1636);
                yield return new hyndsight(235, 34.8571428571429, 859);
                yield return new hyndsight(236, 35, 743);
                yield return new hyndsight(237, 35.1428571428571, 974);
                yield return new hyndsight(238, 35.2857142857143, 1609);
                yield return new hyndsight(239, 35.4285714285714, 1165);
                yield return new hyndsight(240, 35.5714285714286, 848);
                yield return new hyndsight(241, 35.7142857142857, 1030);
                yield return new hyndsight(242, 35.8571428571429, 1410);
                yield return new hyndsight(243, 36, 879);
                yield return new hyndsight(244, 36.1428571428571, 1259);
                yield return new hyndsight(245, 36.2857142857143, 1254);
                yield return new hyndsight(246, 36.4285714285714, 1026);
                yield return new hyndsight(247, 36.5714285714286, 768);
                yield return new hyndsight(248, 36.7142857142857, 736);
                yield return new hyndsight(249, 36.8571428571429, 863);
                yield return new hyndsight(250, 37, 759);
                yield return new hyndsight(251, 37.1428571428571, 1071);
                yield return new hyndsight(252, 37.2857142857143, 1455);
                yield return new hyndsight(253, 37.4285714285714, 1635);
                yield return new hyndsight(254, 37.5714285714286, 1537);
                yield return new hyndsight(255, 37.7142857142857, 1388);
                yield return new hyndsight(256, 37.8571428571429, 1144);
                yield return new hyndsight(257, 38, 728);
                yield return new hyndsight(258, 38.1428571428571, 1335);
                yield return new hyndsight(259, 38.2857142857143, 1730);
                yield return new hyndsight(260, 38.4285714285714, 1558);
                yield return new hyndsight(261, 38.5714285714286, 1571);
                yield return new hyndsight(262, 38.7142857142857, 1502);
                yield return new hyndsight(263, 38.8571428571429, 1203);
                yield return new hyndsight(264, 39, 807);
                yield return new hyndsight(265, 39.1428571428571, 1138);
                yield return new hyndsight(266, 39.2857142857143, 1648);
                yield return new hyndsight(267, 39.4285714285714, 1661);
                yield return new hyndsight(268, 39.5714285714286, 1743);
                yield return new hyndsight(269, 39.7142857142857, 1544);
                yield return new hyndsight(270, 39.8571428571429, 1439);
                yield return new hyndsight(271, 40, 1269);
                yield return new hyndsight(272, 40.1428571428571, 1262);
                yield return new hyndsight(273, 40.2857142857143, 1892);
                yield return new hyndsight(274, 40.4285714285714, 1687);
                yield return new hyndsight(275, 40.5714285714286, 1778);
                yield return new hyndsight(276, 40.7142857142857, 1485);
                yield return new hyndsight(277, 40.8571428571429, 1428);
                yield return new hyndsight(278, 41, 1010);
                yield return new hyndsight(279, 41.1428571428571, 1293);
                yield return new hyndsight(280, 41.2857142857143, 1941);
                yield return new hyndsight(281, 41.4285714285714, 1714);
                yield return new hyndsight(282, 41.5714285714286, 1676);
                yield return new hyndsight(283, 41.7142857142857, 1591);
                yield return new hyndsight(284, 41.8571428571429, 1077);
                yield return new hyndsight(285, 42, 809);
                yield return new hyndsight(286, 42.1428571428571, 1294);
                yield return new hyndsight(287, 42.2857142857143, 1715);
                yield return new hyndsight(288, 42.4285714285714, 1810);
                yield return new hyndsight(289, 42.5714285714286, 1890);
                yield return new hyndsight(290, 42.7142857142857, 1690);
                yield return new hyndsight(291, 42.8571428571429, 989);
                yield return new hyndsight(292, 43, 783);
                yield return new hyndsight(293, 43.1428571428571, 1271);
                yield return new hyndsight(294, 43.2857142857143, 1501);
                yield return new hyndsight(295, 43.4285714285714, 1613);
                yield return new hyndsight(296, 43.5714285714286, 1632);
                yield return new hyndsight(297, 43.7142857142857, 1486);
                yield return new hyndsight(298, 43.8571428571429, 1338);
                yield return new hyndsight(299, 44, 862);
                yield return new hyndsight(300, 44.1428571428571, 1529);
                yield return new hyndsight(301, 44.2857142857143, 1837);
                yield return new hyndsight(302, 44.4285714285714, 1948);
                yield return new hyndsight(303, 44.5714285714286, 1917);
                yield return new hyndsight(304, 44.7142857142857, 1765);
                yield return new hyndsight(305, 44.8571428571429, 1261);
                yield return new hyndsight(306, 45, 895);
                yield return new hyndsight(307, 45.1428571428571, 1219);
                yield return new hyndsight(308, 45.2857142857143, 1690);
                yield return new hyndsight(309, 45.4285714285714, 1660);
                yield return new hyndsight(310, 45.5714285714286, 1662);
                yield return new hyndsight(311, 45.7142857142857, 1616);
                yield return new hyndsight(312, 45.8571428571429, 1245);
                yield return new hyndsight(313, 46, 931);
                yield return new hyndsight(314, 46.1428571428571, 1259);
                yield return new hyndsight(315, 46.2857142857143, 1666);
                yield return new hyndsight(316, 46.4285714285714, 1782);
                yield return new hyndsight(317, 46.5714285714286, 2083);
                yield return new hyndsight(318, 46.7142857142857, 2287);
                yield return new hyndsight(319, 46.8571428571429, 1247);
                yield return new hyndsight(320, 47, 1120);
                yield return new hyndsight(321, 47.1428571428571, 1668);
                yield return new hyndsight(322, 47.2857142857143, 2006);
                yield return new hyndsight(323, 47.4285714285714, 2359);
                yield return new hyndsight(324, 47.5714285714286, 2649);
                yield return new hyndsight(325, 47.7142857142857, 2006);
                yield return new hyndsight(326, 47.8571428571429, 1364);
                yield return new hyndsight(327, 48, 966);
                yield return new hyndsight(328, 48.1428571428571, 1626);
                yield return new hyndsight(329, 48.2857142857143, 2001);
                yield return new hyndsight(330, 48.4285714285714, 1992);
                yield return new hyndsight(331, 48.5714285714286, 2279);
                yield return new hyndsight(332, 48.7142857142857, 1850);
                yield return new hyndsight(333, 48.8571428571429, 1250);
                yield return new hyndsight(334, 49, 968);
                yield return new hyndsight(335, 49.1428571428571, 1411);
                yield return new hyndsight(336, 49.2857142857143, 1833);
                yield return new hyndsight(337, 49.4285714285714, 1923);
                yield return new hyndsight(338, 49.5714285714286, 1910);
                yield return new hyndsight(339, 49.7142857142857, 1486);
                yield return new hyndsight(340, 49.8571428571429, 1044);
                yield return new hyndsight(341, 50, 927);
                yield return new hyndsight(342, 50.1428571428571, 1030);
                yield return new hyndsight(343, 50.2857142857143, 1965);
                yield return new hyndsight(344, 50.4285714285714, 1768);
                yield return new hyndsight(345, 50.5714285714286, 2082);
                yield return new hyndsight(346, 50.7142857142857, 2063);
                yield return new hyndsight(347, 50.8571428571429, 1424);
                yield return new hyndsight(348, 51, 1073);
                yield return new hyndsight(349, 51.1428571428571, 1664);
                yield return new hyndsight(350, 51.2857142857143, 1799);
                yield return new hyndsight(351, 51.4285714285714, 1947);
                yield return new hyndsight(352, 51.5714285714286, 1839);
                yield return new hyndsight(353, 51.7142857142857, 1885);
                yield return new hyndsight(354, 51.8571428571429, 1237);
                yield return new hyndsight(355, 52, 950);
                yield return new hyndsight(356, 52.1428571428571, 1636);
                yield return new hyndsight(357, 52.2857142857143, 1928);
                yield return new hyndsight(358, 52.4285714285714, 1898);
                yield return new hyndsight(359, 52.5714285714286, 2323);
                yield return new hyndsight(360, 52.7142857142857, 1979);
                yield return new hyndsight(361, 52.8571428571429, 1259);
                yield return new hyndsight(362, 53, 1158);
                yield return new hyndsight(363, 53.1428571428571, 1617);
                yield return new hyndsight(364, 53.2857142857143, 2144);
                yield return new hyndsight(365, 53.4285714285714, 2028);
            }
        }
    }
}
