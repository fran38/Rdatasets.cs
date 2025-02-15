// ReSharper disable All

namespace Rdatasets.rpart
{
    using System.Collections.Generic;

    /// <summary>
    /// Stage C Prostate Cancer
    /// </summary>

    public class stagec
    {
        public readonly int κ;
        public readonly double pgtime;
        public readonly int pgstat;
        public readonly int age;
        public readonly int? eet;
        public readonly double? g2;
        public readonly int grade;
        public readonly int? gleason;
        public readonly string ploidy;

        public stagec(int κ, double pgtime, int pgstat, int age, int? eet, double? g2, int grade, int? gleason, string ploidy)
        {
            this.κ = κ;
            this.pgtime = pgtime;
            this.pgstat = pgstat;
            this.age = age;
            this.eet = eet;
            this.g2 = g2;
            this.grade = grade;
            this.gleason = gleason;
            this.ploidy = ploidy;
        }

        public static IEnumerable<stagec> Data
        {
            get
            {
                yield return new stagec(1, 6.1, 0, 64, 2, 10.26, 2, 4, "diploid");
                yield return new stagec(2, 9.4, 0, 62, 1, null, 3, 8, "aneuploid");
                yield return new stagec(3, 5.2, 1, 59, 2, 9.99, 3, 7, "diploid");
                yield return new stagec(4, 3.2, 1, 62, 2, 3.57, 2, 4, "diploid");
                yield return new stagec(5, 1.9, 1, 64, 2, 22.56, 4, 8, "tetraploid");
                yield return new stagec(6, 4.8, 0, 69, 1, 6.14, 3, 7, "diploid");
                yield return new stagec(7, 5.8, 0, 75, 2, 13.69, 2, null, "tetraploid");
                yield return new stagec(8, 7.3, 0, 71, 2, null, 3, 7, "aneuploid");
                yield return new stagec(9, 3.7, 1, 73, 2, 11.77, 3, 6, "diploid");
                yield return new stagec(10, 15.9, 0, 64, 2, 27.27, 3, 7, "tetraploid");
                yield return new stagec(11, 6.3, 0, 65, 2, 19.34, 3, 7, "tetraploid");
                yield return new stagec(12, 2.9, 1, 58, 2, 14.82, 4, 8, "tetraploid");
                yield return new stagec(13, 1.5, 1, 70, 2, 10.22, 3, 8, "diploid");
                yield return new stagec(14, 14.5, 0, 67, 2, 15.66, 2, 6, "tetraploid");
                yield return new stagec(15, 4.2, 1, 66, 2, 17.79, 3, 7, "tetraploid");
                yield return new stagec(16, 1.7, 1, 74, 2, 11.11, 3, 8, "diploid");
                yield return new stagec(17, 5, 0, 70, 2, 11.44, 2, 5, "diploid");
                yield return new stagec(18, 13.2, 0, 57, 2, 14.78, 2, 4, "tetraploid");
                yield return new stagec(19, 10.9, 0, 63, 2, 54.93, 3, 8, "tetraploid");
                yield return new stagec(20, 13, 0, 65, 2, 24.58, 3, 7, "tetraploid");
                yield return new stagec(21, 11.4, 0, 62, 2, 27.79, 2, 5, "tetraploid");
                yield return new stagec(22, 2.6, 1, 72, 2, 14.86, 3, 6, "tetraploid");
                yield return new stagec(23, 9.8, 0, 64, 1, 10.51, 2, 5, "diploid");
                yield return new stagec(24, 3.4, 1, 67, null, 14.22, 2, 6, "tetraploid");
                yield return new stagec(25, 7.6, 1, 64, 2, 15.28, 2, 5, "tetraploid");
                yield return new stagec(26, 4.8, 1, 70, 2, 16.91, 3, 6, "tetraploid");
                yield return new stagec(27, 3.7, 1, 58, 1, 17.87, 3, 7, "tetraploid");
                yield return new stagec(28, 13.9, 0, 57, 2, 12.13, 3, 6, "diploid");
                yield return new stagec(29, 4.9, 1, 54, 1, 17.25, 2, 5, "tetraploid");
                yield return new stagec(30, 15.9, 0, 61, 1, 16.53, 3, 7, "tetraploid");
                yield return new stagec(31, 2.9, 1, 68, 2, 17.49, 2, 4, "tetraploid");
                yield return new stagec(32, 9.3, 0, 64, 1, 3.85, 3, 6, "aneuploid");
                yield return new stagec(33, 6.5, 0, 70, 1, 7.88, 2, 6, "diploid");
                yield return new stagec(34, 1.7, 0, 64, 2, 16.64, 2, 5, "tetraploid");
                yield return new stagec(35, 6.9, 0, 66, 2, 13.19, 3, 7, "tetraploid");
                yield return new stagec(36, 5.5, 0, 61, 2, 9.42, 2, 5, "diploid");
                yield return new stagec(37, 5.7, 0, 70, 2, 22.79, 2, 5, "tetraploid");
                yield return new stagec(38, 4.1, 1, 63, 2, 11.37, 2, 6, "diploid");
                yield return new stagec(39, 0.3, 1, 59, 2, 3.77, 3, 6, "aneuploid");
                yield return new stagec(40, 1.1, 1, 66, 1, 13.76, 3, 6, "tetraploid");
                yield return new stagec(41, 7.8, 0, 53, 2, 14.52, 2, 5, "tetraploid");
                yield return new stagec(42, 2, 1, 62, 2, 7.55, 3, 7, "diploid");
                yield return new stagec(43, 7.3, 0, 69, 2, 8.46, 2, 5, "diploid");
                yield return new stagec(44, 13.5, 0, 63, 2, 7.66, 3, 7, "diploid");
                yield return new stagec(45, 11.7, 0, 61, 2, 8.4, 2, 5, "diploid");
                yield return new stagec(46, 8.7, 0, 70, 1, 4.43, 1, 3, "diploid");
                yield return new stagec(47, 3.4, 0, 61, 2, 10.37, 3, 7, "diploid");
                yield return new stagec(48, 6.3, 0, 62, 2, 10.82, 2, 6, "diploid");
                yield return new stagec(49, 10.6, 0, 55, 2, 7.81, 2, 5, "diploid");
                yield return new stagec(50, 9.3, 0, 61, 2, 11.23, 2, 5, "diploid");
                yield return new stagec(51, 7.9, 0, 63, 2, 13.99, 3, 6, "tetraploid");
                yield return new stagec(52, 4.9, 0, 67, 2, 6.41, 2, 5, "diploid");
                yield return new stagec(53, 13.4, 0, 59, 2, 16.05, 2, 5, "tetraploid");
                yield return new stagec(54, 17.7, 0, 58, 2, 22.97, 3, 6, "tetraploid");
                yield return new stagec(55, 1, 1, 61, 1, 2.4, 4, 10, "diploid");
                yield return new stagec(56, 0.3, 1, 47, 2, 11.92, 4, 10, "diploid");
                yield return new stagec(57, 13.1, 0, 65, 2, null, 3, 6, "tetraploid");
                yield return new stagec(58, 16.7, 0, 56, 2, 5.29, 1, 3, "diploid");
                yield return new stagec(59, 4.5, 0, 63, 2, 5.75, 2, 5, "diploid");
                yield return new stagec(60, 3.4, 1, 69, 1, 7.64, 3, 8, "aneuploid");
                yield return new stagec(61, 2.4, 1, 50, 1, 16.81, 3, 7, "tetraploid");
                yield return new stagec(62, 6.8, 0, 70, 2, 29.56, 2, 5, "tetraploid");
                yield return new stagec(63, 3, 1, 55, 1, 13.35, 3, 6, "aneuploid");
                yield return new stagec(64, 10.4, 0, 55, 2, 8.1, 2, 5, "diploid");
                yield return new stagec(65, 11.8, 0, 62, 1, 12.62, 2, 5, "diploid");
                yield return new stagec(66, 8, 1, 66, 2, 14.14, 2, 5, "tetraploid");
                yield return new stagec(67, 5.7, 0, 71, 1, 10.16, 2, 6, "diploid");
                yield return new stagec(68, 6.1, 0, 63, 2, 17.21, 2, 5, "tetraploid");
                yield return new stagec(69, 5.2, 0, 54, 2, 11.35, 2, 6, "diploid");
                yield return new stagec(70, 6.2, 0, 65, 2, 11.35, 2, 5, "diploid");
                yield return new stagec(71, 11.4, 0, 59, 2, 7.61, 2, 5, "diploid");
                yield return new stagec(72, 7, 1, 61, 2, 20.82, 3, 6, "tetraploid");
                yield return new stagec(73, 6.5, 0, 65, 1, 12.93, 3, 7, "diploid");
                yield return new stagec(74, 0.5, 1, 57, 1, 21.75, 3, 7, "tetraploid");
                yield return new stagec(75, 6.1, 0, 69, 2, 8.58, 2, 6, "diploid");
                yield return new stagec(76, 5.1, 1, 53, 1, 14.94, 3, 7, "tetraploid");
                yield return new stagec(77, 3.7, 1, 48, 2, 17.16, 3, 7, "tetraploid");
                yield return new stagec(78, 12.2, 0, 57, 2, 23.62, 3, 8, "tetraploid");
                yield return new stagec(79, 7.7, 1, 63, 2, 16.06, 3, 9, "tetraploid");
                yield return new stagec(80, 7, 0, 52, 2, 7.15, 2, 7, "diploid");
                yield return new stagec(81, 7.2, 1, 57, 2, 13.21, 3, 8, "tetraploid");
                yield return new stagec(82, 4.4, 1, 62, 2, 11.35, 3, 6, "diploid");
                yield return new stagec(83, 6.7, 0, 54, 2, 8.11, 2, 4, "diploid");
                yield return new stagec(84, 6.8, 1, 67, 2, 11.18, 3, 7, "diploid");
                yield return new stagec(85, 5.2, 1, 65, 2, 24.84, 3, 7, "tetraploid");
                yield return new stagec(86, 8.7, 0, 67, 2, 7.67, 3, 6, "diploid");
                yield return new stagec(87, 10.8, 0, 72, 1, 6.68, 2, null, "diploid");
                yield return new stagec(88, 2.6, 1, 66, 2, 15.23, 3, 8, "tetraploid");
                yield return new stagec(89, 10.9, 0, 72, 2, 6.8, 2, 5, "diploid");
                yield return new stagec(90, 5.6, 1, 60, 2, 14.58, 3, 7, "tetraploid");
                yield return new stagec(91, 10.1, 0, 70, 2, 13.17, 2, 6, "tetraploid");
                yield return new stagec(92, 7.2, 0, 63, 1, 9.76, 2, 5, "diploid");
                yield return new stagec(93, 10.2, 0, 64, 1, 7.61, 2, null, "diploid");
                yield return new stagec(94, 7.7, 1, 62, 2, 38.05, 3, 7, "tetraploid");
                yield return new stagec(95, 2.7, 1, 61, 1, 13.87, 3, 6, "tetraploid");
                yield return new stagec(96, 1.9, 1, 64, 2, 21.2, 3, 7, "tetraploid");
                yield return new stagec(97, 3.6, 0, 64, 1, 17.96, 3, 7, "tetraploid");
                yield return new stagec(98, 8.2, 0, 68, 2, 27.14, 3, 9, "tetraploid");
                yield return new stagec(99, 9.2, 0, 62, 1, 6.74, 2, 5, "diploid");
                yield return new stagec(100, 6.1, 0, 69, 2, 11.21, 3, 8, "diploid");
                yield return new stagec(101, 8.7, 0, 59, 2, 20.22, 3, 6, "tetraploid");
                yield return new stagec(102, 7.4, 1, 66, 1, 15.35, 3, 8, "tetraploid");
                yield return new stagec(103, 1.6, 1, 53, 1, 16.79, 3, 9, "tetraploid");
                yield return new stagec(104, 8.4, 0, 59, 2, 8.76, 2, 6, "diploid");
                yield return new stagec(105, 4.7, 1, 58, 2, 13.23, 2, 6, "tetraploid");
                yield return new stagec(106, 5.7, 0, 61, 2, 34.01, 2, 7, "tetraploid");
                yield return new stagec(107, 3.2, 1, 65, null, 14.68, 3, 8, "tetraploid");
                yield return new stagec(108, 4.9, 0, 67, 1, 17.95, 3, 8, "tetraploid");
                yield return new stagec(109, 3.4, 1, 57, 1, 23.34, 3, 8, "tetraploid");
                yield return new stagec(110, 1, 1, 55, 2, 10.25, 3, 7, "aneuploid");
                yield return new stagec(111, 5.4, 1, 57, 2, null, 3, 8, "aneuploid");
                yield return new stagec(112, 4.7, 0, 57, 1, 15.1, 3, 7, "tetraploid");
                yield return new stagec(113, 6.3, 0, 68, 1, 26.55, 2, 6, "tetraploid");
                yield return new stagec(114, 7, 0, 67, 2, 7.78, 2, 6, "diploid");
                yield return new stagec(115, 1.5, 1, 60, 1, null, 4, 9, "aneuploid");
                yield return new stagec(116, 7.1, 0, 63, 2, 21.2, 3, 7, "tetraploid");
                yield return new stagec(117, 6, 0, 69, 2, 7.93, 3, 6, "diploid");
                yield return new stagec(118, 3.8, 0, 54, 2, 10.58, 3, 8, "diploid");
                yield return new stagec(119, 6.5, 0, 66, 2, 5.92, 2, 5, "diploid");
                yield return new stagec(120, 3.1, 0, 59, 2, 5.08, 3, 7, "diploid");
                yield return new stagec(121, 6.8, 0, 62, 2, 13.1, 3, 8, "tetraploid");
                yield return new stagec(122, 6.7, 0, 73, 1, 41.31, 3, 8, "tetraploid");
                yield return new stagec(123, 5.7, 1, 65, 2, 11.29, 3, 7, "diploid");
                yield return new stagec(124, 1.5, 1, 67, 2, 14.02, 3, 7, "tetraploid");
                yield return new stagec(125, 5.2, 0, 75, 2, 12.46, 3, 7, "diploid");
                yield return new stagec(126, 1.3, 1, 70, 2, 13.69, 3, 8, "tetraploid");
                yield return new stagec(127, 6.2, 0, 59, 2, 12.06, 2, 5, "diploid");
                yield return new stagec(128, 6.5, 0, 73, 2, 13.01, 3, 6, "diploid");
                yield return new stagec(129, 1.2, 1, 66, 2, 13.21, 2, 6, "tetraploid");
                yield return new stagec(130, 5.7, 0, 66, 2, 10.43, 3, 5, "diploid");
                yield return new stagec(131, 3.4, 1, 65, 2, null, 3, 7, "aneuploid");
                yield return new stagec(132, 5.6, 0, 66, 1, 13.33, 2, 5, "tetraploid");
                yield return new stagec(133, 6, 0, 66, 2, 37.49, 3, 7, "tetraploid");
                yield return new stagec(134, 5.1, 0, 59, 2, 11.69, 3, 7, "diploid");
                yield return new stagec(135, 6, 0, 52, 2, 9.9, 2, 4, "diploid");
                yield return new stagec(136, 5.4, 0, 68, 2, 13.01, 2, 5, "diploid");
                yield return new stagec(137, 2.4, 0, 63, 2, 4.81, 3, 8, "diploid");
                yield return new stagec(138, 4.2, 0, 67, 2, 14.71, 2, 5, "tetraploid");
                yield return new stagec(139, 5.5, 0, 59, 1, 9.01, 2, 5, "diploid");
                yield return new stagec(140, 5.4, 0, 57, 1, 10.9, 3, 6, "diploid");
                yield return new stagec(141, 8.2, 0, 62, 2, 10.72, 3, 7, "diploid");
                yield return new stagec(142, 10.2, 0, 63, 2, 5.14, 2, 5, "diploid");
                yield return new stagec(143, 2.5, 1, 73, 2, 46.92, 4, 9, "tetraploid");
                yield return new stagec(144, 7.9, 0, 68, 2, null, 2, 5, "aneuploid");
                yield return new stagec(145, 5.6, 0, 51, 2, 9.59, 3, 6, "diploid");
                yield return new stagec(146, 2.1, 1, 56, 2, 9.01, 3, 7, "diploid");
            }
        }
    }
}
