// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Total weekly air passenger numbers on Ansett airline flights between Melbourne and Sydney, 1987-1992.
    /// </summary>

    public class melsyd
    {
        public readonly double? First_Class;
        public readonly double? Business_Class;
        public readonly double? Economy_Class;

        public melsyd(double? First_Class, double? Business_Class, double? Economy_Class)
        {
            this.First_Class = First_Class;
            this.Business_Class = Business_Class;
            this.Economy_Class = Economy_Class;
        }

        public static IEnumerable<melsyd> Data
        {
            get
            {
                yield return new melsyd(1.912, null, 20.167);
                yield return new melsyd(1.848, null, 20.161);
                yield return new melsyd(1.856, null, 19.993);
                yield return new melsyd(2.142, null, 20.986);
                yield return new melsyd(2.118, null, 20.497);
                yield return new melsyd(2.048, null, 20.77);
                yield return new melsyd(2.111, null, 21.111);
                yield return new melsyd(2.199, null, 20.675);
                yield return new melsyd(2.231, null, 22.092);
                yield return new melsyd(2.081, null, 20.772);
                yield return new melsyd(2.213, null, 21.642);
                yield return new melsyd(2.131, null, 21.911);
                yield return new melsyd(null, null, null);
                yield return new melsyd(2.131, null, 23.777);
                yield return new melsyd(2.034, null, 22.658);
                yield return new melsyd(2.19, null, 23.515);
                yield return new melsyd(2.262, null, 21.384);
                yield return new melsyd(2.579, null, 24.344);
                yield return new melsyd(2.367, null, 21.137);
                yield return new melsyd(2.432, null, 23.069);
                yield return new melsyd(2.64, null, 23.664);
                yield return new melsyd(2.614, null, 23.219);
                yield return new melsyd(2.569, null, 23.192);
                yield return new melsyd(2.523, null, 23.475);
                yield return new melsyd(2.26, null, 22.377);
                yield return new melsyd(1.117, null, 16.606);
                yield return new melsyd(0.59, null, 13.987);
                yield return new melsyd(0.966, null, 16.251);
                yield return new melsyd(1.235, null, 18.439);
                yield return new melsyd(2.001, null, 20.262);
                yield return new melsyd(1.696, null, 19.535);
                yield return new melsyd(2.089, null, 22.467);
                yield return new melsyd(2.716, null, 24.559);
                yield return new melsyd(2.483, null, 24.591);
                yield return new melsyd(2.461, null, 24.511);
                yield return new melsyd(2.533, null, 24.524);
                yield return new melsyd(2.273, null, 23.119);
                yield return new melsyd(2.273, null, 23.106);
                yield return new melsyd(2.37, null, 23.292);
                yield return new melsyd(1.782, null, 21.566);
                yield return new melsyd(1.385, null, 18.565);
                yield return new melsyd(2.322, null, 24.361);
                yield return new melsyd(2.34, null, 22.983);
                yield return new melsyd(2.203, null, 21.062);
                yield return new melsyd(2.3, null, 21.766);
                yield return new melsyd(2.125, null, 22.285);
                yield return new melsyd(2.345, null, 22.867);
                yield return new melsyd(2.224, null, 23.276);
                yield return new melsyd(1.952, null, 20.924);
                yield return new melsyd(2.212, null, 21.716);
                yield return new melsyd(2.028, null, 20.908);
                yield return new melsyd(1.906, null, 21.41);
                yield return new melsyd(1.834, null, 21.361);
                yield return new melsyd(1.797, null, 22.412);
                yield return new melsyd(1.869, null, 21.29);
                yield return new melsyd(1.886, null, 22.247);
                yield return new melsyd(2.131, null, 22.445);
                yield return new melsyd(2.021, null, 21.26);
                yield return new melsyd(2.199, null, 22.771);
                yield return new melsyd(2.14, null, 23.723);
                yield return new melsyd(2.19, null, 23.757);
                yield return new melsyd(1.917, null, 23.482);
                yield return new melsyd(2.096, null, 23.653);
                yield return new melsyd(2.254, null, 26.054);
                yield return new melsyd(2.251, null, 25.695);
                yield return new melsyd(2.072, null, 26.72);
                yield return new melsyd(0.993, null, 15.033);
                yield return new melsyd(1.675, null, 22.34);
                yield return new melsyd(1.463, null, 19.297);
                yield return new melsyd(2.256, null, 23.761);
                yield return new melsyd(2.216, null, 22.15);
                yield return new melsyd(2.218, null, 22.236);
                yield return new melsyd(2.568, null, 23.157);
                yield return new melsyd(2.483, null, 24.387);
                yield return new melsyd(2.545, null, 23.844);
                yield return new melsyd(2.599, null, 23.681);
                yield return new melsyd(2.483, null, 24.456);
                yield return new melsyd(1.793, null, 19.899);
                yield return new melsyd(0.516, null, 13.662);
                yield return new melsyd(0.873, null, 15.698);
                yield return new melsyd(1.195, null, 18.189);
                yield return new melsyd(1.525, null, 19.448);
                yield return new melsyd(1.906, null, 20.891);
                yield return new melsyd(2.246, null, 22.284);
                yield return new melsyd(2.247, null, 23.247);
                yield return new melsyd(2.316, null, 24.44);
                yield return new melsyd(2.276, null, 22.519);
                yield return new melsyd(2.403, null, 22.818);
                yield return new melsyd(2.432, null, 23.472);
                yield return new melsyd(2.49, null, 24.117);
                yield return new melsyd(2.013, null, 24.435);
                yield return new melsyd(1.508, null, 20.589);
                yield return new melsyd(2.251, null, 23.427);
                yield return new melsyd(2.079, null, 20.923);
                yield return new melsyd(2.21, null, 22.959);
                yield return new melsyd(1.96, null, 19.152);
                yield return new melsyd(2.251, null, 22.011);
                yield return new melsyd(2.013, null, 20.228);
                yield return new melsyd(2.252, null, 21.332);
                yield return new melsyd(2.067, null, 20.5);
                yield return new melsyd(1.831, null, 19.09);
                yield return new melsyd(2.069, null, 21.692);
                yield return new melsyd(1.953, null, 20.157);
                yield return new melsyd(2.199, null, 22.231);
                yield return new melsyd(1.771, null, 20.914);
                yield return new melsyd(1.696, null, 21.454);
                yield return new melsyd(1.788, null, 21.345);
                yield return new melsyd(1.636, 1.524, 19.26);
                yield return new melsyd(1.741, 2.212, 18.781);
                yield return new melsyd(1.597, 1.777, 17.445);
                yield return new melsyd(1.943, 2.552, 19.628);
                yield return new melsyd(1.66, 1.889, 17.692);
                yield return new melsyd(0.616, 0.851, 7.046);
                yield return new melsyd(0, 0, 0);
                yield return new melsyd(0, 0, 0);
                yield return new melsyd(0, 0, 0);
                yield return new melsyd(0, 0, 0);
                yield return new melsyd(0, 0, 0);
                yield return new melsyd(0, 0, 0);
                yield return new melsyd(0, 0, 0);
                yield return new melsyd(0.053, 0.618, 11.569);
                yield return new melsyd(0.04, 0.565, 11.973);
                yield return new melsyd(0.354, 0.414, 11.123);
                yield return new melsyd(0.505, 0.543, 11.479);
                yield return new melsyd(0.711, 0.712, 16.969);
                yield return new melsyd(0.723, 0.652, 15.997);
                yield return new melsyd(0.796, 0.709, 16.555);
                yield return new melsyd(0.856, 0.793, 17.959);
                yield return new melsyd(0.845, 0.838, 18.868);
                yield return new melsyd(0.807, 0.763, 15.4);
                yield return new melsyd(0.276, 0.266, 10.544);
                yield return new melsyd(0.339, 0.362, 12.755);
                yield return new melsyd(0.581, 0.665, 19.02);
                yield return new melsyd(0.894, 0.957, 20.077);
                yield return new melsyd(0.936, 1.145, 22.124);
                yield return new melsyd(1.111, 1.312, 19.92);
                yield return new melsyd(1.446, 1.689, 17.215);
                yield return new melsyd(1.517, 1.762, 17.662);
                yield return new melsyd(1.513, 2.16, 19.828);
                yield return new melsyd(1.508, 1.877, 18.754);
                yield return new melsyd(1.636, 2.048, 20.39);
                yield return new melsyd(1.38, 1.824, 18.383);
                yield return new melsyd(1.453, 1.986, 19.377);
                yield return new melsyd(1.459, 2.032, 20.133);
                yield return new melsyd(1.538, 1.956, 19.21);
                yield return new melsyd(1.327, 1.503, 20.736);
                yield return new melsyd(1.027, 1.256, 18.821);
                yield return new melsyd(1.365, 1.752, 20.952);
                yield return new melsyd(1.475, 1.878, 20.565);
                yield return new melsyd(1.365, 1.945, 20.311);
                yield return new melsyd(1.351, 1.735, 17.859);
                yield return new melsyd(1.231, 1.825, 19.385);
                yield return new melsyd(1.447, 1.715, 17.962);
                yield return new melsyd(1.408, 1.594, 19.569);
                yield return new melsyd(1.089, 1.377, 17.894);
                yield return new melsyd(1.357, 1.686, 18.114);
                yield return new melsyd(1.287, 1.56, 19.17);
                yield return new melsyd(1.087, 1.692, 18.713);
                yield return new melsyd(1.017, 1.597, 20.52);
                yield return new melsyd(1.09, 1.729, 20.345);
                yield return new melsyd(1.343, 1.733, 20.015);
                yield return new melsyd(1.164, 1.813, 18.027);
                yield return new melsyd(1.169, 1.725, 19.697);
                yield return new melsyd(1.465, 1.909, 19.897);
                yield return new melsyd(1.242, 1.765, 19.213);
                yield return new melsyd(1.22, 1.781, 19.773);
                yield return new melsyd(1.231, 1.717, 20.128);
                yield return new melsyd(1.266, 1.884, 21.181);
                yield return new melsyd(1.337, 1.881, 21.933);
                yield return new melsyd(1.079, 1.433, 20.049);
                yield return new melsyd(1.223, 1.534, 23.358);
                yield return new melsyd(1.351, 1.926, 21.12);
                yield return new melsyd(1.269, 1.87, 21.97);
                yield return new melsyd(1.382, 1.942, 21.411);
                yield return new melsyd(1.435, 2.222, 22.569);
                yield return new melsyd(1.371, 1.909, 20.849);
                yield return new melsyd(1.341, 2.089, 20.658);
                yield return new melsyd(1.399, 2.026, 21.192);
                yield return new melsyd(1.44, 2.009, 21.502);
                yield return new melsyd(1.236, 2.034, 22.152);
                yield return new melsyd(1.441, 2.085, 21.904);
                yield return new melsyd(0.988, 1.33, 20.634);
                yield return new melsyd(0.3, 0.318, 15.535);
                yield return new melsyd(0.401, 0.522, 16.69);
                yield return new melsyd(0.529, 0.824, 19.15);
                yield return new melsyd(0.786, 1.113, 21.128);
                yield return new melsyd(1.086, 1.285, 21.136);
                yield return new melsyd(0.725, 1.107, 19.693);
                yield return new melsyd(1.127, 1.591, 21.576);
                yield return new melsyd(1.146, 1.726, 21.449);
                yield return new melsyd(1.086, 1.758, 22.298);
                yield return new melsyd(1.134, 1.883, 21.056);
                yield return new melsyd(1.02, 2.089, 19.014);
                yield return new melsyd(1.022, 2.198, 19.511);
                yield return new melsyd(1.224, 2.449, 20.162);
                yield return new melsyd(0.895, 1.739, 21.158);
                yield return new melsyd(0.658, 1.48, 19.059);
                yield return new melsyd(0.977, 2.152, 21.972);
                yield return new melsyd(0.916, 2.258, 22.877);
                yield return new melsyd(0.83, 1.776, 22.19);
                yield return new melsyd(0.99, 2.355, 22.533);
                yield return new melsyd(0.77, 2.14, 20.682);
                yield return new melsyd(0.801, 1.988, 21.788);
                yield return new melsyd(0.839, 2.083, 21.299);
                yield return new melsyd(0.835, 2.115, 20.663);
                yield return new melsyd(0.802, 1.884, 21.948);
                yield return new melsyd(0.763, 1.797, 21.009);
                yield return new melsyd(0.77, 1.944, 20.443);
                yield return new melsyd(0.838, 2.001, 21.418);
                yield return new melsyd(0.742, 1.668, 23.273);
                yield return new melsyd(0.793, 1.527, 25.763);
                yield return new melsyd(0.9, 1.477, 26.045);
                yield return new melsyd(0.96, 1.949, 23.831);
                yield return new melsyd(0.8, 1.914, 22.742);
                yield return new melsyd(0.807, 1.632, 22.962);
                yield return new melsyd(0.841, 1.796, 25.253);
                yield return new melsyd(0.88, 1.696, 25.239);
                yield return new melsyd(0.818, 1.718, 27.387);
                yield return new melsyd(0.817, 1.442, 26.824);
                yield return new melsyd(0.819, 1.713, 27.294);
                yield return new melsyd(0.998, 1.796, 28.935);
                yield return new melsyd(1.22, 1.86, 31.642);
                yield return new melsyd(0.966, 1.554, 32.468);
                yield return new melsyd(0.895, 1.623, 27.673);
                yield return new melsyd(0.978, 1.641, 28.89);
                yield return new melsyd(0.913, 1.818, 26.465);
                yield return new melsyd(0.947, 1.969, 28.296);
                yield return new melsyd(1.002, 1.886, 29.274);
                yield return new melsyd(1.081, 2.03, 30.686);
                yield return new melsyd(0.977, 1.883, 29.786);
                yield return new melsyd(1.027, 1.871, 31.155);
                yield return new melsyd(0.895, 1.91, 28.459);
                yield return new melsyd(0.9, 1.921, 27.195);
                yield return new melsyd(0.762, 1.672, 26.274);
                yield return new melsyd(0.329, 0.386, 25.204);
                yield return new melsyd(0.351, 0.446, 24.434);
                yield return new melsyd(0.419, 0.819, 27.323);
                yield return new melsyd(0.618, 1.238, 27.303);
                yield return new melsyd(0.845, 1.761, 30.334);
                yield return new melsyd(0.727, 1.65, 26.833);
                yield return new melsyd(1.2, 2.031, 25.811);
                yield return new melsyd(1.801, 2.064, 27.238);
                yield return new melsyd(1.727, 2.418, 28.788);
                yield return new melsyd(1.992, 2.171, 27.263);
                yield return new melsyd(1.865, 2.362, 27.217);
                yield return new melsyd(1.801, 2.328, 26.41);
                yield return new melsyd(1.661, 2.336, 26.118);
                yield return new melsyd(2.366, 10.301, 18.642);
                yield return new melsyd(2.003, 9.964, 16.518);
                yield return new melsyd(2.092, 10.433, 17.276);
                yield return new melsyd(1.703, 8.281, 21.662);
                yield return new melsyd(1.337, 6.128, 20.473);
                yield return new melsyd(1.985, 9.709, 18.336);
                yield return new melsyd(1.808, 8.828, 17.018);
                yield return new melsyd(1.839, 8.078, 18.111);
                yield return new melsyd(1.714, 7.527, 18.41);
                yield return new melsyd(1.73, 7.486, 20.541);
                yield return new melsyd(1.725, 6.711, 21.408);
                yield return new melsyd(1.456, 5.93, 21.545);
                yield return new melsyd(1.447, 5.462, 21.732);
                yield return new melsyd(1.357, 3.71, 26.173);
                yield return new melsyd(1.28, 2.894, 27.432);
                yield return new melsyd(1.363, 3.008, 28.362);
                yield return new melsyd(1.228, 2.829, 29.827);
                yield return new melsyd(1.411, 3.252, 29.87);
                yield return new melsyd(1.13, 3.021, 26.534);
                yield return new melsyd(1.153, 2.667, 26.434);
                yield return new melsyd(1.257, 2.74, 26.137);
                yield return new melsyd(1.259, 2.807, 27.365);
                yield return new melsyd(1.153, 2.961, 27.91);
                yield return new melsyd(1.202, 2.57, 26.311);
                yield return new melsyd(1.185, 2.671, 27.538);
                yield return new melsyd(1.247, 2.809, 29.445);
                yield return new melsyd(1.434, 2.712, 28.326);
                yield return new melsyd(1.45, 2.606, 30.203);
                yield return new melsyd(1.227, 2.5, 27.838);
                yield return new melsyd(1.245, 2.898, 27.76);
                yield return new melsyd(1.417, 3.152, 27.322);
                yield return new melsyd(1.458, 3.053, 28.837);
                yield return new melsyd(1.398, 2.745, 26.548);
                yield return new melsyd(1.423, 3.156, 27.279);
                yield return new melsyd(1.358, 3.069, 27.306);
                yield return new melsyd(1.488, 3.379, 28.299);
            }
        }
    }
}