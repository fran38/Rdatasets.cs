// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Data on Depression
    /// </summary>

    public class Ginzberg
    {
        public readonly int κ;
        public readonly double simplicity;
        public readonly double fatalism;
        public readonly double depression;
        public readonly double adjsimp;
        public readonly double adjfatal;
        public readonly double adjdep;

        public Ginzberg(int κ, double simplicity, double fatalism, double depression, double adjsimp, double adjfatal, double adjdep)
        {
            this.κ = κ;
            this.simplicity = simplicity;
            this.fatalism = fatalism;
            this.depression = depression;
            this.adjsimp = adjsimp;
            this.adjfatal = adjfatal;
            this.adjdep = adjdep;
        }

        public static IEnumerable<Ginzberg> Data
        {
            get
            {
                yield return new Ginzberg(1, 0.92983, 0.35589, 0.5987, 0.75934, 0.10673, 0.41865);
                yield return new Ginzberg(2, 0.91097, 1.18439, 0.72787, 0.72717, 0.99915, 0.51688);
                yield return new Ginzberg(3, 0.53366, -0.05837, 0.53411, 0.62176, 0.03811, 0.70699);
                yield return new Ginzberg(4, 0.74118, 0.35589, 0.56641, 0.83522, 0.42218, 0.65639);
                yield return new Ginzberg(5, 0.53366, 0.77014, 0.50182, 0.47697, 0.81423, 0.53518);
                yield return new Ginzberg(6, 0.62799, 1.39152, 0.56641, 0.40664, 1.23261, 0.34042);
                yield return new Ginzberg(7, 0.77891, 0.35589, 0.46953, 0.84556, 0.29789, 0.42168);
                yield return new Ginzberg(8, 0.8355, 0.56301, 0.53411, 1.49961, 1.20366, 1.08127);
                yield return new Ginzberg(9, 0.5148, 0.77014, 0.46953, 0.31082, 0.65651, 0.36337);
                yield return new Ginzberg(10, 0.87323, 0.35589, 0.46953, 1.40836, 0.85391, 0.91711);
                yield return new Ginzberg(11, 0.53366, 0.56301, 0.46953, 0.43378, 0.41506, 0.32811);
                yield return new Ginzberg(12, 0.74118, 0.35589, 0.63099, 0.53485, 0.06531, 0.411);
                yield return new Ginzberg(13, 0.68458, -0.05837, 0.46953, 1.17308, 0.30413, 0.83122);
                yield return new Ginzberg(14, 0.47707, 0.97727, 0.56641, 0.42366, 1.08912, 0.64871);
                yield return new Ginzberg(15, 0.76004, 0.97727, 0.66329, 0.755, 1.13055, 0.79753);
                yield return new Ginzberg(16, 0.98643, 1.39152, 0.72787, 1.38099, 1.82207, 1.01999);
                yield return new Ginzberg(17, 0.36387, 0.56301, 0.56641, 0.8206, 1.04594, 0.98004);
                yield return new Ginzberg(18, 0.8355, 1.18439, 0.56641, 1.23164, 1.67146, 0.92942);
                yield return new Ginzberg(19, 0.55253, 0.77014, 0.5987, 0.49834, 0.81423, 0.64106);
                yield return new Ginzberg(20, 0.38274, 0.56301, 0.56641, 0.5524, 0.7305, 0.70702);
                yield return new Ginzberg(21, 0.53366, 0.56301, 0.46953, 0.96973, 0.88023, 0.70239);
                yield return new Ginzberg(22, 0.70345, 1.39152, 0.5987, 0.77089, 1.50663, 0.60579);
                yield return new Ginzberg(23, 1.11848, 0.97727, 0.69558, 1.09622, 0.88198, 0.57515);
                yield return new Ginzberg(24, 0.74118, 0.56301, 0.66329, 0.83522, 0.65564, 0.76227);
                yield return new Ginzberg(25, 0.57139, 0.97727, 0.63099, 1.04486, 1.47144, 1.00768);
                yield return new Ginzberg(26, 0.70345, 0.77014, 0.46953, 1.03886, 1.03883, 0.65177);
                yield return new Ginzberg(27, 0.47707, 0.56301, 0.46953, 0.52526, 0.61421, 0.50757);
                yield return new Ginzberg(28, 0.57139, 0.35589, 0.50182, 0.75529, 0.45561, 0.59349);
                yield return new Ginzberg(29, 0.64685, 0.77014, 0.53411, 0.58359, 0.73138, 0.48458);
                yield return new Ginzberg(30, 0.85437, 1.18439, 0.53411, 0.66306, 0.99915, 0.30513);
                yield return new Ginzberg(31, 1.09962, 0.97727, 0.63099, 0.95166, 0.80712, 0.45395);
                yield return new Ginzberg(32, 1.19394, 0.97727, 0.5987, 1.20329, 0.96484, 0.55517);
                yield return new Ginzberg(33, 0.57139, 0.56301, 0.46953, 0.34253, 0.29877, 0.23454);
                yield return new Ginzberg(34, 1.04302, 0.56301, 0.5987, 1.03234, 0.49792, 0.55517);
                yield return new Ginzberg(35, 1.28827, 0.97727, 0.72787, 1.03136, 0.69082, 0.46625);
                yield return new Ginzberg(36, 0.25068, 1.18439, 0.50182, 0.5368, 1.54718, 0.73);
                yield return new Ginzberg(37, 0.47707, 0.77014, 0.50182, 0.51446, 0.80624, 0.49992);
                yield return new Ginzberg(38, 0.91097, 0.35589, 0.56641, 0.99515, 0.29789, 0.52756);
                yield return new Ginzberg(39, 0.47707, 0.35589, 0.53411, 0.23569, 0.06531, 0.30513);
                yield return new Ginzberg(40, 0.77891, -0.05837, 0.53411, 1.00115, 0.03012, 0.67172);
                yield return new Ginzberg(41, 0.38274, 0.56301, 0.46953, 0.69719, 0.88822, 0.73765);
                yield return new Ginzberg(42, 1.3826, 0.77014, 1.30915, 1.12741, 0.41594, 1.05856);
                yield return new Ginzberg(43, 1.2694, 1.59865, 1.34144, 1.15478, 1.54893, 1.27331);
                yield return new Ginzberg(44, 0.72231, 0.97727, 1.14768, 0.43348, 0.85653, 1.09682);
                yield return new Ginzberg(45, 1.00529, 0.97727, 1.21227, 0.9788, 0.92341, 1.18277);
                yield return new Ginzberg(46, 0.98643, 0.97727, 1.11539, 0.70026, 0.73225, 0.9327);
                yield return new Ginzberg(47, 0.5148, 0.97727, 1.0831, 0.43401, 0.96484, 1.08454);
                yield return new Ginzberg(48, 1.68444, 1.39152, 1.37373, 1.67889, 1.5226, 1.52332);
                yield return new Ginzberg(49, 1.2694, 0.97727, 1.01851, 1.05318, 0.85653, 0.95565);
                yield return new Ginzberg(50, 2.08061, 1.39152, 1.27685, 2.06284, 1.27404, 1.15978);
                yield return new Ginzberg(51, 1.04302, 0.97727, 1.17997, 0.79676, 0.85653, 1.13211);
                yield return new Ginzberg(52, 0.92983, 0.97727, 1.0831, 0.78093, 0.88997, 1.03392);
                yield return new Ginzberg(53, 1.59011, 1.59865, 1.14768, 1.67363, 1.74808, 1.24102);
                yield return new Ginzberg(54, 0.77891, 1.18439, 1.11539, 0.4544, 0.92429, 0.88975);
                yield return new Ginzberg(55, 1.23167, 1.39152, 1.27685, 0.96725, 1.15775, 1.06621);
                yield return new Ginzberg(56, 1.34487, 1.59865, 1.37373, 1.08467, 1.34978, 1.12914);
                yield return new Ginzberg(57, 0.47707, 0.97727, 1.14768, 0.39127, 0.96484, 1.15513);
                yield return new Ginzberg(58, 1.30714, 1.18439, 1.14768, 1.05273, 0.92429, 0.92504);
                yield return new Ginzberg(59, 1.42033, 1.59865, 1.21227, 1.31493, 1.5075, 1.0892);
                yield return new Ginzberg(60, 1.326, 1.18439, 1.27685, 1.19729, 0.99915, 1.11684);
                yield return new Ginzberg(61, 1.09962, 0.56301, 0.92163, 1.38602, 0.81336, 1.18111);
                yield return new Ginzberg(62, 1.02416, 0.56301, 1.21227, 1.02177, 0.53934, 1.26866);
                yield return new Ginzberg(63, 0.8921, 0.97727, 1.79354, 0.7166, 0.80712, 1.72445);
                yield return new Ginzberg(64, 1.00529, 1.18439, 1.69666, 0.71083, 0.92429, 1.525);
                yield return new Ginzberg(65, 2.85408, 2.22003, 1.5352, 2.94977, 2.24931, 1.48506);
                yield return new Ginzberg(66, 0.68458, 1.39152, 1.59979, 0.77111, 1.58948, 1.78573);
                yield return new Ginzberg(67, 2.11834, 2.0129, 1.50291, 1.99319, 1.94099, 1.39914);
                yield return new Ginzberg(68, 1.57125, 1.18439, 1.92272, 1.60907, 1.11544, 1.91624);
                yield return new Ginzberg(69, 1.74104, 2.0129, 2.0196, 1.54422, 1.85813, 1.87792);
                yield return new Ginzberg(70, 0.87323, 0.77014, 1.76125, 0.9848, 0.8891, 1.96219);
                yield return new Ginzberg(71, 0.72231, 1.59865, 2.24565, 1.4406, 2.2387, 2.78763);
                yield return new Ginzberg(72, 1.74104, 1.80577, 2.05189, 1.50102, 1.45896, 1.74144);
                yield return new Ginzberg(73, 0.81664, 1.39152, 1.40603, 0.74352, 1.30748, 1.30863);
                yield return new Ginzberg(74, 1.30714, 1.59865, 1.66437, 1.03113, 1.30835, 1.40382);
                yield return new Ginzberg(75, 0.70345, 0.97727, 1.43832, 0.79248, 1.12256, 1.60927);
                yield return new Ginzberg(76, 1.85423, 1.59865, 1.63208, 1.83881, 1.63178, 1.67682);
                yield return new Ginzberg(77, 2.26926, 1.59865, 1.85813, 2.09935, 1.2255, 1.52969);
                yield return new Ginzberg(78, 1.04302, 1.80577, 1.47061, 0.72117, 1.50039, 1.14913);
                yield return new Ginzberg(79, 1.79763, 2.22003, 1.40603, 1.59752, 2.05016, 1.16443);
                yield return new Ginzberg(80, 2.11834, 0.77014, 2.0196, 2.39515, 0.8891, 2.24452);
                yield return new Ginzberg(81, 1.42033, 1.18439, 1.47061, 1.31493, 1.04058, 1.37153);
                yield return new Ginzberg(82, 0.98643, 1.18439, 1.56749, 0.97903, 1.23973, 1.65687);
            }
        }
    }
}
