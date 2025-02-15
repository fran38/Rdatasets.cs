// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Named US Atlantic Hurricanes
    /// </summary>

    public class hurricNamed
    {
        public readonly string κ;
        public readonly string Name;
        public readonly int Year;
        public readonly int LF_WindsMPH;
        public readonly int LF_PressureMB;
        public readonly int LF_times;
        public readonly double BaseDamage;
        public readonly int NDAM2014;
        public readonly string AffectedStates;
        public readonly string firstLF;
        public readonly int deaths;
        public readonly string mf;
        public readonly double BaseDam2014;

        public hurricNamed(string κ, string Name, int Year, int LF_WindsMPH, int LF_PressureMB, int LF_times, double BaseDamage, int NDAM2014, string AffectedStates, string firstLF, int deaths, string mf, double BaseDam2014)
        {
            this.κ = κ;
            this.Name = Name;
            this.Year = Year;
            this.LF_WindsMPH = LF_WindsMPH;
            this.LF_PressureMB = LF_PressureMB;
            this.LF_times = LF_times;
            this.BaseDamage = BaseDamage;
            this.NDAM2014 = NDAM2014;
            this.AffectedStates = AffectedStates;
            this.firstLF = firstLF;
            this.deaths = deaths;
            this.mf = mf;
            this.BaseDam2014 = BaseDam2014;
        }

        public static IEnumerable<hurricNamed> Data
        {
            get
            {
                yield return new hurricNamed("Easy1950", "Easy", 1950, 120, 958, 1, 3.3, 1870, "FL", "1950-09-04", 2, "f", 32.4194190871369);
                yield return new hurricNamed("King1950", "King", 1950, 130, 955, 1, 28, 6030, "FL", "1950-10-17", 4, "m", 275.073858921162);
                yield return new hurricNamed("Able1952", "Able", 1952, 85, 985, 1, 2.75, 170, "SC", "1952-08-30", 3, "m", 24.5694339622641);
                yield return new hurricNamed("Barbara1953", "Barbara", 1953, 85, 987, 1, 1, 65, "NC", "1953-08-13", 1, "f", 8.86741573033708);
                yield return new hurricNamed("Florence1953", "Florence", 1953, 85, 985, 1, 0.2, 18, "FL", "1953-09-26", 0, "f", 1.77348314606742);
                yield return new hurricNamed("Carol1954", "Carol", 1954, 120, 960, 2, 460.2275, 21375, "NC,NY,CT,RI", "1954-08-30", 60, "f", 4050.68635315985);
                yield return new hurricNamed("Edna1954", "Edna", 1954, 120, 954, 1, 40, 3520, "MA,ME", "1954-09-11", 20, "f", 352.059479553903);
                yield return new hurricNamed("Hazel1954", "Hazel", 1954, 145, 938, 1, 281, 28500, "SC,NC,MD", "1954-10-18", 20, "f", 2473.21784386617);
                yield return new hurricNamed("Connie1955", "Connie", 1955, 120, 962, 1, 40, 2270, "NC,VA", "1955-08-12", 0, "f", 353.373134328358);
                yield return new hurricNamed("Diane1955", "Diane", 1955, 85, 987, 1, 200, 17250, "NC", "1955-08-17", 200, "f", 1766.86567164179);
                yield return new hurricNamed("Ione1955", "Ione", 1955, 120, 960, 1, 88.035, 6990, "NC", "1955-09-19", 7, "m", 777.730097014925);
                yield return new hurricNamed("Flossy1956", "Flossy", 1956, 105, 975, 1, 25, 1730, "LA,MS,AL,FL", "1956-09-24", 15, "f", 217.610294117647);
                yield return new hurricNamed("Audrey1957", "Audrey", 1957, 145, 945, 1, 150, 4290, "TX,LA", "1957-06-27", 416, "f", 1263.84341637011);
                yield return new hurricNamed("Helene1958", "Helene", 1958, 120, 946, 1, 11.2, 610, "NC", "1958-09-27", 1, "f", 91.7547404844291);
                yield return new hurricNamed("Debra1959", "Debra", 1959, 85, 984, 1, 7, 500, "TX", "1959-07-25", 0, "f", 56.9525773195876);
                yield return new hurricNamed("Gracie1959", "Gracie", 1959, 120, 950, 1, 14, 580, "SC", "1959-09-29", 22, "f", 113.905154639175);
                yield return new hurricNamed("Donna1960", "Donna", 1960, 145, 930, 3, 386.5, 62030, "FL,NC,NY,CT,RI,MA,NH,ME", "1960-09-10", 50, "f", 3091.4777027027);
                yield return new hurricNamed("Ethel1960", "Ethel", 1960, 85, 981, 1, 1.06, 39, "MS", "1960-09-15", 0, "f", 8.47856756756757);
                yield return new hurricNamed("Carla1961", "Carla", 1961, 145, 931, 1, 325, 18130, "TX", "1961-09-11", 46, "f", 2573.47826086957);
                yield return new hurricNamed("Cindy1963", "Cindy", 1963, 85, 996, 1, 12.56, 340, "TX", "1963-09-17", 3, "f", 97.1799215686274);
                yield return new hurricNamed("Cleo1964", "Cleo", 1964, 105, 968, 1, 128.5, 7270, "FL", "1964-08-27", 3, "f", 981.408387096774);
                yield return new hurricNamed("Dora1964", "Dora", 1964, 105, 966, 1, 250, 18540, "FL", "1964-09-09", 5, "f", 1909.35483870968);
                yield return new hurricNamed("Hilda1964", "Hilda", 1964, 120, 950, 1, 125, 3070, "LA", "1964-10-03", 37, "f", 954.677419354839);
                yield return new hurricNamed("Isbell1964", "Isbell", 1964, 105, 974, 1, 10, 910, "FL", "1964-10-14", 3, "f", 76.3741935483871);
                yield return new hurricNamed("Betsy1965", "Betsy", 1965, 120, 941, 2, 1419.8, 20640, "FL,LA", "1965-09-08", 75, "f", 10671.4872380952);
                yield return new hurricNamed("Alma1966", "Alma", 1966, 105, 982, 1, 10.05, 870, "FL", "1966-06-09", 6, "f", 73.4394444444444);
                yield return new hurricNamed("Inez1966", "Inez", 1966, 85, 983, 1, 5, 110, "FL", "1966-10-04", 3, "f", 36.537037037037);
                yield return new hurricNamed("Beulah1967", "Beulah", 1967, 120, 950, 1, 200, 5760, "TX", "1967-09-20", 15, "f", 1417.7245508982);
                yield return new hurricNamed("Gladys1968", "Gladys", 1968, 105, 977, 1, 6.7, 930, "FL", "1968-10-18", 3, "f", 45.5831034482759);
                yield return new hurricNamed("Camille1969", "Camille", 1969, 190, 909, 1, 1421, 25070, "LA,MS", "1969-08-17", 256, "f", 9167.19237057221);
                yield return new hurricNamed("Celia1970", "Celia", 1970, 120, 945, 1, 454, 7660, "TX", "1970-08-03", 22, "f", 2770.33608247423);
                yield return new hurricNamed("Fern1971", "Fern", 1971, 85, 979, 1, 30.23, 570, "TX", "1971-09-10", 2, "f", 176.722340740741);
                yield return new hurricNamed("Edith1971", "Edith", 1971, 105, 978, 1, 25, 330, "LA", "1971-09-16", 0, "f", 146.148148148148);
                yield return new hurricNamed("Ginger1971", "Ginger", 1971, 85, 995, 1, 10, 230, "NC", "1971-09-30", 0, "f", 58.4592592592593);
                yield return new hurricNamed("Agnes1972", "Agnes", 1972, 85, 980, 2, 2100, 22650, "FL,NY,CT,PA", "1972-06-19", 117, "f", 11894.6411483254);
                yield return new hurricNamed("Carmen1974", "Carmen", 1974, 120, 952, 1, 150, 1310, "LA", "1974-09-07", 1, "f", 720.365111561866);
                yield return new hurricNamed("Eloise1975", "Eloise", 1975, 120, 955, 1, 490, 7020, "FL,AL", "1975-09-23", 21, "f", 2156.36431226766);
                yield return new hurricNamed("Belle1976", "Belle", 1976, 85, 980, 1, 100, 620, "NY", "1976-08-09", 5, "f", 416.09841827768);
                yield return new hurricNamed("Babe1977", "Babe", 1977, 85, 995, 1, 10, 74, "LA", "1977-09-05", 0, "f", 39.0693069306931);
                yield return new hurricNamed("Bob1979", "Bob", 1979, 85, 986, 1, 20, 78, "LA", "1979-07-11", 1, "m", 65.2231404958678);
                yield return new hurricNamed("David1979", "David", 1979, 105, 970, 2, 320, 3100, "FL,GA,SC", "1979-09-03", 15, "m", 1043.57024793388);
                yield return new hurricNamed("Frederic1979", "Frederic", 1979, 120, 946, 1, 2300, 14350, "AL, MS", "1979-09-12", 5, "m", 7500.66115702479);
                yield return new hurricNamed("Allen1980", "Allen", 1980, 115, 945, 1, 300, 2450, "TX", "1980-08-09", 2, "m", 861.990291262136);
                yield return new hurricNamed("Alicia1983", "Alicia", 1983, 115, 962, 1, 2000, 12000, "TX", "1983-08-18", 21, "f", 4754.21686746988);
                yield return new hurricNamed("Diana1984", "Diana", 1984, 110, 949, 1, 65, 490, "NC", "1984-09-13", 3, "f", 148.117420596728);
                yield return new hurricNamed("Bob1985", "Bob", 1985, 75, 1003, 1, 20, 150, "SC", "1985-07-25", 0, "m", 44.0074349442379);
                yield return new hurricNamed("Danny1985", "Danny", 1985, 90, 987, 1, 50, 170, "LA", "1985-08-15", 1, "m", 110.018587360595);
                yield return new hurricNamed("Elena1985", "Elena", 1985, 115, 959, 1, 1250, 4600, "MS,AL,FL", "1985-09-02", 4, "f", 2750.46468401487);
                yield return new hurricNamed("Gloria1985", "Gloria", 1985, 120, 942, 2, 900, 3340, "NC,NY,CT,NH.ME", "1985-09-26", 8, "f", 1980.33457249071);
                yield return new hurricNamed("Juan1985", "Juan", 1985, 85, 971, 1, 1500, 5230, "LA", "1985-10-29", 12, "m", 3300.55762081784);
                yield return new hurricNamed("Kate1985", "Kate", 1985, 100, 967, 1, 300, 1480, "FL,GA", "1985-11-21", 5, "f", 660.111524163569);
                yield return new hurricNamed("Bonnie1986", "Bonnie", 1986, 85, 990, 1, 2, 6, "TX", "1986-06-26", 3, "f", 4.32043795620438);
                yield return new hurricNamed("Charley1986", "Charley", 1986, 75, 990, 1, 15, 66, "NC", "1986-08-17", 5, "m", 32.4032846715328);
                yield return new hurricNamed("Floyd1987", "Floyd", 1987, 75, 993, 1, 0.5, 1, "FL", "1987-10-12", 0, "m", 1.04207746478873);
                yield return new hurricNamed("Florence1988", "Florence", 1988, 80, 984, 1, 2.92, 4, "LA", "1988-09-09", 1, "f", 5.84394928148774);
                yield return new hurricNamed("Chantal1989", "Chantal", 1989, 80, 986, 1, 100, 320, "TX", "1989-08-01", 13, "f", 190.935483870968);
                yield return new hurricNamed("Hugo1989", "Hugo", 1989, 140, 934, 1, 7000, 22690, "SC,NC", "1989-09-21", 21, "m", 13365.4838709677);
                yield return new hurricNamed("Jerry1989", "Jerry", 1989, 85, 983, 1, 70, 260, "TX", "1989-10-15", 3, "m", 133.654838709677);
                yield return new hurricNamed("Bob1991", "Bob", 1991, 105, 962, 1, 1500, 4020, "RI,MA,NY,CT", "1991-08-19", 15, "m", 2607.48898678414);
                yield return new hurricNamed("Andrew1992", "Andrew", 1992, 170, 922, 2, 25000, 75260, "FL,LA", "1992-08-24", 62, "m", 42188.1682109765);
                yield return new hurricNamed("Emily1993", "Emily", 1993, 115, 961, 1, 35, 110, "NC", "1993-08-31", 3, "f", 57.3467128027682);
                yield return new hurricNamed("Erin1995", "Erin", 1995, 100, 973, 2, 700, 1850, "FL,FL", "1995-08-02", 6, "f", 1087.48031496063);
                yield return new hurricNamed("Opal1995", "Opal", 1995, 115, 942, 1, 3000, 8600, "FL,AL", "1995-10-04", 9, "f", 4660.62992125984);
                yield return new hurricNamed("Bertha1996", "Bertha", 1996, 105, 974, 1, 270, 810, "NC", "1996-07-12", 8, "f", 407.42638623327);
                yield return new hurricNamed("Fran1996", "Fran", 1996, 115, 954, 1, 3200, 9610, "NC", "1996-09-05", 26, "f", 4828.75717017208);
                yield return new hurricNamed("Danny1997", "Danny", 1997, 80, 984, 1, 100, 220, "LA,AL", "1997-07-19", 10, "m", 147.514018691589);
                yield return new hurricNamed("Bonnie1998", "Bonnie", 1998, 110, 964, 1, 720, 1910, "NC", "1998-08-26", 3, "f", 1045.81104294479);
                yield return new hurricNamed("Earl1998", "Earl", 1998, 80, 987, 1, 79, 180, "FL", "1998-09-02", 3, "m", 114.748711656442);
                yield return new hurricNamed("Georges1998", "Georges", 1998, 105, 964, 2, 2310, 4230, "FL,MS", "1998-09-25", 1, "m", 3355.31042944785);
                yield return new hurricNamed("Bret1999", "Bret", 1999, 115, 951, 1, 60, 100, "TX", "1999-08-22", 0, "m", 85.2677070828331);
                yield return new hurricNamed("Floyd1999", "Floyd", 1999, 105, 956, 1, 4500, 9200, "NC", "1999-09-16", 56, "m", 6395.07803121249);
                yield return new hurricNamed("Irene1999", "Irene", 1999, 80, 987, 1, 800, 1610, "FL", "1999-10-15", 8, "f", 1136.90276110444);
                yield return new hurricNamed("Lili2002", "Lili", 2002, 90, 963, 1, 860, 1380, "LA", "2002-10-03", 2, "f", 1131.94129419613);
                yield return new hurricNamed("Claudette2003", "Claudette", 2003, 90, 979, 1, 180, 280, "TX", "2003-07-15", 3, "f", 231.663405088063);
                yield return new hurricNamed("Isabel2003", "Isabel", 2003, 105, 957, 1, 3370, 5610, "NC,VA", "2003-09-18", 51, "f", 4337.25375081539);
                yield return new hurricNamed("Alex2004", "Alex", 2004, 80, 972, 1, 4, 6, "NC", "2004-08-03", 1, "m", 5.0134462678666);
                yield return new hurricNamed("Charley2004", "Charley", 2004, 150, 941, 2, 13600, 24590, "FL,SC,NC", "2004-08-13", 10, "m", 17045.7173107464);
                yield return new hurricNamed("Gaston2004", "Gaston", 2004, 75, 985, 1, 130, 200, "SC", "2004-08-29", 8, "m", 162.937003705664);
                yield return new hurricNamed("Frances2004", "Frances", 2004, 105, 960, 1, 9000, 14820, "FL", "2004-09-05", 7, "f", 11280.2541026998);
                yield return new hurricNamed("Ivan2004", "Ivan", 2004, 120, 946, 1, 14200, 21340, "AL,FL", "2004-09-16", 25, "m", 17797.7342509264);
                yield return new hurricNamed("Jeanne2004", "Jeanne", 2004, 120, 950, 1, 6900, 12180, "FL", "2004-09-26", 5, "f", 8648.19481206988);
                yield return new hurricNamed("Cindy2005", "Cindy", 2005, 75, 991, 1, 320, 370, "LA", "2005-07-05", 1, "f", 387.932411674347);
                yield return new hurricNamed("Dennis2005", "Dennis", 2005, 120, 946, 1, 2230, 2930, "FL,AL", "2005-07-10", 15, "m", 2703.40399385561);
                yield return new hurricNamed("Katrina2005", "Katrina", 2005, 125, 920, 1, 81000, 88420, "LA,MS,FL,AL", "2005-08-29", 1836, "f", 98195.3917050691);
                yield return new hurricNamed("Ophelia2005", "Ophelia", 2005, 75, 982, 1, 70, 100, "NC", "2005-09-15", 1, "f", 84.8602150537634);
                yield return new hurricNamed("Rita2005", "Rita", 2005, 115, 937, 1, 10000, 11280, "LA,TX,FL", "2005-09-24", 62, "f", 12122.8878648233);
                yield return new hurricNamed("Wilma2005", "Wilma", 2005, 120, 950, 1, 20600, 29330, "FL", "2005-10-24", 5, "f", 24973.1490015361);
                yield return new hurricNamed("Humberto2007", "Humberto", 2007, 90, 985, 1, 50, 55, "TX,LA", "2007-09-13", 1, "m", 57.0940764533958);
                yield return new hurricNamed("Dolly2008", "Dolly", 2008, 85, 967, 1, 1050, 1260, "TX", "2008-07-23", 1, "f", 1154.64252704328);
                yield return new hurricNamed("Gustav2008", "Gustav", 2008, 105, 954, 1, 4300, 4800, "LA", "2008-09-01", 52, "m", 4728.53606312964);
                yield return new hurricNamed("Ike2008", "Ike", 2008, 110, 950, 1, 19300, 23070, "TX,LA", "2008-09-13", 84, "m", 21223.4293066051);
                yield return new hurricNamed("Irene2011", "Irene", 2011, 75, 952, 1, 7000, 7580, "NC,VA,MD,DE,NJ,NY,MA", "2011-08-27", 41, "f", 7367.86417651008);
                yield return new hurricNamed("Isaac2012", "Isaac", 2012, 80, 966, 1, 2350, 2400, "LA", "2012-08-28", 5, "m", 2423.34730001655);
                yield return new hurricNamed("Sandy2012", "Sandy", 2012, 75, 942, 1, 50000, 52270, "NY", "2012-10-29", 159, "f", 51560.580851416);
            }
        }
    }
}
