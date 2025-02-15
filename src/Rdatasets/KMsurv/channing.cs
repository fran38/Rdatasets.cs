// ReSharper disable All

namespace Rdatasets.KMsurv
{
    using System.Collections.Generic;

    /// <summary>
    /// data from Section 1.16
    /// </summary>

    public class channing
    {
        public readonly int κ;
        public readonly int obs;
        public readonly int death;
        public readonly int ageentry;
        public readonly int age;
        public readonly int time;
        public readonly int gender;

        public channing(int κ, int obs, int death, int ageentry, int age, int time, int gender)
        {
            this.κ = κ;
            this.obs = obs;
            this.death = death;
            this.ageentry = ageentry;
            this.age = age;
            this.time = time;
            this.gender = gender;
        }

        public static IEnumerable<channing> Data
        {
            get
            {
                yield return new channing(1, 1, 1, 1042, 1172, 130, 2);
                yield return new channing(2, 2, 1, 921, 1040, 119, 2);
                yield return new channing(3, 3, 1, 885, 1003, 118, 2);
                yield return new channing(4, 4, 1, 901, 1018, 117, 2);
                yield return new channing(5, 5, 1, 808, 932, 124, 2);
                yield return new channing(6, 6, 1, 915, 1004, 89, 2);
                yield return new channing(7, 7, 1, 901, 1023, 122, 2);
                yield return new channing(8, 8, 1, 852, 908, 56, 2);
                yield return new channing(9, 9, 1, 828, 868, 40, 2);
                yield return new channing(10, 10, 1, 968, 990, 22, 2);
                yield return new channing(11, 11, 1, 936, 1033, 97, 2);
                yield return new channing(12, 12, 1, 977, 1056, 79, 2);
                yield return new channing(13, 13, 1, 929, 999, 70, 2);
                yield return new channing(14, 14, 1, 936, 1064, 128, 2);
                yield return new channing(15, 15, 1, 1016, 1122, 106, 2);
                yield return new channing(16, 16, 1, 910, 1020, 110, 2);
                yield return new channing(17, 17, 1, 1140, 1200, 60, 2);
                yield return new channing(18, 18, 1, 1015, 1056, 41, 2);
                yield return new channing(19, 19, 1, 850, 940, 90, 2);
                yield return new channing(20, 20, 1, 895, 996, 101, 2);
                yield return new channing(21, 21, 1, 854, 969, 115, 2);
                yield return new channing(22, 22, 1, 957, 1089, 132, 2);
                yield return new channing(23, 23, 1, 1013, 1115, 102, 2);
                yield return new channing(24, 24, 1, 1073, 1192, 119, 2);
                yield return new channing(25, 25, 1, 976, 1085, 109, 2);
                yield return new channing(26, 26, 1, 872, 976, 104, 2);
                yield return new channing(27, 27, 1, 1027, 1142, 115, 2);
                yield return new channing(28, 28, 1, 1071, 1200, 129, 2);
                yield return new channing(29, 29, 1, 919, 1017, 98, 2);
                yield return new channing(30, 30, 1, 894, 1006, 112, 2);
                yield return new channing(31, 31, 1, 885, 1012, 127, 2);
                yield return new channing(32, 32, 1, 889, 1000, 111, 2);
                yield return new channing(33, 33, 1, 887, 1012, 125, 2);
                yield return new channing(34, 34, 1, 920, 1040, 120, 2);
                yield return new channing(35, 35, 1, 1015, 1024, 9, 2);
                yield return new channing(36, 36, 1, 942, 1070, 128, 2);
                yield return new channing(37, 37, 1, 924, 1014, 90, 2);
                yield return new channing(38, 38, 1, 883, 996, 113, 2);
                yield return new channing(39, 39, 1, 930, 944, 14, 2);
                yield return new channing(40, 40, 1, 956, 1085, 129, 2);
                yield return new channing(41, 41, 1, 886, 994, 108, 2);
                yield return new channing(42, 42, 1, 987, 1097, 110, 2);
                yield return new channing(43, 43, 1, 883, 966, 83, 2);
                yield return new channing(44, 44, 1, 837, 948, 111, 2);
                yield return new channing(45, 45, 1, 958, 1029, 71, 2);
                yield return new channing(46, 46, 1, 850, 963, 113, 2);
                yield return new channing(47, 47, 1, 890, 905, 15, 2);
                yield return new channing(48, 48, 1, 847, 970, 123, 2);
                yield return new channing(49, 49, 1, 919, 1015, 96, 2);
                yield return new channing(50, 50, 1, 748, 804, 56, 2);
                yield return new channing(51, 51, 1, 934, 1041, 107, 2);
                yield return new channing(52, 52, 1, 895, 991, 96, 2);
                yield return new channing(53, 53, 1, 874, 982, 108, 2);
                yield return new channing(54, 54, 1, 877, 989, 112, 2);
                yield return new channing(55, 55, 1, 900, 959, 59, 2);
                yield return new channing(56, 56, 1, 957, 1084, 127, 2);
                yield return new channing(57, 57, 1, 1013, 1131, 118, 2);
                yield return new channing(58, 58, 1, 967, 1068, 101, 2);
                yield return new channing(59, 59, 0, 904, 919, 15, 2);
                yield return new channing(60, 60, 0, 829, 848, 19, 2);
                yield return new channing(61, 61, 0, 842, 979, 137, 2);
                yield return new channing(62, 62, 0, 802, 876, 74, 2);
                yield return new channing(63, 63, 0, 840, 938, 98, 2);
                yield return new channing(64, 64, 0, 792, 929, 137, 2);
                yield return new channing(65, 65, 0, 837, 848, 11, 2);
                yield return new channing(66, 66, 0, 941, 1006, 65, 2);
                yield return new channing(67, 67, 0, 746, 804, 58, 2);
                yield return new channing(68, 68, 0, 834, 932, 98, 2);
                yield return new channing(69, 69, 0, 865, 932, 67, 2);
                yield return new channing(70, 70, 0, 828, 965, 137, 2);
                yield return new channing(71, 71, 0, 894, 1011, 117, 2);
                yield return new channing(72, 72, 0, 874, 1011, 137, 2);
                yield return new channing(73, 73, 0, 917, 1054, 137, 2);
                yield return new channing(74, 74, 0, 993, 1028, 35, 2);
                yield return new channing(75, 75, 0, 918, 1055, 137, 2);
                yield return new channing(76, 76, 0, 818, 955, 137, 2);
                yield return new channing(77, 77, 0, 984, 1019, 35, 2);
                yield return new channing(78, 78, 0, 1002, 1010, 8, 2);
                yield return new channing(79, 79, 0, 857, 994, 137, 2);
                yield return new channing(80, 80, 0, 827, 836, 9, 2);
                yield return new channing(81, 81, 0, 883, 1020, 137, 2);
                yield return new channing(82, 82, 0, 1008, 1042, 34, 2);
                yield return new channing(83, 83, 0, 954, 1091, 137, 2);
                yield return new channing(84, 84, 0, 905, 1042, 137, 2);
                yield return new channing(85, 85, 0, 838, 975, 137, 2);
                yield return new channing(86, 86, 0, 934, 946, 12, 2);
                yield return new channing(87, 87, 0, 872, 940, 68, 2);
                yield return new channing(88, 88, 0, 918, 922, 4, 2);
                yield return new channing(89, 89, 0, 844, 981, 137, 2);
                yield return new channing(90, 90, 0, 805, 928, 123, 2);
                yield return new channing(91, 91, 0, 922, 1059, 137, 2);
                yield return new channing(92, 92, 0, 821, 958, 137, 2);
                yield return new channing(93, 93, 0, 838, 975, 137, 2);
                yield return new channing(94, 94, 0, 934, 961, 27, 2);
                yield return new channing(95, 95, 0, 886, 1023, 137, 2);
                yield return new channing(96, 96, 0, 934, 1023, 89, 2);
                yield return new channing(97, 97, 0, 878, 1010, 132, 2);
                yield return new channing(98, 98, 0, 935, 1072, 137, 2);
                yield return new channing(99, 99, 0, 799, 825, 26, 2);
                yield return new channing(100, 100, 0, 849, 952, 103, 2);
                yield return new channing(101, 101, 0, 920, 953, 33, 2);
                yield return new channing(102, 102, 1, 948, 998, 50, 2);
                yield return new channing(103, 103, 0, 968, 1105, 137, 2);
                yield return new channing(104, 104, 0, 908, 996, 88, 2);
                yield return new channing(105, 105, 0, 828, 965, 137, 2);
                yield return new channing(106, 106, 0, 897, 1034, 137, 2);
                yield return new channing(107, 107, 0, 823, 938, 115, 2);
                yield return new channing(108, 108, 0, 950, 1008, 58, 2);
                yield return new channing(109, 109, 0, 1049, 1186, 137, 2);
                yield return new channing(110, 110, 0, 878, 1015, 137, 2);
                yield return new channing(111, 111, 0, 854, 991, 137, 2);
                yield return new channing(112, 112, 0, 877, 1014, 137, 2);
                yield return new channing(113, 113, 0, 820, 955, 135, 2);
                yield return new channing(114, 114, 0, 899, 1036, 137, 2);
                yield return new channing(115, 115, 0, 855, 893, 38, 2);
                yield return new channing(116, 116, 0, 827, 964, 137, 2);
                yield return new channing(117, 117, 0, 925, 960, 35, 2);
                yield return new channing(118, 118, 0, 900, 1037, 137, 2);
                yield return new channing(119, 119, 0, 935, 948, 13, 2);
                yield return new channing(120, 120, 0, 1005, 1053, 48, 2);
                yield return new channing(121, 121, 0, 855, 992, 137, 2);
                yield return new channing(122, 122, 0, 920, 992, 72, 2);
                yield return new channing(123, 123, 0, 810, 895, 85, 2);
                yield return new channing(124, 124, 0, 792, 857, 65, 2);
                yield return new channing(125, 125, 0, 882, 1019, 37, 2);
                yield return new channing(126, 126, 0, 934, 1071, 137, 2);
                yield return new channing(127, 127, 0, 910, 1047, 137, 2);
                yield return new channing(128, 128, 0, 865, 973, 110, 2);
                yield return new channing(129, 129, 0, 899, 1036, 137, 2);
                yield return new channing(130, 130, 0, 982, 1119, 137, 2);
                yield return new channing(131, 131, 0, 856, 993, 137, 2);
                yield return new channing(132, 132, 0, 961, 963, 2, 2);
                yield return new channing(133, 133, 0, 893, 1030, 137, 2);
                yield return new channing(134, 134, 0, 861, 998, 137, 2);
                yield return new channing(135, 135, 0, 829, 932, 103, 2);
                yield return new channing(136, 136, 0, 882, 1019, 137, 2);
                yield return new channing(137, 137, 0, 875, 1012, 137, 2);
                yield return new channing(138, 138, 0, 833, 970, 137, 2);
                yield return new channing(139, 139, 0, 972, 1013, 41, 2);
                yield return new channing(140, 140, 0, 807, 944, 137, 2);
                yield return new channing(141, 141, 0, 924, 959, 35, 2);
                yield return new channing(142, 142, 0, 845, 982, 137, 2);
                yield return new channing(143, 143, 0, 840, 977, 137, 2);
                yield return new channing(144, 144, 0, 867, 1004, 137, 2);
                yield return new channing(145, 145, 0, 881, 913, 32, 2);
                yield return new channing(146, 146, 0, 901, 917, 16, 2);
                yield return new channing(147, 147, 0, 944, 947, 3, 2);
                yield return new channing(148, 148, 0, 821, 824, 3, 2);
                yield return new channing(149, 149, 0, 811, 898, 87, 2);
                yield return new channing(150, 150, 0, 1007, 1014, 7, 2);
                yield return new channing(151, 151, 0, 912, 1049, 137, 2);
                yield return new channing(152, 152, 0, 802, 939, 137, 2);
                yield return new channing(153, 153, 0, 928, 1065, 137, 2);
                yield return new channing(154, 154, 0, 911, 938, 27, 2);
                yield return new channing(155, 155, 0, 847, 899, 52, 2);
                yield return new channing(156, 156, 0, 1035, 1172, 137, 2);
                yield return new channing(157, 157, 0, 893, 973, 80, 2);
                yield return new channing(158, 158, 0, 922, 971, 49, 2);
                yield return new channing(159, 159, 0, 977, 985, 8, 2);
                yield return new channing(160, 160, 0, 941, 944, 3, 2);
                yield return new channing(161, 161, 0, 869, 1006, 137, 2);
                yield return new channing(162, 162, 0, 885, 955, 70, 2);
                yield return new channing(163, 163, 0, 859, 996, 137, 2);
                yield return new channing(164, 164, 0, 948, 1085, 137, 2);
                yield return new channing(165, 165, 0, 890, 1005, 115, 2);
                yield return new channing(166, 166, 0, 887, 891, 4, 2);
                yield return new channing(167, 167, 0, 968, 1105, 137, 2);
                yield return new channing(168, 168, 0, 927, 989, 62, 2);
                yield return new channing(169, 169, 0, 997, 1134, 137, 2);
                yield return new channing(170, 170, 0, 846, 983, 137, 2);
                yield return new channing(171, 171, 0, 831, 861, 30, 2);
                yield return new channing(172, 172, 0, 842, 979, 137, 2);
                yield return new channing(173, 173, 0, 768, 905, 137, 2);
                yield return new channing(174, 174, 0, 896, 1033, 137, 2);
                yield return new channing(175, 175, 0, 894, 1014, 120, 2);
                yield return new channing(176, 176, 0, 885, 1022, 137, 2);
                yield return new channing(177, 177, 0, 822, 959, 137, 2);
                yield return new channing(178, 178, 0, 927, 954, 27, 2);
                yield return new channing(179, 179, 0, 897, 904, 7, 2);
                yield return new channing(180, 180, 0, 848, 985, 137, 2);
                yield return new channing(181, 181, 0, 912, 1001, 89, 2);
                yield return new channing(182, 182, 0, 863, 1000, 137, 2);
                yield return new channing(183, 183, 0, 813, 950, 137, 2);
                yield return new channing(184, 184, 0, 802, 939, 137, 2);
                yield return new channing(185, 185, 0, 956, 1061, 105, 2);
                yield return new channing(186, 186, 0, 822, 945, 123, 2);
                yield return new channing(187, 187, 0, 934, 993, 59, 2);
                yield return new channing(188, 188, 0, 1026, 1054, 28, 2);
                yield return new channing(189, 189, 0, 981, 1114, 133, 2);
                yield return new channing(190, 190, 0, 934, 1071, 137, 2);
                yield return new channing(191, 191, 0, 836, 927, 91, 2);
                yield return new channing(192, 192, 0, 760, 897, 137, 2);
                yield return new channing(193, 193, 0, 820, 957, 137, 2);
                yield return new channing(194, 194, 0, 907, 1044, 137, 2);
                yield return new channing(195, 195, 0, 979, 1016, 37, 2);
                yield return new channing(196, 196, 0, 894, 1031, 137, 2);
                yield return new channing(197, 197, 0, 852, 989, 137, 2);
                yield return new channing(198, 198, 0, 948, 971, 23, 2);
                yield return new channing(199, 199, 0, 813, 950, 137, 2);
                yield return new channing(200, 200, 0, 902, 1024, 122, 2);
                yield return new channing(201, 201, 0, 882, 1019, 137, 2);
                yield return new channing(202, 202, 0, 815, 952, 137, 2);
                yield return new channing(203, 203, 1, 972, 1083, 111, 2);
                yield return new channing(204, 204, 0, 973, 985, 12, 2);
                yield return new channing(205, 205, 0, 957, 957, 0, 2);
                yield return new channing(206, 206, 0, 1010, 1147, 137, 2);
                yield return new channing(207, 207, 0, 1070, 1207, 137, 2);
                yield return new channing(208, 208, 0, 895, 1032, 137, 2);
                yield return new channing(209, 209, 0, 818, 860, 42, 2);
                yield return new channing(210, 210, 0, 864, 1001, 137, 2);
                yield return new channing(211, 211, 0, 857, 994, 137, 2);
                yield return new channing(212, 212, 0, 1028, 1063, 35, 2);
                yield return new channing(213, 213, 0, 892, 1029, 137, 2);
                yield return new channing(214, 214, 0, 769, 906, 137, 2);
                yield return new channing(215, 215, 0, 883, 1020, 137, 2);
                yield return new channing(216, 216, 0, 972, 1109, 137, 2);
                yield return new channing(217, 217, 0, 965, 1088, 123, 2);
                yield return new channing(218, 218, 0, 925, 961, 36, 2);
                yield return new channing(219, 219, 0, 814, 872, 58, 2);
                yield return new channing(220, 220, 0, 805, 942, 137, 2);
                yield return new channing(221, 221, 0, 992, 1010, 18, 2);
                yield return new channing(222, 222, 0, 943, 1080, 137, 2);
                yield return new channing(223, 223, 0, 951, 958, 7, 2);
                yield return new channing(224, 224, 0, 926, 987, 61, 2);
                yield return new channing(225, 225, 0, 954, 962, 8, 2);
                yield return new channing(226, 226, 0, 944, 944, 0, 2);
                yield return new channing(227, 227, 0, 935, 935, 0, 2);
                yield return new channing(228, 228, 0, 900, 912, 12, 2);
                yield return new channing(229, 229, 0, 762, 854, 92, 2);
                yield return new channing(230, 230, 0, 823, 882, 59, 2);
                yield return new channing(231, 231, 1, 978, 1010, 32, 2);
                yield return new channing(232, 232, 1, 966, 1027, 61, 2);
                yield return new channing(233, 233, 0, 912, 916, 4, 2);
                yield return new channing(234, 234, 0, 823, 829, 6, 2);
                yield return new channing(235, 235, 0, 909, 933, 24, 2);
                yield return new channing(236, 236, 1, 967, 1041, 74, 2);
                yield return new channing(237, 237, 1, 851, 905, 54, 2);
                yield return new channing(238, 238, 1, 843, 861, 18, 2);
                yield return new channing(239, 239, 1, 963, 1021, 58, 2);
                yield return new channing(240, 240, 1, 888, 919, 31, 2);
                yield return new channing(241, 241, 0, 794, 798, 4, 2);
                yield return new channing(242, 242, 1, 905, 928, 23, 2);
                yield return new channing(243, 243, 1, 1039, 1086, 47, 2);
                yield return new channing(244, 244, 1, 901, 923, 22, 2);
                yield return new channing(245, 245, 1, 823, 830, 7, 2);
                yield return new channing(246, 246, 1, 809, 822, 13, 2);
                yield return new channing(247, 247, 0, 887, 905, 18, 2);
                yield return new channing(248, 248, 1, 859, 926, 67, 2);
                yield return new channing(249, 249, 0, 1004, 1015, 11, 2);
                yield return new channing(250, 250, 1, 919, 931, 12, 2);
                yield return new channing(251, 251, 0, 913, 1050, 137, 2);
                yield return new channing(252, 252, 0, 810, 812, 2, 2);
                yield return new channing(253, 253, 0, 841, 978, 137, 2);
                yield return new channing(254, 254, 0, 875, 1012, 137, 2);
                yield return new channing(255, 255, 0, 841, 927, 86, 2);
                yield return new channing(256, 256, 0, 948, 1012, 64, 2);
                yield return new channing(257, 257, 1, 859, 995, 136, 2);
                yield return new channing(258, 258, 0, 820, 957, 137, 2);
                yield return new channing(259, 259, 0, 860, 997, 137, 2);
                yield return new channing(260, 260, 0, 917, 948, 31, 2);
                yield return new channing(261, 261, 0, 936, 1073, 137, 2);
                yield return new channing(262, 262, 0, 950, 986, 36, 2);
                yield return new channing(263, 263, 0, 1013, 1031, 18, 2);
                yield return new channing(264, 264, 0, 847, 984, 137, 2);
                yield return new channing(265, 265, 0, 777, 914, 137, 2);
                yield return new channing(266, 266, 0, 960, 988, 28, 2);
                yield return new channing(267, 267, 0, 920, 1057, 137, 2);
                yield return new channing(268, 268, 0, 935, 1051, 116, 2);
                yield return new channing(269, 269, 0, 933, 979, 46, 2);
                yield return new channing(270, 270, 0, 933, 985, 52, 2);
                yield return new channing(271, 271, 0, 797, 934, 137, 2);
                yield return new channing(272, 272, 0, 733, 870, 137, 2);
                yield return new channing(273, 273, 0, 866, 953, 87, 2);
                yield return new channing(274, 274, 0, 870, 930, 60, 2);
                yield return new channing(275, 275, 0, 795, 875, 80, 2);
                yield return new channing(276, 276, 1, 905, 1005, 100, 2);
                yield return new channing(277, 277, 0, 796, 891, 95, 2);
                yield return new channing(278, 278, 0, 965, 1102, 137, 2);
                yield return new channing(279, 279, 0, 775, 912, 137, 2);
                yield return new channing(280, 280, 0, 942, 977, 35, 2);
                yield return new channing(281, 281, 0, 895, 926, 31, 2);
                yield return new channing(282, 282, 0, 981, 1038, 57, 2);
                yield return new channing(283, 283, 0, 991, 1006, 15, 2);
                yield return new channing(284, 284, 0, 894, 918, 24, 2);
                yield return new channing(285, 285, 0, 886, 943, 57, 2);
                yield return new channing(286, 286, 0, 871, 924, 53, 2);
                yield return new channing(287, 287, 0, 839, 976, 137, 2);
                yield return new channing(288, 288, 0, 839, 976, 137, 2);
                yield return new channing(289, 289, 0, 858, 995, 137, 2);
                yield return new channing(290, 290, 0, 830, 967, 137, 2);
                yield return new channing(291, 291, 0, 868, 1005, 137, 2);
                yield return new channing(292, 292, 0, 831, 925, 94, 2);
                yield return new channing(293, 293, 0, 783, 888, 105, 2);
                yield return new channing(294, 294, 0, 925, 1062, 137, 2);
                yield return new channing(295, 295, 0, 898, 1035, 137, 2);
                yield return new channing(296, 296, 0, 910, 1009, 99, 2);
                yield return new channing(297, 297, 0, 958, 1008, 50, 2);
                yield return new channing(298, 298, 0, 866, 1003, 137, 2);
                yield return new channing(299, 299, 0, 851, 988, 137, 2);
                yield return new channing(300, 300, 0, 906, 1043, 137, 2);
                yield return new channing(301, 301, 1, 958, 1041, 83, 2);
                yield return new channing(302, 302, 1, 1003, 1093, 90, 2);
                yield return new channing(303, 303, 1, 871, 944, 73, 2);
                yield return new channing(304, 304, 1, 864, 873, 9, 2);
                yield return new channing(305, 305, 1, 996, 1073, 77, 2);
                yield return new channing(306, 306, 1, 1034, 1068, 34, 2);
                yield return new channing(307, 307, 1, 873, 897, 24, 2);
                yield return new channing(308, 308, 1, 984, 1047, 63, 2);
                yield return new channing(309, 309, 1, 943, 1011, 68, 2);
                yield return new channing(310, 310, 1, 1007, 1019, 12, 2);
                yield return new channing(311, 311, 1, 935, 1006, 71, 2);
                yield return new channing(312, 312, 1, 929, 996, 67, 2);
                yield return new channing(313, 313, 1, 939, 978, 39, 2);
                yield return new channing(314, 314, 1, 772, 840, 68, 2);
                yield return new channing(315, 315, 0, 871, 912, 41, 2);
                yield return new channing(316, 316, 1, 873, 954, 81, 2);
                yield return new channing(317, 317, 1, 981, 1018, 37, 2);
                yield return new channing(318, 318, 0, 894, 927, 33, 2);
                yield return new channing(319, 319, 1, 994, 1040, 46, 2);
                yield return new channing(320, 320, 1, 976, 995, 19, 2);
                yield return new channing(321, 321, 1, 847, 883, 36, 2);
                yield return new channing(322, 322, 1, 859, 941, 82, 2);
                yield return new channing(323, 323, 1, 933, 990, 57, 2);
                yield return new channing(324, 324, 1, 861, 934, 73, 2);
                yield return new channing(325, 325, 1, 886, 908, 22, 2);
                yield return new channing(326, 326, 1, 943, 986, 43, 2);
                yield return new channing(327, 327, 1, 931, 969, 38, 2);
                yield return new channing(328, 328, 1, 948, 1019, 71, 2);
                yield return new channing(329, 329, 1, 955, 992, 37, 2);
                yield return new channing(330, 330, 1, 1004, 1023, 19, 2);
                yield return new channing(331, 331, 1, 828, 895, 67, 2);
                yield return new channing(332, 332, 1, 835, 845, 10, 2);
                yield return new channing(333, 333, 0, 868, 870, 2, 2);
                yield return new channing(334, 334, 1, 988, 1074, 86, 2);
                yield return new channing(335, 335, 1, 861, 930, 69, 2);
                yield return new channing(336, 336, 0, 959, 976, 17, 2);
                yield return new channing(337, 337, 1, 859, 912, 53, 2);
                yield return new channing(338, 338, 0, 871, 874, 3, 2);
                yield return new channing(339, 339, 0, 847, 892, 45, 2);
                yield return new channing(340, 340, 1, 874, 885, 11, 2);
                yield return new channing(341, 341, 1, 992, 1044, 52, 2);
                yield return new channing(342, 342, 1, 1027, 1072, 45, 2);
                yield return new channing(343, 343, 1, 857, 901, 44, 2);
                yield return new channing(344, 344, 1, 994, 1013, 19, 2);
                yield return new channing(345, 345, 1, 1041, 1043, 2, 2);
                yield return new channing(346, 346, 0, 900, 926, 26, 2);
                yield return new channing(347, 347, 1, 1096, 1152, 56, 2);
                yield return new channing(348, 348, 1, 930, 936, 6, 2);
                yield return new channing(349, 349, 1, 943, 994, 51, 2);
                yield return new channing(350, 350, 1, 1024, 1063, 39, 2);
                yield return new channing(351, 351, 0, 802, 821, 19, 2);
                yield return new channing(352, 352, 0, 811, 819, 8, 2);
                yield return new channing(353, 353, 1, 927, 1001, 74, 2);
                yield return new channing(354, 354, 1, 967, 975, 8, 2);
                yield return new channing(355, 355, 1, 943, 982, 39, 2);
                yield return new channing(356, 356, 0, 840, 905, 65, 2);
                yield return new channing(357, 357, 1, 979, 1040, 61, 2);
                yield return new channing(358, 358, 0, 921, 926, 5, 2);
                yield return new channing(359, 359, 1, 986, 1030, 44, 2);
                yield return new channing(360, 360, 1, 1039, 1132, 93, 2);
                yield return new channing(361, 361, 1, 968, 990, 22, 2);
                yield return new channing(362, 362, 1, 955, 990, 35, 2);
                yield return new channing(363, 363, 1, 837, 911, 74, 2);
                yield return new channing(364, 364, 1, 861, 915, 54, 2);
                yield return new channing(365, 365, 1, 967, 983, 16, 2);
                yield return new channing(366, 366, 1, 782, 909, 127, 1);
                yield return new channing(367, 367, 1, 1020, 1128, 108, 1);
                yield return new channing(368, 368, 1, 856, 969, 113, 1);
                yield return new channing(369, 369, 1, 915, 957, 42, 1);
                yield return new channing(370, 370, 1, 863, 983, 120, 1);
                yield return new channing(371, 371, 1, 906, 1012, 106, 1);
                yield return new channing(372, 372, 1, 955, 1055, 100, 1);
                yield return new channing(373, 373, 1, 943, 1025, 82, 1);
                yield return new channing(374, 374, 1, 943, 1043, 100, 1);
                yield return new channing(375, 375, 1, 837, 945, 108, 1);
                yield return new channing(376, 376, 1, 966, 1009, 43, 1);
                yield return new channing(377, 377, 1, 936, 971, 35, 1);
                yield return new channing(378, 378, 1, 919, 1033, 114, 1);
                yield return new channing(379, 379, 1, 852, 869, 17, 1);
                yield return new channing(380, 380, 1, 1073, 1139, 66, 1);
                yield return new channing(381, 381, 1, 925, 1036, 111, 1);
                yield return new channing(382, 382, 1, 967, 1085, 118, 1);
                yield return new channing(383, 383, 0, 806, 943, 137, 1);
                yield return new channing(384, 384, 0, 969, 1001, 32, 1);
                yield return new channing(385, 385, 0, 923, 1060, 137, 1);
                yield return new channing(386, 386, 0, 865, 1002, 137, 1);
                yield return new channing(387, 387, 0, 953, 1031, 78, 1);
                yield return new channing(388, 388, 0, 871, 945, 74, 1);
                yield return new channing(389, 389, 0, 982, 1006, 24, 1);
                yield return new channing(390, 390, 0, 883, 959, 76, 1);
                yield return new channing(391, 391, 0, 817, 843, 26, 1);
                yield return new channing(392, 392, 0, 875, 1012, 137, 1);
                yield return new channing(393, 393, 0, 821, 956, 135, 1);
                yield return new channing(394, 394, 0, 936, 1073, 137, 1);
                yield return new channing(395, 395, 0, 971, 1107, 136, 1);
                yield return new channing(396, 396, 0, 830, 940, 110, 1);
                yield return new channing(397, 397, 0, 885, 911, 26, 1);
                yield return new channing(398, 398, 0, 894, 1031, 137, 1);
                yield return new channing(399, 399, 0, 893, 996, 103, 1);
                yield return new channing(400, 400, 0, 866, 895, 29, 1);
                yield return new channing(401, 401, 0, 878, 1015, 137, 1);
                yield return new channing(402, 402, 0, 820, 957, 137, 1);
                yield return new channing(403, 403, 0, 1007, 1043, 36, 1);
                yield return new channing(404, 404, 0, 879, 1016, 137, 1);
                yield return new channing(405, 405, 0, 956, 1093, 137, 1);
                yield return new channing(406, 406, 1, 854, 989, 135, 1);
                yield return new channing(407, 407, 0, 890, 1027, 137, 1);
                yield return new channing(408, 408, 0, 1041, 1044, 3, 1);
                yield return new channing(409, 409, 0, 978, 1005, 27, 1);
                yield return new channing(410, 410, 0, 836, 973, 137, 1);
                yield return new channing(411, 411, 0, 938, 1064, 126, 1);
                yield return new channing(412, 412, 0, 886, 1023, 137, 1);
                yield return new channing(413, 413, 0, 876, 1013, 137, 1);
                yield return new channing(414, 414, 0, 955, 977, 22, 1);
                yield return new channing(415, 415, 0, 823, 960, 137, 1);
                yield return new channing(416, 416, 0, 960, 1047, 87, 1);
                yield return new channing(417, 417, 0, 843, 943, 100, 1);
                yield return new channing(418, 418, 0, 856, 951, 95, 1);
                yield return new channing(419, 419, 0, 847, 984, 137, 1);
                yield return new channing(420, 420, 0, 1027, 1058, 31, 1);
                yield return new channing(421, 421, 0, 988, 1045, 57, 1);
                yield return new channing(422, 422, 0, 953, 953, 0, 1);
                yield return new channing(423, 423, 0, 978, 1018, 40, 1);
                yield return new channing(424, 424, 0, 981, 1118, 137, 1);
                yield return new channing(425, 425, 0, 926, 970, 44, 1);
                yield return new channing(426, 426, 0, 1036, 1070, 34, 1);
                yield return new channing(427, 427, 0, 1016, 1153, 137, 1);
                yield return new channing(428, 428, 0, 969, 1106, 137, 1);
                yield return new channing(429, 429, 0, 900, 936, 36, 1);
                yield return new channing(430, 430, 0, 898, 906, 8, 1);
                yield return new channing(431, 431, 0, 846, 866, 20, 1);
                yield return new channing(432, 432, 1, 964, 1029, 65, 1);
                yield return new channing(433, 433, 1, 984, 1053, 69, 1);
                yield return new channing(434, 434, 1, 1046, 1080, 34, 1);
                yield return new channing(435, 435, 1, 871, 872, 1, 1);
                yield return new channing(436, 436, 1, 847, 893, 46, 1);
                yield return new channing(437, 437, 0, 962, 966, 4, 1);
                yield return new channing(438, 438, 1, 853, 894, 41, 1);
                yield return new channing(439, 439, 1, 967, 985, 18, 1);
                yield return new channing(440, 440, 1, 1063, 1094, 31, 1);
                yield return new channing(441, 441, 1, 856, 927, 71, 1);
                yield return new channing(442, 442, 1, 865, 948, 83, 1);
                yield return new channing(443, 443, 1, 1051, 1059, 8, 1);
                yield return new channing(444, 444, 1, 1010, 1012, 2, 1);
                yield return new channing(445, 445, 1, 878, 911, 33, 1);
                yield return new channing(446, 446, 1, 1021, 1094, 73, 1);
                yield return new channing(447, 447, 0, 959, 972, 13, 1);
                yield return new channing(448, 448, 1, 921, 993, 72, 1);
                yield return new channing(449, 449, 1, 836, 876, 40, 1);
                yield return new channing(450, 450, 1, 919, 993, 74, 1);
                yield return new channing(451, 451, 1, 751, 777, 26, 1);
                yield return new channing(452, 452, 1, 906, 966, 60, 1);
                yield return new channing(453, 453, 1, 835, 907, 72, 1);
                yield return new channing(454, 454, 1, 946, 1031, 85, 1);
                yield return new channing(455, 455, 1, 759, 781, 22, 1);
                yield return new channing(456, 456, 0, 909, 914, 5, 1);
                yield return new channing(457, 457, 1, 962, 998, 36, 1);
                yield return new channing(458, 458, 1, 984, 1022, 38, 1);
                yield return new channing(459, 459, 1, 891, 932, 41, 1);
                yield return new channing(460, 460, 1, 835, 898, 63, 1);
                yield return new channing(461, 461, 1, 1039, 1060, 21, 1);
                yield return new channing(462, 462, 1, 1010, 1044, 34, 1);
            }
        }
    }
}
