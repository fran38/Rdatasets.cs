// ReSharper disable All

namespace Rdatasets.mosaicData
{
    using System.Collections.Generic;

    /// <summary>
    /// US Births in 2015
    /// </summary>

    public class Births2015
    {
        public readonly int κ;
        public readonly string date;
        public readonly int births;
        public readonly string wday;
        public readonly int year;
        public readonly int month;
        public readonly int day_of_year;
        public readonly int day_of_month;
        public readonly int day_of_week;

        public Births2015(int κ, string date, int births, string wday, int year, int month, int day_of_year, int day_of_month, int day_of_week)
        {
            this.κ = κ;
            this.date = date;
            this.births = births;
            this.wday = wday;
            this.year = year;
            this.month = month;
            this.day_of_year = day_of_year;
            this.day_of_month = day_of_month;
            this.day_of_week = day_of_week;
        }

        public static IEnumerable<Births2015> Data
        {
            get
            {
                yield return new Births2015(1, "2015-01-01", 8068, "Thu", 2015, 1, 1, 1, 5);
                yield return new Births2015(2, "2015-01-02", 10850, "Fri", 2015, 1, 2, 2, 6);
                yield return new Births2015(3, "2015-01-03", 8328, "Sat", 2015, 1, 3, 3, 7);
                yield return new Births2015(4, "2015-01-04", 7065, "Sun", 2015, 1, 4, 4, 1);
                yield return new Births2015(5, "2015-01-05", 11892, "Mon", 2015, 1, 5, 5, 2);
                yield return new Births2015(6, "2015-01-06", 12425, "Tue", 2015, 1, 6, 6, 3);
                yield return new Births2015(7, "2015-01-07", 12141, "Wed", 2015, 1, 7, 7, 4);
                yield return new Births2015(8, "2015-01-08", 12094, "Thu", 2015, 1, 8, 8, 5);
                yield return new Births2015(9, "2015-01-09", 11868, "Fri", 2015, 1, 9, 9, 6);
                yield return new Births2015(10, "2015-01-10", 8014, "Sat", 2015, 1, 10, 10, 7);
                yield return new Births2015(11, "2015-01-11", 7172, "Sun", 2015, 1, 11, 11, 1);
                yield return new Births2015(12, "2015-01-12", 11479, "Mon", 2015, 1, 12, 12, 2);
                yield return new Births2015(13, "2015-01-13", 11924, "Tue", 2015, 1, 13, 13, 3);
                yield return new Births2015(14, "2015-01-14", 12013, "Wed", 2015, 1, 14, 14, 4);
                yield return new Births2015(15, "2015-01-15", 12339, "Thu", 2015, 1, 15, 15, 5);
                yield return new Births2015(16, "2015-01-16", 11861, "Fri", 2015, 1, 16, 16, 6);
                yield return new Births2015(17, "2015-01-17", 8280, "Sat", 2015, 1, 17, 17, 7);
                yield return new Births2015(18, "2015-01-18", 7195, "Sun", 2015, 1, 18, 18, 1);
                yield return new Births2015(19, "2015-01-19", 10602, "Mon", 2015, 1, 19, 19, 2);
                yield return new Births2015(20, "2015-01-20", 12242, "Tue", 2015, 1, 20, 20, 3);
                yield return new Births2015(21, "2015-01-21", 12086, "Wed", 2015, 1, 21, 21, 4);
                yield return new Births2015(22, "2015-01-22", 11949, "Thu", 2015, 1, 22, 22, 5);
                yield return new Births2015(23, "2015-01-23", 11910, "Fri", 2015, 1, 23, 23, 6);
                yield return new Births2015(24, "2015-01-24", 8235, "Sat", 2015, 1, 24, 24, 7);
                yield return new Births2015(25, "2015-01-25", 7186, "Sun", 2015, 1, 25, 25, 1);
                yield return new Births2015(26, "2015-01-26", 11728, "Mon", 2015, 1, 26, 26, 2);
                yield return new Births2015(27, "2015-01-27", 11882, "Tue", 2015, 1, 27, 27, 3);
                yield return new Births2015(28, "2015-01-28", 11602, "Wed", 2015, 1, 28, 28, 4);
                yield return new Births2015(29, "2015-01-29", 11967, "Thu", 2015, 1, 29, 29, 5);
                yield return new Births2015(30, "2015-01-30", 11571, "Fri", 2015, 1, 30, 30, 6);
                yield return new Births2015(31, "2015-01-31", 7987, "Sat", 2015, 1, 31, 31, 7);
                yield return new Births2015(32, "2015-02-01", 7139, "Sun", 2015, 2, 32, 1, 1);
                yield return new Births2015(33, "2015-02-02", 11480, "Mon", 2015, 2, 33, 2, 2);
                yield return new Births2015(34, "2015-02-03", 12079, "Tue", 2015, 2, 34, 3, 3);
                yield return new Births2015(35, "2015-02-04", 11924, "Wed", 2015, 2, 35, 4, 4);
                yield return new Births2015(36, "2015-02-05", 11821, "Thu", 2015, 2, 36, 5, 5);
                yield return new Births2015(37, "2015-02-06", 11656, "Fri", 2015, 2, 37, 6, 6);
                yield return new Births2015(38, "2015-02-07", 8285, "Sat", 2015, 2, 38, 7, 7);
                yield return new Births2015(39, "2015-02-08", 7265, "Sun", 2015, 2, 39, 8, 1);
                yield return new Births2015(40, "2015-02-09", 11937, "Mon", 2015, 2, 40, 9, 2);
                yield return new Births2015(41, "2015-02-10", 12291, "Tue", 2015, 2, 41, 10, 3);
                yield return new Births2015(42, "2015-02-11", 11911, "Wed", 2015, 2, 42, 11, 4);
                yield return new Births2015(43, "2015-02-12", 12285, "Thu", 2015, 2, 43, 12, 5);
                yield return new Births2015(44, "2015-02-13", 11321, "Fri", 2015, 2, 44, 13, 6);
                yield return new Births2015(45, "2015-02-14", 8390, "Sat", 2015, 2, 45, 14, 7);
                yield return new Births2015(46, "2015-02-15", 7508, "Sun", 2015, 2, 46, 15, 1);
                yield return new Births2015(47, "2015-02-16", 11038, "Mon", 2015, 2, 47, 16, 2);
                yield return new Births2015(48, "2015-02-17", 11952, "Tue", 2015, 2, 48, 17, 3);
                yield return new Births2015(49, "2015-02-18", 12061, "Wed", 2015, 2, 49, 18, 4);
                yield return new Births2015(50, "2015-02-19", 11968, "Thu", 2015, 2, 50, 19, 5);
                yield return new Births2015(51, "2015-02-20", 11864, "Fri", 2015, 2, 51, 20, 6);
                yield return new Births2015(52, "2015-02-21", 8343, "Sat", 2015, 2, 52, 21, 7);
                yield return new Births2015(53, "2015-02-22", 7254, "Sun", 2015, 2, 53, 22, 1);
                yield return new Births2015(54, "2015-02-23", 11260, "Mon", 2015, 2, 54, 23, 2);
                yield return new Births2015(55, "2015-02-24", 11941, "Tue", 2015, 2, 55, 24, 3);
                yield return new Births2015(56, "2015-02-25", 11828, "Wed", 2015, 2, 56, 25, 4);
                yield return new Births2015(57, "2015-02-26", 11672, "Thu", 2015, 2, 57, 26, 5);
                yield return new Births2015(58, "2015-02-27", 11596, "Fri", 2015, 2, 58, 27, 6);
                yield return new Births2015(59, "2015-02-28", 7989, "Sat", 2015, 2, 59, 28, 7);
                yield return new Births2015(60, "2015-03-01", 7273, "Sun", 2015, 3, 60, 1, 1);
                yield return new Births2015(61, "2015-03-02", 11609, "Mon", 2015, 3, 61, 2, 2);
                yield return new Births2015(62, "2015-03-03", 12402, "Tue", 2015, 3, 62, 3, 3);
                yield return new Births2015(63, "2015-03-04", 11927, "Wed", 2015, 3, 63, 4, 4);
                yield return new Births2015(64, "2015-03-05", 11681, "Thu", 2015, 3, 64, 5, 5);
                yield return new Births2015(65, "2015-03-06", 11612, "Fri", 2015, 3, 65, 6, 6);
                yield return new Births2015(66, "2015-03-07", 7980, "Sat", 2015, 3, 66, 7, 7);
                yield return new Births2015(67, "2015-03-08", 6929, "Sun", 2015, 3, 67, 8, 1);
                yield return new Births2015(68, "2015-03-09", 11678, "Mon", 2015, 3, 68, 9, 2);
                yield return new Births2015(69, "2015-03-10", 12282, "Tue", 2015, 3, 69, 10, 3);
                yield return new Births2015(70, "2015-03-11", 11850, "Wed", 2015, 3, 70, 11, 4);
                yield return new Births2015(71, "2015-03-12", 12042, "Thu", 2015, 3, 71, 12, 5);
                yield return new Births2015(72, "2015-03-13", 10940, "Fri", 2015, 3, 72, 13, 6);
                yield return new Births2015(73, "2015-03-14", 8217, "Sat", 2015, 3, 73, 14, 7);
                yield return new Births2015(74, "2015-03-15", 7202, "Sun", 2015, 3, 74, 15, 1);
                yield return new Births2015(75, "2015-03-16", 11537, "Mon", 2015, 3, 75, 16, 2);
                yield return new Births2015(76, "2015-03-17", 12312, "Tue", 2015, 3, 76, 17, 3);
                yield return new Births2015(77, "2015-03-18", 11807, "Wed", 2015, 3, 77, 18, 4);
                yield return new Births2015(78, "2015-03-19", 11721, "Thu", 2015, 3, 78, 19, 5);
                yield return new Births2015(79, "2015-03-20", 12040, "Fri", 2015, 3, 79, 20, 6);
                yield return new Births2015(80, "2015-03-21", 8080, "Sat", 2015, 3, 80, 21, 7);
                yield return new Births2015(81, "2015-03-22", 7171, "Sun", 2015, 3, 81, 22, 1);
                yield return new Births2015(82, "2015-03-23", 11674, "Mon", 2015, 3, 82, 23, 2);
                yield return new Births2015(83, "2015-03-24", 12333, "Tue", 2015, 3, 83, 24, 3);
                yield return new Births2015(84, "2015-03-25", 11872, "Wed", 2015, 3, 84, 25, 4);
                yield return new Births2015(85, "2015-03-26", 12065, "Thu", 2015, 3, 85, 26, 5);
                yield return new Births2015(86, "2015-03-27", 11629, "Fri", 2015, 3, 86, 27, 6);
                yield return new Births2015(87, "2015-03-28", 8071, "Sat", 2015, 3, 87, 28, 7);
                yield return new Births2015(88, "2015-03-29", 7125, "Sun", 2015, 3, 88, 29, 1);
                yield return new Births2015(89, "2015-03-30", 11500, "Mon", 2015, 3, 89, 30, 2);
                yield return new Births2015(90, "2015-03-31", 12362, "Tue", 2015, 3, 90, 31, 3);
                yield return new Births2015(91, "2015-04-01", 11596, "Wed", 2015, 4, 91, 1, 4);
                yield return new Births2015(92, "2015-04-02", 12296, "Thu", 2015, 4, 92, 2, 5);
                yield return new Births2015(93, "2015-04-03", 11234, "Fri", 2015, 4, 93, 3, 6);
                yield return new Births2015(94, "2015-04-04", 7981, "Sat", 2015, 4, 94, 4, 7);
                yield return new Births2015(95, "2015-04-05", 6821, "Sun", 2015, 4, 95, 5, 1);
                yield return new Births2015(96, "2015-04-06", 11455, "Mon", 2015, 4, 96, 6, 2);
                yield return new Births2015(97, "2015-04-07", 12334, "Tue", 2015, 4, 97, 7, 3);
                yield return new Births2015(98, "2015-04-08", 11976, "Wed", 2015, 4, 98, 8, 4);
                yield return new Births2015(99, "2015-04-09", 11874, "Thu", 2015, 4, 99, 9, 5);
                yield return new Births2015(100, "2015-04-10", 11724, "Fri", 2015, 4, 100, 10, 6);
                yield return new Births2015(101, "2015-04-11", 8092, "Sat", 2015, 4, 101, 11, 7);
                yield return new Births2015(102, "2015-04-12", 7141, "Sun", 2015, 4, 102, 12, 1);
                yield return new Births2015(103, "2015-04-13", 11503, "Mon", 2015, 4, 103, 13, 2);
                yield return new Births2015(104, "2015-04-14", 12309, "Tue", 2015, 4, 104, 14, 3);
                yield return new Births2015(105, "2015-04-15", 11794, "Wed", 2015, 4, 105, 15, 4);
                yield return new Births2015(106, "2015-04-16", 11947, "Thu", 2015, 4, 106, 16, 5);
                yield return new Births2015(107, "2015-04-17", 11718, "Fri", 2015, 4, 107, 17, 6);
                yield return new Births2015(108, "2015-04-18", 8028, "Sat", 2015, 4, 108, 18, 7);
                yield return new Births2015(109, "2015-04-19", 7180, "Sun", 2015, 4, 109, 19, 1);
                yield return new Births2015(110, "2015-04-20", 11513, "Mon", 2015, 4, 110, 20, 2);
                yield return new Births2015(111, "2015-04-21", 12173, "Tue", 2015, 4, 111, 21, 3);
                yield return new Births2015(112, "2015-04-22", 11917, "Wed", 2015, 4, 112, 22, 4);
                yield return new Births2015(113, "2015-04-23", 11877, "Thu", 2015, 4, 113, 23, 5);
                yield return new Births2015(114, "2015-04-24", 11749, "Fri", 2015, 4, 114, 24, 6);
                yield return new Births2015(115, "2015-04-25", 8101, "Sat", 2015, 4, 115, 25, 7);
                yield return new Births2015(116, "2015-04-26", 7178, "Sun", 2015, 4, 116, 26, 1);
                yield return new Births2015(117, "2015-04-27", 11494, "Mon", 2015, 4, 117, 27, 2);
                yield return new Births2015(118, "2015-04-28", 12221, "Tue", 2015, 4, 118, 28, 3);
                yield return new Births2015(119, "2015-04-29", 11775, "Wed", 2015, 4, 119, 29, 4);
                yield return new Births2015(120, "2015-04-30", 11831, "Thu", 2015, 4, 120, 30, 5);
                yield return new Births2015(121, "2015-05-01", 12178, "Fri", 2015, 5, 121, 1, 6);
                yield return new Births2015(122, "2015-05-02", 8075, "Sat", 2015, 5, 122, 2, 7);
                yield return new Births2015(123, "2015-05-03", 7195, "Sun", 2015, 5, 123, 3, 1);
                yield return new Births2015(124, "2015-05-04", 11724, "Mon", 2015, 5, 124, 4, 2);
                yield return new Births2015(125, "2015-05-05", 12618, "Tue", 2015, 5, 125, 5, 3);
                yield return new Births2015(126, "2015-05-06", 11924, "Wed", 2015, 5, 126, 6, 4);
                yield return new Births2015(127, "2015-05-07", 11649, "Thu", 2015, 5, 127, 7, 5);
                yield return new Births2015(128, "2015-05-08", 11810, "Fri", 2015, 5, 128, 8, 6);
                yield return new Births2015(129, "2015-05-09", 8216, "Sat", 2015, 5, 129, 9, 7);
                yield return new Births2015(130, "2015-05-10", 7246, "Sun", 2015, 5, 130, 10, 1);
                yield return new Births2015(131, "2015-05-11", 11549, "Mon", 2015, 5, 131, 11, 2);
                yield return new Births2015(132, "2015-05-12", 12400, "Tue", 2015, 5, 132, 12, 3);
                yield return new Births2015(133, "2015-05-13", 11572, "Wed", 2015, 5, 133, 13, 4);
                yield return new Births2015(134, "2015-05-14", 11793, "Thu", 2015, 5, 134, 14, 5);
                yield return new Births2015(135, "2015-05-15", 12306, "Fri", 2015, 5, 135, 15, 6);
                yield return new Births2015(136, "2015-05-16", 8337, "Sat", 2015, 5, 136, 16, 7);
                yield return new Births2015(137, "2015-05-17", 7354, "Sun", 2015, 5, 137, 17, 1);
                yield return new Births2015(138, "2015-05-18", 11708, "Mon", 2015, 5, 138, 18, 2);
                yield return new Births2015(139, "2015-05-19", 12469, "Tue", 2015, 5, 139, 19, 3);
                yield return new Births2015(140, "2015-05-20", 12352, "Wed", 2015, 5, 140, 20, 4);
                yield return new Births2015(141, "2015-05-21", 12246, "Thu", 2015, 5, 141, 21, 5);
                yield return new Births2015(142, "2015-05-22", 12147, "Fri", 2015, 5, 142, 22, 6);
                yield return new Births2015(143, "2015-05-23", 8267, "Sat", 2015, 5, 143, 23, 7);
                yield return new Births2015(144, "2015-05-24", 7261, "Sun", 2015, 5, 144, 24, 1);
                yield return new Births2015(145, "2015-05-25", 7746, "Mon", 2015, 5, 145, 25, 2);
                yield return new Births2015(146, "2015-05-26", 12242, "Tue", 2015, 5, 146, 26, 3);
                yield return new Births2015(147, "2015-05-27", 12845, "Wed", 2015, 5, 147, 27, 4);
                yield return new Births2015(148, "2015-05-28", 12722, "Thu", 2015, 5, 148, 28, 5);
                yield return new Births2015(149, "2015-05-29", 12168, "Fri", 2015, 5, 149, 29, 6);
                yield return new Births2015(150, "2015-05-30", 8431, "Sat", 2015, 5, 150, 30, 7);
                yield return new Births2015(151, "2015-05-31", 7367, "Sun", 2015, 5, 151, 31, 1);
                yield return new Births2015(152, "2015-06-01", 11793, "Mon", 2015, 6, 152, 1, 2);
                yield return new Births2015(153, "2015-06-02", 11994, "Tue", 2015, 6, 153, 2, 3);
                yield return new Births2015(154, "2015-06-03", 11890, "Wed", 2015, 6, 154, 3, 4);
                yield return new Births2015(155, "2015-06-04", 11918, "Thu", 2015, 6, 155, 4, 5);
                yield return new Births2015(156, "2015-06-05", 12303, "Fri", 2015, 6, 156, 5, 6);
                yield return new Births2015(157, "2015-06-06", 8313, "Sat", 2015, 6, 157, 6, 7);
                yield return new Births2015(158, "2015-06-07", 7230, "Sun", 2015, 6, 158, 7, 1);
                yield return new Births2015(159, "2015-06-08", 11938, "Mon", 2015, 6, 159, 8, 2);
                yield return new Births2015(160, "2015-06-09", 12479, "Tue", 2015, 6, 160, 9, 3);
                yield return new Births2015(161, "2015-06-10", 12123, "Wed", 2015, 6, 161, 10, 4);
                yield return new Births2015(162, "2015-06-11", 12029, "Thu", 2015, 6, 162, 11, 5);
                yield return new Births2015(163, "2015-06-12", 12064, "Fri", 2015, 6, 163, 12, 6);
                yield return new Births2015(164, "2015-06-13", 8104, "Sat", 2015, 6, 164, 13, 7);
                yield return new Births2015(165, "2015-06-14", 7292, "Sun", 2015, 6, 165, 14, 1);
                yield return new Births2015(166, "2015-06-15", 12348, "Mon", 2015, 6, 166, 15, 2);
                yield return new Births2015(167, "2015-06-16", 12400, "Tue", 2015, 6, 167, 16, 3);
                yield return new Births2015(168, "2015-06-17", 12192, "Wed", 2015, 6, 168, 17, 4);
                yield return new Births2015(169, "2015-06-18", 12323, "Thu", 2015, 6, 169, 18, 5);
                yield return new Births2015(170, "2015-06-19", 11767, "Fri", 2015, 6, 170, 19, 6);
                yield return new Births2015(171, "2015-06-20", 8451, "Sat", 2015, 6, 171, 20, 7);
                yield return new Births2015(172, "2015-06-21", 7580, "Sun", 2015, 6, 172, 21, 1);
                yield return new Births2015(173, "2015-06-22", 11883, "Mon", 2015, 6, 173, 22, 2);
                yield return new Births2015(174, "2015-06-23", 12351, "Tue", 2015, 6, 174, 23, 3);
                yield return new Births2015(175, "2015-06-24", 12292, "Wed", 2015, 6, 175, 24, 4);
                yield return new Births2015(176, "2015-06-25", 12416, "Thu", 2015, 6, 176, 25, 5);
                yield return new Births2015(177, "2015-06-26", 12152, "Fri", 2015, 6, 177, 26, 6);
                yield return new Births2015(178, "2015-06-27", 8652, "Sat", 2015, 6, 178, 27, 7);
                yield return new Births2015(179, "2015-06-28", 7371, "Sun", 2015, 6, 179, 28, 1);
                yield return new Births2015(180, "2015-06-29", 11961, "Mon", 2015, 6, 180, 29, 2);
                yield return new Births2015(181, "2015-06-30", 12932, "Tue", 2015, 6, 181, 30, 3);
                yield return new Births2015(182, "2015-07-01", 13033, "Wed", 2015, 7, 182, 1, 4);
                yield return new Births2015(183, "2015-07-02", 13038, "Thu", 2015, 7, 183, 2, 5);
                yield return new Births2015(184, "2015-07-03", 10375, "Fri", 2015, 7, 184, 3, 6);
                yield return new Births2015(185, "2015-07-04", 7944, "Sat", 2015, 7, 185, 4, 7);
                yield return new Births2015(186, "2015-07-05", 7164, "Sun", 2015, 7, 186, 5, 1);
                yield return new Births2015(187, "2015-07-06", 12088, "Mon", 2015, 7, 187, 6, 2);
                yield return new Births2015(188, "2015-07-07", 13426, "Tue", 2015, 7, 188, 7, 3);
                yield return new Births2015(189, "2015-07-08", 12788, "Wed", 2015, 7, 189, 8, 4);
                yield return new Births2015(190, "2015-07-09", 12517, "Thu", 2015, 7, 190, 9, 5);
                yield return new Births2015(191, "2015-07-10", 12396, "Fri", 2015, 7, 191, 10, 6);
                yield return new Births2015(192, "2015-07-11", 8769, "Sat", 2015, 7, 192, 11, 7);
                yield return new Births2015(193, "2015-07-12", 7591, "Sun", 2015, 7, 193, 12, 1);
                yield return new Births2015(194, "2015-07-13", 11835, "Mon", 2015, 7, 194, 13, 2);
                yield return new Births2015(195, "2015-07-14", 12862, "Tue", 2015, 7, 195, 14, 3);
                yield return new Births2015(196, "2015-07-15", 12853, "Wed", 2015, 7, 196, 15, 4);
                yield return new Births2015(197, "2015-07-16", 12502, "Thu", 2015, 7, 197, 16, 5);
                yield return new Births2015(198, "2015-07-17", 12291, "Fri", 2015, 7, 198, 17, 6);
                yield return new Births2015(199, "2015-07-18", 8546, "Sat", 2015, 7, 199, 18, 7);
                yield return new Births2015(200, "2015-07-19", 7681, "Sun", 2015, 7, 200, 19, 1);
                yield return new Births2015(201, "2015-07-20", 12424, "Mon", 2015, 7, 201, 20, 2);
                yield return new Births2015(202, "2015-07-21", 13264, "Tue", 2015, 7, 202, 21, 3);
                yield return new Births2015(203, "2015-07-22", 12519, "Wed", 2015, 7, 203, 22, 4);
                yield return new Births2015(204, "2015-07-23", 12852, "Thu", 2015, 7, 204, 23, 5);
                yield return new Births2015(205, "2015-07-24", 12612, "Fri", 2015, 7, 205, 24, 6);
                yield return new Births2015(206, "2015-07-25", 8748, "Sat", 2015, 7, 206, 25, 7);
                yield return new Births2015(207, "2015-07-26", 7836, "Sun", 2015, 7, 207, 26, 1);
                yield return new Births2015(208, "2015-07-27", 12416, "Mon", 2015, 7, 208, 27, 2);
                yield return new Births2015(209, "2015-07-28", 13240, "Tue", 2015, 7, 209, 28, 3);
                yield return new Births2015(210, "2015-07-29", 12739, "Wed", 2015, 7, 210, 29, 4);
                yield return new Births2015(211, "2015-07-30", 12797, "Thu", 2015, 7, 211, 30, 5);
                yield return new Births2015(212, "2015-07-31", 12269, "Fri", 2015, 7, 212, 31, 6);
                yield return new Births2015(213, "2015-08-01", 8851, "Sat", 2015, 8, 213, 1, 7);
                yield return new Births2015(214, "2015-08-02", 7907, "Sun", 2015, 8, 214, 2, 1);
                yield return new Births2015(215, "2015-08-03", 12449, "Mon", 2015, 8, 215, 3, 2);
                yield return new Births2015(216, "2015-08-04", 13149, "Tue", 2015, 8, 216, 4, 3);
                yield return new Births2015(217, "2015-08-05", 12793, "Wed", 2015, 8, 217, 5, 4);
                yield return new Births2015(218, "2015-08-06", 12872, "Thu", 2015, 8, 218, 6, 5);
                yield return new Births2015(219, "2015-08-07", 12770, "Fri", 2015, 8, 219, 7, 6);
                yield return new Births2015(220, "2015-08-08", 8956, "Sat", 2015, 8, 220, 8, 7);
                yield return new Births2015(221, "2015-08-09", 7726, "Sun", 2015, 8, 221, 9, 1);
                yield return new Births2015(222, "2015-08-10", 12333, "Mon", 2015, 8, 222, 10, 2);
                yield return new Births2015(223, "2015-08-11", 13010, "Tue", 2015, 8, 223, 11, 3);
                yield return new Births2015(224, "2015-08-12", 12960, "Wed", 2015, 8, 224, 12, 4);
                yield return new Births2015(225, "2015-08-13", 12591, "Thu", 2015, 8, 225, 13, 5);
                yield return new Births2015(226, "2015-08-14", 12861, "Fri", 2015, 8, 226, 14, 6);
                yield return new Births2015(227, "2015-08-15", 8938, "Sat", 2015, 8, 227, 15, 7);
                yield return new Births2015(228, "2015-08-16", 7896, "Sun", 2015, 8, 228, 16, 1);
                yield return new Births2015(229, "2015-08-17", 12337, "Mon", 2015, 8, 229, 17, 2);
                yield return new Births2015(230, "2015-08-18", 13197, "Tue", 2015, 8, 230, 18, 3);
                yield return new Births2015(231, "2015-08-19", 12966, "Wed", 2015, 8, 231, 19, 4);
                yield return new Births2015(232, "2015-08-20", 13002, "Thu", 2015, 8, 232, 20, 5);
                yield return new Births2015(233, "2015-08-21", 12834, "Fri", 2015, 8, 233, 21, 6);
                yield return new Births2015(234, "2015-08-22", 9153, "Sat", 2015, 8, 234, 22, 7);
                yield return new Births2015(235, "2015-08-23", 7821, "Sun", 2015, 8, 235, 23, 1);
                yield return new Births2015(236, "2015-08-24", 12274, "Mon", 2015, 8, 236, 24, 2);
                yield return new Births2015(237, "2015-08-25", 13149, "Tue", 2015, 8, 237, 25, 3);
                yield return new Births2015(238, "2015-08-26", 12729, "Wed", 2015, 8, 238, 26, 4);
                yield return new Births2015(239, "2015-08-27", 12829, "Thu", 2015, 8, 239, 27, 5);
                yield return new Births2015(240, "2015-08-28", 12719, "Fri", 2015, 8, 240, 28, 6);
                yield return new Births2015(241, "2015-08-29", 8772, "Sat", 2015, 8, 241, 29, 7);
                yield return new Births2015(242, "2015-08-30", 7805, "Sun", 2015, 8, 242, 30, 1);
                yield return new Births2015(243, "2015-08-31", 12142, "Mon", 2015, 8, 243, 31, 2);
                yield return new Births2015(244, "2015-09-01", 13231, "Tue", 2015, 9, 244, 1, 3);
                yield return new Births2015(245, "2015-09-02", 12799, "Wed", 2015, 9, 245, 2, 4);
                yield return new Births2015(246, "2015-09-03", 12839, "Thu", 2015, 9, 246, 3, 5);
                yield return new Births2015(247, "2015-09-04", 12862, "Fri", 2015, 9, 247, 4, 6);
                yield return new Births2015(248, "2015-09-05", 8950, "Sat", 2015, 9, 248, 5, 7);
                yield return new Births2015(249, "2015-09-06", 7778, "Sun", 2015, 9, 249, 6, 1);
                yield return new Births2015(250, "2015-09-07", 8127, "Mon", 2015, 9, 250, 7, 2);
                yield return new Births2015(251, "2015-09-08", 12823, "Tue", 2015, 9, 251, 8, 3);
                yield return new Births2015(252, "2015-09-09", 13949, "Wed", 2015, 9, 252, 9, 4);
                yield return new Births2015(253, "2015-09-10", 13925, "Thu", 2015, 9, 253, 10, 5);
                yield return new Births2015(254, "2015-09-11", 12295, "Fri", 2015, 9, 254, 11, 6);
                yield return new Births2015(255, "2015-09-12", 9062, "Sat", 2015, 9, 255, 12, 7);
                yield return new Births2015(256, "2015-09-13", 7900, "Sun", 2015, 9, 256, 13, 1);
                yield return new Births2015(257, "2015-09-14", 12699, "Mon", 2015, 9, 257, 14, 2);
                yield return new Births2015(258, "2015-09-15", 13439, "Tue", 2015, 9, 258, 15, 3);
                yield return new Births2015(259, "2015-09-16", 13136, "Wed", 2015, 9, 259, 16, 4);
                yield return new Births2015(260, "2015-09-17", 13319, "Thu", 2015, 9, 260, 17, 5);
                yield return new Births2015(261, "2015-09-18", 13229, "Fri", 2015, 9, 261, 18, 6);
                yield return new Births2015(262, "2015-09-19", 9195, "Sat", 2015, 9, 262, 19, 7);
                yield return new Births2015(263, "2015-09-20", 8078, "Sun", 2015, 9, 263, 20, 1);
                yield return new Births2015(264, "2015-09-21", 12567, "Mon", 2015, 9, 264, 21, 2);
                yield return new Births2015(265, "2015-09-22", 13047, "Tue", 2015, 9, 265, 22, 3);
                yield return new Births2015(266, "2015-09-23", 12595, "Wed", 2015, 9, 266, 23, 4);
                yield return new Births2015(267, "2015-09-24", 12942, "Thu", 2015, 9, 267, 24, 5);
                yield return new Births2015(268, "2015-09-25", 12792, "Fri", 2015, 9, 268, 25, 6);
                yield return new Births2015(269, "2015-09-26", 8927, "Sat", 2015, 9, 269, 26, 7);
                yield return new Births2015(270, "2015-09-27", 7778, "Sun", 2015, 9, 270, 27, 1);
                yield return new Births2015(271, "2015-09-28", 12158, "Mon", 2015, 9, 271, 28, 2);
                yield return new Births2015(272, "2015-09-29", 12791, "Tue", 2015, 9, 272, 29, 3);
                yield return new Births2015(273, "2015-09-30", 12284, "Wed", 2015, 9, 273, 30, 4);
                yield return new Births2015(274, "2015-10-01", 13043, "Thu", 2015, 10, 274, 1, 5);
                yield return new Births2015(275, "2015-10-02", 12399, "Fri", 2015, 10, 275, 2, 6);
                yield return new Births2015(276, "2015-10-03", 8579, "Sat", 2015, 10, 276, 3, 7);
                yield return new Births2015(277, "2015-10-04", 7530, "Sun", 2015, 10, 277, 4, 1);
                yield return new Births2015(278, "2015-10-05", 12166, "Mon", 2015, 10, 278, 5, 2);
                yield return new Births2015(279, "2015-10-06", 12520, "Tue", 2015, 10, 279, 6, 3);
                yield return new Births2015(280, "2015-10-07", 12429, "Wed", 2015, 10, 280, 7, 4);
                yield return new Births2015(281, "2015-10-08", 12458, "Thu", 2015, 10, 281, 8, 5);
                yield return new Births2015(282, "2015-10-09", 12282, "Fri", 2015, 10, 282, 9, 6);
                yield return new Births2015(283, "2015-10-10", 8550, "Sat", 2015, 10, 283, 10, 7);
                yield return new Births2015(284, "2015-10-11", 7571, "Sun", 2015, 10, 284, 11, 1);
                yield return new Births2015(285, "2015-10-12", 11633, "Mon", 2015, 10, 285, 12, 2);
                yield return new Births2015(286, "2015-10-13", 12094, "Tue", 2015, 10, 286, 13, 3);
                yield return new Births2015(287, "2015-10-14", 12205, "Wed", 2015, 10, 287, 14, 4);
                yield return new Births2015(288, "2015-10-15", 12522, "Thu", 2015, 10, 288, 15, 5);
                yield return new Births2015(289, "2015-10-16", 11917, "Fri", 2015, 10, 289, 16, 6);
                yield return new Births2015(290, "2015-10-17", 8233, "Sat", 2015, 10, 290, 17, 7);
                yield return new Births2015(291, "2015-10-18", 7211, "Sun", 2015, 10, 291, 18, 1);
                yield return new Births2015(292, "2015-10-19", 11388, "Mon", 2015, 10, 292, 19, 2);
                yield return new Births2015(293, "2015-10-20", 12500, "Tue", 2015, 10, 293, 20, 3);
                yield return new Births2015(294, "2015-10-21", 12093, "Wed", 2015, 10, 294, 21, 4);
                yield return new Births2015(295, "2015-10-22", 12013, "Thu", 2015, 10, 295, 22, 5);
                yield return new Births2015(296, "2015-10-23", 11942, "Fri", 2015, 10, 296, 23, 6);
                yield return new Births2015(297, "2015-10-24", 8239, "Sat", 2015, 10, 297, 24, 7);
                yield return new Births2015(298, "2015-10-25", 7288, "Sun", 2015, 10, 298, 25, 1);
                yield return new Births2015(299, "2015-10-26", 11923, "Mon", 2015, 10, 299, 26, 2);
                yield return new Births2015(300, "2015-10-27", 12485, "Tue", 2015, 10, 300, 27, 3);
                yield return new Births2015(301, "2015-10-28", 12266, "Wed", 2015, 10, 301, 28, 4);
                yield return new Births2015(302, "2015-10-29", 11950, "Thu", 2015, 10, 302, 29, 5);
                yield return new Births2015(303, "2015-10-30", 11529, "Fri", 2015, 10, 303, 30, 6);
                yield return new Births2015(304, "2015-10-31", 8049, "Sat", 2015, 10, 304, 31, 7);
                yield return new Births2015(305, "2015-11-01", 7731, "Sun", 2015, 11, 305, 1, 1);
                yield return new Births2015(306, "2015-11-02", 12236, "Mon", 2015, 11, 306, 2, 2);
                yield return new Births2015(307, "2015-11-03", 12524, "Tue", 2015, 11, 307, 3, 3);
                yield return new Births2015(308, "2015-11-04", 12279, "Wed", 2015, 11, 308, 4, 4);
                yield return new Births2015(309, "2015-11-05", 12452, "Thu", 2015, 11, 309, 5, 5);
                yield return new Births2015(310, "2015-11-06", 11909, "Fri", 2015, 11, 310, 6, 6);
                yield return new Births2015(311, "2015-11-07", 8517, "Sat", 2015, 11, 311, 7, 7);
                yield return new Births2015(312, "2015-11-08", 7324, "Sun", 2015, 11, 312, 8, 1);
                yield return new Births2015(313, "2015-11-09", 11688, "Mon", 2015, 11, 313, 9, 2);
                yield return new Births2015(314, "2015-11-10", 12451, "Tue", 2015, 11, 314, 10, 3);
                yield return new Births2015(315, "2015-11-11", 12311, "Wed", 2015, 11, 315, 11, 4);
                yield return new Births2015(316, "2015-11-12", 12329, "Thu", 2015, 11, 316, 12, 5);
                yield return new Births2015(317, "2015-11-13", 11643, "Fri", 2015, 11, 317, 13, 6);
                yield return new Births2015(318, "2015-11-14", 8221, "Sat", 2015, 11, 318, 14, 7);
                yield return new Births2015(319, "2015-11-15", 7378, "Sun", 2015, 11, 319, 15, 1);
                yield return new Births2015(320, "2015-11-16", 11791, "Mon", 2015, 11, 320, 16, 2);
                yield return new Births2015(321, "2015-11-17", 12321, "Tue", 2015, 11, 321, 17, 3);
                yield return new Births2015(322, "2015-11-18", 12230, "Wed", 2015, 11, 322, 18, 4);
                yield return new Births2015(323, "2015-11-19", 12504, "Thu", 2015, 11, 323, 19, 5);
                yield return new Births2015(324, "2015-11-20", 12495, "Fri", 2015, 11, 324, 20, 6);
                yield return new Births2015(325, "2015-11-21", 8392, "Sat", 2015, 11, 325, 21, 7);
                yield return new Births2015(326, "2015-11-22", 7427, "Sun", 2015, 11, 326, 22, 1);
                yield return new Births2015(327, "2015-11-23", 12419, "Mon", 2015, 11, 327, 23, 2);
                yield return new Births2015(328, "2015-11-24", 13051, "Tue", 2015, 11, 328, 24, 3);
                yield return new Births2015(329, "2015-11-25", 11745, "Wed", 2015, 11, 329, 25, 4);
                yield return new Births2015(330, "2015-11-26", 7332, "Thu", 2015, 11, 330, 26, 5);
                yield return new Births2015(331, "2015-11-27", 8942, "Fri", 2015, 11, 331, 27, 6);
                yield return new Births2015(332, "2015-11-28", 7734, "Sat", 2015, 11, 332, 28, 7);
                yield return new Births2015(333, "2015-11-29", 7230, "Sun", 2015, 11, 333, 29, 1);
                yield return new Births2015(334, "2015-11-30", 12214, "Mon", 2015, 11, 334, 30, 2);
                yield return new Births2015(335, "2015-12-01", 13185, "Tue", 2015, 12, 335, 1, 3);
                yield return new Births2015(336, "2015-12-02", 12708, "Wed", 2015, 12, 336, 2, 4);
                yield return new Births2015(337, "2015-12-03", 12281, "Thu", 2015, 12, 337, 3, 5);
                yield return new Births2015(338, "2015-12-04", 11828, "Fri", 2015, 12, 338, 4, 6);
                yield return new Births2015(339, "2015-12-05", 8262, "Sat", 2015, 12, 339, 5, 7);
                yield return new Births2015(340, "2015-12-06", 7194, "Sun", 2015, 12, 340, 6, 1);
                yield return new Births2015(341, "2015-12-07", 11567, "Mon", 2015, 12, 341, 7, 2);
                yield return new Births2015(342, "2015-12-08", 12328, "Tue", 2015, 12, 342, 8, 3);
                yield return new Births2015(343, "2015-12-09", 11857, "Wed", 2015, 12, 343, 9, 4);
                yield return new Births2015(344, "2015-12-10", 12259, "Thu", 2015, 12, 344, 10, 5);
                yield return new Births2015(345, "2015-12-11", 11406, "Fri", 2015, 12, 345, 11, 6);
                yield return new Births2015(346, "2015-12-12", 8073, "Sat", 2015, 12, 346, 12, 7);
                yield return new Births2015(347, "2015-12-13", 7262, "Sun", 2015, 12, 347, 13, 1);
                yield return new Births2015(348, "2015-12-14", 11753, "Mon", 2015, 12, 348, 14, 2);
                yield return new Births2015(349, "2015-12-15", 12437, "Tue", 2015, 12, 349, 15, 3);
                yield return new Births2015(350, "2015-12-16", 12282, "Wed", 2015, 12, 350, 16, 4);
                yield return new Births2015(351, "2015-12-17", 12339, "Thu", 2015, 12, 351, 17, 5);
                yield return new Births2015(352, "2015-12-18", 12247, "Fri", 2015, 12, 352, 18, 6);
                yield return new Births2015(353, "2015-12-19", 8368, "Sat", 2015, 12, 353, 19, 7);
                yield return new Births2015(354, "2015-12-20", 7361, "Sun", 2015, 12, 354, 20, 1);
                yield return new Births2015(355, "2015-12-21", 12692, "Mon", 2015, 12, 355, 21, 2);
                yield return new Births2015(356, "2015-12-22", 13131, "Tue", 2015, 12, 356, 22, 3);
                yield return new Births2015(357, "2015-12-23", 11595, "Wed", 2015, 12, 357, 23, 4);
                yield return new Births2015(358, "2015-12-24", 8714, "Thu", 2015, 12, 358, 24, 5);
                yield return new Births2015(359, "2015-12-25", 6515, "Fri", 2015, 12, 359, 25, 6);
                yield return new Births2015(360, "2015-12-26", 7294, "Sat", 2015, 12, 360, 26, 7);
                yield return new Births2015(361, "2015-12-27", 7518, "Sun", 2015, 12, 361, 27, 1);
                yield return new Births2015(362, "2015-12-28", 13100, "Mon", 2015, 12, 362, 28, 2);
                yield return new Births2015(363, "2015-12-29", 13458, "Tue", 2015, 12, 363, 29, 3);
                yield return new Births2015(364, "2015-12-30", 13100, "Wed", 2015, 12, 364, 30, 4);
                yield return new Births2015(365, "2015-12-31", 11608, "Thu", 2015, 12, 365, 31, 5);
            }
        }
    }
}
