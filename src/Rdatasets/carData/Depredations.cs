// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Minnesota Wolf Depredation Data
    /// </summary>

    public class Depredations
    {
        public readonly int κ;
        public readonly double longitude;
        public readonly double latitude;
        public readonly int number;
        public readonly int early;
        public readonly int late;

        public Depredations(int κ, double longitude, double latitude, int number, int early, int late)
        {
            this.κ = κ;
            this.longitude = longitude;
            this.latitude = latitude;
            this.number = number;
            this.early = early;
            this.late = late;
        }

        public static IEnumerable<Depredations> Data
        {
            get
            {
                yield return new Depredations(1, -94.5, 46.1, 1, 0, 1);
                yield return new Depredations(2, -93, 46.6, 2, 0, 2);
                yield return new Depredations(3, -94.6, 48.5, 1, 1, 0);
                yield return new Depredations(4, -92.9, 46.6, 2, 0, 2);
                yield return new Depredations(5, -95.9, 48.8, 1, 0, 1);
                yield return new Depredations(6, -92.7, 47.1, 1, 0, 1);
                yield return new Depredations(7, -94.2, 48, 2, 0, 2);
                yield return new Depredations(8, -95.6, 46.8, 1, 0, 1);
                yield return new Depredations(9, -96.3, 48.6, 3, 2, 1);
                yield return new Depredations(10, -91.4, 47.2, 1, 0, 1);
                yield return new Depredations(11, -95.7, 48.6, 1, 0, 1);
                yield return new Depredations(12, -96.6, 48.8, 1, 0, 1);
                yield return new Depredations(13, -96.3, 48.6, 1, 1, 0);
                yield return new Depredations(14, -96.1, 48.5, 1, 0, 1);
                yield return new Depredations(15, -93.7, 47.2, 1, 0, 1);
                yield return new Depredations(16, -94, 47.4, 1, 0, 1);
                yield return new Depredations(17, -94.1, 48, 1, 0, 1);
                yield return new Depredations(18, -95.6, 47.4, 1, 0, 1);
                yield return new Depredations(19, -94.5, 48.5, 1, 1, 0);
                yield return new Depredations(20, -95.5, 47.9, 2, 2, 0);
                yield return new Depredations(21, -94.8, 46.7, 4, 0, 4);
                yield return new Depredations(22, -93.7, 47, 4, 0, 4);
                yield return new Depredations(23, -93.7, 47, 1, 0, 1);
                yield return new Depredations(24, -92.9, 46.9, 1, 0, 1);
                yield return new Depredations(25, -95.4, 47.3, 1, 1, 0);
                yield return new Depredations(26, -94.9, 47.8, 1, 0, 1);
                yield return new Depredations(27, -94.8, 47.9, 2, 1, 1);
                yield return new Depredations(28, -93, 47.9, 3, 1, 2);
                yield return new Depredations(29, -91.8, 47, 1, 0, 1);
                yield return new Depredations(30, -95.8, 48.6, 7, 7, 0);
                yield return new Depredations(31, -95.5, 48.6, 3, 1, 2);
                yield return new Depredations(32, -93.4, 47.5, 1, 0, 1);
                yield return new Depredations(33, -94.5, 46.8, 1, 0, 1);
                yield return new Depredations(34, -92.7, 46, 1, 0, 1);
                yield return new Depredations(35, -94.6, 48.5, 1, 1, 0);
                yield return new Depredations(36, -94.5, 48, 2, 2, 0);
                yield return new Depredations(37, -94.4, 47.8, 30, 14, 16);
                yield return new Depredations(38, -93.3, 48.4, 1, 0, 1);
                yield return new Depredations(39, -94.1, 48.4, 1, 0, 1);
                yield return new Depredations(40, -94.5, 46.6, 1, 0, 1);
                yield return new Depredations(41, -93.4, 46.7, 1, 0, 1);
                yield return new Depredations(42, -93, 48.3, 15, 7, 8);
                yield return new Depredations(43, -96.3, 48.7, 2, 2, 0);
                yield return new Depredations(44, -93.5, 48.3, 1, 1, 0);
                yield return new Depredations(45, -95.9, 48.9, 1, 0, 1);
                yield return new Depredations(46, -94.9, 48.7, 1, 1, 0);
                yield return new Depredations(47, -93.5, 46.6, 1, 0, 1);
                yield return new Depredations(48, -96.5, 48.5, 1, 0, 1);
                yield return new Depredations(49, -95.1, 47.7, 1, 1, 0);
                yield return new Depredations(50, -93, 47.1, 1, 0, 1);
                yield return new Depredations(51, -93, 46.4, 1, 0, 1);
                yield return new Depredations(52, -95.6, 47.8, 1, 1, 0);
                yield return new Depredations(53, -95.6, 48.3, 6, 5, 1);
                yield return new Depredations(54, -96.7, 48.9, 1, 0, 1);
                yield return new Depredations(55, -96.6, 48.8, 2, 2, 0);
                yield return new Depredations(56, -96.6, 48.8, 1, 0, 1);
                yield return new Depredations(57, -95.3, 48.8, 2, 0, 2);
                yield return new Depredations(58, -94.4, 48.7, 3, 0, 3);
                yield return new Depredations(59, -95.4, 48.9, 1, 1, 0);
                yield return new Depredations(60, -96.4, 48, 1, 0, 1);
                yield return new Depredations(61, -94.7, 47.3, 1, 0, 1);
                yield return new Depredations(62, -92.6, 46, 3, 0, 3);
                yield return new Depredations(63, -91.9, 47, 1, 1, 0);
                yield return new Depredations(64, -92.9, 46.8, 1, 1, 0);
                yield return new Depredations(65, -92.8, 46.6, 1, 0, 1);
                yield return new Depredations(66, -92.7, 46.4, 1, 0, 1);
                yield return new Depredations(67, -95.2, 47.7, 1, 1, 0);
                yield return new Depredations(68, -94.7, 48.7, 1, 1, 0);
                yield return new Depredations(69, -93.4, 46.6, 3, 0, 3);
                yield return new Depredations(70, -92.6, 47.2, 3, 1, 2);
                yield return new Depredations(71, -93.9, 48.6, 3, 3, 0);
                yield return new Depredations(72, -95.4, 47.1, 1, 1, 0);
                yield return new Depredations(73, -92.5, 46.8, 1, 0, 1);
                yield return new Depredations(74, -94.1, 47.9, 2, 0, 2);
                yield return new Depredations(75, -94.2, 47.9, 1, 0, 1);
                yield return new Depredations(76, -92, 44.2, 1, 1, 0);
                yield return new Depredations(77, -95.2, 47.8, 1, 1, 0);
                yield return new Depredations(78, -96.6, 48.8, 1, 1, 0);
                yield return new Depredations(79, -92.8, 47.9, 1, 1, 0);
                yield return new Depredations(80, -95.4, 48.9, 1, 1, 0);
                yield return new Depredations(81, -95.4, 48.9, 1, 1, 0);
                yield return new Depredations(82, -93.6, 46.7, 2, 0, 2);
                yield return new Depredations(83, -95.5, 48.2, 2, 2, 0);
                yield return new Depredations(84, -93.5, 48.5, 2, 0, 2);
                yield return new Depredations(85, -94.4, 48.7, 2, 2, 0);
                yield return new Depredations(86, -96.2, 48.9, 1, 1, 0);
                yield return new Depredations(87, -96.1, 48.8, 1, 0, 1);
                yield return new Depredations(88, -92.8, 47.9, 1, 0, 1);
                yield return new Depredations(89, -93.9, 47.4, 2, 0, 2);
                yield return new Depredations(90, -94.8, 47.7, 7, 2, 5);
                yield return new Depredations(91, -94.6, 47.9, 1, 1, 0);
                yield return new Depredations(92, -94.2, 47.9, 6, 3, 3);
                yield return new Depredations(93, -94.4, 47.7, 1, 1, 0);
                yield return new Depredations(94, -93, 46.8, 1, 0, 1);
                yield return new Depredations(95, -92.9, 46.9, 2, 0, 2);
                yield return new Depredations(96, -91.6, 47.1, 1, 0, 1);
                yield return new Depredations(97, -92.4, 47.4, 1, 0, 1);
                yield return new Depredations(98, -96, 48.6, 10, 8, 2);
                yield return new Depredations(99, -96.6, 48.9, 1, 0, 1);
                yield return new Depredations(100, -94.5, 47.9, 5, 1, 4);
                yield return new Depredations(101, -94.8, 48.8, 3, 1, 2);
                yield return new Depredations(102, -95.4, 47.3, 1, 1, 0);
                yield return new Depredations(103, -94.6, 47.9, 1, 1, 0);
                yield return new Depredations(104, -94.4, 47.6, 1, 0, 1);
                yield return new Depredations(105, -95.7, 47.3, 1, 0, 1);
                yield return new Depredations(106, -91.7, 47.2, 1, 1, 0);
                yield return new Depredations(107, -95.1, 47.7, 2, 2, 0);
                yield return new Depredations(108, -93.8, 46.1, 1, 0, 1);
                yield return new Depredations(109, -92.8, 46.6, 1, 0, 1);
                yield return new Depredations(110, -93.8, 47.2, 1, 0, 1);
                yield return new Depredations(111, -92.7, 47.8, 1, 1, 0);
                yield return new Depredations(112, -92.9, 46.8, 1, 0, 1);
                yield return new Depredations(113, -95.6, 48.8, 4, 0, 4);
                yield return new Depredations(114, -94.7, 46.5, 1, 0, 1);
                yield return new Depredations(115, -96, 48.8, 1, 1, 0);
                yield return new Depredations(116, -92.5, 47.4, 1, 0, 1);
                yield return new Depredations(117, -94.6, 47.7, 2, 0, 2);
                yield return new Depredations(118, -94.7, 47.8, 15, 7, 8);
                yield return new Depredations(119, -93.7, 46.8, 1, 1, 0);
                yield return new Depredations(120, -91.5, 47.4, 2, 2, 0);
                yield return new Depredations(121, -95.5, 48.4, 2, 0, 2);
                yield return new Depredations(122, -94.5, 48.2, 3, 1, 2);
                yield return new Depredations(123, -95.6, 48, 1, 0, 1);
                yield return new Depredations(124, -95.7, 48.2, 11, 5, 6);
                yield return new Depredations(125, -95.5, 47, 1, 1, 0);
                yield return new Depredations(126, -95.7, 48, 1, 0, 1);
                yield return new Depredations(127, -94.7, 48.5, 1, 1, 0);
                yield return new Depredations(128, -93.4, 46.5, 3, 0, 3);
                yield return new Depredations(129, -96.6, 48.8, 4, 0, 4);
                yield return new Depredations(130, -96, 48.6, 2, 1, 1);
                yield return new Depredations(131, -95.2, 47.3, 1, 0, 1);
                yield return new Depredations(132, -92.8, 46, 1, 1, 0);
                yield return new Depredations(133, -94.3, 48.7, 2, 0, 2);
                yield return new Depredations(134, -93.6, 46.8, 3, 2, 1);
                yield return new Depredations(135, -95.1, 47.5, 2, 0, 2);
                yield return new Depredations(136, -94.4, 46.5, 1, 0, 1);
                yield return new Depredations(137, -95.6, 48.7, 1, 1, 0);
                yield return new Depredations(138, -95.7, 48.8, 2, 0, 2);
                yield return new Depredations(139, -95.6, 48.7, 3, 3, 0);
                yield return new Depredations(140, -92.2, 47.4, 1, 0, 1);
                yield return new Depredations(141, -92.8, 47.3, 1, 0, 1);
                yield return new Depredations(142, -95.5, 48.8, 1, 1, 0);
                yield return new Depredations(143, -94.5, 48.5, 5, 5, 0);
                yield return new Depredations(144, -94.4, 48.6, 1, 0, 1);
                yield return new Depredations(145, -94.7, 46.5, 1, 0, 1);
                yield return new Depredations(146, -93.6, 45.9, 2, 0, 2);
                yield return new Depredations(147, -92.9, 47.1, 1, 0, 1);
                yield return new Depredations(148, -95.3, 48.9, 1, 0, 1);
                yield return new Depredations(149, -92.9, 46.6, 1, 0, 1);
                yield return new Depredations(150, -94.6, 46.7, 1, 0, 1);
                yield return new Depredations(151, -92.6, 46.1, 3, 0, 3);
                yield return new Depredations(152, -92.6, 46.1, 1, 0, 1);
                yield return new Depredations(153, -93.4, 46.7, 1, 0, 1);
                yield return new Depredations(154, -95.5, 48.9, 2, 0, 2);
                yield return new Depredations(155, -92.9, 46.7, 1, 1, 0);
                yield return new Depredations(156, -94.3, 46.9, 1, 0, 1);
                yield return new Depredations(157, -94.4, 46.7, 1, 0, 1);
                yield return new Depredations(158, -95.4, 48.9, 1, 1, 0);
                yield return new Depredations(159, -94.6, 47.9, 3, 2, 1);
                yield return new Depredations(160, -94.5, 47, 1, 0, 1);
                yield return new Depredations(161, -96, 48.6, 1, 1, 0);
                yield return new Depredations(162, -95.8, 48.7, 17, 8, 9);
                yield return new Depredations(163, -95.4, 48.9, 2, 0, 2);
                yield return new Depredations(164, -95.7, 48.4, 2, 0, 2);
                yield return new Depredations(165, -94.5, 46.5, 5, 0, 5);
                yield return new Depredations(166, -93, 46.8, 1, 0, 1);
                yield return new Depredations(167, -92.6, 46.4, 3, 0, 3);
                yield return new Depredations(168, -92.3, 47.3, 1, 0, 1);
                yield return new Depredations(169, -92.9, 46.7, 2, 1, 1);
                yield return new Depredations(170, -92.9, 46.6, 2, 0, 2);
                yield return new Depredations(171, -96.7, 48.9, 1, 0, 1);
                yield return new Depredations(172, -92.9, 46.6, 1, 0, 1);
                yield return new Depredations(173, -94.5, 47.5, 1, 0, 1);
                yield return new Depredations(174, -94.6, 47.7, 1, 1, 0);
                yield return new Depredations(175, -92.1, 47, 3, 0, 3);
                yield return new Depredations(176, -93.1, 47.6, 1, 0, 1);
                yield return new Depredations(177, -95.5, 48.3, 1, 0, 1);
                yield return new Depredations(178, -94.3, 46.7, 1, 0, 1);
                yield return new Depredations(179, -95.1, 46.6, 1, 0, 1);
                yield return new Depredations(180, -94.5, 46.7, 1, 0, 1);
                yield return new Depredations(181, -95.9, 48.4, 1, 0, 1);
                yield return new Depredations(182, -96, 48.6, 1, 1, 0);
                yield return new Depredations(183, -94.2, 47.9, 2, 0, 2);
                yield return new Depredations(184, -94.7, 48, 1, 0, 1);
                yield return new Depredations(185, -92.5, 46.5, 1, 0, 1);
                yield return new Depredations(186, -93.5, 48.3, 1, 0, 1);
                yield return new Depredations(187, -94.9, 47.7, 1, 1, 0);
                yield return new Depredations(188, -92.8, 47.1, 3, 0, 3);
                yield return new Depredations(189, -95.5, 47.5, 2, 1, 1);
                yield return new Depredations(190, -92.5, 47.6, 1, 0, 1);
                yield return new Depredations(191, -93.7, 46.6, 2, 1, 1);
                yield return new Depredations(192, -94.3, 47.7, 1, 1, 0);
                yield return new Depredations(193, -94.7, 46.7, 1, 0, 1);
                yield return new Depredations(194, -94.8, 46.8, 1, 0, 1);
                yield return new Depredations(195, -94.6, 47.9, 1, 1, 0);
                yield return new Depredations(196, -92.8, 46.9, 1, 0, 1);
                yield return new Depredations(197, -92.9, 46.4, 1, 0, 1);
                yield return new Depredations(198, -94.3, 46.6, 4, 2, 2);
                yield return new Depredations(199, -92.9, 46.4, 1, 0, 1);
                yield return new Depredations(200, -96.6, 48.9, 3, 3, 0);
                yield return new Depredations(201, -96.5, 49, 1, 1, 0);
                yield return new Depredations(202, -92.2, 47.4, 2, 2, 0);
                yield return new Depredations(203, -94.2, 47.9, 1, 1, 0);
                yield return new Depredations(204, -94.4, 48.2, 2, 2, 0);
                yield return new Depredations(205, -94.5, 48.2, 10, 4, 6);
                yield return new Depredations(206, -95, 47.2, 1, 0, 1);
                yield return new Depredations(207, -96.7, 48.8, 1, 0, 1);
                yield return new Depredations(208, -95.7, 48.3, 1, 0, 1);
                yield return new Depredations(209, -91.4, 47.2, 2, 2, 0);
                yield return new Depredations(210, -94.1, 47, 1, 0, 1);
                yield return new Depredations(211, -93.3, 48.4, 3, 1, 2);
                yield return new Depredations(212, -95.5, 48.9, 2, 1, 1);
                yield return new Depredations(213, -94.2, 48, 1, 1, 0);
                yield return new Depredations(214, -94.5, 48.1, 9, 5, 4);
                yield return new Depredations(215, -94.5, 48.1, 1, 1, 0);
                yield return new Depredations(216, -96.5, 48.5, 1, 0, 1);
                yield return new Depredations(217, -93.1, 46.7, 1, 0, 1);
                yield return new Depredations(218, -95.6, 48.6, 2, 2, 0);
                yield return new Depredations(219, -96, 48.6, 4, 4, 0);
                yield return new Depredations(220, -95.1, 47.6, 1, 0, 1);
                yield return new Depredations(221, -95.5, 48.9, 3, 1, 2);
                yield return new Depredations(222, -94.5, 48.7, 3, 0, 3);
                yield return new Depredations(223, -93.6, 47.9, 1, 0, 1);
                yield return new Depredations(224, -94.4, 47.9, 14, 8, 6);
                yield return new Depredations(225, -94.3, 47.9, 1, 1, 0);
                yield return new Depredations(226, -94.4, 48, 10, 4, 6);
                yield return new Depredations(227, -95.8, 48.4, 4, 0, 4);
                yield return new Depredations(228, -94.1, 46.3, 1, 1, 0);
                yield return new Depredations(229, -96.8, 48.9, 2, 1, 1);
                yield return new Depredations(230, -95.3, 47, 1, 0, 1);
                yield return new Depredations(231, -95.4, 47.8, 3, 2, 1);
                yield return new Depredations(232, -92.9, 46.6, 1, 0, 1);
                yield return new Depredations(233, -93.5, 48.5, 1, 0, 1);
                yield return new Depredations(234, -93.9, 46, 3, 0, 3);
                yield return new Depredations(235, -94, 46, 1, 0, 1);
                yield return new Depredations(236, -94.6, 47.9, 1, 1, 0);
                yield return new Depredations(237, -94.8, 47.8, 2, 0, 2);
                yield return new Depredations(238, -95.5, 47.8, 6, 0, 6);
                yield return new Depredations(239, -93.3, 47.1, 5, 1, 4);
                yield return new Depredations(240, -93.8, 46.9, 2, 0, 2);
                yield return new Depredations(241, -91.9, 47.9, 1, 1, 0);
                yield return new Depredations(242, -93.7, 48.4, 1, 0, 1);
                yield return new Depredations(243, -94.9, 47.8, 1, 0, 1);
                yield return new Depredations(244, -94.9, 47.8, 1, 0, 1);
                yield return new Depredations(245, -93.3, 47, 2, 2, 0);
                yield return new Depredations(246, -95.1, 47.5, 5, 2, 3);
                yield return new Depredations(247, -95.9, 48.7, 1, 0, 1);
                yield return new Depredations(248, -95.5, 48.6, 1, 1, 0);
                yield return new Depredations(249, -94, 47.8, 3, 1, 2);
                yield return new Depredations(250, -94.7, 48, 1, 1, 0);
                yield return new Depredations(251, -94.4, 47.9, 1, 1, 0);
                yield return new Depredations(252, -94.6, 47.9, 1, 1, 0);
                yield return new Depredations(253, -96.4, 48.5, 1, 0, 1);
                yield return new Depredations(254, -95.8, 47.8, 1, 0, 1);
                yield return new Depredations(255, -92.6, 46.1, 5, 0, 5);
                yield return new Depredations(256, -96, 48.2, 1, 0, 1);
                yield return new Depredations(257, -92.3, 46.9, 3, 3, 0);
                yield return new Depredations(258, -95.6, 48.3, 2, 0, 2);
                yield return new Depredations(259, -95.6, 48.3, 1, 1, 0);
                yield return new Depredations(260, -95.7, 48.3, 1, 1, 0);
                yield return new Depredations(261, -95.4, 48.3, 2, 2, 0);
                yield return new Depredations(262, -95.4, 48.8, 2, 1, 1);
                yield return new Depredations(263, -93.7, 46.6, 1, 0, 1);
                yield return new Depredations(264, -94.7, 47.8, 2, 1, 1);
                yield return new Depredations(265, -94.3, 48, 1, 0, 1);
                yield return new Depredations(266, -96.6, 48.8, 1, 1, 0);
                yield return new Depredations(267, -92.6, 47, 1, 0, 1);
                yield return new Depredations(268, -95.9, 46.6, 1, 0, 1);
                yield return new Depredations(269, -92.9, 46.6, 1, 0, 1);
                yield return new Depredations(270, -92.6, 46.7, 2, 0, 2);
                yield return new Depredations(271, -96, 48.6, 5, 0, 5);
                yield return new Depredations(272, -93.4, 46.8, 1, 0, 1);
                yield return new Depredations(273, -96.6, 48.6, 1, 0, 1);
                yield return new Depredations(274, -94.9, 48.9, 3, 2, 1);
                yield return new Depredations(275, -95.1, 47.6, 1, 0, 1);
                yield return new Depredations(276, -92.5, 46.9, 1, 0, 1);
                yield return new Depredations(277, -92.3, 47.4, 1, 0, 1);
                yield return new Depredations(278, -93.1, 46, 1, 0, 1);
                yield return new Depredations(279, -95.8, 48.6, 4, 1, 3);
                yield return new Depredations(280, -93.6, 47.8, 1, 0, 1);
                yield return new Depredations(281, -93.6, 48.4, 1, 0, 1);
                yield return new Depredations(282, -93.6, 48.5, 1, 1, 0);
                yield return new Depredations(283, -92.7, 47, 1, 0, 1);
                yield return new Depredations(284, -94.9, 47.8, 2, 2, 0);
                yield return new Depredations(285, -94.6, 47.9, 1, 1, 0);
                yield return new Depredations(286, -92.7, 47.9, 1, 1, 0);
                yield return new Depredations(287, -92.8, 47.7, 2, 2, 0);
                yield return new Depredations(288, -93.9, 47.5, 2, 0, 2);
                yield return new Depredations(289, -94.6, 47.8, 1, 1, 0);
                yield return new Depredations(290, -95, 48.8, 1, 0, 1);
                yield return new Depredations(291, -94.8, 47.2, 1, 0, 1);
                yield return new Depredations(292, -95.3, 46.7, 1, 0, 1);
                yield return new Depredations(293, -94.5, 48.5, 1, 1, 0);
                yield return new Depredations(294, -92.8, 46.7, 2, 2, 0);
                yield return new Depredations(295, -93.1, 46.1, 1, 0, 1);
                yield return new Depredations(296, -95.3, 46.7, 1, 0, 1);
                yield return new Depredations(297, -95.9, 48.4, 4, 0, 4);
                yield return new Depredations(298, -95, 47.6, 4, 4, 0);
                yield return new Depredations(299, -95.3, 47.1, 3, 1, 2);
                yield return new Depredations(300, -95.4, 48.8, 5, 5, 0);
                yield return new Depredations(301, -93.6, 47.9, 1, 0, 1);
                yield return new Depredations(302, -92.7, 46.8, 1, 0, 1);
                yield return new Depredations(303, -93.4, 47, 1, 0, 1);
                yield return new Depredations(304, -93.7, 47.9, 1, 1, 0);
                yield return new Depredations(305, -94.6, 48, 1, 0, 1);
                yield return new Depredations(306, -95.8, 48.3, 2, 2, 0);
                yield return new Depredations(307, -93.6, 47.8, 13, 9, 4);
                yield return new Depredations(308, -96.5, 48.7, 5, 0, 5);
                yield return new Depredations(309, -93.2, 47.2, 14, 8, 6);
                yield return new Depredations(310, -91.9, 47, 2, 0, 2);
                yield return new Depredations(311, -93.8, 47, 1, 0, 1);
                yield return new Depredations(312, -94.1, 47.8, 2, 1, 1);
                yield return new Depredations(313, -93.6, 46.7, 1, 0, 1);
                yield return new Depredations(314, -94.7, 47.9, 1, 0, 1);
                yield return new Depredations(315, -92.8, 46.7, 1, 0, 1);
                yield return new Depredations(316, -94.7, 48.5, 1, 1, 0);
                yield return new Depredations(317, -95.4, 49, 1, 1, 0);
                yield return new Depredations(318, -92.8, 47.7, 2, 2, 0);
                yield return new Depredations(319, -93.2, 46.3, 6, 4, 2);
                yield return new Depredations(320, -95.2, 48.2, 3, 2, 1);
                yield return new Depredations(321, -94.6, 48.5, 1, 1, 0);
                yield return new Depredations(322, -94.6, 46.5, 1, 0, 1);
                yield return new Depredations(323, -93.5, 47.7, 1, 0, 1);
                yield return new Depredations(324, -96.3, 48.5, 1, 0, 1);
                yield return new Depredations(325, -92.9, 46.7, 1, 0, 1);
                yield return new Depredations(326, -94.8, 47.8, 2, 1, 1);
                yield return new Depredations(327, -93, 47.9, 1, 0, 1);
                yield return new Depredations(328, -93.8, 48.4, 6, 1, 5);
                yield return new Depredations(329, -92.6, 46.1, 1, 0, 1);
                yield return new Depredations(330, -95.6, 48.3, 1, 0, 1);
                yield return new Depredations(331, -93.6, 47.8, 3, 1, 2);
                yield return new Depredations(332, -91.2, 47.3, 1, 0, 1);
                yield return new Depredations(333, -92.9, 46.2, 1, 0, 1);
                yield return new Depredations(334, -92.3, 47.7, 3, 3, 0);
                yield return new Depredations(335, -95.6, 48.5, 3, 2, 1);
                yield return new Depredations(336, -95.2, 46.8, 1, 1, 0);
                yield return new Depredations(337, -94, 47.7, 2, 2, 0);
                yield return new Depredations(338, -93.8, 47.3, 1, 0, 1);
                yield return new Depredations(339, -95.8, 48.4, 1, 0, 1);
                yield return new Depredations(340, -94.3, 46.7, 3, 0, 3);
                yield return new Depredations(341, -94.2, 48, 4, 4, 0);
                yield return new Depredations(342, -93.5, 46.8, 3, 1, 2);
                yield return new Depredations(343, -94.7, 48, 1, 1, 0);
                yield return new Depredations(344, -96.4, 48.9, 26, 24, 2);
                yield return new Depredations(345, -92.7, 47.2, 4, 1, 3);
                yield return new Depredations(346, -95.7, 48.5, 1, 0, 1);
                yield return new Depredations(347, -92.8, 48, 3, 0, 3);
                yield return new Depredations(348, -95.1, 47.7, 2, 1, 1);
                yield return new Depredations(349, -95.6, 48.5, 1, 0, 1);
                yield return new Depredations(350, -94.2, 47.9, 1, 0, 1);
                yield return new Depredations(351, -92.2, 47.4, 1, 0, 1);
                yield return new Depredations(352, -93.5, 46.4, 2, 0, 2);
                yield return new Depredations(353, -95.6, 48.7, 2, 2, 0);
                yield return new Depredations(354, -94.1, 47.9, 1, 0, 1);
                yield return new Depredations(355, -95.8, 47.8, 1, 1, 0);
                yield return new Depredations(356, -94.6, 46.5, 1, 0, 1);
                yield return new Depredations(357, -95.5, 47.4, 1, 0, 1);
                yield return new Depredations(358, -95.4, 47.4, 1, 0, 1);
                yield return new Depredations(359, -96.6, 48.7, 1, 0, 1);
                yield return new Depredations(360, -93.6, 46.9, 1, 0, 1);
                yield return new Depredations(361, -93.8, 45.9, 1, 0, 1);
                yield return new Depredations(362, -93.3, 47.2, 1, 0, 1);
                yield return new Depredations(363, -95, 47.7, 1, 1, 0);
                yield return new Depredations(364, -96, 48.6, 1, 1, 0);
                yield return new Depredations(365, -96.2, 48.7, 2, 1, 1);
                yield return new Depredations(366, -96.9, 49, 1, 1, 0);
                yield return new Depredations(367, -95.2, 47.6, 1, 1, 0);
                yield return new Depredations(368, -94.7, 47.9, 1, 0, 1);
                yield return new Depredations(369, -96.5, 48.9, 2, 2, 0);
                yield return new Depredations(370, -92.8, 47.2, 1, 0, 1);
                yield return new Depredations(371, -92.5, 47.4, 2, 2, 0);
                yield return new Depredations(372, -95.4, 47.4, 2, 1, 1);
                yield return new Depredations(373, -95.4, 47.1, 3, 1, 2);
                yield return new Depredations(374, -96, 48.7, 1, 0, 1);
                yield return new Depredations(375, -94.2, 48, 2, 0, 2);
                yield return new Depredations(376, -94.2, 47.9, 1, 0, 1);
                yield return new Depredations(377, -94.5, 47.9, 1, 1, 0);
                yield return new Depredations(378, -92.8, 46.7, 1, 1, 0);
                yield return new Depredations(379, -92.7, 47.4, 2, 0, 2);
                yield return new Depredations(380, -95.6, 47.8, 1, 0, 1);
                yield return new Depredations(381, -94.5, 47.6, 4, 1, 3);
                yield return new Depredations(382, -95.9, 48.6, 2, 2, 0);
                yield return new Depredations(383, -95.9, 48.6, 3, 3, 0);
                yield return new Depredations(384, -96.6, 48.7, 1, 1, 0);
                yield return new Depredations(385, -94.2, 47.9, 1, 0, 1);
                yield return new Depredations(386, -94.5, 47.9, 2, 2, 0);
                yield return new Depredations(387, -93.1, 46.4, 1, 0, 1);
                yield return new Depredations(388, -94.4, 46.6, 1, 0, 1);
                yield return new Depredations(389, -93.9, 46, 3, 0, 3);
                yield return new Depredations(390, -94.8, 47.7, 1, 1, 0);
                yield return new Depredations(391, -95.2, 47.6, 1, 0, 1);
                yield return new Depredations(392, -93.6, 47.4, 3, 3, 0);
                yield return new Depredations(393, -92.3, 47.8, 1, 1, 0);
                yield return new Depredations(394, -94.5, 46.6, 1, 0, 1);
                yield return new Depredations(395, -93.6, 46.8, 1, 0, 1);
                yield return new Depredations(396, -94.5, 48, 2, 2, 0);
                yield return new Depredations(397, -94.4, 47.9, 4, 4, 0);
                yield return new Depredations(398, -94.4, 47.9, 1, 1, 0);
                yield return new Depredations(399, -94.2, 48, 1, 1, 0);
                yield return new Depredations(400, -93.6, 45.9, 1, 0, 1);
                yield return new Depredations(401, -92.6, 47.4, 2, 0, 2);
                yield return new Depredations(402, -93.8, 46.6, 1, 0, 1);
                yield return new Depredations(403, -94.7, 46.8, 1, 0, 1);
                yield return new Depredations(404, -93.6, 46.8, 4, 0, 4);
                yield return new Depredations(405, -93.8, 46.8, 2, 0, 2);
                yield return new Depredations(406, -94.2, 47.2, 2, 1, 1);
                yield return new Depredations(407, -93.5, 47.9, 12, 5, 7);
                yield return new Depredations(408, -94.8, 46.6, 2, 0, 2);
                yield return new Depredations(409, -95.9, 48.2, 1, 0, 1);
                yield return new Depredations(410, -94.5, 47.7, 1, 0, 1);
                yield return new Depredations(411, -94.5, 47.9, 5, 3, 2);
                yield return new Depredations(412, -96.5, 48.9, 5, 3, 2);
                yield return new Depredations(413, -94.6, 46.6, 1, 0, 1);
                yield return new Depredations(414, -93.5, 47.9, 1, 0, 1);
                yield return new Depredations(415, -92.1, 47, 2, 0, 2);
                yield return new Depredations(416, -93.5, 46.4, 5, 2, 3);
                yield return new Depredations(417, -93.6, 46.4, 1, 0, 1);
                yield return new Depredations(418, -94.6, 47.3, 1, 0, 1);
                yield return new Depredations(419, -94.5, 46.6, 2, 0, 2);
                yield return new Depredations(420, -94.3, 46.8, 2, 0, 2);
                yield return new Depredations(421, -95.4, 46.8, 1, 0, 1);
                yield return new Depredations(422, -93.5, 46.7, 2, 0, 2);
                yield return new Depredations(423, -93.8, 47.2, 1, 0, 1);
                yield return new Depredations(424, -92.6, 46.5, 1, 0, 1);
                yield return new Depredations(425, -94.1, 47.8, 2, 1, 1);
                yield return new Depredations(426, -95.8, 47.8, 1, 1, 0);
                yield return new Depredations(427, -96, 48.6, 6, 1, 5);
                yield return new Depredations(428, -92.9, 47.8, 1, 0, 1);
                yield return new Depredations(429, -93.9, 48.5, 1, 0, 1);
                yield return new Depredations(430, -94.8, 47.9, 1, 0, 1);
                yield return new Depredations(431, -94.8, 47.8, 2, 2, 0);
                yield return new Depredations(432, -96.6, 48.8, 4, 1, 3);
                yield return new Depredations(433, -92.8, 47.8, 3, 2, 1);
                yield return new Depredations(434, -92.6, 46.3, 1, 0, 1);
            }
        }
    }
}
