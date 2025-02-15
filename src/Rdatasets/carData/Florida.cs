// ReSharper disable All

namespace Rdatasets.carData
{
    using System.Collections.Generic;

    /// <summary>
    /// Florida County Voting
    /// </summary>

    public class Florida
    {
        public readonly string κ;
        public readonly int GORE;
        public readonly int BUSH;
        public readonly int BUCHANAN;
        public readonly int NADER;
        public readonly int BROWNE;
        public readonly int HAGELIN;
        public readonly int HARRIS;
        public readonly int MCREYNOLDS;
        public readonly int MOOREHEAD;
        public readonly int PHILLIPS;
        public readonly int Total;

        public Florida(string κ, int GORE, int BUSH, int BUCHANAN, int NADER, int BROWNE, int HAGELIN, int HARRIS, int MCREYNOLDS, int MOOREHEAD, int PHILLIPS, int Total)
        {
            this.κ = κ;
            this.GORE = GORE;
            this.BUSH = BUSH;
            this.BUCHANAN = BUCHANAN;
            this.NADER = NADER;
            this.BROWNE = BROWNE;
            this.HAGELIN = HAGELIN;
            this.HARRIS = HARRIS;
            this.MCREYNOLDS = MCREYNOLDS;
            this.MOOREHEAD = MOOREHEAD;
            this.PHILLIPS = PHILLIPS;
            this.Total = Total;
        }

