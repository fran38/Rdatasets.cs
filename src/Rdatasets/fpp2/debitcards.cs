// ReSharper disable All

namespace Rdatasets.fpp2
{
    using System.Collections.Generic;

    /// <summary>
    /// Retail debit card usage in Iceland.
    /// </summary>

    public class debitcards
    {
        public readonly int κ;
        public readonly double time;
        public readonly double value;

        public debitcards(int κ, double time, double value)
        {
            this.κ = κ;
            this.time = time;
            this.value = value;
        }

        public static IEnumerable<debitcards> Data
        {
            get
            {
                yield return new debitcards(1, 2000, 7.204);
                yield return new debitcards(2, 2000.08333333333, 7.335);
                yield return new debitcards(3, 2000.16666666667, 7.812);
                yield return new debitcards(4, 2000.25, 7.413);
                yield return new debitcards(5, 2000.33333333333, 9.136);
                yield return new debitcards(6, 2000.41666666667, 8.725);
                yield return new debitcards(7, 2000.5, 8.751);
                yield return new debitcards(8, 2000.58333333333, 9.609);
                yield return new debitcards(9, 2000.66666666667, 8.601);
                yield return new debitcards(10, 2000.75, 8.93);
                yield return new debitcards(11, 2000.83333333333, 8.835);
                yield return new debitcards(12, 2000.91666666667, 11.688);
                yield return new debitcards(13, 2001, 8.078);
                yield return new debitcards(14, 2001.08333333333, 7.892);
                yield return new debitcards(15, 2001.16666666667, 8.151);
                yield return new debitcards(16, 2001.25, 8.738);
                yield return new debitcards(17, 2001.33333333333, 9.416);
                yield return new debitcards(18, 2001.41666666667, 9.533);
                yield return new debitcards(19, 2001.5, 9.943);
                yield return new debitcards(20, 2001.58333333333, 10.859);
                yield return new debitcards(21, 2001.66666666667, 8.789);
                yield return new debitcards(22, 2001.75, 9.96);
                yield return new debitcards(23, 2001.83333333333, 9.619);
                yield return new debitcards(24, 2001.91666666667, 12.9);
                yield return new debitcards(25, 2002, 8.62);
                yield return new debitcards(26, 2002.08333333333, 8.401);
                yield return new debitcards(27, 2002.16666666667, 8.546);
                yield return new debitcards(28, 2002.25, 10.004);
                yield return new debitcards(29, 2002.33333333333, 10.675);
                yield return new debitcards(30, 2002.41666666667, 10.115);
                yield return new debitcards(31, 2002.5, 11.206);
                yield return new debitcards(32, 2002.58333333333, 11.555);
                yield return new debitcards(33, 2002.66666666667, 10.453);
                yield return new debitcards(34, 2002.75, 10.421);
                yield return new debitcards(35, 2002.83333333333, 9.95);
                yield return new debitcards(36, 2002.91666666667, 13.975);
                yield return new debitcards(37, 2003, 9.315);
                yield return new debitcards(38, 2003.08333333333, 9.366);
                yield return new debitcards(39, 2003.16666666667, 9.91);
                yield return new debitcards(40, 2003.25, 10.302);
                yield return new debitcards(41, 2003.33333333333, 11.371);
                yield return new debitcards(42, 2003.41666666667, 11.857);
                yield return new debitcards(43, 2003.5, 12.387);
                yield return new debitcards(44, 2003.58333333333, 12.421);
                yield return new debitcards(45, 2003.66666666667, 12.073);
                yield return new debitcards(46, 2003.75, 11.963);
                yield return new debitcards(47, 2003.83333333333, 10.666);
                yield return new debitcards(48, 2003.91666666667, 15.613);
                yield return new debitcards(49, 2004, 10.586);
                yield return new debitcards(50, 2004.08333333333, 10.558);
                yield return new debitcards(51, 2004.16666666667, 12.064);
                yield return new debitcards(52, 2004.25, 11.899);
                yield return new debitcards(53, 2004.33333333333, 12.077);
                yield return new debitcards(54, 2004.41666666667, 13.918);
                yield return new debitcards(55, 2004.5, 13.611);
                yield return new debitcards(56, 2004.58333333333, 14.132);
                yield return new debitcards(57, 2004.66666666667, 13.509);
                yield return new debitcards(58, 2004.75, 13.152);
                yield return new debitcards(59, 2004.83333333333, 13.993);
                yield return new debitcards(60, 2004.91666666667, 18.203);
                yield return new debitcards(61, 2005, 14.262);
                yield return new debitcards(62, 2005.08333333333, 13.024);
                yield return new debitcards(63, 2005.16666666667, 14.062);
                yield return new debitcards(64, 2005.25, 14.718);
                yield return new debitcards(65, 2005.33333333333, 16.544);
                yield return new debitcards(66, 2005.41666666667, 16.732);
                yield return new debitcards(67, 2005.5, 16.23);
                yield return new debitcards(68, 2005.58333333333, 18.126);
                yield return new debitcards(69, 2005.66666666667, 16.016);
                yield return new debitcards(70, 2005.75, 15.601);
                yield return new debitcards(71, 2005.83333333333, 15.394);
                yield return new debitcards(72, 2005.91666666667, 20.439);
                yield return new debitcards(73, 2006, 14.991);
                yield return new debitcards(74, 2006.08333333333, 14.908);
                yield return new debitcards(75, 2006.16666666667, 17.459);
                yield return new debitcards(76, 2006.25, 14.501);
                yield return new debitcards(77, 2006.33333333333, 18.271);
                yield return new debitcards(78, 2006.41666666667, 17.963);
                yield return new debitcards(79, 2006.5, 17.026);
                yield return new debitcards(80, 2006.58333333333, 18.111);
                yield return new debitcards(81, 2006.66666666667, 15.989);
                yield return new debitcards(82, 2006.75, 16.735);
                yield return new debitcards(83, 2006.83333333333, 15.949);
                yield return new debitcards(84, 2006.91666666667, 20.216);
                yield return new debitcards(85, 2007, 16.198);
                yield return new debitcards(86, 2007.08333333333, 15.06);
                yield return new debitcards(87, 2007.16666666667, 16.168);
                yield return new debitcards(88, 2007.25, 16.376);
                yield return new debitcards(89, 2007.33333333333, 18.403);
                yield return new debitcards(90, 2007.41666666667, 19.113);
                yield return new debitcards(91, 2007.5, 19.303);
                yield return new debitcards(92, 2007.58333333333, 20.56);
                yield return new debitcards(93, 2007.66666666667, 16.621);
                yield return new debitcards(94, 2007.75, 18.788);
                yield return new debitcards(95, 2007.83333333333, 17.97);
                yield return new debitcards(96, 2007.91666666667, 22.464);
                yield return new debitcards(97, 2008, 16.658);
                yield return new debitcards(98, 2008.08333333333, 16.214);
                yield return new debitcards(99, 2008.16666666667, 16.043);
                yield return new debitcards(100, 2008.25, 16.418);
                yield return new debitcards(101, 2008.33333333333, 17.644);
                yield return new debitcards(102, 2008.41666666667, 17.705);
                yield return new debitcards(103, 2008.5, 18.107);
                yield return new debitcards(104, 2008.58333333333, 17.975);
                yield return new debitcards(105, 2008.66666666667, 17.598);
                yield return new debitcards(106, 2008.75, 17.658);
                yield return new debitcards(107, 2008.83333333333, 15.75);
                yield return new debitcards(108, 2008.91666666667, 22.414);
                yield return new debitcards(109, 2009, 16.065);
                yield return new debitcards(110, 2009.08333333333, 15.467);
                yield return new debitcards(111, 2009.16666666667, 16.297);
                yield return new debitcards(112, 2009.25, 16.53);
                yield return new debitcards(113, 2009.33333333333, 18.41);
                yield return new debitcards(114, 2009.41666666667, 20.274);
                yield return new debitcards(115, 2009.5, 21.311);
                yield return new debitcards(116, 2009.58333333333, 20.991);
                yield return new debitcards(117, 2009.66666666667, 18.305);
                yield return new debitcards(118, 2009.75, 17.832);
                yield return new debitcards(119, 2009.83333333333, 18.223);
                yield return new debitcards(120, 2009.91666666667, 23.987);
                yield return new debitcards(121, 2010, 15.964);
                yield return new debitcards(122, 2010.08333333333, 16.606);
                yield return new debitcards(123, 2010.16666666667, 19.216);
                yield return new debitcards(124, 2010.25, 16.419);
                yield return new debitcards(125, 2010.33333333333, 19.638);
                yield return new debitcards(126, 2010.41666666667, 19.773);
                yield return new debitcards(127, 2010.5, 21.052);
                yield return new debitcards(128, 2010.58333333333, 22.011);
                yield return new debitcards(129, 2010.66666666667, 19.039);
                yield return new debitcards(130, 2010.75, 17.893);
                yield return new debitcards(131, 2010.83333333333, 19.276);
                yield return new debitcards(132, 2010.91666666667, 25.167);
                yield return new debitcards(133, 2011, 16.699);
                yield return new debitcards(134, 2011.08333333333, 16.619);
                yield return new debitcards(135, 2011.16666666667, 17.851);
                yield return new debitcards(136, 2011.25, 18.16);
                yield return new debitcards(137, 2011.33333333333, 22.032);
                yield return new debitcards(138, 2011.41666666667, 21.395);
                yield return new debitcards(139, 2011.5, 22.217);
                yield return new debitcards(140, 2011.58333333333, 24.565);
                yield return new debitcards(141, 2011.66666666667, 21.095);
                yield return new debitcards(142, 2011.75, 20.114);
                yield return new debitcards(143, 2011.83333333333, 19.931);
                yield return new debitcards(144, 2011.91666666667, 26.12);
                yield return new debitcards(145, 2012, 18.58);
                yield return new debitcards(146, 2012.08333333333, 18.492);
                yield return new debitcards(147, 2012.16666666667, 19.724);
                yield return new debitcards(148, 2012.25, 20.123);
                yield return new debitcards(149, 2012.33333333333, 22.582);
                yield return new debitcards(150, 2012.41666666667, 22.595);
                yield return new debitcards(151, 2012.5, 23.379);
                yield return new debitcards(152, 2012.58333333333, 24.92);
                yield return new debitcards(153, 2012.66666666667, 20.325);
                yield return new debitcards(154, 2012.75, 22.038);
                yield return new debitcards(155, 2012.83333333333, 20.988);
                yield return new debitcards(156, 2012.91666666667, 26.675);
                yield return new debitcards(157, 2013, 19.061);
                yield return new debitcards(158, 2013.08333333333, 19.303);
                yield return new debitcards(159, 2013.16666666667, 19.323);
                yield return new debitcards(160, 2013.25, 21.573);
                yield return new debitcards(161, 2013.33333333333, 23.685);
                yield return new debitcards(162, 2013.41666666667, 22.104);
                yield return new debitcards(163, 2013.5, 25.34);
                yield return new debitcards(164, 2013.58333333333, 25.211);
            }
        }
    }
}
