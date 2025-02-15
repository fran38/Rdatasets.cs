// ReSharper disable All

namespace Rdatasets.geepack
{
    using System.Collections.Generic;

    /// <summary>
    /// Ordinal Data from Koch
    /// </summary>

    public class koch
    {
        public readonly double κ;
        public readonly int trt;
        public readonly int day;
        public readonly int y;
        public readonly int id;

        public koch(double κ, int trt, int day, int y, int id)
        {
            this.κ = κ;
            this.trt = trt;
            this.day = day;
            this.y = y;
            this.id = id;
        }

        public static IEnumerable<koch> Data
        {
            get
            {
                yield return new koch(1.1, 1, 3, 3, 1);
                yield return new koch(1.2, 1, 7, 2, 1);
                yield return new koch(1.3, 1, 10, 2, 1);
                yield return new koch(1.4, 1, 14, 2, 1);
                yield return new koch(2.1, 1, 3, 2, 2);
                yield return new koch(2.2, 1, 7, 2, 2);
                yield return new koch(2.3, 1, 10, 2, 2);
                yield return new koch(2.4, 1, 14, 1, 2);
                yield return new koch(3.1, 1, 3, 2, 3);
                yield return new koch(3.2, 1, 7, 2, 3);
                yield return new koch(3.3, 1, 10, 2, 3);
                yield return new koch(3.4, 1, 14, 2, 3);
                yield return new koch(4.1, 1, 3, 1, 4);
                yield return new koch(4.2, 1, 7, 2, 4);
                yield return new koch(4.3, 1, 10, 1, 4);
                yield return new koch(4.4, 1, 14, 2, 4);
                yield return new koch(5.1, 1, 3, 3, 5);
                yield return new koch(5.2, 1, 7, 2, 5);
                yield return new koch(5.3, 1, 10, 2, 5);
                yield return new koch(5.4, 1, 14, 1, 5);
                yield return new koch(6.1, 1, 3, 2, 6);
                yield return new koch(6.2, 1, 7, 2, 6);
                yield return new koch(6.3, 1, 10, 1, 6);
                yield return new koch(6.4, 1, 14, 3, 6);
                yield return new koch(7.1, 1, 3, 3, 7);
                yield return new koch(7.2, 1, 7, 2, 7);
                yield return new koch(7.3, 1, 10, 2, 7);
                yield return new koch(7.4, 1, 14, 1, 7);
                yield return new koch(8.1, 1, 3, 2, 8);
                yield return new koch(8.2, 1, 7, 1, 8);
                yield return new koch(8.3, 1, 10, 2, 8);
                yield return new koch(8.4, 1, 14, 1, 8);
                yield return new koch(9.1, 1, 3, 2, 9);
                yield return new koch(9.2, 1, 7, 2, 9);
                yield return new koch(9.3, 1, 10, 2, 9);
                yield return new koch(9.4, 1, 14, 1, 9);
                yield return new koch(10.1, 1, 3, 2, 10);
                yield return new koch(10.2, 1, 7, 1, 10);
                yield return new koch(10.3, 1, 10, 2, 10);
                yield return new koch(10.4, 1, 14, 1, 10);
                yield return new koch(11.1, 1, 3, 2, 11);
                yield return new koch(11.2, 1, 7, 1, 11);
                yield return new koch(11.3, 1, 10, 2, 11);
                yield return new koch(11.4, 1, 14, 2, 11);
                yield return new koch(12.1, 1, 3, 2, 12);
                yield return new koch(12.2, 1, 7, 2, 12);
                yield return new koch(12.3, 1, 10, 1, 12);
                yield return new koch(12.4, 1, 14, 2, 12);
                yield return new koch(13.1, 1, 3, 3, 13);
                yield return new koch(13.2, 1, 7, 2, 13);
                yield return new koch(13.3, 1, 10, 2, 13);
                yield return new koch(13.4, 1, 14, 2, 13);
                yield return new koch(14.1, 1, 3, 2, 14);
                yield return new koch(14.2, 1, 7, 1, 14);
                yield return new koch(14.3, 1, 10, 1, 14);
                yield return new koch(14.4, 1, 14, 1, 14);
                yield return new koch(15.1, 1, 3, 3, 15);
                yield return new koch(15.2, 1, 7, 2, 15);
                yield return new koch(15.3, 1, 10, 3, 15);
                yield return new koch(15.4, 1, 14, 2, 15);
                yield return new koch(16.1, 1, 3, 3, 16);
                yield return new koch(16.2, 1, 7, 2, 16);
                yield return new koch(16.3, 1, 10, 1, 16);
                yield return new koch(16.4, 1, 14, 1, 16);
                yield return new koch(17.1, 1, 3, 2, 17);
                yield return new koch(17.2, 1, 7, 3, 17);
                yield return new koch(17.3, 1, 10, 2, 17);
                yield return new koch(17.4, 1, 14, 2, 17);
                yield return new koch(18.1, 1, 3, 3, 18);
                yield return new koch(18.2, 1, 7, 3, 18);
                yield return new koch(18.3, 1, 10, 3, 18);
                yield return new koch(18.4, 1, 14, 2, 18);
                yield return new koch(19.1, 1, 3, 1, 19);
                yield return new koch(19.2, 1, 7, 1, 19);
                yield return new koch(19.3, 1, 10, 1, 19);
                yield return new koch(19.4, 1, 14, 1, 19);
                yield return new koch(20.1, 1, 3, 2, 20);
                yield return new koch(20.2, 1, 7, 2, 20);
                yield return new koch(20.3, 1, 10, 2, 20);
                yield return new koch(20.4, 1, 14, 1, 20);
                yield return new koch(21.1, 1, 3, 3, 21);
                yield return new koch(21.2, 1, 7, 1, 21);
                yield return new koch(21.3, 1, 10, 2, 21);
                yield return new koch(21.4, 1, 14, 2, 21);
                yield return new koch(22.1, 1, 3, 2, 22);
                yield return new koch(22.2, 1, 7, 2, 22);
                yield return new koch(22.3, 1, 10, 3, 22);
                yield return new koch(22.4, 1, 14, 1, 22);
                yield return new koch(23.1, 1, 3, 2, 23);
                yield return new koch(23.2, 1, 7, 1, 23);
                yield return new koch(23.3, 1, 10, 1, 23);
                yield return new koch(23.4, 1, 14, 1, 23);
                yield return new koch(24.1, 1, 3, 2, 24);
                yield return new koch(24.2, 1, 7, 1, 24);
                yield return new koch(24.3, 1, 10, 1, 24);
                yield return new koch(24.4, 1, 14, 1, 24);
                yield return new koch(25.1, 1, 3, 2, 25);
                yield return new koch(25.2, 1, 7, 1, 25);
                yield return new koch(25.3, 1, 10, 2, 25);
                yield return new koch(25.4, 1, 14, 1, 25);
                yield return new koch(26.1, 1, 3, 2, 26);
                yield return new koch(26.2, 1, 7, 2, 26);
                yield return new koch(26.3, 1, 10, 2, 26);
                yield return new koch(26.4, 1, 14, 2, 26);
                yield return new koch(27.1, 1, 3, 3, 27);
                yield return new koch(27.2, 1, 7, 2, 27);
                yield return new koch(27.3, 1, 10, 3, 27);
                yield return new koch(27.4, 1, 14, 2, 27);
                yield return new koch(28.1, 1, 3, 3, 28);
                yield return new koch(28.2, 1, 7, 2, 28);
                yield return new koch(28.3, 1, 10, 2, 28);
                yield return new koch(28.4, 1, 14, 2, 28);
                yield return new koch(29.1, 1, 3, 2, 29);
                yield return new koch(29.2, 1, 7, 3, 29);
                yield return new koch(29.3, 1, 10, 2, 29);
                yield return new koch(29.4, 1, 14, 2, 29);
                yield return new koch(30.1, 1, 3, 1, 30);
                yield return new koch(30.2, 1, 7, 1, 30);
                yield return new koch(30.3, 1, 10, 1, 30);
                yield return new koch(30.4, 1, 14, 1, 30);
                yield return new koch(31.1, 1, 3, 1, 31);
                yield return new koch(31.2, 1, 7, 2, 31);
                yield return new koch(31.3, 1, 10, 1, 31);
                yield return new koch(31.4, 1, 14, 2, 31);
                yield return new koch(32.1, 1, 3, 2, 32);
                yield return new koch(32.2, 1, 7, 2, 32);
                yield return new koch(32.3, 1, 10, 2, 32);
                yield return new koch(32.4, 1, 14, 1, 32);
                yield return new koch(33.1, 1, 3, 2, 33);
                yield return new koch(33.2, 1, 7, 1, 33);
                yield return new koch(33.3, 1, 10, 1, 33);
                yield return new koch(33.4, 1, 14, 1, 33);
                yield return new koch(34.1, 1, 3, 1, 34);
                yield return new koch(34.2, 1, 7, 1, 34);
                yield return new koch(34.3, 1, 10, 1, 34);
                yield return new koch(34.4, 1, 14, 1, 34);
                yield return new koch(35.1, 1, 3, 2, 35);
                yield return new koch(35.2, 1, 7, 1, 35);
                yield return new koch(35.3, 1, 10, 1, 35);
                yield return new koch(35.4, 1, 14, 1, 35);
                yield return new koch(36.1, 1, 3, 2, 36);
                yield return new koch(36.2, 1, 7, 3, 36);
                yield return new koch(36.3, 1, 10, 2, 36);
                yield return new koch(36.4, 1, 14, 2, 36);
                yield return new koch(37.1, 0, 3, 3, 37);
                yield return new koch(37.2, 0, 7, 2, 37);
                yield return new koch(37.3, 0, 10, 2, 37);
                yield return new koch(37.4, 0, 14, 2, 37);
                yield return new koch(38.1, 0, 3, 2, 38);
                yield return new koch(38.2, 0, 7, 2, 38);
                yield return new koch(38.3, 0, 10, 1, 38);
                yield return new koch(38.4, 0, 14, 1, 38);
                yield return new koch(39.1, 0, 3, 3, 39);
                yield return new koch(39.2, 0, 7, 3, 39);
                yield return new koch(39.3, 0, 10, 3, 39);
                yield return new koch(39.4, 0, 14, 2, 39);
                yield return new koch(40.1, 0, 3, 2, 40);
                yield return new koch(40.2, 0, 7, 2, 40);
                yield return new koch(40.3, 0, 10, 1, 40);
                yield return new koch(40.4, 0, 14, 2, 40);
                yield return new koch(41.1, 0, 3, 3, 41);
                yield return new koch(41.2, 0, 7, 2, 41);
                yield return new koch(41.3, 0, 10, 2, 41);
                yield return new koch(41.4, 0, 14, 1, 41);
                yield return new koch(42.1, 0, 3, 2, 42);
                yield return new koch(42.2, 0, 7, 2, 42);
                yield return new koch(42.3, 0, 10, 2, 42);
                yield return new koch(42.4, 0, 14, 1, 42);
                yield return new koch(43.1, 0, 3, 2, 43);
                yield return new koch(43.2, 0, 7, 2, 43);
                yield return new koch(43.3, 0, 10, 2, 43);
                yield return new koch(43.4, 0, 14, 2, 43);
                yield return new koch(44.1, 0, 3, 3, 44);
                yield return new koch(44.2, 0, 7, 3, 44);
                yield return new koch(44.3, 0, 10, 3, 44);
                yield return new koch(44.4, 0, 14, 2, 44);
                yield return new koch(45.1, 0, 3, 3, 45);
                yield return new koch(45.2, 0, 7, 2, 45);
                yield return new koch(45.3, 0, 10, 3, 45);
                yield return new koch(45.4, 0, 14, 2, 45);
                yield return new koch(46.1, 0, 3, 2, 46);
                yield return new koch(46.2, 0, 7, 2, 46);
                yield return new koch(46.3, 0, 10, 1, 46);
                yield return new koch(46.4, 0, 14, 2, 46);
                yield return new koch(47.1, 0, 3, 1, 47);
                yield return new koch(47.2, 0, 7, 2, 47);
                yield return new koch(47.3, 0, 10, 1, 47);
                yield return new koch(47.4, 0, 14, 2, 47);
                yield return new koch(48.1, 0, 3, 3, 48);
                yield return new koch(48.2, 0, 7, 2, 48);
                yield return new koch(48.3, 0, 10, 2, 48);
                yield return new koch(48.4, 0, 14, 2, 48);
                yield return new koch(49.1, 0, 3, 2, 49);
                yield return new koch(49.2, 0, 7, 1, 49);
                yield return new koch(49.3, 0, 10, 1, 49);
                yield return new koch(49.4, 0, 14, 1, 49);
                yield return new koch(50.1, 0, 3, 2, 50);
                yield return new koch(50.2, 0, 7, 2, 50);
                yield return new koch(50.3, 0, 10, 3, 50);
                yield return new koch(50.4, 0, 14, 2, 50);
                yield return new koch(51.1, 0, 3, 3, 51);
                yield return new koch(51.2, 0, 7, 2, 51);
                yield return new koch(51.3, 0, 10, 2, 51);
                yield return new koch(51.4, 0, 14, 2, 51);
                yield return new koch(52.1, 0, 3, 2, 52);
                yield return new koch(52.2, 0, 7, 1, 52);
                yield return new koch(52.3, 0, 10, 2, 52);
                yield return new koch(52.4, 0, 14, 2, 52);
                yield return new koch(53.1, 0, 3, 3, 53);
                yield return new koch(53.2, 0, 7, 3, 53);
                yield return new koch(53.3, 0, 10, 3, 53);
                yield return new koch(53.4, 0, 14, 2, 53);
                yield return new koch(54.1, 0, 3, 2, 54);
                yield return new koch(54.2, 0, 7, 2, 54);
                yield return new koch(54.3, 0, 10, 2, 54);
                yield return new koch(54.4, 0, 14, 1, 54);
                yield return new koch(55.1, 0, 3, 3, 55);
                yield return new koch(55.2, 0, 7, 2, 55);
                yield return new koch(55.3, 0, 10, 3, 55);
                yield return new koch(55.4, 0, 14, 2, 55);
                yield return new koch(56.1, 0, 3, 3, 56);
                yield return new koch(56.2, 0, 7, 3, 56);
                yield return new koch(56.3, 0, 10, 3, 56);
                yield return new koch(56.4, 0, 14, 2, 56);
                yield return new koch(57.1, 0, 3, 3, 57);
                yield return new koch(57.2, 0, 7, 2, 57);
                yield return new koch(57.3, 0, 10, 3, 57);
                yield return new koch(57.4, 0, 14, 2, 57);
                yield return new koch(58.1, 0, 3, 2, 58);
                yield return new koch(58.2, 0, 7, 2, 58);
                yield return new koch(58.3, 0, 10, 1, 58);
                yield return new koch(58.4, 0, 14, 1, 58);
                yield return new koch(59.1, 0, 3, 3, 59);
                yield return new koch(59.2, 0, 7, 3, 59);
                yield return new koch(59.3, 0, 10, 3, 59);
                yield return new koch(59.4, 0, 14, 1, 59);
                yield return new koch(60.1, 0, 3, 2, 60);
                yield return new koch(60.2, 0, 7, 2, 60);
                yield return new koch(60.3, 0, 10, 1, 60);
                yield return new koch(60.4, 0, 14, 1, 60);
                yield return new koch(61.1, 0, 3, 3, 61);
                yield return new koch(61.2, 0, 7, 3, 61);
                yield return new koch(61.3, 0, 10, 2, 61);
                yield return new koch(61.4, 0, 14, 2, 61);
                yield return new koch(62.1, 0, 3, 3, 62);
                yield return new koch(62.2, 0, 7, 2, 62);
                yield return new koch(62.3, 0, 10, 3, 62);
                yield return new koch(62.4, 0, 14, 1, 62);
                yield return new koch(63.1, 0, 3, 3, 63);
                yield return new koch(63.2, 0, 7, 3, 63);
                yield return new koch(63.3, 0, 10, 3, 63);
                yield return new koch(63.4, 0, 14, 2, 63);
                yield return new koch(64.1, 0, 3, 3, 64);
                yield return new koch(64.2, 0, 7, 1, 64);
                yield return new koch(64.3, 0, 10, 2, 64);
                yield return new koch(64.4, 0, 14, 3, 64);
                yield return new koch(65.1, 0, 3, 3, 65);
                yield return new koch(65.2, 0, 7, 2, 65);
                yield return new koch(65.3, 0, 10, 2, 65);
                yield return new koch(65.4, 0, 14, 2, 65);
                yield return new koch(66.1, 0, 3, 3, 66);
                yield return new koch(66.2, 0, 7, 1, 66);
                yield return new koch(66.3, 0, 10, 3, 66);
                yield return new koch(66.4, 0, 14, 1, 66);
                yield return new koch(67.1, 0, 3, 3, 67);
                yield return new koch(67.2, 0, 7, 2, 67);
                yield return new koch(67.3, 0, 10, 2, 67);
                yield return new koch(67.4, 0, 14, 1, 67);
                yield return new koch(68.1, 0, 3, 2, 68);
                yield return new koch(68.2, 0, 7, 2, 68);
                yield return new koch(68.3, 0, 10, 1, 68);
                yield return new koch(68.4, 0, 14, 2, 68);
                yield return new koch(69.1, 0, 3, 3, 69);
                yield return new koch(69.2, 0, 7, 2, 69);
                yield return new koch(69.3, 0, 10, 2, 69);
                yield return new koch(69.4, 0, 14, 2, 69);
                yield return new koch(70.1, 0, 3, 3, 70);
                yield return new koch(70.2, 0, 7, 3, 70);
                yield return new koch(70.3, 0, 10, 3, 70);
                yield return new koch(70.4, 0, 14, 2, 70);
                yield return new koch(71.1, 0, 3, 3, 71);
                yield return new koch(71.2, 0, 7, 3, 71);
                yield return new koch(71.3, 0, 10, 2, 71);
                yield return new koch(71.4, 0, 14, 2, 71);
                yield return new koch(72.1, 0, 3, 3, 72);
                yield return new koch(72.2, 0, 7, 2, 72);
                yield return new koch(72.3, 0, 10, 2, 72);
                yield return new koch(72.4, 0, 14, 2, 72);
            }
        }
    }
}
