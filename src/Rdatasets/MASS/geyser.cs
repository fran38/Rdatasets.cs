// ReSharper disable All

namespace Rdatasets.MASS
{
    using System.Collections.Generic;

    /// <summary>
    /// Old Faithful Geyser Data
    /// </summary>

    public class geyser
    {
        public readonly int κ;
        public readonly int waiting;
        public readonly double duration;

        public geyser(int κ, int waiting, double duration)
        {
            this.κ = κ;
            this.waiting = waiting;
            this.duration = duration;
        }

        public static IEnumerable<geyser> Data
        {
            get
            {
                yield return new geyser(1, 80, 4.0166667);
                yield return new geyser(2, 71, 2.15);
                yield return new geyser(3, 57, 4);
                yield return new geyser(4, 80, 4);
                yield return new geyser(5, 75, 4);
                yield return new geyser(6, 77, 2);
                yield return new geyser(7, 60, 4.3833333);
                yield return new geyser(8, 86, 4.2833333);
                yield return new geyser(9, 77, 2.0333333);
                yield return new geyser(10, 56, 4.8333333);
                yield return new geyser(11, 81, 1.8333333);
                yield return new geyser(12, 50, 5.45);
                yield return new geyser(13, 89, 1.6166667);
                yield return new geyser(14, 54, 4.8666667);
                yield return new geyser(15, 90, 4.3833333);
                yield return new geyser(16, 73, 1.7666667);
                yield return new geyser(17, 60, 4.6666667);
                yield return new geyser(18, 83, 2);
                yield return new geyser(19, 65, 4.7333333);
                yield return new geyser(20, 82, 4.2166667);
                yield return new geyser(21, 84, 1.9);
                yield return new geyser(22, 54, 4.9666667);
                yield return new geyser(23, 85, 2);
                yield return new geyser(24, 58, 4);
                yield return new geyser(25, 79, 2);
                yield return new geyser(26, 57, 4);
                yield return new geyser(27, 88, 2.8333333);
                yield return new geyser(28, 68, 4.5);
                yield return new geyser(29, 76, 4.0666667);
                yield return new geyser(30, 78, 3.7166667);
                yield return new geyser(31, 74, 3.5166667);
                yield return new geyser(32, 85, 4.4666667);
                yield return new geyser(33, 75, 2.2166667);
                yield return new geyser(34, 65, 4.8833333);
                yield return new geyser(35, 76, 2.6);
                yield return new geyser(36, 58, 4.15);
                yield return new geyser(37, 91, 2.2);
                yield return new geyser(38, 50, 4.7666667);
                yield return new geyser(39, 87, 1.8333333);
                yield return new geyser(40, 48, 4.6);
                yield return new geyser(41, 93, 2.2666667);
                yield return new geyser(42, 54, 4.1333333);
                yield return new geyser(43, 86, 2);
                yield return new geyser(44, 53, 4);
                yield return new geyser(45, 78, 2);
                yield return new geyser(46, 52, 4);
                yield return new geyser(47, 83, 1.8833333);
                yield return new geyser(48, 60, 4.2666667);
                yield return new geyser(49, 87, 2.0833333);
                yield return new geyser(50, 49, 4.4666667);
                yield return new geyser(51, 80, 2.5);
                yield return new geyser(52, 60, 4);
                yield return new geyser(53, 92, 1.7666667);
                yield return new geyser(54, 43, 4.3333333);
                yield return new geyser(55, 89, 2.1833333);
                yield return new geyser(56, 60, 4.4833333);
                yield return new geyser(57, 84, 3.8833333);
                yield return new geyser(58, 69, 3.3333333);
                yield return new geyser(59, 74, 3.7333333);
                yield return new geyser(60, 71, 4);
                yield return new geyser(61, 108, 1.95);
                yield return new geyser(62, 50, 5.2666667);
                yield return new geyser(63, 77, 2);
                yield return new geyser(64, 57, 4);
                yield return new geyser(65, 80, 2);
                yield return new geyser(66, 61, 4);
                yield return new geyser(67, 82, 2);
                yield return new geyser(68, 48, 4);
                yield return new geyser(69, 81, 3.5333333);
                yield return new geyser(70, 73, 2.1666667);
                yield return new geyser(71, 62, 4.5);
                yield return new geyser(72, 79, 2.0166667);
                yield return new geyser(73, 54, 4.15);
                yield return new geyser(74, 80, 4.2);
                yield return new geyser(75, 73, 4.3333333);
                yield return new geyser(76, 81, 1.9333333);
                yield return new geyser(77, 62, 4.65);
                yield return new geyser(78, 81, 3.8166667);
                yield return new geyser(79, 71, 4.0333333);
                yield return new geyser(80, 79, 4.1666667);
                yield return new geyser(81, 81, 4.6666667);
                yield return new geyser(82, 74, 1.8166667);
                yield return new geyser(83, 59, 4);
                yield return new geyser(84, 81, 3);
                yield return new geyser(85, 66, 4);
                yield return new geyser(86, 87, 2);
                yield return new geyser(87, 53, 4.45);
                yield return new geyser(88, 80, 2.05);
                yield return new geyser(89, 50, 4.25);
                yield return new geyser(90, 87, 1.9166667);
                yield return new geyser(91, 51, 4.6666667);
                yield return new geyser(92, 82, 1.7333333);
                yield return new geyser(93, 58, 4.3833333);
                yield return new geyser(94, 81, 1.7666667);
                yield return new geyser(95, 49, 4.6);
                yield return new geyser(96, 92, 1.8666667);
                yield return new geyser(97, 50, 4.45);
                yield return new geyser(98, 88, 1.6333333);
                yield return new geyser(99, 62, 5.0333333);
                yield return new geyser(100, 93, 1.8166667);
                yield return new geyser(101, 56, 5.1);
                yield return new geyser(102, 89, 1.6333333);
                yield return new geyser(103, 51, 4.2833333);
                yield return new geyser(104, 79, 2);
                yield return new geyser(105, 58, 4);
                yield return new geyser(106, 82, 2);
                yield return new geyser(107, 52, 4.5333333);
                yield return new geyser(108, 88, 2);
                yield return new geyser(109, 52, 4);
                yield return new geyser(110, 78, 2.9333333);
                yield return new geyser(111, 69, 4.7333333);
                yield return new geyser(112, 75, 3.9);
                yield return new geyser(113, 77, 1.95);
                yield return new geyser(114, 53, 4.1166667);
                yield return new geyser(115, 80, 1.8);
                yield return new geyser(116, 55, 4.6666667);
                yield return new geyser(117, 87, 1.8333333);
                yield return new geyser(118, 53, 4.7);
                yield return new geyser(119, 85, 2.1166667);
                yield return new geyser(120, 61, 4.7833333);
                yield return new geyser(121, 93, 1.8166667);
                yield return new geyser(122, 54, 4.1);
                yield return new geyser(123, 76, 4.65);
                yield return new geyser(124, 80, 4);
                yield return new geyser(125, 81, 2);
                yield return new geyser(126, 59, 4);
                yield return new geyser(127, 86, 4);
                yield return new geyser(128, 78, 4.2166667);
                yield return new geyser(129, 71, 4.1333333);
                yield return new geyser(130, 77, 3.9333333);
                yield return new geyser(131, 76, 3.75);
                yield return new geyser(132, 94, 4.4166667);
                yield return new geyser(133, 75, 2.4666667);
                yield return new geyser(134, 50, 4.1666667);
                yield return new geyser(135, 83, 3.8);
                yield return new geyser(136, 82, 4.3166667);
                yield return new geyser(137, 72, 3.8666667);
                yield return new geyser(138, 77, 4.6833333);
                yield return new geyser(139, 75, 1.7);
                yield return new geyser(140, 65, 4.9666667);
                yield return new geyser(141, 79, 4.2666667);
                yield return new geyser(142, 72, 4.5833333);
                yield return new geyser(143, 78, 4);
                yield return new geyser(144, 77, 4);
                yield return new geyser(145, 79, 4);
                yield return new geyser(146, 75, 4);
                yield return new geyser(147, 78, 1.9833333);
                yield return new geyser(148, 64, 4.6);
                yield return new geyser(149, 80, 0.8333333);
                yield return new geyser(150, 49, 4.9166667);
                yield return new geyser(151, 88, 1.7333333);
                yield return new geyser(152, 54, 4.5833333);
                yield return new geyser(153, 85, 1.7);
                yield return new geyser(154, 51, 4.75);
                yield return new geyser(155, 96, 1.8333333);
                yield return new geyser(156, 50, 4.5);
                yield return new geyser(157, 80, 1.8666667);
                yield return new geyser(158, 78, 4.45);
                yield return new geyser(159, 81, 4.45);
                yield return new geyser(160, 72, 4);
                yield return new geyser(161, 75, 4.8);
                yield return new geyser(162, 78, 4);
                yield return new geyser(163, 87, 4);
                yield return new geyser(164, 69, 2);
                yield return new geyser(165, 55, 4);
                yield return new geyser(166, 83, 1.9333333);
                yield return new geyser(167, 49, 4.5833333);
                yield return new geyser(168, 82, 2);
                yield return new geyser(169, 57, 3.7);
                yield return new geyser(170, 84, 2.8666667);
                yield return new geyser(171, 57, 4.8333333);
                yield return new geyser(172, 84, 3.45);
                yield return new geyser(173, 73, 4.3833333);
                yield return new geyser(174, 78, 1.8);
                yield return new geyser(175, 57, 4.4);
                yield return new geyser(176, 79, 2.4833333);
                yield return new geyser(177, 57, 4.5166667);
                yield return new geyser(178, 90, 2.1);
                yield return new geyser(179, 62, 4.35);
                yield return new geyser(180, 87, 4.3666667);
                yield return new geyser(181, 78, 1.7833333);
                yield return new geyser(182, 52, 4.9166667);
                yield return new geyser(183, 98, 1.8166667);
                yield return new geyser(184, 48, 4);
                yield return new geyser(185, 78, 4);
                yield return new geyser(186, 79, 4);
                yield return new geyser(187, 65, 3.8666667);
                yield return new geyser(188, 84, 1.85);
                yield return new geyser(189, 50, 4.7);
                yield return new geyser(190, 83, 2.0166667);
                yield return new geyser(191, 60, 4.4666667);
                yield return new geyser(192, 80, 1.8666667);
                yield return new geyser(193, 50, 4.1666667);
                yield return new geyser(194, 88, 1.9);
                yield return new geyser(195, 50, 4.25);
                yield return new geyser(196, 84, 3.25);
                yield return new geyser(197, 74, 4.2166667);
                yield return new geyser(198, 76, 1.8833333);
                yield return new geyser(199, 65, 4.9833333);
                yield return new geyser(200, 89, 1.85);
                yield return new geyser(201, 49, 4);
                yield return new geyser(202, 88, 1.9666667);
                yield return new geyser(203, 51, 4.7666667);
                yield return new geyser(204, 78, 4);
                yield return new geyser(205, 85, 2);
                yield return new geyser(206, 65, 4);
                yield return new geyser(207, 75, 4);
                yield return new geyser(208, 77, 2.3833333);
                yield return new geyser(209, 69, 4.4166667);
                yield return new geyser(210, 92, 4.2166667);
                yield return new geyser(211, 68, 4.3666667);
                yield return new geyser(212, 87, 2);
                yield return new geyser(213, 61, 4.45);
                yield return new geyser(214, 81, 1.75);
                yield return new geyser(215, 55, 4.5);
                yield return new geyser(216, 93, 1.6166667);
                yield return new geyser(217, 53, 4.7);
                yield return new geyser(218, 84, 2.5666667);
                yield return new geyser(219, 70, 3.7);
                yield return new geyser(220, 73, 4.2333333);
                yield return new geyser(221, 93, 1.9333333);
                yield return new geyser(222, 50, 4.35);
                yield return new geyser(223, 87, 4);
                yield return new geyser(224, 77, 4);
                yield return new geyser(225, 74, 4);
                yield return new geyser(226, 72, 4.2166667);
                yield return new geyser(227, 82, 4);
                yield return new geyser(228, 74, 4.1333333);
                yield return new geyser(229, 80, 1.8833333);
                yield return new geyser(230, 49, 4.4666667);
                yield return new geyser(231, 91, 1.95);
                yield return new geyser(232, 53, 4.2166667);
                yield return new geyser(233, 86, 1.7166667);
                yield return new geyser(234, 49, 4.45);
                yield return new geyser(235, 79, 4.25);
                yield return new geyser(236, 89, 3.9666667);
                yield return new geyser(237, 87, 4.3833333);
                yield return new geyser(238, 76, 1.9666667);
                yield return new geyser(239, 59, 4.45);
                yield return new geyser(240, 80, 4.2666667);
                yield return new geyser(241, 89, 1.9166667);
                yield return new geyser(242, 45, 4.4166667);
                yield return new geyser(243, 93, 3);
                yield return new geyser(244, 72, 4);
                yield return new geyser(245, 71, 2);
                yield return new geyser(246, 54, 4);
                yield return new geyser(247, 79, 3.2833333);
                yield return new geyser(248, 74, 1.8333333);
                yield return new geyser(249, 65, 4.6166667);
                yield return new geyser(250, 78, 1.8333333);
                yield return new geyser(251, 57, 4.6166667);
                yield return new geyser(252, 87, 4.6);
                yield return new geyser(253, 72, 4.25);
                yield return new geyser(254, 84, 1.9333333);
                yield return new geyser(255, 47, 4.9833333);
                yield return new geyser(256, 84, 1.9666667);
                yield return new geyser(257, 57, 4.3);
                yield return new geyser(258, 87, 4.2);
                yield return new geyser(259, 68, 4.5333333);
                yield return new geyser(260, 86, 4.4);
                yield return new geyser(261, 75, 4.6166667);
                yield return new geyser(262, 73, 2);
                yield return new geyser(263, 53, 4);
                yield return new geyser(264, 82, 4);
                yield return new geyser(265, 93, 3.9166667);
                yield return new geyser(266, 77, 2);
                yield return new geyser(267, 54, 4.5);
                yield return new geyser(268, 96, 1.8);
                yield return new geyser(269, 48, 4);
                yield return new geyser(270, 89, 2.75);
                yield return new geyser(271, 63, 4.7333333);
                yield return new geyser(272, 84, 3.9666667);
                yield return new geyser(273, 76, 1.95);
                yield return new geyser(274, 62, 4.9666667);
                yield return new geyser(275, 83, 1.85);
                yield return new geyser(276, 50, 4.8);
                yield return new geyser(277, 85, 4);
                yield return new geyser(278, 78, 4);
                yield return new geyser(279, 78, 4);
                yield return new geyser(280, 81, 4);
                yield return new geyser(281, 78, 4);
                yield return new geyser(282, 76, 4);
                yield return new geyser(283, 74, 4);
                yield return new geyser(284, 81, 2);
                yield return new geyser(285, 66, 4);
                yield return new geyser(286, 84, 1.9333333);
                yield return new geyser(287, 48, 4.3333333);
                yield return new geyser(288, 93, 1.6666667);
                yield return new geyser(289, 47, 4.7666667);
                yield return new geyser(290, 87, 1.95);
                yield return new geyser(291, 51, 4.6833333);
                yield return new geyser(292, 78, 1.9333333);
                yield return new geyser(293, 54, 4.4166667);
                yield return new geyser(294, 87, 2.1333333);
                yield return new geyser(295, 52, 4.0833333);
                yield return new geyser(296, 85, 2.0666667);
                yield return new geyser(297, 58, 4);
                yield return new geyser(298, 88, 4);
                yield return new geyser(299, 79, 2);
            }
        }
    }
}
