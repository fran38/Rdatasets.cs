// ReSharper disable All

namespace Rdatasets.datasets
{
    using System.Collections.Generic;

    /// <summary>
    /// Weight versus age of chicks on different diets
    /// </summary>

    public class ChickWeight
    {
        public readonly int κ;
        public readonly int weight;
        public readonly int Time;
        public readonly int Chick;
        public readonly int Diet;

        public ChickWeight(int κ, int weight, int Time, int Chick, int Diet)
        {
            this.κ = κ;
            this.weight = weight;
            this.Time = Time;
            this.Chick = Chick;
            this.Diet = Diet;
        }

        public static IEnumerable<ChickWeight> Data
        {
            get
            {
                yield return new ChickWeight(1, 42, 0, 1, 1);
                yield return new ChickWeight(2, 51, 2, 1, 1);
                yield return new ChickWeight(3, 59, 4, 1, 1);
                yield return new ChickWeight(4, 64, 6, 1, 1);
                yield return new ChickWeight(5, 76, 8, 1, 1);
                yield return new ChickWeight(6, 93, 10, 1, 1);
                yield return new ChickWeight(7, 106, 12, 1, 1);
                yield return new ChickWeight(8, 125, 14, 1, 1);
                yield return new ChickWeight(9, 149, 16, 1, 1);
                yield return new ChickWeight(10, 171, 18, 1, 1);
                yield return new ChickWeight(11, 199, 20, 1, 1);
                yield return new ChickWeight(12, 205, 21, 1, 1);
                yield return new ChickWeight(13, 40, 0, 2, 1);
                yield return new ChickWeight(14, 49, 2, 2, 1);
                yield return new ChickWeight(15, 58, 4, 2, 1);
                yield return new ChickWeight(16, 72, 6, 2, 1);
                yield return new ChickWeight(17, 84, 8, 2, 1);
                yield return new ChickWeight(18, 103, 10, 2, 1);
                yield return new ChickWeight(19, 122, 12, 2, 1);
                yield return new ChickWeight(20, 138, 14, 2, 1);
                yield return new ChickWeight(21, 162, 16, 2, 1);
                yield return new ChickWeight(22, 187, 18, 2, 1);
                yield return new ChickWeight(23, 209, 20, 2, 1);
                yield return new ChickWeight(24, 215, 21, 2, 1);
                yield return new ChickWeight(25, 43, 0, 3, 1);
                yield return new ChickWeight(26, 39, 2, 3, 1);
                yield return new ChickWeight(27, 55, 4, 3, 1);
                yield return new ChickWeight(28, 67, 6, 3, 1);
                yield return new ChickWeight(29, 84, 8, 3, 1);
                yield return new ChickWeight(30, 99, 10, 3, 1);
                yield return new ChickWeight(31, 115, 12, 3, 1);
                yield return new ChickWeight(32, 138, 14, 3, 1);
                yield return new ChickWeight(33, 163, 16, 3, 1);
                yield return new ChickWeight(34, 187, 18, 3, 1);
                yield return new ChickWeight(35, 198, 20, 3, 1);
                yield return new ChickWeight(36, 202, 21, 3, 1);
                yield return new ChickWeight(37, 42, 0, 4, 1);
                yield return new ChickWeight(38, 49, 2, 4, 1);
                yield return new ChickWeight(39, 56, 4, 4, 1);
                yield return new ChickWeight(40, 67, 6, 4, 1);
                yield return new ChickWeight(41, 74, 8, 4, 1);
                yield return new ChickWeight(42, 87, 10, 4, 1);
                yield return new ChickWeight(43, 102, 12, 4, 1);
                yield return new ChickWeight(44, 108, 14, 4, 1);
                yield return new ChickWeight(45, 136, 16, 4, 1);
                yield return new ChickWeight(46, 154, 18, 4, 1);
                yield return new ChickWeight(47, 160, 20, 4, 1);
                yield return new ChickWeight(48, 157, 21, 4, 1);
                yield return new ChickWeight(49, 41, 0, 5, 1);
                yield return new ChickWeight(50, 42, 2, 5, 1);
                yield return new ChickWeight(51, 48, 4, 5, 1);
                yield return new ChickWeight(52, 60, 6, 5, 1);
                yield return new ChickWeight(53, 79, 8, 5, 1);
                yield return new ChickWeight(54, 106, 10, 5, 1);
                yield return new ChickWeight(55, 141, 12, 5, 1);
                yield return new ChickWeight(56, 164, 14, 5, 1);
                yield return new ChickWeight(57, 197, 16, 5, 1);
                yield return new ChickWeight(58, 199, 18, 5, 1);
                yield return new ChickWeight(59, 220, 20, 5, 1);
                yield return new ChickWeight(60, 223, 21, 5, 1);
                yield return new ChickWeight(61, 41, 0, 6, 1);
                yield return new ChickWeight(62, 49, 2, 6, 1);
                yield return new ChickWeight(63, 59, 4, 6, 1);
                yield return new ChickWeight(64, 74, 6, 6, 1);
                yield return new ChickWeight(65, 97, 8, 6, 1);
                yield return new ChickWeight(66, 124, 10, 6, 1);
                yield return new ChickWeight(67, 141, 12, 6, 1);
                yield return new ChickWeight(68, 148, 14, 6, 1);
                yield return new ChickWeight(69, 155, 16, 6, 1);
                yield return new ChickWeight(70, 160, 18, 6, 1);
                yield return new ChickWeight(71, 160, 20, 6, 1);
                yield return new ChickWeight(72, 157, 21, 6, 1);
                yield return new ChickWeight(73, 41, 0, 7, 1);
                yield return new ChickWeight(74, 49, 2, 7, 1);
                yield return new ChickWeight(75, 57, 4, 7, 1);
                yield return new ChickWeight(76, 71, 6, 7, 1);
                yield return new ChickWeight(77, 89, 8, 7, 1);
                yield return new ChickWeight(78, 112, 10, 7, 1);
                yield return new ChickWeight(79, 146, 12, 7, 1);
                yield return new ChickWeight(80, 174, 14, 7, 1);
                yield return new ChickWeight(81, 218, 16, 7, 1);
                yield return new ChickWeight(82, 250, 18, 7, 1);
                yield return new ChickWeight(83, 288, 20, 7, 1);
                yield return new ChickWeight(84, 305, 21, 7, 1);
                yield return new ChickWeight(85, 42, 0, 8, 1);
                yield return new ChickWeight(86, 50, 2, 8, 1);
                yield return new ChickWeight(87, 61, 4, 8, 1);
                yield return new ChickWeight(88, 71, 6, 8, 1);
                yield return new ChickWeight(89, 84, 8, 8, 1);
                yield return new ChickWeight(90, 93, 10, 8, 1);
                yield return new ChickWeight(91, 110, 12, 8, 1);
                yield return new ChickWeight(92, 116, 14, 8, 1);
                yield return new ChickWeight(93, 126, 16, 8, 1);
                yield return new ChickWeight(94, 134, 18, 8, 1);
                yield return new ChickWeight(95, 125, 20, 8, 1);
                yield return new ChickWeight(96, 42, 0, 9, 1);
                yield return new ChickWeight(97, 51, 2, 9, 1);
                yield return new ChickWeight(98, 59, 4, 9, 1);
                yield return new ChickWeight(99, 68, 6, 9, 1);
                yield return new ChickWeight(100, 85, 8, 9, 1);
                yield return new ChickWeight(101, 96, 10, 9, 1);
                yield return new ChickWeight(102, 90, 12, 9, 1);
                yield return new ChickWeight(103, 92, 14, 9, 1);
                yield return new ChickWeight(104, 93, 16, 9, 1);
                yield return new ChickWeight(105, 100, 18, 9, 1);
                yield return new ChickWeight(106, 100, 20, 9, 1);
                yield return new ChickWeight(107, 98, 21, 9, 1);
                yield return new ChickWeight(108, 41, 0, 10, 1);
                yield return new ChickWeight(109, 44, 2, 10, 1);
                yield return new ChickWeight(110, 52, 4, 10, 1);
                yield return new ChickWeight(111, 63, 6, 10, 1);
                yield return new ChickWeight(112, 74, 8, 10, 1);
                yield return new ChickWeight(113, 81, 10, 10, 1);
                yield return new ChickWeight(114, 89, 12, 10, 1);
                yield return new ChickWeight(115, 96, 14, 10, 1);
                yield return new ChickWeight(116, 101, 16, 10, 1);
                yield return new ChickWeight(117, 112, 18, 10, 1);
                yield return new ChickWeight(118, 120, 20, 10, 1);
                yield return new ChickWeight(119, 124, 21, 10, 1);
                yield return new ChickWeight(120, 43, 0, 11, 1);
                yield return new ChickWeight(121, 51, 2, 11, 1);
                yield return new ChickWeight(122, 63, 4, 11, 1);
                yield return new ChickWeight(123, 84, 6, 11, 1);
                yield return new ChickWeight(124, 112, 8, 11, 1);
                yield return new ChickWeight(125, 139, 10, 11, 1);
                yield return new ChickWeight(126, 168, 12, 11, 1);
                yield return new ChickWeight(127, 177, 14, 11, 1);
                yield return new ChickWeight(128, 182, 16, 11, 1);
                yield return new ChickWeight(129, 184, 18, 11, 1);
                yield return new ChickWeight(130, 181, 20, 11, 1);
                yield return new ChickWeight(131, 175, 21, 11, 1);
                yield return new ChickWeight(132, 41, 0, 12, 1);
                yield return new ChickWeight(133, 49, 2, 12, 1);
                yield return new ChickWeight(134, 56, 4, 12, 1);
                yield return new ChickWeight(135, 62, 6, 12, 1);
                yield return new ChickWeight(136, 72, 8, 12, 1);
                yield return new ChickWeight(137, 88, 10, 12, 1);
                yield return new ChickWeight(138, 119, 12, 12, 1);
                yield return new ChickWeight(139, 135, 14, 12, 1);
                yield return new ChickWeight(140, 162, 16, 12, 1);
                yield return new ChickWeight(141, 185, 18, 12, 1);
                yield return new ChickWeight(142, 195, 20, 12, 1);
                yield return new ChickWeight(143, 205, 21, 12, 1);
                yield return new ChickWeight(144, 41, 0, 13, 1);
                yield return new ChickWeight(145, 48, 2, 13, 1);
                yield return new ChickWeight(146, 53, 4, 13, 1);
                yield return new ChickWeight(147, 60, 6, 13, 1);
                yield return new ChickWeight(148, 65, 8, 13, 1);
                yield return new ChickWeight(149, 67, 10, 13, 1);
                yield return new ChickWeight(150, 71, 12, 13, 1);
                yield return new ChickWeight(151, 70, 14, 13, 1);
                yield return new ChickWeight(152, 71, 16, 13, 1);
                yield return new ChickWeight(153, 81, 18, 13, 1);
                yield return new ChickWeight(154, 91, 20, 13, 1);
                yield return new ChickWeight(155, 96, 21, 13, 1);
                yield return new ChickWeight(156, 41, 0, 14, 1);
                yield return new ChickWeight(157, 49, 2, 14, 1);
                yield return new ChickWeight(158, 62, 4, 14, 1);
                yield return new ChickWeight(159, 79, 6, 14, 1);
                yield return new ChickWeight(160, 101, 8, 14, 1);
                yield return new ChickWeight(161, 128, 10, 14, 1);
                yield return new ChickWeight(162, 164, 12, 14, 1);
                yield return new ChickWeight(163, 192, 14, 14, 1);
                yield return new ChickWeight(164, 227, 16, 14, 1);
                yield return new ChickWeight(165, 248, 18, 14, 1);
                yield return new ChickWeight(166, 259, 20, 14, 1);
                yield return new ChickWeight(167, 266, 21, 14, 1);
                yield return new ChickWeight(168, 41, 0, 15, 1);
                yield return new ChickWeight(169, 49, 2, 15, 1);
                yield return new ChickWeight(170, 56, 4, 15, 1);
                yield return new ChickWeight(171, 64, 6, 15, 1);
                yield return new ChickWeight(172, 68, 8, 15, 1);
                yield return new ChickWeight(173, 68, 10, 15, 1);
                yield return new ChickWeight(174, 67, 12, 15, 1);
                yield return new ChickWeight(175, 68, 14, 15, 1);
                yield return new ChickWeight(176, 41, 0, 16, 1);
                yield return new ChickWeight(177, 45, 2, 16, 1);
                yield return new ChickWeight(178, 49, 4, 16, 1);
                yield return new ChickWeight(179, 51, 6, 16, 1);
                yield return new ChickWeight(180, 57, 8, 16, 1);
                yield return new ChickWeight(181, 51, 10, 16, 1);
                yield return new ChickWeight(182, 54, 12, 16, 1);
                yield return new ChickWeight(183, 42, 0, 17, 1);
                yield return new ChickWeight(184, 51, 2, 17, 1);
                yield return new ChickWeight(185, 61, 4, 17, 1);
                yield return new ChickWeight(186, 72, 6, 17, 1);
                yield return new ChickWeight(187, 83, 8, 17, 1);
                yield return new ChickWeight(188, 89, 10, 17, 1);
                yield return new ChickWeight(189, 98, 12, 17, 1);
                yield return new ChickWeight(190, 103, 14, 17, 1);
                yield return new ChickWeight(191, 113, 16, 17, 1);
                yield return new ChickWeight(192, 123, 18, 17, 1);
                yield return new ChickWeight(193, 133, 20, 17, 1);
                yield return new ChickWeight(194, 142, 21, 17, 1);
                yield return new ChickWeight(195, 39, 0, 18, 1);
                yield return new ChickWeight(196, 35, 2, 18, 1);
                yield return new ChickWeight(197, 43, 0, 19, 1);
                yield return new ChickWeight(198, 48, 2, 19, 1);
                yield return new ChickWeight(199, 55, 4, 19, 1);
                yield return new ChickWeight(200, 62, 6, 19, 1);
                yield return new ChickWeight(201, 65, 8, 19, 1);
                yield return new ChickWeight(202, 71, 10, 19, 1);
                yield return new ChickWeight(203, 82, 12, 19, 1);
                yield return new ChickWeight(204, 88, 14, 19, 1);
                yield return new ChickWeight(205, 106, 16, 19, 1);
                yield return new ChickWeight(206, 120, 18, 19, 1);
                yield return new ChickWeight(207, 144, 20, 19, 1);
                yield return new ChickWeight(208, 157, 21, 19, 1);
                yield return new ChickWeight(209, 41, 0, 20, 1);
                yield return new ChickWeight(210, 47, 2, 20, 1);
                yield return new ChickWeight(211, 54, 4, 20, 1);
                yield return new ChickWeight(212, 58, 6, 20, 1);
                yield return new ChickWeight(213, 65, 8, 20, 1);
                yield return new ChickWeight(214, 73, 10, 20, 1);
                yield return new ChickWeight(215, 77, 12, 20, 1);
                yield return new ChickWeight(216, 89, 14, 20, 1);
                yield return new ChickWeight(217, 98, 16, 20, 1);
                yield return new ChickWeight(218, 107, 18, 20, 1);
                yield return new ChickWeight(219, 115, 20, 20, 1);
                yield return new ChickWeight(220, 117, 21, 20, 1);
                yield return new ChickWeight(221, 40, 0, 21, 2);
                yield return new ChickWeight(222, 50, 2, 21, 2);
                yield return new ChickWeight(223, 62, 4, 21, 2);
                yield return new ChickWeight(224, 86, 6, 21, 2);
                yield return new ChickWeight(225, 125, 8, 21, 2);
                yield return new ChickWeight(226, 163, 10, 21, 2);
                yield return new ChickWeight(227, 217, 12, 21, 2);
                yield return new ChickWeight(228, 240, 14, 21, 2);
                yield return new ChickWeight(229, 275, 16, 21, 2);
                yield return new ChickWeight(230, 307, 18, 21, 2);
                yield return new ChickWeight(231, 318, 20, 21, 2);
                yield return new ChickWeight(232, 331, 21, 21, 2);
                yield return new ChickWeight(233, 41, 0, 22, 2);
                yield return new ChickWeight(234, 55, 2, 22, 2);
                yield return new ChickWeight(235, 64, 4, 22, 2);
                yield return new ChickWeight(236, 77, 6, 22, 2);
                yield return new ChickWeight(237, 90, 8, 22, 2);
                yield return new ChickWeight(238, 95, 10, 22, 2);
                yield return new ChickWeight(239, 108, 12, 22, 2);
                yield return new ChickWeight(240, 111, 14, 22, 2);
                yield return new ChickWeight(241, 131, 16, 22, 2);
                yield return new ChickWeight(242, 148, 18, 22, 2);
                yield return new ChickWeight(243, 164, 20, 22, 2);
                yield return new ChickWeight(244, 167, 21, 22, 2);
                yield return new ChickWeight(245, 43, 0, 23, 2);
                yield return new ChickWeight(246, 52, 2, 23, 2);
                yield return new ChickWeight(247, 61, 4, 23, 2);
                yield return new ChickWeight(248, 73, 6, 23, 2);
                yield return new ChickWeight(249, 90, 8, 23, 2);
                yield return new ChickWeight(250, 103, 10, 23, 2);
                yield return new ChickWeight(251, 127, 12, 23, 2);
                yield return new ChickWeight(252, 135, 14, 23, 2);
                yield return new ChickWeight(253, 145, 16, 23, 2);
                yield return new ChickWeight(254, 163, 18, 23, 2);
                yield return new ChickWeight(255, 170, 20, 23, 2);
                yield return new ChickWeight(256, 175, 21, 23, 2);
                yield return new ChickWeight(257, 42, 0, 24, 2);
                yield return new ChickWeight(258, 52, 2, 24, 2);
                yield return new ChickWeight(259, 58, 4, 24, 2);
                yield return new ChickWeight(260, 74, 6, 24, 2);
                yield return new ChickWeight(261, 66, 8, 24, 2);
                yield return new ChickWeight(262, 68, 10, 24, 2);
                yield return new ChickWeight(263, 70, 12, 24, 2);
                yield return new ChickWeight(264, 71, 14, 24, 2);
                yield return new ChickWeight(265, 72, 16, 24, 2);
                yield return new ChickWeight(266, 72, 18, 24, 2);
                yield return new ChickWeight(267, 76, 20, 24, 2);
                yield return new ChickWeight(268, 74, 21, 24, 2);
                yield return new ChickWeight(269, 40, 0, 25, 2);
                yield return new ChickWeight(270, 49, 2, 25, 2);
                yield return new ChickWeight(271, 62, 4, 25, 2);
                yield return new ChickWeight(272, 78, 6, 25, 2);
                yield return new ChickWeight(273, 102, 8, 25, 2);
                yield return new ChickWeight(274, 124, 10, 25, 2);
                yield return new ChickWeight(275, 146, 12, 25, 2);
                yield return new ChickWeight(276, 164, 14, 25, 2);
                yield return new ChickWeight(277, 197, 16, 25, 2);
                yield return new ChickWeight(278, 231, 18, 25, 2);
                yield return new ChickWeight(279, 259, 20, 25, 2);
                yield return new ChickWeight(280, 265, 21, 25, 2);
                yield return new ChickWeight(281, 42, 0, 26, 2);
                yield return new ChickWeight(282, 48, 2, 26, 2);
                yield return new ChickWeight(283, 57, 4, 26, 2);
                yield return new ChickWeight(284, 74, 6, 26, 2);
                yield return new ChickWeight(285, 93, 8, 26, 2);
                yield return new ChickWeight(286, 114, 10, 26, 2);
                yield return new ChickWeight(287, 136, 12, 26, 2);
                yield return new ChickWeight(288, 147, 14, 26, 2);
                yield return new ChickWeight(289, 169, 16, 26, 2);
                yield return new ChickWeight(290, 205, 18, 26, 2);
                yield return new ChickWeight(291, 236, 20, 26, 2);
                yield return new ChickWeight(292, 251, 21, 26, 2);
                yield return new ChickWeight(293, 39, 0, 27, 2);
                yield return new ChickWeight(294, 46, 2, 27, 2);
                yield return new ChickWeight(295, 58, 4, 27, 2);
                yield return new ChickWeight(296, 73, 6, 27, 2);
                yield return new ChickWeight(297, 87, 8, 27, 2);
                yield return new ChickWeight(298, 100, 10, 27, 2);
                yield return new ChickWeight(299, 115, 12, 27, 2);
                yield return new ChickWeight(300, 123, 14, 27, 2);
                yield return new ChickWeight(301, 144, 16, 27, 2);
                yield return new ChickWeight(302, 163, 18, 27, 2);
                yield return new ChickWeight(303, 185, 20, 27, 2);
                yield return new ChickWeight(304, 192, 21, 27, 2);
                yield return new ChickWeight(305, 39, 0, 28, 2);
                yield return new ChickWeight(306, 46, 2, 28, 2);
                yield return new ChickWeight(307, 58, 4, 28, 2);
                yield return new ChickWeight(308, 73, 6, 28, 2);
                yield return new ChickWeight(309, 92, 8, 28, 2);
                yield return new ChickWeight(310, 114, 10, 28, 2);
                yield return new ChickWeight(311, 145, 12, 28, 2);
                yield return new ChickWeight(312, 156, 14, 28, 2);
                yield return new ChickWeight(313, 184, 16, 28, 2);
                yield return new ChickWeight(314, 207, 18, 28, 2);
                yield return new ChickWeight(315, 212, 20, 28, 2);
                yield return new ChickWeight(316, 233, 21, 28, 2);
                yield return new ChickWeight(317, 39, 0, 29, 2);
                yield return new ChickWeight(318, 48, 2, 29, 2);
                yield return new ChickWeight(319, 59, 4, 29, 2);
                yield return new ChickWeight(320, 74, 6, 29, 2);
                yield return new ChickWeight(321, 87, 8, 29, 2);
                yield return new ChickWeight(322, 106, 10, 29, 2);
                yield return new ChickWeight(323, 134, 12, 29, 2);
                yield return new ChickWeight(324, 150, 14, 29, 2);
                yield return new ChickWeight(325, 187, 16, 29, 2);
                yield return new ChickWeight(326, 230, 18, 29, 2);
                yield return new ChickWeight(327, 279, 20, 29, 2);
                yield return new ChickWeight(328, 309, 21, 29, 2);
                yield return new ChickWeight(329, 42, 0, 30, 2);
                yield return new ChickWeight(330, 48, 2, 30, 2);
                yield return new ChickWeight(331, 59, 4, 30, 2);
                yield return new ChickWeight(332, 72, 6, 30, 2);
                yield return new ChickWeight(333, 85, 8, 30, 2);
                yield return new ChickWeight(334, 98, 10, 30, 2);
                yield return new ChickWeight(335, 115, 12, 30, 2);
                yield return new ChickWeight(336, 122, 14, 30, 2);
                yield return new ChickWeight(337, 143, 16, 30, 2);
                yield return new ChickWeight(338, 151, 18, 30, 2);
                yield return new ChickWeight(339, 157, 20, 30, 2);
                yield return new ChickWeight(340, 150, 21, 30, 2);
                yield return new ChickWeight(341, 42, 0, 31, 3);
                yield return new ChickWeight(342, 53, 2, 31, 3);
                yield return new ChickWeight(343, 62, 4, 31, 3);
                yield return new ChickWeight(344, 73, 6, 31, 3);
                yield return new ChickWeight(345, 85, 8, 31, 3);
                yield return new ChickWeight(346, 102, 10, 31, 3);
                yield return new ChickWeight(347, 123, 12, 31, 3);
                yield return new ChickWeight(348, 138, 14, 31, 3);
                yield return new ChickWeight(349, 170, 16, 31, 3);
                yield return new ChickWeight(350, 204, 18, 31, 3);
                yield return new ChickWeight(351, 235, 20, 31, 3);
                yield return new ChickWeight(352, 256, 21, 31, 3);
                yield return new ChickWeight(353, 41, 0, 32, 3);
                yield return new ChickWeight(354, 49, 2, 32, 3);
                yield return new ChickWeight(355, 65, 4, 32, 3);
                yield return new ChickWeight(356, 82, 6, 32, 3);
                yield return new ChickWeight(357, 107, 8, 32, 3);
                yield return new ChickWeight(358, 129, 10, 32, 3);
                yield return new ChickWeight(359, 159, 12, 32, 3);
                yield return new ChickWeight(360, 179, 14, 32, 3);
                yield return new ChickWeight(361, 221, 16, 32, 3);
                yield return new ChickWeight(362, 263, 18, 32, 3);
                yield return new ChickWeight(363, 291, 20, 32, 3);
                yield return new ChickWeight(364, 305, 21, 32, 3);
                yield return new ChickWeight(365, 39, 0, 33, 3);
                yield return new ChickWeight(366, 50, 2, 33, 3);
                yield return new ChickWeight(367, 63, 4, 33, 3);
                yield return new ChickWeight(368, 77, 6, 33, 3);
                yield return new ChickWeight(369, 96, 8, 33, 3);
                yield return new ChickWeight(370, 111, 10, 33, 3);
                yield return new ChickWeight(371, 137, 12, 33, 3);
                yield return new ChickWeight(372, 144, 14, 33, 3);
                yield return new ChickWeight(373, 151, 16, 33, 3);
                yield return new ChickWeight(374, 146, 18, 33, 3);
                yield return new ChickWeight(375, 156, 20, 33, 3);
                yield return new ChickWeight(376, 147, 21, 33, 3);
                yield return new ChickWeight(377, 41, 0, 34, 3);
                yield return new ChickWeight(378, 49, 2, 34, 3);
                yield return new ChickWeight(379, 63, 4, 34, 3);
                yield return new ChickWeight(380, 85, 6, 34, 3);
                yield return new ChickWeight(381, 107, 8, 34, 3);
                yield return new ChickWeight(382, 134, 10, 34, 3);
                yield return new ChickWeight(383, 164, 12, 34, 3);
                yield return new ChickWeight(384, 186, 14, 34, 3);
                yield return new ChickWeight(385, 235, 16, 34, 3);
                yield return new ChickWeight(386, 294, 18, 34, 3);
                yield return new ChickWeight(387, 327, 20, 34, 3);
                yield return new ChickWeight(388, 341, 21, 34, 3);
                yield return new ChickWeight(389, 41, 0, 35, 3);
                yield return new ChickWeight(390, 53, 2, 35, 3);
                yield return new ChickWeight(391, 64, 4, 35, 3);
                yield return new ChickWeight(392, 87, 6, 35, 3);
                yield return new ChickWeight(393, 123, 8, 35, 3);
                yield return new ChickWeight(394, 158, 10, 35, 3);
                yield return new ChickWeight(395, 201, 12, 35, 3);
                yield return new ChickWeight(396, 238, 14, 35, 3);
                yield return new ChickWeight(397, 287, 16, 35, 3);
                yield return new ChickWeight(398, 332, 18, 35, 3);
                yield return new ChickWeight(399, 361, 20, 35, 3);
                yield return new ChickWeight(400, 373, 21, 35, 3);
                yield return new ChickWeight(401, 39, 0, 36, 3);
                yield return new ChickWeight(402, 48, 2, 36, 3);
                yield return new ChickWeight(403, 61, 4, 36, 3);
                yield return new ChickWeight(404, 76, 6, 36, 3);
                yield return new ChickWeight(405, 98, 8, 36, 3);
                yield return new ChickWeight(406, 116, 10, 36, 3);
                yield return new ChickWeight(407, 145, 12, 36, 3);
                yield return new ChickWeight(408, 166, 14, 36, 3);
                yield return new ChickWeight(409, 198, 16, 36, 3);
                yield return new ChickWeight(410, 227, 18, 36, 3);
                yield return new ChickWeight(411, 225, 20, 36, 3);
                yield return new ChickWeight(412, 220, 21, 36, 3);
                yield return new ChickWeight(413, 41, 0, 37, 3);
                yield return new ChickWeight(414, 48, 2, 37, 3);
                yield return new ChickWeight(415, 56, 4, 37, 3);
                yield return new ChickWeight(416, 68, 6, 37, 3);
                yield return new ChickWeight(417, 80, 8, 37, 3);
                yield return new ChickWeight(418, 83, 10, 37, 3);
                yield return new ChickWeight(419, 103, 12, 37, 3);
                yield return new ChickWeight(420, 112, 14, 37, 3);
                yield return new ChickWeight(421, 135, 16, 37, 3);
                yield return new ChickWeight(422, 157, 18, 37, 3);
                yield return new ChickWeight(423, 169, 20, 37, 3);
                yield return new ChickWeight(424, 178, 21, 37, 3);
                yield return new ChickWeight(425, 41, 0, 38, 3);
                yield return new ChickWeight(426, 49, 2, 38, 3);
                yield return new ChickWeight(427, 61, 4, 38, 3);
                yield return new ChickWeight(428, 74, 6, 38, 3);
                yield return new ChickWeight(429, 98, 8, 38, 3);
                yield return new ChickWeight(430, 109, 10, 38, 3);
                yield return new ChickWeight(431, 128, 12, 38, 3);
                yield return new ChickWeight(432, 154, 14, 38, 3);
                yield return new ChickWeight(433, 192, 16, 38, 3);
                yield return new ChickWeight(434, 232, 18, 38, 3);
                yield return new ChickWeight(435, 280, 20, 38, 3);
                yield return new ChickWeight(436, 290, 21, 38, 3);
                yield return new ChickWeight(437, 42, 0, 39, 3);
                yield return new ChickWeight(438, 50, 2, 39, 3);
                yield return new ChickWeight(439, 61, 4, 39, 3);
                yield return new ChickWeight(440, 78, 6, 39, 3);
                yield return new ChickWeight(441, 89, 8, 39, 3);
                yield return new ChickWeight(442, 109, 10, 39, 3);
                yield return new ChickWeight(443, 130, 12, 39, 3);
                yield return new ChickWeight(444, 146, 14, 39, 3);
                yield return new ChickWeight(445, 170, 16, 39, 3);
                yield return new ChickWeight(446, 214, 18, 39, 3);
                yield return new ChickWeight(447, 250, 20, 39, 3);
                yield return new ChickWeight(448, 272, 21, 39, 3);
                yield return new ChickWeight(449, 41, 0, 40, 3);
                yield return new ChickWeight(450, 55, 2, 40, 3);
                yield return new ChickWeight(451, 66, 4, 40, 3);
                yield return new ChickWeight(452, 79, 6, 40, 3);
                yield return new ChickWeight(453, 101, 8, 40, 3);
                yield return new ChickWeight(454, 120, 10, 40, 3);
                yield return new ChickWeight(455, 154, 12, 40, 3);
                yield return new ChickWeight(456, 182, 14, 40, 3);
                yield return new ChickWeight(457, 215, 16, 40, 3);
                yield return new ChickWeight(458, 262, 18, 40, 3);
                yield return new ChickWeight(459, 295, 20, 40, 3);
                yield return new ChickWeight(460, 321, 21, 40, 3);
                yield return new ChickWeight(461, 42, 0, 41, 4);
                yield return new ChickWeight(462, 51, 2, 41, 4);
                yield return new ChickWeight(463, 66, 4, 41, 4);
                yield return new ChickWeight(464, 85, 6, 41, 4);
                yield return new ChickWeight(465, 103, 8, 41, 4);
                yield return new ChickWeight(466, 124, 10, 41, 4);
                yield return new ChickWeight(467, 155, 12, 41, 4);
                yield return new ChickWeight(468, 153, 14, 41, 4);
                yield return new ChickWeight(469, 175, 16, 41, 4);
                yield return new ChickWeight(470, 184, 18, 41, 4);
                yield return new ChickWeight(471, 199, 20, 41, 4);
                yield return new ChickWeight(472, 204, 21, 41, 4);
                yield return new ChickWeight(473, 42, 0, 42, 4);
                yield return new ChickWeight(474, 49, 2, 42, 4);
                yield return new ChickWeight(475, 63, 4, 42, 4);
                yield return new ChickWeight(476, 84, 6, 42, 4);
                yield return new ChickWeight(477, 103, 8, 42, 4);
                yield return new ChickWeight(478, 126, 10, 42, 4);
                yield return new ChickWeight(479, 160, 12, 42, 4);
                yield return new ChickWeight(480, 174, 14, 42, 4);
                yield return new ChickWeight(481, 204, 16, 42, 4);
                yield return new ChickWeight(482, 234, 18, 42, 4);
                yield return new ChickWeight(483, 269, 20, 42, 4);
                yield return new ChickWeight(484, 281, 21, 42, 4);
                yield return new ChickWeight(485, 42, 0, 43, 4);
                yield return new ChickWeight(486, 55, 2, 43, 4);
                yield return new ChickWeight(487, 69, 4, 43, 4);
                yield return new ChickWeight(488, 96, 6, 43, 4);
                yield return new ChickWeight(489, 131, 8, 43, 4);
                yield return new ChickWeight(490, 157, 10, 43, 4);
                yield return new ChickWeight(491, 184, 12, 43, 4);
                yield return new ChickWeight(492, 188, 14, 43, 4);
                yield return new ChickWeight(493, 197, 16, 43, 4);
                yield return new ChickWeight(494, 198, 18, 43, 4);
                yield return new ChickWeight(495, 199, 20, 43, 4);
                yield return new ChickWeight(496, 200, 21, 43, 4);
                yield return new ChickWeight(497, 42, 0, 44, 4);
                yield return new ChickWeight(498, 51, 2, 44, 4);
                yield return new ChickWeight(499, 65, 4, 44, 4);
                yield return new ChickWeight(500, 86, 6, 44, 4);
                yield return new ChickWeight(501, 103, 8, 44, 4);
                yield return new ChickWeight(502, 118, 10, 44, 4);
                yield return new ChickWeight(503, 127, 12, 44, 4);
                yield return new ChickWeight(504, 138, 14, 44, 4);
                yield return new ChickWeight(505, 145, 16, 44, 4);
                yield return new ChickWeight(506, 146, 18, 44, 4);
                yield return new ChickWeight(507, 41, 0, 45, 4);
                yield return new ChickWeight(508, 50, 2, 45, 4);
                yield return new ChickWeight(509, 61, 4, 45, 4);
                yield return new ChickWeight(510, 78, 6, 45, 4);
                yield return new ChickWeight(511, 98, 8, 45, 4);
                yield return new ChickWeight(512, 117, 10, 45, 4);
                yield return new ChickWeight(513, 135, 12, 45, 4);
                yield return new ChickWeight(514, 141, 14, 45, 4);
                yield return new ChickWeight(515, 147, 16, 45, 4);
                yield return new ChickWeight(516, 174, 18, 45, 4);
                yield return new ChickWeight(517, 197, 20, 45, 4);
                yield return new ChickWeight(518, 196, 21, 45, 4);
                yield return new ChickWeight(519, 40, 0, 46, 4);
                yield return new ChickWeight(520, 52, 2, 46, 4);
                yield return new ChickWeight(521, 62, 4, 46, 4);
                yield return new ChickWeight(522, 82, 6, 46, 4);
                yield return new ChickWeight(523, 101, 8, 46, 4);
                yield return new ChickWeight(524, 120, 10, 46, 4);
                yield return new ChickWeight(525, 144, 12, 46, 4);
                yield return new ChickWeight(526, 156, 14, 46, 4);
                yield return new ChickWeight(527, 173, 16, 46, 4);
                yield return new ChickWeight(528, 210, 18, 46, 4);
                yield return new ChickWeight(529, 231, 20, 46, 4);
                yield return new ChickWeight(530, 238, 21, 46, 4);
                yield return new ChickWeight(531, 41, 0, 47, 4);
                yield return new ChickWeight(532, 53, 2, 47, 4);
                yield return new ChickWeight(533, 66, 4, 47, 4);
                yield return new ChickWeight(534, 79, 6, 47, 4);
                yield return new ChickWeight(535, 100, 8, 47, 4);
                yield return new ChickWeight(536, 123, 10, 47, 4);
                yield return new ChickWeight(537, 148, 12, 47, 4);
                yield return new ChickWeight(538, 157, 14, 47, 4);
                yield return new ChickWeight(539, 168, 16, 47, 4);
                yield return new ChickWeight(540, 185, 18, 47, 4);
                yield return new ChickWeight(541, 210, 20, 47, 4);
                yield return new ChickWeight(542, 205, 21, 47, 4);
                yield return new ChickWeight(543, 39, 0, 48, 4);
                yield return new ChickWeight(544, 50, 2, 48, 4);
                yield return new ChickWeight(545, 62, 4, 48, 4);
                yield return new ChickWeight(546, 80, 6, 48, 4);
                yield return new ChickWeight(547, 104, 8, 48, 4);
                yield return new ChickWeight(548, 125, 10, 48, 4);
                yield return new ChickWeight(549, 154, 12, 48, 4);
                yield return new ChickWeight(550, 170, 14, 48, 4);
                yield return new ChickWeight(551, 222, 16, 48, 4);
                yield return new ChickWeight(552, 261, 18, 48, 4);
                yield return new ChickWeight(553, 303, 20, 48, 4);
                yield return new ChickWeight(554, 322, 21, 48, 4);
                yield return new ChickWeight(555, 40, 0, 49, 4);
                yield return new ChickWeight(556, 53, 2, 49, 4);
                yield return new ChickWeight(557, 64, 4, 49, 4);
                yield return new ChickWeight(558, 85, 6, 49, 4);
                yield return new ChickWeight(559, 108, 8, 49, 4);
                yield return new ChickWeight(560, 128, 10, 49, 4);
                yield return new ChickWeight(561, 152, 12, 49, 4);
                yield return new ChickWeight(562, 166, 14, 49, 4);
                yield return new ChickWeight(563, 184, 16, 49, 4);
                yield return new ChickWeight(564, 203, 18, 49, 4);
                yield return new ChickWeight(565, 233, 20, 49, 4);
                yield return new ChickWeight(566, 237, 21, 49, 4);
                yield return new ChickWeight(567, 41, 0, 50, 4);
                yield return new ChickWeight(568, 54, 2, 50, 4);
                yield return new ChickWeight(569, 67, 4, 50, 4);
                yield return new ChickWeight(570, 84, 6, 50, 4);
                yield return new ChickWeight(571, 105, 8, 50, 4);
                yield return new ChickWeight(572, 122, 10, 50, 4);
                yield return new ChickWeight(573, 155, 12, 50, 4);
                yield return new ChickWeight(574, 175, 14, 50, 4);
                yield return new ChickWeight(575, 205, 16, 50, 4);
                yield return new ChickWeight(576, 234, 18, 50, 4);
                yield return new ChickWeight(577, 264, 20, 50, 4);
                yield return new ChickWeight(578, 264, 21, 50, 4);
            }
        }
    }
}
