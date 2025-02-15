// ReSharper disable All

namespace Rdatasets.gap
{
    using System.Collections.Generic;

    /// <summary>
    /// APOE/APOC1 markers and Alzheimer's
    /// </summary>

    public class apoeapoc
    {
        public readonly int κ;
        public readonly int id;
        public readonly int y;
        public readonly int sex;
        public readonly int age;
        public readonly int apoe_a1;
        public readonly int apoe_a2;
        public readonly int apoc_a1;
        public readonly int apoc_a2;

        public apoeapoc(int κ, int id, int y, int sex, int age, int apoe_a1, int apoe_a2, int apoc_a1, int apoc_a2)
        {
            this.κ = κ;
            this.id = id;
            this.y = y;
            this.sex = sex;
            this.age = age;
            this.apoe_a1 = apoe_a1;
            this.apoe_a2 = apoe_a2;
            this.apoc_a1 = apoc_a1;
            this.apoc_a2 = apoc_a2;
        }

        public static IEnumerable<apoeapoc> Data
        {
            get
            {
                yield return new apoeapoc(1, 1, 2, 2, 67, 3, 3, 1, 1);
                yield return new apoeapoc(2, 2, 2, 1, 64, 3, 3, 1, 1);
                yield return new apoeapoc(3, 3, 2, 2, 71, 3, 3, 1, 2);
                yield return new apoeapoc(4, 4, 2, 1, 80, 3, 3, 1, 1);
                yield return new apoeapoc(5, 5, 2, 2, 79, 3, 3, 1, 1);
                yield return new apoeapoc(6, 6, 2, 2, 80, 3, 3, 1, 1);
                yield return new apoeapoc(7, 7, 2, 2, 65, 3, 3, 1, 1);
                yield return new apoeapoc(8, 8, 2, 2, 61, 3, 3, 1, 1);
                yield return new apoeapoc(9, 9, 2, 2, 71, 3, 3, 1, 1);
                yield return new apoeapoc(10, 10, 2, 2, 66, 3, 3, 1, 2);
                yield return new apoeapoc(11, 11, 2, 2, 79, 3, 3, 1, 1);
                yield return new apoeapoc(12, 12, 2, 1, 66, 3, 3, 1, 1);
                yield return new apoeapoc(13, 13, 2, 2, 65, 3, 3, 1, 1);
                yield return new apoeapoc(14, 14, 2, 2, 73, 3, 3, 1, 1);
                yield return new apoeapoc(15, 15, 2, 2, 79, 3, 3, 1, 1);
                yield return new apoeapoc(16, 16, 2, 2, 75, 3, 3, 1, 1);
                yield return new apoeapoc(17, 17, 2, 2, 70, 3, 3, 1, 1);
                yield return new apoeapoc(18, 18, 2, 2, 83, 3, 3, 1, 1);
                yield return new apoeapoc(19, 19, 2, 2, 78, 3, 3, 1, 2);
                yield return new apoeapoc(20, 20, 2, 1, 84, 3, 3, 1, 1);
                yield return new apoeapoc(21, 21, 2, 2, 75, 3, 3, 1, 1);
                yield return new apoeapoc(22, 22, 2, 2, 80, 3, 3, 1, 2);
                yield return new apoeapoc(23, 23, 2, 2, 78, 3, 3, 1, 1);
                yield return new apoeapoc(24, 24, 2, 2, 83, 3, 3, 1, 1);
                yield return new apoeapoc(25, 25, 2, 1, 80, 3, 3, 1, 1);
                yield return new apoeapoc(26, 26, 2, 2, 88, 3, 3, 1, 2);
                yield return new apoeapoc(27, 27, 2, 1, 85, 3, 3, 1, 2);
                yield return new apoeapoc(28, 28, 2, 2, 93, 3, 3, 1, 1);
                yield return new apoeapoc(29, 29, 2, 2, 78, 3, 3, 1, 1);
                yield return new apoeapoc(30, 30, 2, 1, 83, 3, 3, 1, 1);
                yield return new apoeapoc(31, 31, 2, 2, 82, 3, 3, 1, 2);
                yield return new apoeapoc(32, 32, 2, 1, 88, 3, 3, 1, 1);
                yield return new apoeapoc(33, 33, 2, 1, 89, 3, 3, 1, 2);
                yield return new apoeapoc(34, 34, 2, 1, 84, 3, 3, 1, 1);
                yield return new apoeapoc(35, 35, 2, 1, 90, 3, 3, 1, 1);
                yield return new apoeapoc(36, 36, 2, 2, 85, 3, 3, 1, 1);
                yield return new apoeapoc(37, 37, 2, 2, 70, 3, 3, 1, 1);
                yield return new apoeapoc(38, 38, 2, 2, 75, 3, 3, 1, 2);
                yield return new apoeapoc(39, 39, 2, 1, 82, 3, 3, 1, 1);
                yield return new apoeapoc(40, 40, 2, 1, 71, 3, 3, 1, 1);
                yield return new apoeapoc(41, 41, 2, 1, 75, 3, 3, 1, 1);
                yield return new apoeapoc(42, 42, 2, 1, 64, 3, 3, 1, 1);
                yield return new apoeapoc(43, 43, 2, 2, 80, 3, 3, 1, 1);
                yield return new apoeapoc(44, 44, 2, 2, 83, 3, 3, 1, 2);
                yield return new apoeapoc(45, 45, 2, 2, 67, 3, 3, 1, 2);
                yield return new apoeapoc(46, 46, 2, 2, 84, 3, 3, 1, 1);
                yield return new apoeapoc(47, 47, 2, 2, 65, 3, 3, 1, 1);
                yield return new apoeapoc(48, 48, 2, 1, 68, 3, 3, 1, 1);
                yield return new apoeapoc(49, 49, 2, 2, 98, 3, 3, 1, 1);
                yield return new apoeapoc(50, 50, 2, 2, 77, 3, 3, 1, 2);
                yield return new apoeapoc(51, 51, 2, 2, 90, 3, 3, 1, 1);
                yield return new apoeapoc(52, 52, 2, 2, 74, 3, 3, 1, 1);
                yield return new apoeapoc(53, 53, 2, 1, 69, 3, 3, 1, 1);
                yield return new apoeapoc(54, 54, 2, 2, 91, 3, 3, 1, 2);
                yield return new apoeapoc(55, 55, 2, 2, 67, 3, 3, 1, 2);
                yield return new apoeapoc(56, 56, 2, 1, 82, 3, 3, 1, 2);
                yield return new apoeapoc(57, 57, 0, 1, 89, 3, 3, 1, 2);
                yield return new apoeapoc(58, 58, 0, 1, 84, 3, 3, 1, 1);
                yield return new apoeapoc(59, 59, 0, 1, 90, 3, 3, 1, 2);
                yield return new apoeapoc(60, 60, 0, 1, 74, 3, 3, 1, 1);
                yield return new apoeapoc(61, 61, 0, 2, 73, 3, 3, 1, 1);
                yield return new apoeapoc(62, 62, 0, 1, 75, 3, 3, 1, 1);
                yield return new apoeapoc(63, 63, 0, 2, 85, 3, 3, 1, 1);
                yield return new apoeapoc(64, 64, 0, 2, 76, 3, 3, 1, 1);
                yield return new apoeapoc(65, 65, 0, 1, 99, 3, 3, 1, 2);
                yield return new apoeapoc(66, 66, 0, 2, 89, 3, 3, 1, 1);
                yield return new apoeapoc(67, 67, 0, 1, 82, 3, 3, 1, 1);
                yield return new apoeapoc(68, 68, 0, 2, 75, 3, 3, 1, 1);
                yield return new apoeapoc(69, 69, 0, 1, 87, 3, 3, 1, 1);
                yield return new apoeapoc(70, 70, 0, 2, 85, 3, 3, 1, 2);
                yield return new apoeapoc(71, 71, 0, 2, 88, 3, 3, 1, 1);
                yield return new apoeapoc(72, 72, 0, 1, 74, 3, 3, 1, 2);
                yield return new apoeapoc(73, 73, 0, 2, 82, 3, 3, 1, 2);
                yield return new apoeapoc(74, 74, 0, 1, 76, 3, 3, 1, 1);
                yield return new apoeapoc(75, 75, 0, 2, 82, 3, 3, 1, 1);
                yield return new apoeapoc(76, 76, 0, 1, 83, 3, 3, 1, 1);
                yield return new apoeapoc(77, 77, 0, 2, 85, 3, 3, 1, 1);
                yield return new apoeapoc(78, 78, 0, 2, 75, 3, 3, 1, 2);
                yield return new apoeapoc(79, 79, 0, 2, 94, 3, 3, 1, 1);
                yield return new apoeapoc(80, 80, 0, 1, 82, 3, 3, 1, 1);
                yield return new apoeapoc(81, 81, 0, 2, 91, 3, 3, 1, 1);
                yield return new apoeapoc(82, 82, 0, 2, 85, 3, 3, 1, 1);
                yield return new apoeapoc(83, 83, 0, 1, 87, 3, 3, 1, 2);
                yield return new apoeapoc(84, 84, 0, 1, 86, 3, 3, 1, 1);
                yield return new apoeapoc(85, 85, 0, 2, 79, 3, 3, 1, 1);
                yield return new apoeapoc(86, 86, 0, 2, 75, 3, 3, 1, 1);
                yield return new apoeapoc(87, 87, 0, 2, 90, 3, 3, 1, 1);
                yield return new apoeapoc(88, 88, 0, 1, 76, 3, 3, 1, 1);
                yield return new apoeapoc(89, 89, 0, 2, 76, 3, 3, 1, 2);
                yield return new apoeapoc(90, 90, 0, 1, 80, 3, 3, 1, 1);
                yield return new apoeapoc(91, 91, 0, 2, 94, 3, 3, 1, 2);
                yield return new apoeapoc(92, 92, 0, 1, 91, 3, 3, 1, 1);
                yield return new apoeapoc(93, 93, 0, 1, 65, 3, 3, 1, 1);
                yield return new apoeapoc(94, 94, 0, 1, 76, 3, 3, 1, 2);
                yield return new apoeapoc(95, 95, 0, 2, 84, 3, 3, 1, 1);
                yield return new apoeapoc(96, 96, 0, 2, 88, 3, 3, 1, 1);
                yield return new apoeapoc(97, 97, 0, 2, 68, 3, 3, 1, 1);
                yield return new apoeapoc(98, 98, 0, 1, 77, 3, 3, 1, 1);
                yield return new apoeapoc(99, 99, 0, 1, 79, 3, 3, 1, 1);
                yield return new apoeapoc(100, 100, 0, 2, 81, 3, 3, 1, 1);
                yield return new apoeapoc(101, 101, 0, 1, 79, 3, 3, 1, 1);
                yield return new apoeapoc(102, 102, 0, 2, 71, 3, 3, 1, 1);
                yield return new apoeapoc(103, 103, 0, 2, 84, 3, 3, 1, 1);
                yield return new apoeapoc(104, 104, 0, 1, 71, 3, 3, 1, 2);
                yield return new apoeapoc(105, 105, 0, 1, 84, 3, 3, 1, 2);
                yield return new apoeapoc(106, 106, 0, 1, 81, 3, 3, 1, 1);
                yield return new apoeapoc(107, 107, 0, 1, 79, 3, 3, 1, 1);
                yield return new apoeapoc(108, 108, 0, 2, 76, 3, 3, 1, 2);
                yield return new apoeapoc(109, 109, 0, 1, 75, 3, 3, 1, 1);
                yield return new apoeapoc(110, 110, 0, 2, 73, 3, 3, 1, 1);
                yield return new apoeapoc(111, 111, 0, 1, 82, 3, 3, 1, 1);
                yield return new apoeapoc(112, 112, 0, 2, 76, 3, 3, 1, 1);
                yield return new apoeapoc(113, 113, 0, 1, 88, 3, 3, 1, 1);
                yield return new apoeapoc(114, 114, 0, 2, 71, 3, 3, 1, 1);
                yield return new apoeapoc(115, 115, 0, 1, 90, 3, 3, 1, 2);
                yield return new apoeapoc(116, 116, 0, 2, 83, 3, 3, 1, 1);
                yield return new apoeapoc(117, 117, 0, 1, 71, 3, 3, 1, 2);
                yield return new apoeapoc(118, 118, 0, 2, 77, 3, 3, 1, 1);
                yield return new apoeapoc(119, 119, 0, 1, 78, 3, 3, 1, 1);
                yield return new apoeapoc(120, 120, 0, 2, 75, 3, 3, 1, 1);
                yield return new apoeapoc(121, 121, 0, 1, 78, 3, 3, 1, 2);
                yield return new apoeapoc(122, 122, 0, 1, 84, 3, 3, 1, 1);
                yield return new apoeapoc(123, 123, 0, 2, 74, 3, 3, 1, 1);
                yield return new apoeapoc(124, 124, 0, 1, 91, 3, 3, 1, 1);
                yield return new apoeapoc(125, 125, 0, 2, 80, 3, 3, 1, 2);
                yield return new apoeapoc(126, 126, 0, 1, 81, 3, 3, 1, 1);
                yield return new apoeapoc(127, 127, 0, 1, 91, 3, 3, 1, 2);
                yield return new apoeapoc(128, 128, 0, 2, 73, 3, 3, 1, 2);
                yield return new apoeapoc(129, 129, 0, 2, 81, 3, 3, 1, 1);
                yield return new apoeapoc(130, 130, 0, 2, 84, 3, 3, 1, 1);
                yield return new apoeapoc(131, 131, 0, 1, 87, 3, 3, 1, 1);
                yield return new apoeapoc(132, 132, 0, 1, 79, 3, 3, 1, 1);
                yield return new apoeapoc(133, 133, 0, 1, 72, 3, 3, 1, 1);
                yield return new apoeapoc(134, 134, 0, 2, 88, 3, 3, 1, 1);
                yield return new apoeapoc(135, 135, 0, 2, 80, 3, 3, 1, 2);
                yield return new apoeapoc(136, 136, 0, 2, 83, 3, 3, 1, 2);
                yield return new apoeapoc(137, 137, 0, 2, 77, 3, 3, 1, 1);
                yield return new apoeapoc(138, 138, 0, 2, 94, 3, 3, 1, 1);
                yield return new apoeapoc(139, 139, 0, 2, 73, 3, 3, 1, 2);
                yield return new apoeapoc(140, 140, 0, 2, 81, 3, 3, 1, 2);
                yield return new apoeapoc(141, 141, 0, 2, 69, 3, 3, 1, 1);
                yield return new apoeapoc(142, 142, 0, 2, 71, 3, 3, 1, 1);
                yield return new apoeapoc(143, 143, 0, 2, 82, 3, 3, 1, 1);
                yield return new apoeapoc(144, 144, 0, 2, 79, 3, 3, 1, 2);
                yield return new apoeapoc(145, 145, 0, 2, 70, 3, 3, 1, 2);
                yield return new apoeapoc(146, 146, 0, 1, 75, 3, 3, 1, 1);
                yield return new apoeapoc(147, 147, 0, 2, 78, 3, 3, 1, 2);
                yield return new apoeapoc(148, 148, 0, 1, 73, 3, 3, 1, 2);
                yield return new apoeapoc(149, 149, 0, 2, 81, 3, 3, 1, 1);
                yield return new apoeapoc(150, 150, 0, 1, 83, 3, 3, 1, 1);
                yield return new apoeapoc(151, 151, 0, 2, 64, 3, 3, 1, 2);
                yield return new apoeapoc(152, 152, 0, 1, 82, 3, 3, 1, 1);
                yield return new apoeapoc(153, 153, 0, 2, 66, 3, 3, 1, 1);
                yield return new apoeapoc(154, 154, 0, 1, 76, 3, 3, 1, 2);
                yield return new apoeapoc(155, 155, 0, 1, 67, 3, 3, 1, 2);
                yield return new apoeapoc(156, 156, 0, 1, 65, 3, 3, 1, 1);
                yield return new apoeapoc(157, 157, 0, 1, 80, 3, 3, 1, 2);
                yield return new apoeapoc(158, 158, 0, 2, 88, 3, 3, 1, 1);
                yield return new apoeapoc(159, 159, 0, 2, 70, 3, 3, 1, 1);
                yield return new apoeapoc(160, 160, 0, 1, 88, 3, 3, 1, 1);
                yield return new apoeapoc(161, 161, 0, 2, 69, 3, 3, 1, 1);
                yield return new apoeapoc(162, 162, 0, 2, 88, 3, 3, 1, 1);
                yield return new apoeapoc(163, 163, 0, 1, 91, 3, 3, 1, 1);
                yield return new apoeapoc(164, 164, 0, 1, 83, 3, 3, 1, 1);
                yield return new apoeapoc(165, 165, 0, 2, 82, 3, 3, 1, 1);
                yield return new apoeapoc(166, 166, 0, 1, 83, 3, 3, 1, 1);
                yield return new apoeapoc(167, 167, 0, 2, 92, 3, 3, 1, 2);
                yield return new apoeapoc(168, 168, 0, 1, 65, 3, 3, 1, 2);
                yield return new apoeapoc(169, 169, 0, 2, 85, 3, 3, 1, 1);
                yield return new apoeapoc(170, 170, 0, 2, 87, 3, 3, 1, 1);
                yield return new apoeapoc(171, 171, 0, 2, 66, 3, 3, 1, 1);
                yield return new apoeapoc(172, 172, 0, 1, 68, 3, 3, 1, 1);
                yield return new apoeapoc(173, 173, 0, 2, 86, 3, 3, 1, 2);
                yield return new apoeapoc(174, 174, 0, 2, 69, 3, 3, 1, 2);
                yield return new apoeapoc(175, 175, 0, 1, 69, 3, 3, 1, 1);
                yield return new apoeapoc(176, 176, 0, 2, 78, 3, 3, 1, 1);
                yield return new apoeapoc(177, 177, 0, 1, 82, 3, 3, 1, 1);
                yield return new apoeapoc(178, 178, 0, 2, 71, 3, 3, 1, 1);
                yield return new apoeapoc(179, 179, 0, 1, 80, 3, 3, 1, 1);
                yield return new apoeapoc(180, 180, 0, 2, 91, 3, 3, 1, 1);
                yield return new apoeapoc(181, 181, 0, 2, 59, 3, 3, 1, 1);
                yield return new apoeapoc(182, 182, 0, 1, 85, 3, 3, 1, 1);
                yield return new apoeapoc(183, 183, 0, 1, 84, 3, 3, 1, 1);
                yield return new apoeapoc(184, 184, 0, 2, 89, 3, 3, 1, 1);
                yield return new apoeapoc(185, 185, 0, 1, 81, 3, 3, 1, 1);
                yield return new apoeapoc(186, 186, 0, 2, 88, 3, 3, 1, 1);
                yield return new apoeapoc(187, 187, 0, 2, 81, 3, 3, 1, 1);
                yield return new apoeapoc(188, 188, 0, 1, 86, 3, 3, 1, 1);
                yield return new apoeapoc(189, 189, 0, 1, 84, 3, 3, 1, 1);
                yield return new apoeapoc(190, 190, 0, 1, 75, 3, 3, 1, 1);
                yield return new apoeapoc(191, 191, 0, 1, 80, 3, 3, 1, 1);
                yield return new apoeapoc(192, 192, 0, 1, 82, 3, 3, 1, 1);
                yield return new apoeapoc(193, 193, 0, 1, 84, 3, 3, 1, 1);
                yield return new apoeapoc(194, 194, 0, 1, 75, 3, 3, 1, 1);
                yield return new apoeapoc(195, 195, 0, 1, 71, 3, 3, 1, 1);
                yield return new apoeapoc(196, 196, 0, 2, 79, 3, 3, 1, 1);
                yield return new apoeapoc(197, 197, 0, 2, 96, 3, 3, 1, 1);
                yield return new apoeapoc(198, 198, 0, 2, 85, 3, 3, 1, 1);
                yield return new apoeapoc(199, 199, 0, 1, 89, 3, 3, 1, 1);
                yield return new apoeapoc(200, 200, 0, 1, 92, 3, 3, 1, 1);
                yield return new apoeapoc(201, 201, 0, 1, 84, 3, 3, 1, 2);
                yield return new apoeapoc(202, 202, 0, 1, 79, 3, 3, 1, 1);
                yield return new apoeapoc(203, 203, 0, 2, 86, 3, 3, 1, 1);
                yield return new apoeapoc(204, 204, 0, 2, 92, 3, 3, 1, 1);
                yield return new apoeapoc(205, 205, 0, 2, 86, 3, 3, 1, 1);
                yield return new apoeapoc(206, 206, 0, 2, 80, 3, 3, 1, 1);
                yield return new apoeapoc(207, 207, 0, 1, 83, 3, 3, 1, 1);
                yield return new apoeapoc(208, 208, 0, 2, 71, 3, 3, 1, 1);
                yield return new apoeapoc(209, 209, 0, 1, 79, 3, 3, 1, 1);
                yield return new apoeapoc(210, 210, 0, 1, 76, 3, 3, 1, 1);
                yield return new apoeapoc(211, 211, 0, 2, 89, 3, 3, 1, 1);
                yield return new apoeapoc(212, 212, 0, 2, 80, 3, 3, 1, 1);
                yield return new apoeapoc(213, 213, 0, 2, 82, 3, 3, 1, 1);
                yield return new apoeapoc(214, 214, 0, 2, 72, 3, 3, 1, 1);
                yield return new apoeapoc(215, 215, 0, 1, 86, 3, 3, 1, 1);
                yield return new apoeapoc(216, 216, 0, 1, 89, 3, 3, 1, 1);
                yield return new apoeapoc(217, 217, 0, 1, 71, 3, 3, 1, 1);
                yield return new apoeapoc(218, 218, 0, 2, 93, 3, 3, 1, 1);
                yield return new apoeapoc(219, 219, 2, 1, 69, 2, 3, 1, 2);
                yield return new apoeapoc(220, 220, 2, 2, 72, 2, 3, 1, 2);
                yield return new apoeapoc(221, 221, 2, 2, 71, 2, 3, 1, 2);
                yield return new apoeapoc(222, 222, 2, 2, 89, 2, 3, 1, 2);
                yield return new apoeapoc(223, 223, 2, 2, 73, 2, 3, 1, 2);
                yield return new apoeapoc(224, 224, 2, 1, 85, 2, 3, 1, 2);
                yield return new apoeapoc(225, 225, 2, 1, 75, 2, 3, 1, 2);
                yield return new apoeapoc(226, 226, 2, 1, 89, 2, 3, 1, 2);
                yield return new apoeapoc(227, 227, 2, 2, 63, 2, 3, 1, 2);
                yield return new apoeapoc(228, 228, 2, 2, 93, 2, 3, 1, 2);
                yield return new apoeapoc(229, 229, 2, 1, 87, 2, 3, 1, 2);
                yield return new apoeapoc(230, 230, 2, 2, 87, 2, 3, 1, 1);
                yield return new apoeapoc(231, 231, 2, 2, 89, 2, 3, 1, 2);
                yield return new apoeapoc(232, 232, 2, 1, 66, 2, 3, 1, 2);
                yield return new apoeapoc(233, 233, 2, 1, 76, 2, 3, 1, 2);
                yield return new apoeapoc(234, 234, 2, 2, 69, 2, 3, 1, 2);
                yield return new apoeapoc(235, 235, 0, 2, 82, 2, 3, 1, 2);
                yield return new apoeapoc(236, 236, 0, 1, 73, 2, 3, 1, 2);
                yield return new apoeapoc(237, 237, 0, 2, 83, 2, 3, 2, 2);
                yield return new apoeapoc(238, 238, 0, 1, 74, 2, 3, 1, 2);
                yield return new apoeapoc(239, 239, 0, 1, 69, 2, 3, 1, 1);
                yield return new apoeapoc(240, 240, 0, 1, 76, 2, 3, 1, 2);
                yield return new apoeapoc(241, 241, 0, 2, 86, 2, 3, 1, 1);
                yield return new apoeapoc(242, 242, 0, 1, 82, 2, 3, 1, 1);
                yield return new apoeapoc(243, 243, 0, 2, 79, 2, 3, 1, 2);
                yield return new apoeapoc(244, 244, 0, 2, 80, 2, 3, 1, 2);
                yield return new apoeapoc(245, 245, 0, 2, 79, 2, 3, 1, 1);
                yield return new apoeapoc(246, 246, 0, 2, 87, 2, 3, 1, 2);
                yield return new apoeapoc(247, 247, 0, 1, 76, 2, 3, 1, 1);
                yield return new apoeapoc(248, 248, 0, 2, 73, 2, 3, 2, 2);
                yield return new apoeapoc(249, 249, 0, 2, 92, 2, 3, 1, 2);
                yield return new apoeapoc(250, 250, 0, 2, 84, 2, 3, 1, 1);
                yield return new apoeapoc(251, 251, 0, 1, 69, 2, 3, 1, 2);
                yield return new apoeapoc(252, 252, 0, 2, 78, 2, 3, 1, 2);
                yield return new apoeapoc(253, 253, 0, 1, 82, 2, 3, 1, 2);
                yield return new apoeapoc(254, 254, 0, 2, 85, 2, 3, 1, 2);
                yield return new apoeapoc(255, 255, 0, 2, 78, 2, 3, 1, 1);
                yield return new apoeapoc(256, 256, 0, 1, 77, 2, 3, 1, 2);
                yield return new apoeapoc(257, 257, 0, 2, 89, 2, 3, 1, 2);
                yield return new apoeapoc(258, 258, 0, 1, 79, 2, 3, 1, 2);
                yield return new apoeapoc(259, 259, 0, 2, 77, 2, 3, 1, 2);
                yield return new apoeapoc(260, 260, 0, 1, 89, 2, 3, 1, 2);
                yield return new apoeapoc(261, 261, 0, 1, 85, 2, 3, 1, 2);
                yield return new apoeapoc(262, 262, 0, 2, 88, 2, 3, 1, 1);
                yield return new apoeapoc(263, 263, 0, 2, 86, 2, 3, 1, 2);
                yield return new apoeapoc(264, 264, 0, 1, 79, 2, 3, 1, 2);
                yield return new apoeapoc(265, 265, 0, 2, 98, 2, 3, 2, 2);
                yield return new apoeapoc(266, 266, 0, 2, 94, 2, 3, 1, 2);
                yield return new apoeapoc(267, 267, 0, 1, 88, 2, 3, 1, 2);
                yield return new apoeapoc(268, 268, 0, 1, 87, 2, 3, 1, 2);
                yield return new apoeapoc(269, 269, 0, 2, 84, 2, 3, 1, 2);
                yield return new apoeapoc(270, 270, 0, 1, 67, 2, 3, 1, 2);
                yield return new apoeapoc(271, 271, 0, 2, 84, 2, 3, 1, 2);
                yield return new apoeapoc(272, 272, 2, 2, 83, 3, 4, 1, 1);
                yield return new apoeapoc(273, 273, 2, 1, 81, 3, 4, 1, 2);
                yield return new apoeapoc(274, 274, 2, 2, 82, 3, 4, 1, 2);
                yield return new apoeapoc(275, 275, 2, 2, 63, 3, 4, 1, 1);
                yield return new apoeapoc(276, 276, 2, 2, 70, 3, 4, 1, 2);
                yield return new apoeapoc(277, 277, 2, 2, 72, 3, 4, 1, 2);
                yield return new apoeapoc(278, 278, 2, 2, 69, 3, 4, 1, 2);
                yield return new apoeapoc(279, 279, 2, 2, 72, 3, 4, 1, 2);
                yield return new apoeapoc(280, 280, 2, 1, 72, 3, 4, 1, 2);
                yield return new apoeapoc(281, 281, 2, 2, 71, 3, 4, 1, 1);
                yield return new apoeapoc(282, 282, 2, 1, 86, 3, 4, 2, 2);
                yield return new apoeapoc(283, 283, 2, 2, 83, 3, 4, 1, 1);
                yield return new apoeapoc(284, 284, 2, 2, 91, 3, 4, 1, 2);
                yield return new apoeapoc(285, 285, 2, 2, 90, 3, 4, 1, 2);
                yield return new apoeapoc(286, 286, 2, 2, 96, 3, 4, 1, 2);
                yield return new apoeapoc(287, 287, 2, 2, 88, 3, 4, 1, 1);
                yield return new apoeapoc(288, 288, 2, 2, 78, 3, 4, 1, 1);
                yield return new apoeapoc(289, 289, 2, 2, 92, 3, 4, 1, 1);
                yield return new apoeapoc(290, 290, 2, 2, 87, 3, 4, 1, 2);
                yield return new apoeapoc(291, 291, 2, 1, 82, 3, 4, 1, 2);
                yield return new apoeapoc(292, 292, 2, 1, 66, 3, 4, 1, 2);
                yield return new apoeapoc(293, 293, 2, 2, 96, 3, 4, 1, 1);
                yield return new apoeapoc(294, 294, 2, 2, 95, 3, 4, 1, 1);
                yield return new apoeapoc(295, 295, 2, 2, 82, 3, 4, 1, 2);
                yield return new apoeapoc(296, 296, 2, 1, 78, 3, 4, 1, 2);
                yield return new apoeapoc(297, 297, 2, 2, 75, 3, 4, 1, 2);
                yield return new apoeapoc(298, 298, 2, 2, 74, 3, 4, 1, 2);
                yield return new apoeapoc(299, 299, 2, 2, 85, 3, 4, 1, 2);
                yield return new apoeapoc(300, 300, 2, 2, 79, 3, 4, 1, 2);
                yield return new apoeapoc(301, 301, 2, 2, 77, 3, 4, 1, 1);
                yield return new apoeapoc(302, 302, 0, 2, 76, 3, 4, 1, 1);
                yield return new apoeapoc(303, 303, 0, 2, 87, 3, 4, 1, 1);
                yield return new apoeapoc(304, 304, 0, 2, 64, 3, 4, 1, 1);
                yield return new apoeapoc(305, 305, 0, 1, 82, 3, 4, 1, 2);
                yield return new apoeapoc(306, 306, 0, 1, 71, 3, 4, 1, 2);
                yield return new apoeapoc(307, 307, 0, 1, 88, 3, 4, 1, 2);
                yield return new apoeapoc(308, 308, 0, 2, 75, 3, 4, 1, 2);
                yield return new apoeapoc(309, 309, 0, 2, 67, 3, 4, 1, 2);
                yield return new apoeapoc(310, 310, 0, 2, 80, 3, 4, 1, 2);
                yield return new apoeapoc(311, 311, 0, 1, 76, 3, 4, 1, 2);
                yield return new apoeapoc(312, 312, 0, 2, 77, 3, 4, 1, 2);
                yield return new apoeapoc(313, 313, 0, 2, 65, 3, 4, 1, 2);
                yield return new apoeapoc(314, 314, 0, 1, 79, 3, 4, 1, 2);
                yield return new apoeapoc(315, 315, 0, 2, 80, 3, 4, 1, 1);
                yield return new apoeapoc(316, 316, 0, 1, 66, 3, 4, 1, 1);
                yield return new apoeapoc(317, 317, 0, 2, 68, 3, 4, 1, 2);
                yield return new apoeapoc(318, 318, 0, 1, 71, 3, 4, 1, 1);
                yield return new apoeapoc(319, 319, 0, 2, 83, 3, 4, 1, 1);
                yield return new apoeapoc(320, 320, 0, 2, 65, 3, 4, 1, 2);
                yield return new apoeapoc(321, 321, 0, 1, 78, 3, 4, 1, 2);
                yield return new apoeapoc(322, 322, 0, 2, 87, 3, 4, 1, 2);
                yield return new apoeapoc(323, 323, 0, 1, 81, 3, 4, 1, 2);
                yield return new apoeapoc(324, 324, 0, 2, 71, 3, 4, 1, 2);
                yield return new apoeapoc(325, 325, 0, 1, 74, 3, 4, 1, 2);
                yield return new apoeapoc(326, 326, 0, 2, 82, 3, 4, 1, 1);
                yield return new apoeapoc(327, 327, 0, 2, 88, 3, 4, 1, 2);
                yield return new apoeapoc(328, 328, 0, 1, 77, 3, 4, 1, 1);
                yield return new apoeapoc(329, 329, 0, 1, 78, 3, 4, 1, 1);
                yield return new apoeapoc(330, 330, 0, 1, 63, 3, 4, 1, 1);
                yield return new apoeapoc(331, 331, 0, 1, 80, 3, 4, 1, 1);
                yield return new apoeapoc(332, 332, 0, 2, 81, 3, 4, 1, 1);
                yield return new apoeapoc(333, 333, 2, 2, 69, 2, 4, 2, 2);
                yield return new apoeapoc(334, 334, 2, 2, 80, 2, 4, 2, 2);
                yield return new apoeapoc(335, 335, 0, 2, 72, 2, 4, 2, 2);
                yield return new apoeapoc(336, 336, 0, 1, 81, 2, 4, 1, 2);
                yield return new apoeapoc(337, 337, 0, 2, 83, 2, 4, 1, 2);
                yield return new apoeapoc(338, 338, 0, 2, 82, 2, 4, 1, 2);
                yield return new apoeapoc(339, 339, 0, 1, 86, 2, 4, 1, 2);
                yield return new apoeapoc(340, 340, 0, 1, 76, 2, 4, 1, 2);
                yield return new apoeapoc(341, 341, 2, 2, 73, 4, 4, 2, 2);
                yield return new apoeapoc(342, 342, 2, 2, 65, 4, 4, 2, 2);
                yield return new apoeapoc(343, 343, 2, 2, 70, 4, 4, 2, 2);
                yield return new apoeapoc(344, 344, 2, 1, 72, 4, 4, 2, 2);
                yield return new apoeapoc(345, 345, 2, 2, 86, 4, 4, 2, 2);
                yield return new apoeapoc(346, 346, 2, 2, 72, 4, 4, 2, 2);
                yield return new apoeapoc(347, 347, 0, 2, 65, 4, 4, 2, 2);
                yield return new apoeapoc(348, 348, 2, 2, 86, 2, 2, 1, 2);
                yield return new apoeapoc(349, 349, 0, 2, 74, 2, 2, 1, 2);
                yield return new apoeapoc(350, 350, 0, 1, 71, 2, 2, 1, 1);
                yield return new apoeapoc(351, 351, 0, 2, 81, 2, 2, 1, 1);
                yield return new apoeapoc(352, 352, 0, 1, 88, 2, 2, 1, 1);
                yield return new apoeapoc(353, 353, 0, 1, 95, 2, 2, 1, 1);
            }
        }
    }
}
