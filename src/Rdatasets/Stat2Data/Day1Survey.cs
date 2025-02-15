// ReSharper disable All

namespace Rdatasets.Stat2Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Day1Survey
    /// </summary>

    public class Day1Survey
    {
        public readonly int κ;
        public readonly int Section;
        public readonly string Class;
        public readonly string Sex;
        public readonly int? Distance;
        public readonly int Height;
        public readonly string Handedness;
        public readonly double Coins;
        public readonly int WhiteString;
        public readonly int BlackString;
        public readonly double Reading;
        public readonly double TV;
        public readonly int Pulse;
        public readonly int Texting;

        public Day1Survey(int κ, int Section, string Class, string Sex, int? Distance, int Height, string Handedness, double Coins, int WhiteString, int BlackString, double Reading, double TV, int Pulse, int Texting)
        {
            this.κ = κ;
            this.Section = Section;
            this.Class = Class;
            this.Sex = Sex;
            this.Distance = Distance;
            this.Height = Height;
            this.Handedness = Handedness;
            this.Coins = Coins;
            this.WhiteString = WhiteString;
            this.BlackString = BlackString;
            this.Reading = Reading;
            this.TV = TV;
            this.Pulse = Pulse;
            this.Texting = Texting;
        }

        public static IEnumerable<Day1Survey> Data
        {
            get
            {
                yield return new Day1Survey(1, 1, "Senior", "F", 400, 62, "Right", 1.12, 42, 6, 80, 3, 71, 3);
                yield return new Day1Survey(2, 1, "*", "F", 450, 61, "Left", 29, 45, 5, 100, 10, 78, 100);
                yield return new Day1Survey(3, 1, "Freshman", "F", 3000, 61, "Right", 1.5, 22, 4, 100, 4, 80, 2);
                yield return new Day1Survey(4, 1, "Freshman", "M", 100, 72, "Right", 0.07, 40, 4, 50, 25, 63, 200);
                yield return new Day1Survey(5, 1, "N/A", "F", 2000, 69, "Right", 0.12, 48, 7, 200, 5, 63, 100);
                yield return new Day1Survey(6, 1, "Senior", "M", 500, 73, "Right", 8, 30, 8, 100, 0, 56, 1);
                yield return new Day1Survey(7, 1, "Sophomore", "F", 1100, 60, "Right", 0.77, 50, 0, 200, 2, 72, 50);
                yield return new Day1Survey(8, 1, "Sophomore", "M", 1000, 71, "Right", 0, 45, 6, 100, 2, 66, 30);
                yield return new Day1Survey(9, 1, "Sophomore", "M", 400, 70, "Right", 0, 38, 0, 100, 20, 54, 40);
                yield return new Day1Survey(10, 1, "Sophomore", "M", 450, 75, "Left", 0, 36, 12, 100, 20, 48, 25);
                yield return new Day1Survey(11, 1, "Sophomore", "M", 400, 71, "Right", 25, 48, 12, 250, 8, 81, 25);
                yield return new Day1Survey(12, 1, "Senior", "M", 762, 69, "Ambidextrous", 4, 48, 6, 2000, 2, 66, 40);
                yield return new Day1Survey(13, 1, "Senior", "M", 300, 68, "Right", 3, 40, 11, 175, 1, 69, 5);
                yield return new Day1Survey(14, 1, "Sophomore", "F", 2300, 62, "Right", 500, 32, 3, 200, 3, 51, 5);
                yield return new Day1Survey(15, 1, "Junior", "M", 50, 77, "Right", 0, 36, 2, 50, 4, 66, 5);
                yield return new Day1Survey(16, 1, "Senior", "F", 150, 62, "Right", 1, 30, 0, 200, 0, 57, 10);
                yield return new Day1Survey(17, 1, "Junior", "M", 250, 70, "Right", 0.25, 35, 2, 200, 6, 57, 25);
                yield return new Day1Survey(18, 1, "Senior", "M", 600, 73, "Right", 4, 48, 20, 450, 1.5, 75, 2);
                yield return new Day1Survey(19, 1, "Senior", "M", 800, 71, "Left", 0, 40, 15, 100, 0, 72, 2);
                yield return new Day1Survey(20, 1, "Junior", "M", 195, 70, "Right", 0.75, 30, 3, 75, 1.5, 96, 3);
                yield return new Day1Survey(21, 1, "Junior", "F", 5000, 66, "Right", 4, 24, 0, 100, 4, 60, 1);
                yield return new Day1Survey(22, 1, "Freshman", "M", 600, 66, "Left", 0, 38, 2, 40, 2, 78, 10);
                yield return new Day1Survey(23, 1, "Junior", "M", 380, 74, "Right", 0, 43, 6, 300, 4, 63, 4);
                yield return new Day1Survey(24, 1, "Freshman", "F", 4500, 70, "Right", 2.34, 40, 4, 50, 2, 60, 12);
                yield return new Day1Survey(25, 2, "Freshman", "M", 1250, 74, "Right", 120, 40, 2, 50, 4.5, 81, 40);
                yield return new Day1Survey(26, 2, "Freshman", "M", 750, 73, "Right", 2.75, 36, 3, 12.5, 6, 57, 45);
                yield return new Day1Survey(27, 2, "Freshman", "F", 100, 66, "Right", 3, 36, 42, 2, 3, 75, 10);
                yield return new Day1Survey(28, 2, "Junior", "M", 426, 70, "Right", 0, 33, 4, 300, 2, 81, 4);
                yield return new Day1Survey(29, 2, "Sophomore", "F", 700, 67, "Right", 2.5, 43, 3, 200, 2, 72, 18);
                yield return new Day1Survey(30, 2, "Freshman", "M", 150, 70, "Right", 20, 70, 1, 80, 10, 60, 100);
                yield return new Day1Survey(31, 2, "Freshman", "F", 700, 62, "Right", 1, 38, 2, 20, 8, 75, 70);
                yield return new Day1Survey(32, 2, "Freshman", "F", 180, 70, "Right", 0, 29, 4, 200, 7, 51, 250);
                yield return new Day1Survey(33, 2, "Freshman", "M", 780, 74, "Right", 35, 43, 3, 250, 7, 72, 4);
                yield return new Day1Survey(34, 2, "Senior", "M", 800, 73, "Right", 0.14, 40, 2, 23, 4, 72, 6);
                yield return new Day1Survey(35, 2, "Junior", "F", 2000, 66, "Right", 0, 30, 3, 50, 1, 90, 3);
                yield return new Day1Survey(36, 2, "Junior", "M", 300, 69, "Right", 10, 30, 2, 45, 0, 66, 1);
                yield return new Day1Survey(37, 2, "Freshman", "M", 20000, 71, "Right", 25, 30, 5, 75, 5, 57, 0);
                yield return new Day1Survey(38, 2, "Junior", "M", 10000, 73, "Right", 0, 26, 0, 10, 5, 51, 0);
                yield return new Day1Survey(39, 2, "Junior", "M", 300, 71, "Right", 0.62, 38, 2, 200, 2, 72, 5);
                yield return new Day1Survey(40, 2, "Junior", "F", 1000, 68, "Right", 1.28, 42, 4, 160, 2, 75, 28);
                yield return new Day1Survey(41, 2, "Senior", "F", 280, 65, "Right", 0, 50, 7, 200, 4, 51, 13);
                yield return new Day1Survey(42, 2, "Senior", "M", null, 73, "Right", 0, 32, 0, 150, 2, 54, 10);
                yield return new Day1Survey(43, 2, "Sophomore", "F", 900, 62, "Right", 0.35, 34, 5, 65, 2.5, 72, 13);
            }
        }
    }
}
