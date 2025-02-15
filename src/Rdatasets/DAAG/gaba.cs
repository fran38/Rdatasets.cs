// ReSharper disable All

namespace Rdatasets.DAAG
{
    using System.Collections.Generic;

    /// <summary>
    /// Effect of pentazocine on post-operative pain (average VAS scores)
    /// </summary>

    public class gaba
    {
        public readonly int κ;
        public readonly int min;
        public readonly double mbac;
        public readonly double mpl;
        public readonly double fbac;
        public readonly double fpl;
        public readonly double avbac;
        public readonly double avplac;

        public gaba(int κ, int min, double mbac, double mpl, double fbac, double fpl, double avbac, double avplac)
        {
            this.κ = κ;
            this.min = min;
            this.mbac = mbac;
            this.mpl = mpl;
            this.fbac = fbac;
            this.fpl = fpl;
            this.avbac = avbac;
            this.avplac = avplac;
        }

        public static IEnumerable<gaba> Data
        {
            get
            {
                yield return new gaba(10, 10, 1.76470588235294, 1.76470588235294, 2.18487394957983, 2.5546218487395, 2.11484593837535, 2.11029411764706);
                yield return new gaba(30, 30, 1.3109243697479, 1.64705882352941, 3.47899159663866, 4.15126050420168, 3.11764705882353, 2.74264705882353);
                yield return new gaba(50, 50, 0.0504201680672269, 0.672268907563025, 3.12605042016807, 3.66386554621849, 2.61344537815126, 1.98109243697479);
                yield return new gaba(70, 70, -0.571428571428572, -0.252100840336134, 3.02521008403361, 2.05042016806723, 2.42577030812325, 0.755252100840336);
                yield return new gaba(90, 90, -1.26050420168067, -0.504201680672269, 2.08403361344538, 0.605042016806723, 1.5266106442577, -0.0189075630252101);
                yield return new gaba(110, 110, -2.15126050420168, -2.21848739495798, 1.59663865546218, 0.336134453781513, 0.971988795518207, -1.10084033613445);
                yield return new gaba(130, 130, -1.64705882352941, -2.18487394957983, 1.3781512605042, 0.672268907563025, 0.873949579831933, -0.934873949579832);
                yield return new gaba(150, 150, -1.68067226890756, -2.85714285714286, 1.76470588235294, 0.756302521008403, 1.19047619047619, -1.27626050420168);
                yield return new gaba(170, 170, -1.68067226890756, -3.22689075630252, 1.05882352941176, 0.38655462184874, 0.602240896358544, -1.64600840336134);
            }
        }
    }
}
