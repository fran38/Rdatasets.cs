// ReSharper disable All

namespace Rdatasets.rpart
{
    using System.Collections.Generic;

    /// <summary>
    /// Automobile Data from 'Consumer Reports' 1990
    /// </summary>

    public class car_test_frame
    {
        public readonly string κ;
        public readonly int Price;
        public readonly string Country;
        public readonly int? Reliability;
        public readonly int Mileage;
        public readonly string Type;
        public readonly int Weight;
        public readonly int Disp_;
        public readonly int HP;

        public car_test_frame(string κ, int Price, string Country, int? Reliability, int Mileage, string Type, int Weight, int Disp_, int HP)
        {
            this.κ = κ;
            this.Price = Price;
            this.Country = Country;
            this.Reliability = Reliability;
            this.Mileage = Mileage;
            this.Type = Type;
            this.Weight = Weight;
            this.Disp_ = Disp_;
            this.HP = HP;
        }

        public static IEnumerable<car_test_frame> Data
        {
            get
            {
                yield return new car_test_frame("Eagle Summit 4", 8895, "USA", 4, 33, "Small", 2560, 97, 113);
                yield return new car_test_frame("Ford Escort   4", 7402, "USA", 2, 33, "Small", 2345, 114, 90);
                yield return new car_test_frame("Ford Festiva 4", 6319, "Korea", 4, 37, "Small", 1845, 81, 63);
                yield return new car_test_frame("Honda Civic 4", 6635, "Japan/USA", 5, 32, "Small", 2260, 91, 92);
                yield return new car_test_frame("Mazda Protege 4", 6599, "Japan", 5, 32, "Small", 2440, 113, 103);
                yield return new car_test_frame("Mercury Tracer 4", 8672, "Mexico", 4, 26, "Small", 2285, 97, 82);
                yield return new car_test_frame("Nissan Sentra 4", 7399, "Japan/USA", 5, 33, "Small", 2275, 97, 90);
                yield return new car_test_frame("Pontiac LeMans 4", 7254, "Korea", 1, 28, "Small", 2350, 98, 74);
                yield return new car_test_frame("Subaru Loyale 4", 9599, "Japan", 5, 25, "Small", 2295, 109, 90);
                yield return new car_test_frame("Subaru Justy 3", 5866, "Japan", null, 34, "Small", 1900, 73, 73);
                yield return new car_test_frame("Toyota Corolla 4", 8748, "Japan/USA", 5, 29, "Small", 2390, 97, 102);
                yield return new car_test_frame("Toyota Tercel 4", 6488, "Japan", 5, 35, "Small", 2075, 89, 78);
                yield return new car_test_frame("Volkswagen Jetta 4", 9995, "Germany", 3, 26, "Small", 2330, 109, 100);
                yield return new car_test_frame("Chevrolet Camaro V8", 11545, "USA", 1, 20, "Sporty", 3320, 305, 170);
                yield return new car_test_frame("Dodge Daytona", 9745, "USA", 1, 27, "Sporty", 2885, 153, 100);
                yield return new car_test_frame("Ford Mustang V8", 12164, "USA", 1, 19, "Sporty", 3310, 302, 225);
                yield return new car_test_frame("Ford Probe", 11470, "USA", 3, 30, "Sporty", 2695, 133, 110);
                yield return new car_test_frame("Honda Civic CRX Si 4", 9410, "Japan", 5, 33, "Sporty", 2170, 97, 108);
                yield return new car_test_frame("Honda Prelude Si 4WS 4", 13945, "Japan", 5, 27, "Sporty", 2710, 125, 140);
                yield return new car_test_frame("Nissan 240SX 4", 13249, "Japan", 3, 24, "Sporty", 2775, 146, 140);
                yield return new car_test_frame("Plymouth Laser", 10855, "USA", null, 26, "Sporty", 2840, 107, 92);
                yield return new car_test_frame("Subaru XT 4", 13071, "Japan", null, 28, "Sporty", 2485, 109, 97);
                yield return new car_test_frame("Audi 80 4", 18900, "Germany", null, 27, "Compact", 2670, 121, 108);
                yield return new car_test_frame("Buick Skylark 4", 10565, "USA", 2, 23, "Compact", 2640, 151, 110);
                yield return new car_test_frame("Chevrolet Beretta 4", 10320, "USA", 1, 26, "Compact", 2655, 133, 95);
                yield return new car_test_frame("Chrysler Le Baron V6", 10945, "USA", 4, 25, "Compact", 3065, 181, 141);
                yield return new car_test_frame("Ford Tempo 4", 9483, "USA", 2, 24, "Compact", 2750, 141, 98);
                yield return new car_test_frame("Honda Accord 4", 12145, "Japan/USA", 5, 26, "Compact", 2920, 132, 125);
                yield return new car_test_frame("Mazda 626 4", 12459, "Japan/USA", 4, 24, "Compact", 2780, 133, 110);
                yield return new car_test_frame("Mitsubishi Galant 4", 10989, "Japan", 5, 25, "Compact", 2745, 122, 102);
                yield return new car_test_frame("Mitsubishi Sigma V6", 17879, "Japan", 4, 21, "Compact", 3110, 181, 142);
                yield return new car_test_frame("Nissan Stanza 4", 11650, "Japan", 5, 21, "Compact", 2920, 146, 138);
                yield return new car_test_frame("Oldsmobile Calais 4", 9995, "USA", 2, 23, "Compact", 2645, 151, 110);
                yield return new car_test_frame("Peugeot 405 4", 15930, "France", null, 24, "Compact", 2575, 116, 120);
                yield return new car_test_frame("Subaru Legacy 4", 11499, "Japan/USA", 5, 23, "Compact", 2935, 135, 130);
                yield return new car_test_frame("Toyota Camry 4", 11588, "Japan/USA", 5, 27, "Compact", 2920, 122, 115);
                yield return new car_test_frame("Volvo 240 4", 18450, "Sweden", 3, 23, "Compact", 2985, 141, 114);
                yield return new car_test_frame("Acura Legend V6", 24760, "Japan", 5, 20, "Medium", 3265, 163, 160);
                yield return new car_test_frame("Buick Century 4", 13150, "USA", 3, 21, "Medium", 2880, 151, 110);
                yield return new car_test_frame("Chrysler Le Baron Coupe", 12495, "USA", 2, 22, "Medium", 2975, 153, 150);
                yield return new car_test_frame("Chrysler New Yorker V6", 16342, "USA", 3, 22, "Medium", 3450, 202, 147);
                yield return new car_test_frame("Eagle Premier V6", 15350, "USA", 2, 22, "Medium", 3145, 180, 150);
                yield return new car_test_frame("Ford Taurus V6", 13195, "USA", 3, 22, "Medium", 3190, 182, 140);
                yield return new car_test_frame("Ford Thunderbird V6", 14980, "USA", 1, 23, "Medium", 3610, 232, 140);
                yield return new car_test_frame("Hyundai Sonata 4", 9999, "Korea", null, 23, "Medium", 2885, 143, 110);
                yield return new car_test_frame("Mazda 929 V6", 23300, "Japan", 5, 21, "Medium", 3480, 180, 158);
                yield return new car_test_frame("Nissan Maxima V6", 17899, "Japan", 5, 22, "Medium", 3200, 180, 160);
                yield return new car_test_frame("Oldsmobile Cutlass Ciera 4", 13150, "USA", 2, 21, "Medium", 2765, 151, 110);
                yield return new car_test_frame("Oldsmobile Cutlass Supreme V6", 14495, "USA", null, 21, "Medium", 3220, 189, 135);
                yield return new car_test_frame("Toyota Cressida 6", 21498, "Japan", 3, 23, "Medium", 3480, 180, 190);
                yield return new car_test_frame("Buick Le Sabre V6", 16145, "USA", 3, 23, "Large", 3325, 231, 165);
                yield return new car_test_frame("Chevrolet Caprice V8", 14525, "USA", 1, 18, "Large", 3855, 305, 170);
                yield return new car_test_frame("Ford LTD Crown Victoria V8", 17257, "USA", 3, 20, "Large", 3850, 302, 150);
                yield return new car_test_frame("Chevrolet Lumina APV V6", 13995, "USA", null, 18, "Van", 3195, 151, 110);
                yield return new car_test_frame("Dodge Grand Caravan V6", 15395, "USA", 3, 18, "Van", 3735, 202, 150);
                yield return new car_test_frame("Ford Aerostar V6", 12267, "USA", 3, 18, "Van", 3665, 182, 145);
                yield return new car_test_frame("Mazda MPV V6", 14944, "Japan", 5, 19, "Van", 3735, 181, 150);
                yield return new car_test_frame("Mitsubishi Wagon 4", 14929, "Japan", null, 20, "Van", 3415, 143, 107);
                yield return new car_test_frame("Nissan Axxess 4", 13949, "Japan", null, 20, "Van", 3185, 146, 138);
                yield return new car_test_frame("Nissan Van 4", 14799, "Japan", null, 19, "Van", 3690, 146, 106);
            }
        }
    }
}
