// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Backpack
    /// </summary>

    public class Backpack
    {
        public readonly int κ;
        public readonly int BackpackWeight;
        public readonly int BodyWeight;
        public readonly double Ratio;
        public readonly int BackProblems;
        public readonly string Major;
        public readonly int Year;
        public readonly string Sex;
        public readonly string Status;
        public readonly int Units;

        public Backpack(int κ, int BackpackWeight, int BodyWeight, double Ratio, int BackProblems, string Major, int Year, string Sex, string Status, int Units)
        {
            this.κ = κ;
            this.BackpackWeight = BackpackWeight;
            this.BodyWeight = BodyWeight;
            this.Ratio = Ratio;
            this.BackProblems = BackProblems;
            this.Major = Major;
            this.Year = Year;
            this.Sex = Sex;
            this.Status = Status;
            this.Units = Units;
        }

        public static IEnumerable<Backpack> Data
        {
            get
            {
                yield return new Backpack(1, 9, 125, 0.072, 1, "Bio", 3, "Female", "U", 13);
                yield return new Backpack(2, 8, 195, 0.0410256, 0, "Philosophy", 5, "Male", "U", 12);
                yield return new Backpack(3, 10, 120, 0.0833333, 1, "GRC", 4, "Female", "U", 14);
                yield return new Backpack(4, 6, 155, 0.0387097, 0, "CSC", 6, "Male", "G", 0);
                yield return new Backpack(5, 8, 180, 0.0444444, 0, "EE", 2, "Female", "U", 14);
                yield return new Backpack(6, 5, 240, 0.0208333, 0, "History", 0, "Male", "G", 0);
                yield return new Backpack(7, 8, 170, 0.0470588, 0, "CM", 3, "Male", "U", 15);
                yield return new Backpack(8, 4, 185, 0.0216216, 1, "ARCE", 5, "Female", "U", 18);
                yield return new Backpack(9, 5, 130, 0.0384615, 0, "Bio", 4, "Female", "U", 14);
                yield return new Backpack(10, 2, 120, 0.0166667, 0, "Bio", 5, "Female", "U", 8);
                yield return new Backpack(11, 8, 135, 0.0592593, 0, "Bus", 3, "Female", "U", 15);
                yield return new Backpack(12, 21, 160, 0.13125, 0, "ME", 5, "Male", "U", 12);
                yield return new Backpack(13, 11, 170, 0.0647059, 0, "CPE", 4, "Male", "U", 16);
                yield return new Backpack(14, 11, 170, 0.0647059, 1, "CPE", 4, "Male", "U", 16);
                yield return new Backpack(15, 12, 125, 0.096, 1, "CS", 3, "Female", "U", 12);
                yield return new Backpack(16, 11, 175, 0.0628571, 0, "CPE", 4, "Male", "U", 16);
                yield return new Backpack(17, 13, 145, 0.0896552, 1, "Bio", 4, "Female", "U", 16);
                yield return new Backpack(18, 6, 105, 0.0571429, 0, "LS", 3, "Female", "U", 16);
                yield return new Backpack(19, 10, 125, 0.08, 1, "LS", 3, "Female", "U", 17);
                yield return new Backpack(20, 5, 165, 0.030303, 0, "Bio", 3, "Male", "U", 14);
                yield return new Backpack(21, 20, 170, 0.117647, 0, "CSC", 2, "Male", "U", 16);
                yield return new Backpack(22, 14, 117, 0.119658, 1, "EE", 2, "Female", "U", 12);
                yield return new Backpack(23, 11, 145, 0.0758621, 0, "CE", 5, "Male", "U", 14);
                yield return new Backpack(24, 15, 205, 0.0731707, 0, "Bio", 5, "Female", "U", 12);
                yield return new Backpack(25, 10, 270, 0.037037, 0, "AGB", 3, "Male", "U", 12);
                yield return new Backpack(26, 18, 160, 0.1125, 1, "Mate", 1, "Male", "U", 13);
                yield return new Backpack(27, 8, 150, 0.0533333, 0, "AGB", 4, "Male", "U", 16);
                yield return new Backpack(28, 5, 140, 0.0357143, 0, "Poli Sci", 2, "Female", "U", 16);
                yield return new Backpack(29, 25, 190, 0.131579, 0, "Aero Eng.", 2, "Male", "U", 14);
                yield return new Backpack(30, 6, 165, 0.0363636, 1, "Soc. Sci.", 1, "Female", "U", 15);
                yield return new Backpack(31, 10, 145, 0.0689655, 1, "GRC", 1, "Female", "U", 14);
                yield return new Backpack(32, 15, 120, 0.125, 1, "MLL", 3, "Female", "U", 16);
                yield return new Backpack(33, 9, 135, 0.0666667, 0, "LS", 6, "Female", "G", 14);
                yield return new Backpack(34, 7, 145, 0.0482759, 0, "CPE", 6, "Male", "U", 11);
                yield return new Backpack(35, 14, 165, 0.0848485, 1, "Math", 5, "Female", "U", 12);
                yield return new Backpack(36, 17, 145, 0.117241, 0, "Psych", 4, "Female", "U", 13);
                yield return new Backpack(37, 14, 140, 0.1, 0, "ARCE", 2, "Female", "U", 15);
                yield return new Backpack(38, 11, 160, 0.06875, 0, "EE", 4, "Male", "U", 15);
                yield return new Backpack(39, 4, 155, 0.0258065, 0, "IT", 3, "Male", "U", 16);
                yield return new Backpack(40, 8, 143, 0.0559441, 0, "Psy", 2, "Female", "U", 17);
                yield return new Backpack(41, 8, 145, 0.0551724, 1, "AGB", 4, "Female", "U", 16);
                yield return new Backpack(42, 13, 135, 0.0962963, 1, "SOCS", 3, "Female", "U", 16);
                yield return new Backpack(43, 10, 130, 0.0769231, 0, "Nut.", 3, "Female", "U", 16);
                yield return new Backpack(44, 15, 165, 0.0909091, 1, "Math", 4, "Female", "U", 12);
                yield return new Backpack(45, 10, 140, 0.0714286, 0, "LS", 1, "Female", "U", 14);
                yield return new Backpack(46, 5, 115, 0.0434783, 0, "Soc. Sci.", 1, "Female", "U", 13);
                yield return new Backpack(47, 6, 128, 0.046875, 0, "Bus", 1, "Female", "U", 14);
                yield return new Backpack(48, 5, 150, 0.0333333, 0, "SPC", 2, "Female", "U", 14);
                yield return new Backpack(49, 13, 220, 0.0590909, 0, "CE", 2, "Male", "U", 13);
                yield return new Backpack(50, 10, 150, 0.0666667, 0, "CD", 3, "Female", "U", 16);
                yield return new Backpack(51, 19, 170, 0.111765, 0, "ME", 5, "Male", "U", 12);
                yield return new Backpack(52, 8, 155, 0.0516129, 0, "Econ", 2, "Male", "U", 12);
                yield return new Backpack(53, 21, 116, 0.181034, 0, "Vocal Music", 4, "Female", "U", 16);
                yield return new Backpack(54, 16, 190, 0.0842105, 0, "Bus", 2, "Male", "U", 14);
                yield return new Backpack(55, 13, 145, 0.0896552, 0, "Bio", 4, "Female", "U", 16);
                yield return new Backpack(56, 17, 144, 0.118056, 1, "Bio", 2, "Female", "U", 13);
                yield return new Backpack(57, 10, 130, 0.0769231, 0, "Kine", 2, "Female", "U", 15);
                yield return new Backpack(58, 5, 185, 0.027027, 1, "Psych", 4, "Male", "U", 15);
                yield return new Backpack(59, 9, 140, 0.0642857, 0, "Kine", 3, "Female", "U", 16);
                yield return new Backpack(60, 13, 125, 0.104, 0, "Math", 2, "Female", "U", 17);
                yield return new Backpack(61, 10, 175, 0.0571429, 0, "Act.", 2, "Male", "U", 19);
                yield return new Backpack(62, 10, 150, 0.0666667, 0, "Nutrition", 4, "Female", "U", 12);
                yield return new Backpack(63, 11, 180, 0.0611111, 1, "Kine", 4, "Male", "U", 18);
                yield return new Backpack(64, 8, 140, 0.0571429, 1, "Poli Sci", 3, "Female", "U", 12);
                yield return new Backpack(65, 12, 220, 0.0545455, 0, "EE", 1, "Male", "U", 14);
                yield return new Backpack(66, 35, 195, 0.179487, 0, "Aero", 5, "Male", "U", 12);
                yield return new Backpack(67, 12, 127, 0.0944882, 1, "Phys", 5, "Female", "U", 16);
                yield return new Backpack(68, 14, 150, 0.0933333, 0, "Kine", 3, "Female", "U", 16);
                yield return new Backpack(69, 2, 125, 0.016, 0, "IT", 5, "Male", "U", 15);
                yield return new Backpack(70, 5, 125, 0.04, 1, "ARCE", 2, "Female", "U", 16);
                yield return new Backpack(71, 6, 180, 0.0333333, 0, "ME", 4, "Male", "U", 15);
                yield return new Backpack(72, 20, 180, 0.111111, 1, "CPE", 1, "Male", "U", 13);
                yield return new Backpack(73, 14, 150, 0.0933333, 0, "Aero", 2, "Male", "U", 14);
                yield return new Backpack(74, 14, 125, 0.112, 0, "Pols", 2, "Female", "U", 17);
                yield return new Backpack(75, 8, 160, 0.05, 0, "ME", 2, "Male", "U", 13);
                yield return new Backpack(76, 25, 144, 0.173611, 0, "LS", 3, "Female", "U", 17);
                yield return new Backpack(77, 2, 105, 0.0190476, 0, "IE", 6, "Female", "U", 15);
                yield return new Backpack(78, 8, 125, 0.064, 1, "Pols", 5, "Female", "U", 16);
                yield return new Backpack(79, 15, 130, 0.115385, 1, "Bus", 3, "Female", "U", 16);
                yield return new Backpack(80, 10, 120, 0.0833333, 0, "AGB", 4, "Female", "U", 16);
                yield return new Backpack(81, 25, 175, 0.142857, 1, "CE", 4, "Female", "U", 15);
                yield return new Backpack(82, 24, 145, 0.165517, 1, "Bus", 3, "Female", "U", 16);
                yield return new Backpack(83, 5, 115, 0.0434783, 1, "ME", 3, "Female", "U", 14);
                yield return new Backpack(84, 10, 110, 0.0909091, 0, "CE", 2, "Female", "U", 16);
                yield return new Backpack(85, 19, 130, 0.146154, 1, "LS", 5, "Female", "U", 16);
                yield return new Backpack(86, 13, 135, 0.0962963, 0, "LS", 4, "Female", "U", 16);
                yield return new Backpack(87, 9, 128, 0.0703125, 0, "Aero", 1, "Female", "U", 16);
                yield return new Backpack(88, 14, 135, 0.103704, 0, "ARCE", 4, "Male", "U", 13);
                yield return new Backpack(89, 20, 170, 0.117647, 1, "Bus", 3, "Male", "U", 18);
                yield return new Backpack(90, 16, 175, 0.0914286, 0, "Bio", 3, "Male", "U", 12);
                yield return new Backpack(91, 18, 150, 0.12, 0, "IT", 6, "Male", "U", 17);
                yield return new Backpack(92, 18, 160, 0.1125, 1, "MFGE", 3, "Male", "U", 13);
                yield return new Backpack(93, 11, 168, 0.0654762, 1, "Bus", 3, "Male", "U", 16);
                yield return new Backpack(94, 13, 155, 0.083871, 0, "Psy", 4, "Male", "U", 14);
                yield return new Backpack(95, 15, 210, 0.0714286, 0, "Arch", 3, "Male", "U", 17);
                yield return new Backpack(96, 14, 165, 0.0848485, 0, "ME", 3, "Male", "U", 11);
                yield return new Backpack(97, 6, 195, 0.0307692, 0, "APIO", 1, "Male", "U", 16);
                yield return new Backpack(98, 11, 130, 0.0846154, 0, "Bus", 1, "Male", "U", 12);
                yield return new Backpack(99, 9, 140, 0.0642857, 0, "AERO", 3, "Male", "U", 12);
                yield return new Backpack(100, 15, 170, 0.0882353, 0, "History", 5, "Male", "U", 14);
            }
        }
    }
}
