// ReSharper disable All

namespace Rdatasets.Ecdat
{
    using System.Collections.Generic;

    /// <summary>
    /// Money, National Product and Interest Rate
    /// </summary>

    public class Mpyr
    {
        public readonly int κ;
        public readonly double m;
        public readonly double p;
        public readonly double y;
        public readonly double r;

        public Mpyr(int κ, double m, double p, double y, double r)
        {
            this.κ = κ;
            this.m = m;
            this.p = p;
            this.y = y;
            this.r = r;
        }

        public static IEnumerable<Mpyr> Data
        {
            get
            {
                yield return new Mpyr(1, 1.718773871544, 2.092641013357, 0.903019518493, 4.38);
                yield return new Mpyr(2, 1.856318241213, 2.086574260675, 1.013103823866, 4.28);
                yield return new Mpyr(3, 1.936512475518, 2.12047581235, 1.011481654118, 4.92);
                yield return new Mpyr(4, 1.984969583897, 2.130231987296, 1.055406571108, 5.47);
                yield return new Mpyr(5, 2.025828886183, 2.145646550697, 1.03315271884, 4.2);
                yield return new Mpyr(6, 2.132493232987, 2.166460925592, 1.110300195095, 4.4);
                yield return new Mpyr(7, 2.195428089084, 2.186850881295, 1.235220105533, 5.68);
                yield return new Mpyr(8, 2.228242288858, 2.228186505353, 1.243617481747, 6.34);
                yield return new Mpyr(9, 2.177124930782, 2.22642439036, 1.129233362741, 4.37);
                yield return new Mpyr(10, 2.216366788043, 2.26108990646, 1.257672657103, 3.98);
                yield return new Mpyr(11, 2.269883003714, 2.286322531941, 1.274864246326, 5.01);
                yield return new Mpyr(12, 2.308991937435, 2.277982200024, 1.291970623712, 4.03);
                yield return new Mpyr(13, 2.359812922171, 2.320611605419, 1.343539355005, 4.74);
                yield return new Mpyr(14, 2.367113556898, 2.325415457732, 1.389246014272, 5.58);
                yield return new Mpyr(15, 2.421697485034, 2.339690085525, 1.285821118827, 4.79);
                yield return new Mpyr(16, 2.564430920107, 2.370700322267, 1.315795011197, 3.45);
                yield return new Mpyr(17, 2.716863322271, 2.49271527283, 1.475856814295, 3.42);
                yield return new Mpyr(18, 2.877120515043, 2.703895658086, 1.449152189657, 4.74);
                yield return new Mpyr(19, 3.003487346242, 2.843562457509, 1.54323865692, 5.87);
                yield return new Mpyr(20, 3.124910068058, 2.858671337934, 1.583120206187, 5.42);
                yield return new Mpyr(21, 3.111308502524, 2.990209179619, 1.531891035947, 7.37);
                yield return new Mpyr(22, 2.99687327815, 2.830152294861, 1.48852713469, 6.53);
                yield return new Mpyr(23, 3.097825934091, 2.779721441234, 1.55806870372, 4.42);
                yield return new Mpyr(24, 3.102151446024, 2.802780106985, 1.698251636114, 4.97);
                yield return new Mpyr(25, 3.164065214965, 2.789812344216, 1.726302455309, 3.9);
                yield return new Mpyr(26, 3.230837224764, 2.80969371477, 1.749585658296, 4);
                yield return new Mpyr(27, 3.205683548335, 2.814602904796, 1.81792358994, 4.23);
                yield return new Mpyr(28, 3.217485170264, 2.787802293288, 1.827657847719, 4.02);
                yield return new Mpyr(29, 3.24412683642, 2.794819865947, 1.843084282724, 4.84);
                yield return new Mpyr(30, 3.244051179148, 2.793820365614, 1.904623077432, 5.78);
                yield return new Mpyr(31, 3.185151066333, 2.747776427113, 1.789383587521, 3.55);
                yield return new Mpyr(32, 3.055612745494, 2.619466978469, 1.698796332555, 2.63);
                yield return new Mpyr(33, 2.982038672432, 2.49676113135, 1.500541803381, 2.72);
                yield return new Mpyr(34, 2.953009202564, 2.483210788518, 1.465431339348, 1.67);
                yield return new Mpyr(35, 3.0950196532, 2.546640236472, 1.566798627553, 0.88);
                yield return new Mpyr(36, 3.266421468224, 2.533753460195, 1.724049693434, 0.75);
                yield return new Mpyr(37, 3.398601696884, 2.574419800579, 1.843672987624, 0.75);
                yield return new Mpyr(38, 3.339760214654, 2.583099334298, 1.930959080201, 0.94);
                yield return new Mpyr(39, 3.426631207995, 2.578148829138, 1.848603297899, 0.86);
                yield return new Mpyr(40, 3.553224566151, 2.5706768143, 1.92609394276, 0.72);
                yield return new Mpyr(41, 3.704948441118, 2.58186400369, 2.018275745697, 0.81);
                yield return new Mpyr(42, 3.843908155477, 2.658000642471, 2.131855763405, 0.7);
                yield return new Mpyr(43, 4.106245265933, 2.780735126065, 2.276417509776, 0.69);
                yield return new Mpyr(44, 4.349712785481, 2.904466885701, 2.350274446993, 0.72);
                yield return new Mpyr(45, 4.477431453996, 2.976141922408, 2.363659914324, 0.75);
                yield return new Mpyr(46, 4.598443069212, 3.019361041528, 2.329062213917, 0.75);
                yield return new Mpyr(47, 4.64782076654, 3.028101661339, 2.245169435698, 0.81);
                yield return new Mpyr(48, 4.693156752469, 3.105707126763, 2.277181141236, 1.058333333333);
                yield return new Mpyr(49, 4.697767797378, 3.17073544954, 2.314891015313, 1.460833333333);
                yield return new Mpyr(50, 4.68747534375, 3.163363114938, 2.310691680527, 1.464166666667);
                yield return new Mpyr(51, 4.713960099344, 3.182211840497, 2.396007411184, 1.493333333333);
                yield return new Mpyr(52, 4.757602089988, 3.225851438605, 2.498550323254, 2.2075);
                yield return new Mpyr(53, 4.806631851635, 3.239658364051, 2.536289721406, 2.325);
                yield return new Mpyr(54, 4.831215710968, 3.256171609612, 2.574683947608, 2.499166666667);
                yield return new Mpyr(55, 4.846167333186, 3.273364010152, 2.555728655469, 1.5325);
                yield return new Mpyr(56, 4.877650132275, 3.305053521109, 2.612629923494, 2.3125);
                yield return new Mpyr(57, 4.889297159638, 3.336658860525, 2.629744255988, 3.363333333333);
                yield return new Mpyr(58, 4.894674173693, 3.371596911886, 2.644316315624, 3.803333333333);
                yield return new Mpyr(59, 4.906306438624, 3.392829131992, 2.632855666002, 2.453333333333);
                yield return new Mpyr(60, 4.944732880317, 3.419364685618, 2.692379777345, 4.099166666667);
                yield return new Mpyr(61, 4.943901773116, 3.437207819185, 2.713235021761, 3.69);
                yield return new Mpyr(62, 4.963368968295, 3.446807892914, 2.739555040068, 2.98);
                yield return new Mpyr(63, 4.987196062362, 3.468856030136, 2.794970712074, 3.2675);
                yield return new Mpyr(64, 5.017224647654, 3.485078865643, 2.834789743437, 3.61);
                yield return new Mpyr(65, 5.055077394785, 3.501796580218, 2.888234333307, 3.9875);
                yield return new Mpyr(66, 5.096762020639, 3.527095548538, 2.946409270905, 4.43);
                yield return new Mpyr(67, 5.14176101764, 3.561046082604, 3.004007597506, 5.6225);
                yield return new Mpyr(68, 5.180378068683, 3.588368272518, 3.030337332606, 5.1);
                yield return new Mpyr(69, 5.247944700883, 3.636928048482, 3.070850738468, 5.974166666667);
                yield return new Mpyr(70, 5.30562394173, 3.690752698496, 3.092006090312, 8.013333333333);
                yield return new Mpyr(71, 5.343211060438, 3.747148362238, 3.084427570005, 7.406666666667);
                yield return new Mpyr(72, 5.408217562248, 3.801091444721, 3.111800618366, 5.023333333333);
                yield return new Mpyr(73, 5.476847020936, 3.848017675452, 3.159401926643, 4.866666666667);
                yield return new Mpyr(74, 5.546673720334, 3.91252288047, 3.2113311937, 8.390833333333);
                yield return new Mpyr(75, 5.595733162237, 3.997282849379, 3.199665859379, 9.7225);
                yield return new Mpyr(76, 5.640043633689, 4.088074949209, 3.18197694248, 6.148333333333);
                yield return new Mpyr(77, 5.694601569941, 4.149858105485, 3.230117094952, 5.300833333333);
                yield return new Mpyr(78, 5.768529307429, 4.212497899679, 3.27691418383, 5.7825);
                yield return new Mpyr(79, 5.847594176688, 4.281169850862, 3.329559169498, 8.288333333333);
                yield return new Mpyr(80, 5.92117619399, 4.365007629504, 3.350305519053, 11.1075);
                yield return new Mpyr(81, 5.981287940656, 4.451727588745, 3.343136748748, 12.494166666667);
                yield return new Mpyr(82, 6.052344038403, 4.542762725859, 3.360011282664, 14.61);
                yield return new Mpyr(83, 6.116259975404, 4.605170185988, 3.326051691778, 11.4525);
                yield return new Mpyr(84, 6.221269197295, 4.647031640083, 3.362372977725, 8.98);
                yield return new Mpyr(85, 6.28911242059, 4.686289237273, 3.43243928568, 10.070833333333);
                yield return new Mpyr(86, 6.375294516563, 4.718945200247, 3.463516239026, 7.961666666667);
                yield return new Mpyr(87, 6.502527642675, 4.746235626267, 3.489005710264, 6.239166666667);
                yield return new Mpyr(88, 6.612533744973, 4.778703236749, 3.524696306461, 6.9375);
                yield return new Mpyr(89, 6.65428137786, 4.813809051099, 3.568033951828, 7.854166666667);
                yield return new Mpyr(90, 6.664058193512, 4.858066695452, 3.59334453541, 8.7075);
            }
        }
    }
}
