// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Growth rates of personal consumption and personal income in the USA.
    /// </summary>

    public class uschange
    {
        public readonly int κ;
        public readonly double Consumption;
        public readonly double Income;
        public readonly double Production;
        public readonly double Savings;
        public readonly double Unemployment;

        public uschange(int κ, double Consumption, double Income, double Production, double Savings, double Unemployment)
        {
            this.κ = κ;
            this.Consumption = Consumption;
            this.Income = Income;
            this.Production = Production;
            this.Savings = Savings;
            this.Unemployment = Unemployment;
        }

        public static IEnumerable<uschange> Data
        {
            get
            {
                yield return new uschange(1, 0.615986218, 0.972261043, -2.452700312, 4.810311502, 0.9);
                yield return new uschange(2, 0.46037569, 1.169084717, -0.551525087, 7.287992337, 0.5);
                yield return new uschange(3, 0.876791423, 1.55327055, -0.358707862, 7.289013063, 0.5);
                yield return new uschange(4, -0.274245141, -0.255272381, -2.185454855, 0.985229644, 0.7);
                yield return new uschange(5, 1.897370758, 1.987153628, 1.90973412, 3.657770614, -0.1);
                yield return new uschange(6, 0.911992909, 1.447334175, 0.901535843, 6.051341804, -0.1);
                yield return new uschange(7, 0.794538845, 0.531811929, 0.308019416, -0.445832214, 0.1);
                yield return new uschange(8, 1.648587467, 1.160125137, 2.291304415, -1.53087186, 0);
                yield return new uschange(9, 1.313722178, 0.457011505, 4.149573867, -4.35859438, -0.2);
                yield return new uschange(10, 1.891474954, 1.016624409, 1.89062398, -5.054525795, -0.1);
                yield return new uschange(11, 1.530714, 1.904101264, 1.273352897, 5.809959038, -0.2);
                yield return new uschange(12, 2.318294715, 3.890258661, 3.436892066, 16.04471706, -0.3);
                yield return new uschange(13, 1.81073916, 0.708252663, 2.799076357, -5.348868495, -0.3);
                yield return new uschange(14, -0.041739961, 0.79430954, 0.817688618, 8.426034362, 0);
                yield return new uschange(15, 0.354235565, 0.433818275, 0.868996932, 2.758795652, -0.1);
                yield return new uschange(16, -0.291632155, 1.093809792, 1.472961869, 11.14642986, 0.1);
                yield return new uschange(17, -0.877027936, -1.661684821, -0.882483578, -2.533514487, 0.2);
                yield return new uschange(18, 0.351135548, -0.938353209, 0.074279194, -6.592644641, 0.3);
                yield return new uschange(19, 0.409597702, 0.094487794, -0.41314971, 0.51717884, 0.5);
                yield return new uschange(20, -1.475808634, -0.122595985, -4.064118932, 11.3433954, 1.3);
                yield return new uschange(21, 0.832257616, -0.163695461, -6.851039124, -5.476190695, 1.4);
                yield return new uschange(22, 1.65583461, 4.536509557, -1.331295584, 24.30960536, 0.2);
                yield return new uschange(23, 1.419420294, -1.463765323, 2.424359723, -17.65616104, -0.4);
                yield return new uschange(24, 1.054379319, 0.761663507, 2.169042084, 0.648090408, -0.2);
                yield return new uschange(25, 1.979980236, 1.168257614, 3.027204713, -2.95006644, -0.6);
                yield return new uschange(26, 0.913916067, 0.517299061, 1.278811007, -1.474557549, 0);
                yield return new uschange(27, 1.055323256, 0.733700255, 1.303864873, -0.067544751, 0);
                yield return new uschange(28, 1.298898253, 0.594583387, 1.775377653, -3.576722386, 0.2);
                yield return new uschange(29, 1.136375865, -0.031080031, 2.055160674, -9.160556577, -0.4);
                yield return new uschange(30, 0.549940731, 1.238089553, 3.058385074, 9.090504035, -0.2);
                yield return new uschange(31, 0.949852624, 1.518802926, 1.103088875, 7.944957186, -0.4);
                yield return new uschange(32, 1.49599724, 1.914562403, 0.633468496, 6.696276475, -0.4);
                yield return new uschange(33, 0.57549599, 0.702666874, -0.293390562, 2.922963831, -0.1);
                yield return new uschange(34, 2.111209598, 0.983141318, 3.948152635, -6.811142586, -0.4);
                yield return new uschange(35, 0.417962788, 0.719926198, 0.871147014, 4.792071621, 0.1);
                yield return new uschange(36, 0.797927101, 0.785536049, 1.784479911, 2.371184004, 0);
                yield return new uschange(37, 0.505845978, 1.057559464, 0.42594327, 7.774183368, -0.2);
                yield return new uschange(38, -0.057753395, -0.867651048, -0.204919439, -5.286348956, -0.1);
                yield return new uschange(39, 0.977300104, 0.471003402, -0.29723637, -1.845496437, 0.2);
                yield return new uschange(40, 0.268269822, 0.440379744, 0.335609285, 4.049598096, 0.1);
                yield return new uschange(41, -0.153918751, 0.338276858, 0.410561413, 5.861688643, 0.3);
                yield return new uschange(42, -2.274110188, -1.463885067, -4.300768323, 8.243229185, 1.3);
                yield return new uschange(43, 1.071881234, 1.213015071, -1.641819766, 5.707750442, -0.1);
                yield return new uschange(44, 1.316449412, 1.942438646, 3.780455204, 9.150987872, -0.3);
                yield return new uschange(45, 0.524727703, -0.268134056, 0.246276869, -5.681390022, 0.2);
                yield return new uschange(46, -0.01728203, -0.023630251, 0.309775731, 0.88183993, 0.1);
                yield return new uschange(47, 0.401651498, 2.026801832, 0.917074436, 15.99035721, 0.1);
                yield return new uschange(48, -0.752876197, 0.195606284, -2.254577974, 7.805506497, 0.9);
                yield return new uschange(49, 0.659383756, 0.119698877, -2.071312935, -3.342439552, 0.5);
                yield return new uschange(50, 0.368541731, 0.575489969, -1.247663845, 2.194001664, 0.6);
                yield return new uschange(51, 0.769544638, 0.5348441, -1.4005043, 0.034995626, 0.5);
                yield return new uschange(52, 1.808760062, 0.449383114, -1.90375664, -9.576514683, 0.7);
                yield return new uschange(53, 0.968029536, 0.855884249, 1.146557199, 0.345954602, -0.5);
                yield return new uschange(54, 1.959468308, 0.706327192, 2.179422483, -10.17004699, -0.2);
                yield return new uschange(55, 1.739494415, 1.498109989, 3.367718968, 0.212179159, -0.9);
                yield return new uschange(56, 1.563893321, 2.131389109, 2.581684451, 8.216000679, -0.9);
                yield return new uschange(57, 0.845264424, 2.02348788, 2.897095449, 13.8691815, -0.5);
                yield return new uschange(58, 1.415044947, 1.649211363, 1.538213236, 4.389002294, -0.6);
                yield return new uschange(59, 0.765466077, 1.361638451, 0.721287396, 6.516860886, 0.1);
                yield return new uschange(60, 1.313800619, 0.819273186, 0.041155571, -2.875449305, 0);
                yield return new uschange(61, 1.686553201, -0.238957592, 0.323531587, -18.71008389, -0.1);
                yield return new uschange(62, 0.934369895, 1.906779055, 0.070209955, 11.8287195, 0.2);
                yield return new uschange(63, 1.90256675, -0.335362834, -0.14046924, -23.57393474, -0.3);
                yield return new uschange(64, 0.256565652, 1.14181151, 0.579788134, 11.36628338, -0.1);
                yield return new uschange(65, 0.843042787, 1.239511103, 0.58132135, 5.861268364, 0.2);
                yield return new uschange(66, 1.111773898, 1.319385489, -0.576417775, 3.275517339, 0);
                yield return new uschange(67, 1.794994057, 0.704771501, 0.372493292, -10.09044542, -0.2);
                yield return new uschange(68, 0.637684461, 0.179779252, 1.137347779, -4.829201307, -0.4);
                yield return new uschange(69, 0.015693968, 0.819733663, 1.307582278, 12.46424452, 0);
                yield return new uschange(70, 1.377316859, -0.975057912, 1.750005633, -29.52866718, -0.4);
                yield return new uschange(71, 1.152257124, 1.80185055, 1.843661997, 12.32810406, -0.3);
                yield return new uschange(72, 0.210164388, 1.32743427, 2.406450582, 16.63076101, -0.2);
                yield return new uschange(73, 1.763160259, 1.448618751, 0.920131207, -0.968965055, 0);
                yield return new uschange(74, 0.730537137, 1.020848942, 0.873163532, 5.677768665, -0.3);
                yield return new uschange(75, 0.850832326, 0.958203359, 0.381036678, 3.646498672, 0);
                yield return new uschange(76, 1.137898379, 0.962070239, 0.702920251, -0.197303583, -0.1);
                yield return new uschange(77, 0.460641524, 1.226930232, 0.433726854, 10.01461545, -0.3);
                yield return new uschange(78, 0.469378076, -0.294890912, -0.366757317, -8.155765252, 0.3);
                yield return new uschange(79, 0.989501453, 0.678228974, -0.621421206, -2.486225541, 0);
                yield return new uschange(80, 0.439427666, 0.80025832, 0.424433925, 5.44681102, 0.1);
                yield return new uschange(81, 0.855434173, 0.839394835, 0.68265169, 2.875449305, -0.2);
                yield return new uschange(82, 0.312304512, 0.595728478, 0.774465467, 5.109516443, 0);
                yield return new uschange(83, 0.40261313, 0.03740765, 0.419448, -3.177672483, 0.7);
                yield return new uschange(84, -0.759107163, -0.79479735, -1.573452965, -0.179533262, 0.4);
                yield return new uschange(85, -0.345350076, 0.211832904, -1.914220279, 6.493152566, 0.5);
                yield return new uschange(86, 0.835642235, 0.690433559, 0.59131506, -0.309206149, 0.1);
                yield return new uschange(87, 0.484398434, 0.362051813, 1.362556445, -0.140864934, 0);
                yield return new uschange(88, -0.026265792, 0.851003244, 0.21710308, 11.3419301, 0.4);
                yield return new uschange(89, 1.859969993, 2.124210667, -0.133653646, 7.232651503, 0.1);
                yield return new uschange(90, 0.683543712, 1.04095059, 1.768747729, 5.467086657, 0.4);
                yield return new uschange(91, 1.076612141, 0.435620406, 0.761673884, -5.936460905, -0.2);
                yield return new uschange(92, 1.183723956, 0.34210852, 1.050245772, -5.886188559, -0.2);
                yield return new uschange(93, 0.378179361, 0.558771864, 0.879014712, 2.634647035, -0.4);
                yield return new uschange(94, 0.893927288, 0.176271033, 0.217551079, -6.916646753, 0);
                yield return new uschange(95, 1.098137664, 0.058688031, 0.401358914, -11.99337844, -0.3);
                yield return new uschange(96, 0.881220253, 0.654963526, 1.496182748, -1.837088702, -0.2);
                yield return new uschange(97, 1.14064791, 0.698465785, 1.222136562, -5.186006288, 0);
                yield return new uschange(98, 0.771762246, 1.053671655, 1.782502746, 5.156097509, -0.4);
                yield return new uschange(99, 0.772143643, 0.592473769, 1.267180998, -2.422158983, -0.2);
                yield return new uschange(100, 1.070148048, 1.381106606, 2.043704038, 6.323518979, -0.4);
                yield return new uschange(101, 0.264205052, 0.948735276, 1.025526009, 10.11514398, -0.1);
                yield return new uschange(102, 0.893111409, 0.227806352, 0.337856848, -10.60541172, 0.2);
                yield return new uschange(103, 0.912647021, 0.889570063, 0.900438868, -0.115707274, 0);
                yield return new uschange(104, 0.700254253, 0.575919976, 0.874672725, -2.907266861, 0);
                yield return new uschange(105, 0.923609672, 0.952556633, 0.692851946, 2.559339575, -0.1);
                yield return new uschange(106, 1.079978873, 0.951617911, 2.111347525, -0.758021122, -0.2);
                yield return new uschange(107, 0.600557985, 0.793697379, 1.244186797, 3.338439524, -0.1);
                yield return new uschange(108, 0.782981223, 0.520357459, 1.3539689, -3.338439524, 0.2);
                yield return new uschange(109, 1.049492533, 0.998585523, 1.867146997, 0.612693383, -0.2);
                yield return new uschange(110, 0.452198553, 0.85103564, 1.487639219, 6.175323221, -0.2);
                yield return new uschange(111, 1.696542639, 1.183522219, 2.28632066, -7.227964519, -0.1);
                yield return new uschange(112, 1.180627971, 1.423257417, 2.480913406, 5.434565647, -0.2);
                yield return new uschange(113, 1.026936255, 2.107530518, 1.10343775, 19.35335228, 0);
                yield return new uschange(114, 1.750693993, 1.387671329, 0.651222385, -4.81709478, -0.2);
                yield return new uschange(115, 1.305969774, 1.014644275, 0.725519551, -3.129839824, 0.1);
                yield return new uschange(116, 1.458886148, 0.808930324, 1.444216739, -9.149234042, -0.2);
                yield return new uschange(117, 0.948211911, 0.891731745, 1.103416632, 1.887357182, -0.2);
                yield return new uschange(118, 1.469714146, 0.247221853, 0.985742612, -23.49652903, 0.1);
                yield return new uschange(119, 1.129214355, 0.667292262, 0.902798808, -9.862648348, -0.1);
                yield return new uschange(120, 1.457488951, 1.460922421, 1.755332342, 2.358252249, -0.2);
                yield return new uschange(121, 1.511067591, 1.950613352, 0.996820185, 12.2868408, 0);
                yield return new uschange(122, 0.955088776, 1.031743486, 1.232938047, 1.280017477, 0);
                yield return new uschange(123, 0.967976475, 1.161786679, -0.102252679, 2.573902292, -0.1);
                yield return new uschange(124, 0.886297381, 0.337253432, -0.203883833, -13.16296208, 0);
                yield return new uschange(125, 0.421590863, 0.848658258, -1.351439108, 13.22491995, 0.4);
                yield return new uschange(126, 0.256899818, -0.088181483, -1.259544368, -6.890439157, 0.2);
                yield return new uschange(127, 0.363810837, 2.336789199, -1.441017442, 41.66826457, 0.5);
                yield return new uschange(128, 1.516303214, -1.244433525, -1.060136752, -56.75209674, 0.7);
                yield return new uschange(129, 0.299582571, 2.403314188, 0.70916406, 50.75796205, 0);
                yield return new uschange(130, 0.508990316, 0.505598766, 1.542809566, 0.878618369, 0.1);
                yield return new uschange(131, 0.696672411, -0.128281941, 0.594781431, -14.70397426, -0.1);
                yield return new uschange(132, 0.536343065, 0.479419266, -0.05776556, 1.587334916, 0.3);
                yield return new uschange(133, 0.438261691, 0.278340261, 0.539227892, 0.497448336, -0.1);
                yield return new uschange(134, 1.107190856, 1.437294453, -0.69876172, 7.008916248, 0.4);
                yield return new uschange(135, 1.463778819, 1.625449475, 0.607273506, 6.184131499, -0.2);
                yield return new uschange(136, 0.773340456, 0.403538639, 1.005991257, -6.892747782, -0.4);
                yield return new uschange(137, 0.967685345, 0.726531616, 0.657928057, -2.961520403, 0.1);
                yield return new uschange(138, 0.647606074, 0.980567459, 0.574617798, 8.308856272, -0.2);
                yield return new uschange(139, 0.951171668, 0.524501133, 0.563300295, -8.993182856, -0.2);
                yield return new uschange(140, 1.020417017, 1.242387061, 1.385227632, 6.235850166, 0);
                yield return new uschange(141, 0.761725559, -0.968270072, 1.39435718, -42.28191228, -0.2);
                yield return new uschange(142, 1.081365878, 0.788354672, 0.505863668, -18.27592893, -0.2);
                yield return new uschange(143, 0.771864939, 0.511369491, -0.503058479, -7.876652293, 0);
                yield return new uschange(144, 0.375914847, 0.821918428, 0.9336501, 20.37236078, -0.1);
                yield return new uschange(145, 1.11522822, 2.259044738, 0.950578533, 37.40653542, -0.2);
                yield return new uschange(146, 0.531005543, 0.149878134, 0.5963601, -12.34810568, -0.1);
                yield return new uschange(147, 0.582087468, 0.284907219, 0.335527731, -10.5527614, -0.1);
                yield return new uschange(148, 1.014343893, 1.300591618, 0.256034008, 6.0310008, -0.1);
                yield return new uschange(149, 0.524861836, 0.653739931, 0.917949565, 6.60516929, 0);
                yield return new uschange(150, 0.338741187, 0.192608703, 1.195942472, -7.236484518, 0.2);
                yield return new uschange(151, 0.443918753, 0.262387319, 0.223569092, -9.006745548, 0.1);
                yield return new uschange(152, 0.125055845, 0.083929375, 0.164246315, 2.328872376, 0.3);
                yield return new uschange(153, -0.206525482, 0.71926565, -0.42872571, 29.83728599, 0.1);
                yield return new uschange(154, 0.16783443, 2.086937749, -1.412970216, 46.43989041, 0.5);
                yield return new uschange(155, -0.724994462, -2.3261186, -3.263499446, -32.53252494, 0.5);
                yield return new uschange(156, -1.210685584, 0.640195342, -4.354177411, 36.3124049, 1.2);
                yield return new uschange(157, -0.343543699, -0.188888489, -5.750450746, 0.923060197, 1.4);
                yield return new uschange(158, -0.451743641, 0.708993682, -3.00372447, 16.09059408, 0.8);
                yield return new uschange(159, 0.604913319, -1.1034318, 1.398804194, -24.49229966, 0.3);
                yield return new uschange(160, -0.011150137, -0.132131931, 1.544006165, 0.848292199, 0.1);
                yield return new uschange(161, 0.5348174, 0.100949855, 1.880069307, -5.543990508, 0);
                yield return new uschange(162, 0.810404062, 1.292292588, 2.054024788, 11.65612884, -0.5);
                yield return new uschange(163, 0.64501881, 0.496780984, 1.426836712, -0.352086089, 0.1);
                yield return new uschange(164, 1.018338739, 0.694952292, 0.37927209, -3.273359581, -0.2);
                yield return new uschange(165, 0.500413148, 1.215715023, 0.501740402, 14.33860193, -0.3);
                yield return new uschange(166, 0.201419784, -0.15658108, 0.21878696, -4.077051314, 0.1);
                yield return new uschange(167, 0.43372599, 0.52891255, 1.011138664, 2.722503997, -0.1);
                yield return new uschange(168, 0.335938954, 0.060747192, 0.851516915, -3.454477125, -0.5);
                yield return new uschange(169, 0.601089953, 1.62204885, 0.886518168, 17.6253051, -0.3);
                yield return new uschange(170, 0.169429564, 0.766895432, 0.629235856, 8.9694971, 0);
                yield return new uschange(171, 0.26416034, -0.050714517, 0.078801659, -3.049221775, -0.4);
                yield return new uschange(172, 0.278771861, 2.591066966, 0.633055093, 29.04670355, 0.1);
                yield return new uschange(173, 0.468612916, -4.265250465, 0.677132428, -68.78826698, -0.4);
                yield return new uschange(174, 0.205458025, 0.58146541, 0.307449609, 7.816477285, 0);
                yield return new uschange(175, 0.466417872, 0.583289124, 0.234408879, 3.49400682, -0.3);
                yield return new uschange(176, 0.839173667, 0.214948957, 0.79208722, -11.2766145, -0.5);
                yield return new uschange(177, 0.473451177, 1.103694866, 0.547091665, 13.52020248, 0);
                yield return new uschange(178, 0.933756976, 1.293904923, 1.338010744, 8.244047697, -0.6);
                yield return new uschange(179, 0.916871775, 0.998533963, 0.623527314, 2.461952556, -0.2);
                yield return new uschange(180, 1.125332501, 1.046418013, 0.903554275, -1.513050221, -0.3);
                yield return new uschange(181, 0.596240045, 0.490406802, -0.467108784, -0.758400168, -0.2);
                yield return new uschange(182, 0.708143887, 0.954959489, -0.697021615, 5.023917728, -0.1);
                yield return new uschange(183, 0.664969559, 0.801662673, 0.380606103, 3.180929764, -0.3);
                yield return new uschange(184, 0.561679779, 0.740062599, -0.845546376, 3.482786015, 0);
                yield return new uschange(185, 0.404682163, 0.5190254, -0.41793048, 2.236534053, 0);
                yield return new uschange(186, 1.047707406, 0.723720782, -0.203318828, -2.721501056, -0.1);
                yield return new uschange(187, 0.729597795, 0.644700809, 0.47491844, -0.572857926, 0);
            }
        }
    }
}
