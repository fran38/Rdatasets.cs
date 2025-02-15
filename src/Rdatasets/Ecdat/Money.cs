// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Money, GDP and Interest Rate in Canada
    /// </summary>

    public class Money
    {
        public readonly int κ;
        public readonly double m;
        public readonly double y;
        public readonly double p;
        public readonly double r;

        public Money(int κ, double m, double y, double p, double r)
        {
            this.κ = κ;
            this.m = m;
            this.y = y;
            this.p = p;
            this.r = r;
        }

        public static IEnumerable<Money> Data
        {
            get
            {
                yield return new Money(1, 11.21111, 12.62052, -1.49969, 4.46333);
                yield return new Money(2, 11.21075, 12.64173, -1.48955, 4.17333);
                yield return new Money(3, 11.20382, 12.64643, -1.48414, 4.47333);
                yield return new Money(4, 11.17621, 12.65076, -1.47146, 5.45333);
                yield return new Money(5, 11.1433, 12.65842, -1.45747, 6.69);
                yield return new Money(6, 11.11438, 12.68715, -1.45569, 6.83333);
                yield return new Money(7, 11.11241, 12.7031, -1.44847, 5.72333);
                yield return new Money(8, 11.10287, 12.71848, -1.43829, 5.82333);
                yield return new Money(9, 11.08563, 12.73085, -1.42332, 6.46333);
                yield return new Money(10, 11.07028, 12.73508, -1.40795, 6.89);
                yield return new Money(11, 11.0349, 12.74712, -1.40062, 7.69333);
                yield return new Money(12, 11.01156, 12.76239, -1.39011, 7.72333);
                yield return new Money(13, 10.9789, 12.76398, -1.37052, 7.46);
                yield return new Money(14, 10.96153, 12.76374, -1.36247, 6.35333);
                yield return new Money(15, 10.95567, 12.77726, -1.35579, 5.53333);
                yield return new Money(16, 10.95667, 12.77405, -1.34416, 4.61667);
                yield return new Money(17, 10.98155, 12.7842, -1.33956, 3.96667);
                yield return new Money(18, 11.0065, 12.81427, -1.32843, 3.13333);
                yield return new Money(19, 11.03369, 12.84125, -1.32286, 3.84333);
                yield return new Money(20, 11.05235, 12.85318, -1.30833, 3.30667);
                yield return new Money(21, 11.05913, 12.84753, -1.28646, 3.46);
                yield return new Money(22, 11.07608, 12.87644, -1.27749, 3.62333);
                yield return new Money(23, 11.09127, 12.87682, -1.26062, 3.52667);
                yield return new Money(24, 11.11172, 12.90129, -1.24253, 3.63333);
                yield return new Money(25, 11.1215, 12.93017, -1.22467, 4.11667);
                yield return new Money(26, 11.11433, 12.93959, -1.19261, 5.18667);
                yield return new Money(27, 11.11017, 12.94252, -1.1621, 6.14);
                yield return new Money(28, 11.09312, 12.9679, -1.12921, 6.43667);
                yield return new Money(29, 11.06725, 12.97796, -1.09044, 6.26667);
                yield return new Money(30, 11.06163, 12.98056, -1.05201, 8.34);
                yield return new Money(31, 11.00764, 12.98935, -1.01908, 9.05);
                yield return new Money(32, 10.98193, 12.99501, -0.99843, 7.64);
                yield return new Money(33, 11.00563, 12.99077, -0.97838, 6.33);
                yield return new Money(34, 11.01921, 13.00144, -0.95779, 6.90333);
                yield return new Money(35, 11.02323, 13.01567, -0.92851, 7.90667);
                yield return new Money(36, 11.04384, 13.02244, -0.90413, 8.44);
                yield return new Money(37, 11.0154, 13.04271, -0.88335, 8.81667);
                yield return new Money(38, 10.98871, 13.06499, -0.8561, 8.97);
                yield return new Money(39, 10.99449, 13.0684, -0.84878, 9.10333);
                yield return new Money(40, 10.9859, 13.06811, -0.82754, 8.58);
                yield return new Money(41, 10.98834, 13.08518, -0.81133, 7.74333);
                yield return new Money(42, 10.9982, 13.08816, -0.79384, 7.23333);
                yield return new Money(43, 11.00111, 13.09496, -0.77828, 7.12667);
                yield return new Money(44, 11.01633, 13.11197, -0.76803, 7.22333);
                yield return new Money(45, 11.0243, 13.11969, -0.75155, 7.38667);
                yield return new Money(46, 11.02548, 13.12995, -0.73308, 8.21667);
                yield return new Money(47, 11.03, 13.1409, -0.71761, 8.87667);
                yield return new Money(48, 11.031, 13.14964, -0.69534, 10.22333);
                yield return new Money(49, 11.00298, 13.16078, -0.67473, 10.86333);
                yield return new Money(50, 10.99349, 13.17404, -0.6428, 10.81333);
                yield return new Money(51, 10.993, 13.17922, -0.61703, 11.44333);
                yield return new Money(52, 10.96523, 13.19088, -0.59884, 13.63);
                yield return new Money(53, 10.95263, 13.195, -0.57422, 14.09667);
                yield return new Money(54, 10.92316, 13.19063, -0.54778, 12.37);
                yield return new Money(55, 10.92545, 13.18109, -0.5133, 10.5);
                yield return new Money(56, 10.93578, 13.19335, -0.48261, 14.20667);
                yield return new Money(57, 10.89838, 13.21775, -0.45638, 16.71);
                yield return new Money(58, 10.87412, 13.22719, -0.43337, 18.20333);
                yield return new Money(59, 10.84751, 13.22017, -0.41332, 20.15333);
                yield return new Money(60, 10.80089, 13.21502, -0.39704, 15.81333);
                yield return new Money(61, 10.79454, 13.20745, -0.37289, 14.66333);
                yield return new Money(62, 10.8201, 13.19351, -0.35139, 15.49667);
                yield return new Money(63, 10.80015, 13.18455, -0.33324, 13.89333);
                yield return new Money(64, 10.81154, 13.17514, -0.31441, 10.57667);
                yield return new Money(65, 10.85662, 13.19098, -0.30581, 9.32667);
                yield return new Money(66, 10.88183, 13.21369, -0.29971, 9.18);
                yield return new Money(67, 10.90767, 13.22663, -0.28328, 9.25667);
                yield return new Money(68, 10.91357, 13.23765, -0.27493, 9.47667);
                yield return new Money(69, 10.92077, 13.25112, -0.26386, 10.02667);
                yield return new Money(70, 10.94166, 13.26962, -0.2603, 11.33);
                yield return new Money(71, 10.97413, 13.27605, -0.25438, 12.29333);
                yield return new Money(72, 11.04225, 13.29304, -0.25077, 10.58667);
                yield return new Money(73, 11.11906, 13.31079, -0.24873, 10.39);
                yield return new Money(74, 11.17584, 13.31544, -0.23319, 9.53667);
                yield return new Money(75, 11.25622, 13.32802, -0.22718, 8.92);
                yield return new Money(76, 11.32914, 13.34604, -0.22343, 8.87333);
                yield return new Money(77, 11.34993, 13.34738, -0.21844, 10.76333);
                yield return new Money(78, 11.3805, 13.35286, -0.21225, 8.54667);
                yield return new Money(79, 11.42103, 13.35513, -0.20382, 8.31333);
                yield return new Money(80, 11.44455, 13.34945, -0.18789, 8.26);
                yield return new Money(81, 11.48619, 13.37097, -0.17652, 7.10667);
                yield return new Money(82, 11.51603, 13.38277, -0.16365, 8.18667);
                yield return new Money(83, 11.4956, 13.3994, -0.15499, 9.10333);
                yield return new Money(84, 11.46743, 13.41202, -0.14236, 8.18667);
                yield return new Money(85, 11.44988, 13.42799, -0.13247, 8.40667);
                yield return new Money(86, 11.45576, 13.4393, -0.12456, 8.99333);
                yield return new Money(87, 11.46161, 13.44025, -0.10758, 9.86667);
                yield return new Money(88, 11.45178, 13.44791, -0.0952, 10.66333);
                yield return new Money(89, 11.45511, 13.45916, -0.087354, 11.64333);
                yield return new Money(90, 11.44049, 13.46359, -0.071957, 12.20667);
                yield return new Money(91, 11.44827, 13.46578, -0.062351, 12.16667);
                yield return new Money(92, 11.46199, 13.46718, -0.05764, 12.2);
                yield return new Money(93, 11.4507, 13.47379, -0.051182, 12.92);
                yield return new Money(94, 11.44046, 13.47097, -0.042226, 13.6);
                yield return new Money(95, 11.42493, 13.46533, -0.035557, 12.76667);
                yield return new Money(96, 11.44, 13.45627, -0.028998, 11.94667);
                yield return new Money(97, 11.44864, 13.4429, -0.019139, 9.95667);
                yield return new Money(98, 11.4645, 13.44536, -0.012249, 8.901);
                yield return new Money(99, 11.47795, 13.44959, -0.010162, 8.50967);
                yield return new Money(100, 11.48163, 13.4529, -0.010912, 7.53933);
                yield return new Money(101, 11.50001, 13.45315, -0.0069838, 7.17633);
                yield return new Money(102, 11.49312, 13.4547, -0.0019126, 6.132);
                yield return new Money(103, 11.51212, 13.45743, 0.0033534, 5.78733);
                yield return new Money(104, 11.52104, 13.46172, 0.005438, 7.244);
                yield return new Money(105, 11.52255, 13.46971, 0.0072989, 5.83933);
                yield return new Money(106, 11.5468, 13.47619, 0.015315, 4.91067);
                yield return new Money(107, 11.56833, 13.48193, 0.015387, 4.51467);
                yield return new Money(108, 11.59901, 13.48989, 0.019507, 4.10967);
                yield return new Money(109, 11.625, 13.50448, 0.020309, 4.29);
                yield return new Money(110, 11.65191, 13.52049, 0.019494, 6.275);
                yield return new Money(111, 11.65288, 13.53398, 0.028742, 5.47967);
                yield return new Money(112, 11.6485, 13.54313, 0.032213, 6.11467);
                yield return new Money(113, 11.64416, 13.55142, 0.03882, 7.988);
                yield return new Money(114, 11.68886, 13.55055, 0.048098, 7.344);
                yield return new Money(115, 11.72855, 13.55262, 0.051896, 6.47233);
                yield return new Money(116, 11.73101, 13.55721, 0.054022, 5.762);
                yield return new Money(117, 11.75624, 13.55976, 0.054191, 5.108);
                yield return new Money(118, 11.77888, 13.56378, 0.062184, 4.68867);
                yield return new Money(119, 11.78758, 13.57417, 0.06668, 4.14);
                yield return new Money(120, 11.83236, 13.58125, 0.073096, 2.894);
                yield return new Money(121, 11.86156, 13.59143, 0.074688, 2.96167);
                yield return new Money(122, 11.87847, 13.60205, 0.072717, 3.00133);
                yield return new Money(123, 11.90236, 13.61624, 0.070846, 3.18333);
                yield return new Money(124, 11.93379, 13.62405, 0.070824, 3.88733);
                yield return new Money(125, 11.96048, 13.63098, 0.068732, 4.43967);
                yield return new Money(126, 11.97186, 13.63364, 0.069563, 4.819);
                yield return new Money(127, 11.99918, 13.63998, 0.063132, 4.91267);
                yield return new Money(128, 12.00088, 13.65164, 0.063732, 4.753);
            }
        }
    }
}
