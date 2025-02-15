// ReSharper disable All

namespace Rdatasets.mediation
{
    using System.Collections.Generic;

    /// <summary>
    /// School-level data
    /// </summary>

    public class school
    {
        public readonly int κ;
        public readonly int SCH_ID;
        public readonly int coed;
        public readonly int smorale;
        public readonly int free;
        public readonly int catholic;

        public school(int κ, int SCH_ID, int coed, int smorale, int free, int catholic)
        {
            this.κ = κ;
            this.SCH_ID = SCH_ID;
            this.coed = coed;
            this.smorale = smorale;
            this.free = free;
            this.catholic = catholic;
        }

        public static IEnumerable<school> Data
        {
            get
            {
                yield return new school(1, 1, 1, 5, 1, 0);
                yield return new school(2, 2, 1, 4, 1, 0);
                yield return new school(3, 3, 1, 3, 4, 0);
                yield return new school(4, 4, 1, 4, 5, 0);
                yield return new school(5, 5, 1, 3, 1, 0);
                yield return new school(6, 6, 1, 4, 1, 0);
                yield return new school(7, 7, 1, 5, 3, 0);
                yield return new school(8, 8, 1, 5, 4, 0);
                yield return new school(9, 9, 1, 4, 1, 0);
                yield return new school(10, 10, 1, 3, 5, 0);
                yield return new school(11, 11, 1, 5, 4, 0);
                yield return new school(12, 12, 1, 3, 4, 0);
                yield return new school(13, 13, 1, 5, 2, 0);
                yield return new school(14, 14, 1, 3, 2, 0);
                yield return new school(15, 15, 1, 4, 4, 0);
                yield return new school(16, 16, 1, 5, 1, 0);
                yield return new school(17, 17, 1, 5, 1, 0);
                yield return new school(18, 18, 1, 4, 4, 0);
                yield return new school(19, 19, 1, 4, 1, 0);
                yield return new school(20, 20, 1, 5, 1, 0);
                yield return new school(21, 21, 1, 4, 5, 0);
                yield return new school(22, 22, 1, 4, 5, 0);
                yield return new school(23, 23, 1, 5, 6, 0);
                yield return new school(24, 24, 1, 4, 3, 0);
                yield return new school(25, 25, 1, 4, 3, 0);
                yield return new school(26, 26, 1, 4, 1, 0);
                yield return new school(27, 27, 1, 4, 4, 0);
                yield return new school(28, 28, 1, 4, 5, 0);
                yield return new school(29, 29, 1, 4, 5, 0);
                yield return new school(30, 30, 1, 4, 6, 0);
                yield return new school(31, 31, 1, 4, 1, 0);
                yield return new school(32, 32, 1, 3, 7, 0);
                yield return new school(33, 33, 1, 4, 3, 0);
                yield return new school(34, 34, 1, 4, 4, 0);
                yield return new school(35, 35, 1, 5, 2, 0);
                yield return new school(36, 36, 1, 3, 6, 0);
                yield return new school(37, 37, 1, 5, 1, 0);
                yield return new school(38, 38, 1, 5, 4, 0);
                yield return new school(39, 39, 1, 4, 5, 0);
                yield return new school(40, 40, 1, 3, 4, 0);
                yield return new school(41, 41, 1, 2, 3, 0);
                yield return new school(42, 42, 0, 5, 1, 1);
                yield return new school(43, 43, 1, 3, 3, 0);
                yield return new school(44, 44, 1, 4, 2, 1);
                yield return new school(45, 45, 1, 4, 4, 0);
                yield return new school(46, 46, 1, 4, 2, 0);
                yield return new school(47, 47, 1, 5, 1, 0);
                yield return new school(48, 48, 1, 4, 1, 1);
                yield return new school(49, 49, 1, 3, 5, 0);
                yield return new school(50, 50, 1, 3, 3, 0);
                yield return new school(51, 51, 1, 4, 4, 0);
                yield return new school(52, 52, 1, 5, 1, 0);
                yield return new school(53, 53, 1, 4, 1, 1);
                yield return new school(54, 54, 0, 5, 4, 0);
                yield return new school(55, 55, 1, 4, 6, 0);
                yield return new school(56, 56, 1, 4, 1, 0);
                yield return new school(57, 57, 1, 4, 2, 0);
                yield return new school(58, 58, 1, 3, 4, 0);
                yield return new school(59, 59, 1, 4, 1, 1);
                yield return new school(60, 60, 1, 3, 6, 0);
                yield return new school(61, 61, 1, 4, 6, 0);
                yield return new school(62, 62, 1, 4, 1, 0);
                yield return new school(63, 63, 1, 4, 3, 0);
                yield return new school(64, 64, 1, 4, 6, 0);
                yield return new school(65, 65, 1, 4, 3, 0);
                yield return new school(66, 66, 1, 4, 3, 0);
                yield return new school(67, 67, 1, 3, 4, 0);
                yield return new school(68, 68, 1, 4, 1, 0);
                yield return new school(69, 69, 1, 4, 6, 0);
                yield return new school(70, 70, 1, 4, 4, 0);
                yield return new school(71, 71, 1, 4, 5, 0);
                yield return new school(72, 72, 1, 3, 6, 0);
                yield return new school(73, 73, 1, 5, 1, 0);
                yield return new school(74, 74, 1, 4, 4, 0);
                yield return new school(75, 75, 1, 4, 1, 0);
                yield return new school(76, 76, 1, 4, 3, 0);
                yield return new school(77, 77, 1, 4, 1, 0);
                yield return new school(78, 78, 1, 5, 2, 0);
                yield return new school(79, 79, 1, 4, 7, 0);
                yield return new school(80, 80, 1, 3, 5, 0);
                yield return new school(81, 81, 1, 4, 2, 0);
                yield return new school(82, 82, 1, 4, 2, 0);
                yield return new school(83, 83, 0, 5, 1, 1);
                yield return new school(84, 84, 1, 2, 1, 0);
                yield return new school(85, 85, 1, 4, 5, 0);
                yield return new school(86, 86, 1, 5, 1, 1);
                yield return new school(87, 87, 1, 3, 7, 0);
                yield return new school(88, 88, 0, 4, 1, 1);
                yield return new school(89, 89, 1, 4, 4, 0);
                yield return new school(90, 90, 1, 2, 6, 0);
                yield return new school(91, 91, 1, 3, 1, 0);
                yield return new school(92, 92, 1, 2, 6, 0);
                yield return new school(93, 93, 1, 4, 5, 0);
                yield return new school(94, 94, 1, 4, 4, 0);
                yield return new school(95, 95, 1, 4, 1, 0);
                yield return new school(96, 96, 1, 3, 3, 0);
                yield return new school(97, 97, 1, 4, 1, 0);
                yield return new school(98, 98, 1, 2, 3, 0);
                yield return new school(99, 99, 1, 4, 5, 0);
                yield return new school(100, 100, 1, 3, 2, 0);
                yield return new school(101, 101, 1, 5, 1, 0);
                yield return new school(102, 102, 1, 3, 4, 0);
                yield return new school(103, 103, 1, 5, 1, 1);
                yield return new school(104, 104, 1, 4, 2, 0);
                yield return new school(105, 105, 1, 4, 1, 0);
                yield return new school(106, 106, 1, 4, 3, 0);
                yield return new school(107, 107, 1, 4, 5, 0);
                yield return new school(108, 108, 1, 5, 1, 0);
                yield return new school(109, 109, 1, 5, 4, 0);
                yield return new school(110, 110, 1, 5, 1, 0);
                yield return new school(111, 111, 1, 5, 6, 0);
                yield return new school(112, 112, 1, 4, 6, 1);
                yield return new school(113, 113, 1, 4, 3, 0);
                yield return new school(114, 114, 1, 5, 3, 0);
                yield return new school(115, 115, 1, 4, 5, 0);
                yield return new school(116, 116, 1, 3, 3, 0);
                yield return new school(117, 117, 1, 3, 1, 0);
                yield return new school(118, 118, 1, 4, 5, 0);
                yield return new school(119, 119, 1, 3, 1, 0);
                yield return new school(120, 120, 1, 2, 6, 0);
                yield return new school(121, 121, 1, 4, 3, 0);
                yield return new school(122, 122, 1, 5, 6, 0);
                yield return new school(123, 123, 1, 4, 4, 0);
                yield return new school(124, 124, 1, 4, 4, 0);
                yield return new school(125, 125, 1, 5, 1, 0);
                yield return new school(126, 126, 1, 4, 3, 0);
                yield return new school(127, 127, 1, 4, 6, 0);
                yield return new school(128, 128, 1, 3, 3, 0);
                yield return new school(129, 129, 1, 3, 5, 0);
                yield return new school(130, 130, 1, 4, 4, 1);
                yield return new school(131, 131, 1, 5, 2, 0);
                yield return new school(132, 132, 1, 5, 5, 0);
                yield return new school(133, 133, 1, 5, 5, 0);
                yield return new school(134, 134, 1, 4, 5, 0);
                yield return new school(135, 135, 1, 4, 4, 0);
                yield return new school(136, 136, 1, 3, 6, 0);
                yield return new school(137, 137, 1, 4, 3, 0);
                yield return new school(138, 138, 1, 3, 3, 0);
                yield return new school(139, 139, 0, 5, 1, 1);
                yield return new school(140, 140, 1, 4, 1, 0);
                yield return new school(141, 141, 1, 5, 4, 0);
                yield return new school(142, 142, 1, 4, 4, 0);
                yield return new school(143, 143, 1, 4, 1, 0);
                yield return new school(144, 144, 1, 5, 1, 0);
                yield return new school(145, 145, 1, 4, 2, 0);
                yield return new school(146, 146, 1, 4, 1, 0);
                yield return new school(147, 147, 1, 5, 1, 0);
                yield return new school(148, 148, 1, 4, 7, 0);
                yield return new school(149, 149, 1, 4, 3, 0);
                yield return new school(150, 150, 1, 2, 7, 0);
                yield return new school(151, 151, 1, 4, 1, 1);
                yield return new school(152, 152, 1, 3, 4, 0);
                yield return new school(153, 153, 1, 4, 5, 0);
                yield return new school(154, 154, 1, 5, 5, 0);
                yield return new school(155, 155, 1, 4, 5, 0);
                yield return new school(156, 156, 1, 4, 3, 0);
                yield return new school(157, 157, 1, 4, 4, 0);
                yield return new school(158, 158, 1, 4, 3, 0);
                yield return new school(159, 159, 1, 4, 5, 0);
                yield return new school(160, 160, 1, 3, 7, 0);
                yield return new school(161, 161, 1, 5, 6, 0);
                yield return new school(162, 162, 1, 4, 1, 0);
                yield return new school(163, 163, 1, 5, 1, 1);
                yield return new school(164, 164, 1, 5, 3, 0);
                yield return new school(165, 165, 1, 3, 4, 0);
                yield return new school(166, 166, 1, 5, 3, 0);
                yield return new school(167, 167, 1, 4, 5, 0);
                yield return new school(168, 168, 1, 4, 5, 0);
                yield return new school(169, 169, 1, 3, 2, 0);
                yield return new school(170, 170, 1, 4, 6, 0);
                yield return new school(171, 171, 1, 5, 4, 0);
                yield return new school(172, 172, 1, 4, 1, 1);
                yield return new school(173, 173, 1, 5, 1, 1);
                yield return new school(174, 174, 1, 3, 4, 0);
                yield return new school(175, 175, 1, 3, 7, 0);
                yield return new school(176, 176, 1, 4, 4, 0);
                yield return new school(177, 177, 1, 5, 1, 1);
                yield return new school(178, 178, 1, 4, 3, 0);
                yield return new school(179, 179, 1, 3, 4, 0);
                yield return new school(180, 180, 1, 3, 1, 0);
                yield return new school(181, 181, 1, 3, 3, 0);
                yield return new school(182, 182, 1, 3, 1, 0);
                yield return new school(183, 183, 1, 5, 5, 0);
                yield return new school(184, 184, 1, 2, 5, 0);
                yield return new school(185, 185, 1, 5, 4, 0);
                yield return new school(186, 186, 1, 3, 5, 0);
                yield return new school(187, 187, 1, 5, 1, 0);
                yield return new school(188, 188, 0, 5, 3, 1);
                yield return new school(189, 189, 1, 5, 1, 0);
                yield return new school(190, 190, 1, 5, 4, 0);
                yield return new school(191, 191, 1, 3, 4, 0);
                yield return new school(192, 192, 1, 4, 5, 0);
                yield return new school(193, 193, 1, 4, 1, 0);
                yield return new school(194, 194, 1, 5, 1, 0);
                yield return new school(195, 195, 0, 5, 1, 1);
                yield return new school(196, 196, 1, 4, 7, 0);
                yield return new school(197, 197, 1, 3, 5, 0);
                yield return new school(198, 198, 1, 3, 1, 0);
                yield return new school(199, 199, 1, 3, 4, 0);
                yield return new school(200, 200, 1, 2, 7, 0);
                yield return new school(201, 201, 1, 5, 4, 0);
                yield return new school(202, 202, 1, 4, 1, 1);
                yield return new school(203, 203, 1, 4, 1, 0);
                yield return new school(204, 204, 1, 4, 1, 0);
                yield return new school(205, 205, 1, 4, 2, 0);
                yield return new school(206, 206, 1, 4, 7, 0);
                yield return new school(207, 207, 1, 4, 1, 1);
                yield return new school(208, 208, 1, 3, 5, 0);
                yield return new school(209, 209, 1, 3, 5, 0);
                yield return new school(210, 210, 1, 3, 7, 0);
                yield return new school(211, 211, 1, 4, 3, 0);
                yield return new school(212, 212, 1, 5, 1, 0);
                yield return new school(213, 213, 1, 4, 3, 0);
                yield return new school(214, 214, 0, 4, 1, 1);
                yield return new school(215, 215, 1, 3, 1, 1);
                yield return new school(216, 216, 1, 5, 2, 0);
                yield return new school(217, 217, 1, 3, 3, 0);
                yield return new school(218, 218, 1, 4, 2, 0);
                yield return new school(219, 219, 0, 5, 1, 1);
                yield return new school(220, 220, 1, 5, 4, 0);
                yield return new school(221, 221, 1, 4, 1, 0);
                yield return new school(222, 222, 1, 4, 7, 0);
                yield return new school(223, 223, 1, 4, 7, 0);
                yield return new school(224, 224, 1, 3, 3, 0);
                yield return new school(225, 225, 1, 4, 5, 0);
                yield return new school(226, 226, 1, 4, 1, 0);
                yield return new school(227, 227, 1, 4, 2, 0);
                yield return new school(228, 228, 1, 4, 4, 0);
                yield return new school(229, 229, 1, 4, 2, 0);
                yield return new school(230, 230, 1, 5, 4, 0);
                yield return new school(231, 231, 1, 4, 1, 0);
                yield return new school(232, 232, 1, 4, 2, 0);
                yield return new school(233, 233, 1, 5, 1, 1);
                yield return new school(234, 234, 1, 5, 2, 0);
                yield return new school(235, 235, 1, 3, 3, 0);
                yield return new school(236, 236, 1, 4, 5, 0);
                yield return new school(237, 237, 1, 3, 5, 0);
                yield return new school(238, 238, 1, 4, 6, 0);
                yield return new school(239, 239, 1, 4, 7, 0);
                yield return new school(240, 240, 1, 5, 6, 0);
                yield return new school(241, 241, 1, 4, 6, 0);
                yield return new school(242, 242, 1, 5, 1, 1);
                yield return new school(243, 243, 1, 3, 6, 0);
                yield return new school(244, 244, 1, 5, 3, 0);
                yield return new school(245, 245, 1, 4, 1, 0);
                yield return new school(246, 246, 1, 3, 2, 0);
                yield return new school(247, 247, 1, 3, 1, 0);
                yield return new school(248, 248, 1, 3, 1, 1);
                yield return new school(249, 249, 1, 5, 1, 1);
                yield return new school(250, 250, 1, 5, 2, 0);
                yield return new school(251, 251, 1, 4, 2, 0);
                yield return new school(252, 252, 1, 5, 5, 0);
                yield return new school(253, 253, 1, 4, 5, 0);
                yield return new school(254, 254, 1, 5, 1, 0);
                yield return new school(255, 255, 1, 4, 1, 0);
                yield return new school(256, 256, 1, 3, 3, 0);
                yield return new school(257, 257, 0, 3, 1, 0);
                yield return new school(258, 258, 1, 4, 1, 0);
                yield return new school(259, 259, 1, 5, 5, 0);
                yield return new school(260, 260, 1, 4, 5, 0);
                yield return new school(261, 261, 1, 4, 3, 0);
                yield return new school(262, 262, 1, 4, 2, 0);
                yield return new school(263, 263, 1, 4, 1, 0);
                yield return new school(264, 264, 1, 4, 4, 0);
                yield return new school(265, 265, 1, 4, 5, 0);
                yield return new school(266, 266, 1, 4, 6, 0);
                yield return new school(267, 267, 1, 4, 1, 0);
                yield return new school(268, 268, 1, 4, 1, 0);
                yield return new school(269, 269, 1, 5, 1, 0);
                yield return new school(270, 270, 1, 5, 1, 0);
                yield return new school(271, 271, 1, 4, 5, 0);
                yield return new school(272, 272, 1, 5, 1, 1);
                yield return new school(273, 273, 0, 4, 1, 1);
                yield return new school(274, 274, 1, 4, 5, 0);
                yield return new school(275, 275, 1, 4, 6, 0);
                yield return new school(276, 276, 1, 3, 2, 0);
                yield return new school(277, 277, 1, 4, 4, 0);
                yield return new school(278, 278, 1, 2, 6, 0);
                yield return new school(279, 279, 1, 5, 2, 0);
                yield return new school(280, 280, 1, 3, 5, 0);
                yield return new school(281, 281, 1, 4, 2, 1);
                yield return new school(282, 282, 1, 4, 3, 0);
                yield return new school(283, 283, 1, 5, 1, 1);
                yield return new school(284, 284, 1, 3, 3, 0);
                yield return new school(285, 285, 1, 5, 1, 0);
                yield return new school(286, 286, 1, 4, 7, 0);
                yield return new school(287, 287, 1, 4, 4, 0);
                yield return new school(288, 288, 1, 4, 4, 0);
                yield return new school(289, 289, 1, 5, 1, 0);
                yield return new school(290, 290, 1, 3, 6, 0);
                yield return new school(291, 291, 1, 3, 4, 0);
                yield return new school(292, 292, 1, 5, 1, 1);
                yield return new school(293, 293, 1, 4, 3, 0);
                yield return new school(294, 294, 1, 4, 3, 0);
                yield return new school(295, 295, 1, 4, 1, 0);
                yield return new school(296, 296, 1, 4, 4, 0);
                yield return new school(297, 297, 1, 3, 1, 0);
                yield return new school(298, 298, 1, 5, 3, 0);
                yield return new school(299, 299, 1, 4, 1, 0);
                yield return new school(300, 300, 1, 2, 3, 0);
                yield return new school(301, 301, 0, 4, 1, 1);
                yield return new school(302, 302, 1, 3, 3, 0);
                yield return new school(303, 303, 0, 4, 1, 1);
                yield return new school(304, 304, 1, 4, 1, 0);
                yield return new school(305, 305, 1, 4, 4, 0);
                yield return new school(306, 306, 1, 3, 3, 0);
                yield return new school(307, 307, 1, 4, 1, 0);
                yield return new school(308, 308, 1, 3, 2, 0);
                yield return new school(309, 309, 1, 4, 1, 1);
                yield return new school(310, 310, 0, 4, 1, 1);
                yield return new school(311, 311, 1, 5, 1, 0);
                yield return new school(312, 312, 0, 5, 1, 1);
                yield return new school(313, 313, 1, 5, 1, 0);
                yield return new school(314, 314, 1, 4, 3, 0);
                yield return new school(315, 315, 1, 4, 2, 0);
                yield return new school(316, 316, 1, 4, 3, 0);
                yield return new school(317, 317, 1, 5, 4, 0);
                yield return new school(318, 318, 1, 5, 1, 1);
                yield return new school(319, 319, 1, 3, 3, 0);
                yield return new school(320, 320, 1, 4, 5, 0);
                yield return new school(321, 321, 1, 3, 3, 0);
                yield return new school(322, 322, 1, 5, 1, 1);
                yield return new school(323, 323, 1, 3, 6, 0);
                yield return new school(324, 324, 1, 5, 3, 0);
                yield return new school(325, 325, 1, 5, 1, 0);
                yield return new school(326, 326, 1, 4, 7, 0);
                yield return new school(327, 327, 1, 4, 3, 0);
                yield return new school(328, 328, 1, 4, 3, 0);
                yield return new school(329, 329, 1, 5, 5, 0);
                yield return new school(330, 330, 1, 4, 3, 0);
                yield return new school(331, 331, 1, 4, 3, 0);
                yield return new school(332, 332, 1, 4, 5, 0);
                yield return new school(333, 333, 1, 5, 4, 0);
                yield return new school(334, 334, 1, 3, 2, 0);
                yield return new school(335, 335, 1, 3, 5, 0);
                yield return new school(336, 336, 1, 2, 3, 0);
                yield return new school(337, 337, 1, 2, 6, 0);
                yield return new school(338, 338, 1, 5, 2, 0);
                yield return new school(339, 339, 1, 4, 6, 0);
                yield return new school(340, 340, 1, 4, 1, 0);
                yield return new school(341, 341, 1, 4, 2, 0);
                yield return new school(342, 342, 1, 4, 6, 0);
                yield return new school(343, 343, 1, 5, 1, 0);
                yield return new school(344, 344, 1, 3, 5, 0);
                yield return new school(345, 345, 1, 5, 3, 0);
                yield return new school(346, 346, 1, 5, 3, 0);
                yield return new school(347, 347, 1, 3, 5, 0);
                yield return new school(348, 348, 1, 5, 6, 0);
                yield return new school(349, 349, 1, 3, 3, 0);
                yield return new school(350, 350, 1, 4, 1, 0);
                yield return new school(351, 351, 1, 4, 6, 0);
                yield return new school(352, 352, 1, 3, 1, 0);
                yield return new school(353, 353, 1, 5, 5, 0);
                yield return new school(354, 354, 0, 4, 1, 1);
                yield return new school(355, 355, 1, 5, 5, 0);
                yield return new school(356, 356, 1, 4, 7, 0);
                yield return new school(357, 357, 1, 5, 1, 0);
                yield return new school(358, 358, 1, 5, 1, 0);
                yield return new school(359, 359, 1, 5, 5, 0);
                yield return new school(360, 360, 1, 3, 4, 0);
                yield return new school(361, 361, 1, 3, 3, 0);
                yield return new school(362, 362, 1, 4, 6, 0);
                yield return new school(363, 363, 1, 4, 3, 0);
                yield return new school(364, 364, 1, 5, 6, 1);
                yield return new school(365, 365, 1, 4, 3, 0);
                yield return new school(366, 366, 1, 4, 3, 1);
                yield return new school(367, 367, 1, 4, 1, 0);
                yield return new school(368, 368, 1, 4, 2, 0);
                yield return new school(369, 369, 1, 4, 3, 0);
                yield return new school(370, 370, 0, 4, 4, 1);
                yield return new school(371, 371, 0, 5, 1, 0);
                yield return new school(372, 372, 1, 5, 1, 0);
                yield return new school(373, 373, 1, 3, 1, 0);
                yield return new school(374, 374, 0, 5, 1, 1);
                yield return new school(375, 375, 1, 5, 4, 0);
                yield return new school(376, 376, 1, 5, 1, 0);
                yield return new school(377, 377, 1, 5, 4, 0);
                yield return new school(378, 378, 1, 5, 4, 0);
                yield return new school(379, 379, 0, 2, 1, 0);
                yield return new school(380, 380, 1, 4, 1, 0);
                yield return new school(381, 381, 1, 4, 3, 0);
                yield return new school(382, 382, 1, 3, 7, 0);
                yield return new school(383, 383, 1, 4, 1, 1);
                yield return new school(384, 384, 1, 4, 2, 0);
                yield return new school(385, 385, 1, 4, 5, 0);
                yield return new school(386, 386, 1, 3, 7, 0);
                yield return new school(387, 387, 1, 4, 6, 0);
                yield return new school(388, 388, 1, 5, 3, 0);
                yield return new school(389, 389, 1, 4, 5, 0);
                yield return new school(390, 390, 1, 4, 2, 0);
                yield return new school(391, 391, 1, 5, 1, 0);
                yield return new school(392, 392, 1, 5, 3, 0);
                yield return new school(393, 393, 1, 3, 3, 0);
                yield return new school(394, 394, 1, 4, 5, 0);
                yield return new school(395, 395, 1, 5, 3, 0);
                yield return new school(396, 396, 1, 4, 1, 1);
                yield return new school(397, 397, 1, 4, 1, 0);
                yield return new school(398, 398, 1, 3, 6, 0);
                yield return new school(399, 399, 1, 5, 1, 0);
                yield return new school(400, 400, 1, 4, 2, 0);
                yield return new school(401, 401, 0, 3, 1, 1);
                yield return new school(402, 402, 1, 5, 1, 0);
                yield return new school(403, 403, 1, 5, 6, 0);
                yield return new school(404, 404, 1, 4, 5, 0);
                yield return new school(405, 405, 1, 4, 3, 1);
                yield return new school(406, 406, 1, 4, 1, 1);
                yield return new school(407, 407, 1, 4, 1, 0);
                yield return new school(408, 408, 1, 5, 1, 0);
                yield return new school(409, 409, 1, 4, 2, 0);
                yield return new school(410, 410, 1, 3, 4, 0);
                yield return new school(411, 411, 1, 4, 1, 1);
                yield return new school(412, 412, 1, 4, 6, 0);
                yield return new school(413, 413, 1, 5, 2, 0);
                yield return new school(414, 414, 1, 3, 3, 0);
                yield return new school(415, 415, 1, 2, 5, 0);
                yield return new school(416, 416, 1, 4, 1, 0);
                yield return new school(417, 417, 1, 4, 5, 0);
                yield return new school(418, 418, 1, 3, 4, 0);
                yield return new school(419, 419, 1, 4, 2, 0);
                yield return new school(420, 420, 1, 4, 6, 0);
                yield return new school(421, 421, 1, 5, 2, 0);
                yield return new school(422, 422, 1, 4, 2, 0);
                yield return new school(423, 423, 1, 4, 1, 0);
                yield return new school(424, 424, 1, 3, 3, 0);
                yield return new school(425, 425, 1, 4, 2, 0);
                yield return new school(426, 426, 1, 4, 3, 0);
                yield return new school(427, 427, 1, 5, 3, 0);
                yield return new school(428, 428, 1, 4, 5, 0);
                yield return new school(429, 429, 0, 4, 1, 1);
                yield return new school(430, 430, 0, 5, 1, 1);
                yield return new school(431, 431, 1, 4, 1, 0);
                yield return new school(432, 432, 1, 5, 7, 0);
                yield return new school(433, 433, 1, 4, 4, 0);
                yield return new school(434, 434, 1, 4, 5, 0);
                yield return new school(435, 435, 1, 4, 1, 0);
                yield return new school(436, 436, 1, 5, 1, 1);
                yield return new school(437, 437, 1, 4, 1, 0);
                yield return new school(438, 438, 1, 3, 3, 0);
                yield return new school(439, 439, 1, 4, 7, 0);
                yield return new school(440, 440, 1, 4, 1, 0);
                yield return new school(441, 441, 1, 2, 7, 0);
                yield return new school(442, 442, 1, 4, 2, 0);
                yield return new school(443, 443, 1, 5, 1, 1);
                yield return new school(444, 444, 1, 5, 3, 0);
                yield return new school(445, 445, 1, 3, 4, 0);
                yield return new school(446, 446, 1, 4, 2, 0);
                yield return new school(447, 447, 1, 4, 1, 0);
                yield return new school(448, 448, 1, 4, 6, 0);
                yield return new school(449, 449, 1, 4, 1, 0);
                yield return new school(450, 450, 1, 4, 3, 0);
                yield return new school(451, 451, 1, 4, 4, 0);
                yield return new school(452, 452, 1, 4, 6, 0);
                yield return new school(453, 453, 1, 4, 1, 0);
                yield return new school(454, 454, 1, 4, 1, 0);
                yield return new school(455, 455, 1, 3, 7, 0);
                yield return new school(456, 456, 1, 4, 1, 1);
                yield return new school(457, 457, 1, 4, 2, 0);
                yield return new school(458, 458, 1, 3, 4, 0);
                yield return new school(459, 459, 1, 3, 1, 0);
                yield return new school(460, 460, 0, 3, 1, 0);
                yield return new school(461, 461, 1, 4, 6, 0);
                yield return new school(462, 462, 1, 4, 3, 0);
                yield return new school(463, 463, 1, 4, 4, 0);
                yield return new school(464, 464, 1, 4, 1, 0);
                yield return new school(465, 465, 1, 4, 1, 0);
                yield return new school(466, 466, 1, 4, 1, 1);
                yield return new school(467, 467, 1, 4, 5, 0);
                yield return new school(468, 468, 1, 5, 1, 1);
                yield return new school(469, 469, 1, 4, 5, 0);
                yield return new school(470, 470, 1, 4, 5, 0);
                yield return new school(471, 471, 1, 4, 3, 1);
                yield return new school(472, 472, 0, 5, 1, 1);
                yield return new school(473, 473, 1, 4, 4, 0);
                yield return new school(474, 474, 1, 5, 1, 0);
                yield return new school(475, 475, 1, 4, 5, 0);
                yield return new school(476, 476, 1, 4, 5, 0);
                yield return new school(477, 477, 1, 5, 3, 0);
                yield return new school(478, 478, 1, 3, 5, 0);
                yield return new school(479, 479, 0, 4, 3, 1);
                yield return new school(480, 480, 1, 4, 1, 0);
                yield return new school(481, 481, 1, 4, 6, 0);
                yield return new school(482, 482, 1, 4, 5, 0);
                yield return new school(483, 483, 1, 4, 5, 0);
                yield return new school(484, 484, 1, 3, 4, 0);
                yield return new school(485, 485, 1, 5, 2, 0);
                yield return new school(486, 486, 1, 4, 3, 0);
                yield return new school(487, 487, 0, 3, 5, 0);
                yield return new school(488, 488, 1, 5, 1, 1);
                yield return new school(489, 489, 1, 4, 1, 0);
                yield return new school(490, 490, 1, 4, 1, 0);
                yield return new school(491, 491, 1, 5, 2, 0);
                yield return new school(492, 492, 1, 4, 4, 0);
                yield return new school(493, 493, 1, 4, 4, 0);
                yield return new school(494, 494, 1, 4, 1, 0);
                yield return new school(495, 495, 1, 3, 2, 0);
                yield return new school(496, 496, 1, 4, 5, 0);
                yield return new school(497, 497, 1, 5, 4, 0);
                yield return new school(498, 498, 1, 4, 4, 0);
                yield return new school(499, 499, 1, 4, 3, 0);
                yield return new school(500, 500, 1, 5, 1, 0);
                yield return new school(501, 501, 1, 4, 5, 0);
                yield return new school(502, 502, 1, 4, 1, 0);
                yield return new school(503, 503, 1, 4, 3, 0);
                yield return new school(504, 504, 1, 4, 1, 1);
                yield return new school(505, 505, 1, 4, 3, 0);
                yield return new school(506, 506, 1, 5, 5, 0);
                yield return new school(507, 507, 1, 4, 3, 0);
                yield return new school(508, 508, 0, 5, 1, 1);
                yield return new school(509, 509, 1, 5, 1, 1);
                yield return new school(510, 510, 1, 4, 1, 0);
                yield return new school(511, 511, 1, 3, 3, 0);
                yield return new school(512, 512, 1, 5, 1, 0);
                yield return new school(513, 513, 1, 3, 6, 0);
                yield return new school(514, 514, 1, 3, 3, 0);
                yield return new school(515, 515, 1, 3, 2, 0);
                yield return new school(516, 516, 1, 4, 6, 0);
                yield return new school(517, 517, 1, 5, 1, 1);
                yield return new school(518, 518, 0, 3, 1, 1);
                yield return new school(519, 519, 1, 4, 1, 0);
                yield return new school(520, 520, 1, 4, 1, 0);
                yield return new school(521, 521, 1, 4, 5, 0);
                yield return new school(522, 522, 1, 4, 5, 0);
                yield return new school(523, 523, 1, 4, 1, 0);
                yield return new school(524, 524, 1, 4, 1, 1);
                yield return new school(525, 525, 1, 4, 2, 0);
                yield return new school(526, 526, 1, 4, 1, 0);
                yield return new school(527, 527, 1, 4, 2, 0);
                yield return new school(528, 528, 0, 4, 1, 1);
                yield return new school(529, 529, 1, 5, 1, 1);
                yield return new school(530, 530, 1, 4, 1, 0);
                yield return new school(531, 531, 1, 4, 1, 0);
                yield return new school(532, 532, 1, 4, 7, 0);
                yield return new school(533, 533, 1, 4, 6, 0);
                yield return new school(534, 534, 1, 5, 3, 0);
                yield return new school(535, 535, 1, 3, 4, 0);
                yield return new school(536, 536, 1, 3, 1, 0);
                yield return new school(537, 537, 1, 4, 6, 0);
                yield return new school(538, 538, 1, 5, 1, 0);
                yield return new school(539, 539, 1, 3, 7, 0);
                yield return new school(540, 540, 1, 4, 5, 0);
                yield return new school(541, 541, 0, 4, 1, 1);
                yield return new school(542, 542, 1, 5, 1, 0);
                yield return new school(543, 543, 1, 5, 3, 0);
                yield return new school(544, 544, 1, 5, 1, 0);
                yield return new school(545, 545, 1, 4, 7, 0);
                yield return new school(546, 546, 1, 4, 5, 0);
                yield return new school(547, 547, 1, 4, 2, 0);
                yield return new school(548, 548, 1, 4, 4, 0);
                yield return new school(549, 549, 1, 4, 2, 0);
                yield return new school(550, 550, 1, 5, 1, 0);
                yield return new school(551, 551, 1, 4, 1, 1);
                yield return new school(552, 552, 1, 5, 2, 0);
                yield return new school(553, 553, 1, 4, 1, 0);
                yield return new school(554, 554, 1, 5, 3, 0);
                yield return new school(555, 555, 1, 4, 5, 0);
                yield return new school(556, 556, 1, 4, 4, 0);
                yield return new school(557, 557, 1, 3, 6, 0);
                yield return new school(558, 558, 1, 5, 2, 0);
                yield return new school(559, 559, 1, 4, 1, 0);
                yield return new school(560, 560, 1, 3, 5, 0);
                yield return new school(561, 561, 1, 2, 7, 0);
                yield return new school(562, 562, 0, 3, 1, 1);
                yield return new school(563, 563, 1, 4, 1, 1);
                yield return new school(564, 564, 1, 4, 3, 0);
                yield return new school(565, 565, 1, 4, 4, 0);
                yield return new school(566, 566, 0, 5, 1, 1);
                yield return new school(567, 567, 1, 3, 1, 0);
                yield return new school(568, 568, 1, 5, 6, 0);
            }
        }
    }
}