        public static IEnumerable<Florida> Data
        {
            get
            {
                yield return new Florida("ALACHUA", 47300, 34062, 262, 3215, 658, 42, 4, 658, 21, 20, 86242);
                yield return new Florida("BAKER", 2392, 5610, 73, 53, 17, 3, 0, 0, 3, 3, 8154);
                yield return new Florida("BAY", 18850, 38637, 248, 828, 171, 18, 5, 3, 37, 18, 58815);
                yield return new Florida("BRADFORD", 3072, 5413, 65, 84, 28, 2, 0, 0, 3, 2, 8669);
                yield return new Florida("BREVARD", 97318, 115185, 570, 4470, 643, 39, 11, 11, 76, 72, 218395);
                yield return new Florida("BROWARD", 386518, 177279, 789, 7099, 1212, 128, 49, 35, 123, 74, 573306);
                yield return new Florida("CALHOUN", 2155, 2873, 90, 39, 10, 1, 0, 1, 3, 2, 5174);
                yield return new Florida("CHARLOTTE", 29641, 35419, 182, 1461, 127, 15, 6, 3, 12, 19, 66885);
                yield return new Florida("CITRUS", 25501, 29744, 270, 1378, 194, 16, 5, 0, 28, 18, 57154);
                yield return new Florida("CLAY", 14630, 41745, 186, 562, 204, 14, 1, 3, 9, 6, 57360);
                yield return new Florida("COLLIER", 29905, 60426, 122, 1400, 185, 34, 7, 4, 29, 10, 92122);
                yield return new Florida("COLUMBIA", 7047, 10964, 89, 258, 127, 7, 1, 2, 5, 8, 18508);
                yield return new Florida("DADE", 328702, 289456, 561, 5355, 759, 119, 88, 36, 124, 69, 625269);
                yield return new Florida("DE.SOTO", 3322, 4256, 36, 157, 23, 0, 0, 3, 2, 8, 7807);
                yield return new Florida("DIXIE", 1825, 2698, 29, 75, 32, 2, 0, 0, 2, 3, 4666);
                yield return new Florida("DUVAL", 107680, 152082, 650, 2752, 954, 160, 36, 16, 41, 57, 264428);
                yield return new Florida("ESCAMBIA", 40958, 73029, 504, 1729, 297, 24, 6, 3, 20, 110, 116680);
                yield return new Florida("FLAGLER", 13891, 12608, 83, 435, 60, 4, 1, 3, 12, 3, 27100);
                yield return new Florida("FRANKLIN", 2042, 2448, 33, 85, 17, 3, 1, 0, 2, 3, 4634);
                yield return new Florida("GADSDEN", 9565, 4750, 39, 139, 24, 4, 7, 3, 12, 6, 14549);
                yield return new Florida("GILCHRIST", 1910, 3300, 29, 97, 52, 1, 0, 0, 4, 2, 5395);
                yield return new Florida("GLADES", 1420, 1840, 9, 56, 12, 3, 0, 1, 1, 0, 3342);
                yield return new Florida("GULF", 2389, 3546, 71, 86, 21, 4, 2, 2, 9, 2, 6132);
                yield return new Florida("HAMILTON", 1718, 2153, 24, 39, 11, 2, 6, 9, 4, 7, 3973);
                yield return new Florida("HARDEE", 2341, 3764, 30, 75, 17, 2, 0, 0, 3, 2, 6234);
                yield return new Florida("HENDRY", 3239, 4743, 22, 103, 11, 1, 3, 2, 2, 7, 8133);
                yield return new Florida("HERNANDO", 32644, 30646, 242, 1501, 116, 26, 8, 4, 22, 10, 65219);
                yield return new Florida("HIGHLANDS", 14152, 20196, 99, 409, 51, 14, 5, 3, 7, 5, 34941);
                yield return new Florida("HILLSBOROUGH", 166581, 176967, 836, 7348, 1104, 215, 35, 29, 150, 66, 353331);
                yield return new Florida("HOLMES", 2154, 4985, 76, 91, 18, 7, 1, 3, 2, 6, 7343);
                yield return new Florida("INDIAN.RIVER", 19769, 28627, 105, 950, 123, 13, 4, 2, 10, 13, 49616);
                yield return new Florida("JACKSON", 6868, 9138, 102, 138, 40, 2, 0, 1, 7, 4, 16300);
                yield return new Florida("JEFFERSON", 3038, 2481, 29, 76, 14, 1, 2, 1, 0, 0, 5642);
                yield return new Florida("LAFAYETTE", 788, 1669, 10, 26, 6, 0, 3, 1, 0, 1, 2504);
                yield return new Florida("LAKE", 36555, 49963, 289, 1459, 203, 36, 4, 1, 14, 21, 88545);
                yield return new Florida("LEE", 73560, 106141, 305, 3587, 538, 81, 30, 5, 96, 34, 184377);
                yield return new Florida("LEON", 61425, 39053, 282, 1932, 330, 28, 9, 7, 31, 16, 103113);
                yield return new Florida("LEVY", 5403, 6860, 67, 284, 92, 1, 1, 1, 11, 10, 12730);
                yield return new Florida("LIBERTY", 1011, 1316, 39, 19, 12, 3, 0, 0, 2, 1, 2403);
                yield return new Florida("MADISON", 3011, 3038, 29, 54, 18, 2, 0, 1, 5, 1, 6159);
                yield return new Florida("MANATEE", 49169, 57948, 272, 2489, 243, 35, 5, 3, 26, 19, 110209);
                yield return new Florida("MARION", 44648, 55135, 563, 1810, 361, 26, 14, 6, 49, 22, 102634);
                yield return new Florida("MARTIN", 26619, 33864, 108, 1075, 105, 29, 13, 8, 12, 19, 61852);
                yield return new Florida("MONROE", 16483, 16059, 47, 1090, 162, 26, 1, 0, 7, 3, 33878);
                yield return new Florida("NASSAU", 6952, 16404, 90, 255, 63, 8, 0, 4, 3, 3, 23782);
                yield return new Florida("OKALOOSA", 16924, 52043, 267, 984, 313, 15, 4, 2, 20, 33, 70605);
                yield return new Florida("OKEECHOBEE", 4588, 5058, 43, 131, 21, 4, 1, 1, 4, 3, 9854);
                yield return new Florida("ORANGE", 140115, 134476, 446, 3881, 892, 65, 13, 7, 45, 41, 279981);
                yield return new Florida("OSCEOLA", 28177, 26216, 145, 732, 309, 21, 10, 5, 33, 10, 55658);
                yield return new Florida("PALM.BEACH", 268945, 152846, 3407, 5564, 743, 143, 45, 302, 103, 188, 432286);
                yield return new Florida("PASCO", 69550, 68581, 570, 3392, 412, 82, 18, 14, 77, 17, 142713);
                yield return new Florida("PINELLAS", 199660, 184312, 1010, 9986, 1222, 444, 40, 27, 167, 70, 396938);
                yield return new Florida("POLK", 74977, 90101, 538, 2060, 365, 59, 8, 5, 36, 46, 168195);
                yield return new Florida("PUTNAM", 12091, 13439, 147, 379, 114, 7, 2, 4, 12, 10, 26205);
                yield return new Florida("ST.JOHNS", 19482, 39497, 229, 1214, 210, 11, 4, 2, 13, 12, 60674);
                yield return new Florida("ST.LUCIE", 41559, 34705, 124, 1368, 165, 12, 4, 10, 29, 13, 77989);
                yield return new Florida("SANTA.ROSA", 12795, 36248, 311, 723, 131, 13, 1, 1, 19, 43, 50285);
                yield return new Florida("SARASOTA", 72854, 83100, 305, 4066, 431, 94, 11, 5, 59, 15, 160940);
                yield return new Florida("SEMINOLE", 58888, 75293, 194, 1940, 551, 38, 38, 5, 70, 27, 137044);
                yield return new Florida("SUMTER", 9634, 12126, 114, 307, 53, 2, 2, 0, 17, 3, 22258);
                yield return new Florida("SUWANNEE", 4084, 8014, 108, 182, 53, 4, 2, 0, 5, 9, 12461);
                yield return new Florida("TAYLOR", 2647, 4051, 27, 59, 4, 3, 0, 1, 1, 8, 6801);
                yield return new Florida("UNION", 1399, 2326, 26, 29, 13, 0, 1, 0, 0, 0, 3794);
                yield return new Florida("VOLUSIA", 97063, 82214, 396, 2436, 3211, 33, 9888, 3, 59, 2927, 198230);
                yield return new Florida("WAKULLA", 3835, 4511, 46, 149, 30, 3, 2, 1, 6, 0, 8583);
                yield return new Florida("WALTON", 5637, 12176, 120, 265, 68, 11, 3, 2, 18, 7, 18307);
                yield return new Florida("WASHINGTON", 2796, 4983, 88, 93, 32, 20, 0, 0, 5, 9, 8026);
            }
        }
    }
}
