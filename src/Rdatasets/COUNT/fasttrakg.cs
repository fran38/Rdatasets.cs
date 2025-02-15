// ReSharper disable All

namespace Rdatasets.COUNT
{
    using System.Collections.Generic;

    /// <summary>
    /// fasttrakg
    /// </summary>

    public class fasttrakg
    {
        public readonly int κ;
        public readonly int die;
        public readonly int cases;
        public readonly int anterior;
        public readonly int hcabg;
        public readonly int killip;
        public readonly int kk1;
        public readonly int kk2;
        public readonly int kk3;
        public readonly int kk4;

        public fasttrakg(int κ, int die, int cases, int anterior, int hcabg, int killip, int kk1, int kk2, int kk3, int kk4)
        {
            this.κ = κ;
            this.die = die;
            this.cases = cases;
            this.anterior = anterior;
            this.hcabg = hcabg;
            this.killip = killip;
            this.kk1 = kk1;
            this.kk2 = kk2;
            this.kk3 = kk3;
            this.kk4 = kk4;
        }

        public static IEnumerable<fasttrakg> Data
        {
            get
            {
                yield return new fasttrakg(1, 5, 19, 0, 0, 4, 0, 0, 0, 1);
                yield return new fasttrakg(2, 10, 83, 0, 0, 3, 0, 0, 1, 0);
                yield return new fasttrakg(3, 15, 412, 0, 0, 2, 0, 1, 0, 0);
                yield return new fasttrakg(4, 28, 1864, 0, 0, 1, 1, 0, 0, 0);
                yield return new fasttrakg(5, 1, 1, 0, 1, 4, 0, 0, 0, 1);
                yield return new fasttrakg(6, 0, 3, 0, 1, 3, 0, 0, 1, 0);
                yield return new fasttrakg(7, 1, 18, 0, 1, 2, 0, 1, 0, 0);
                yield return new fasttrakg(8, 2, 70, 0, 1, 1, 1, 0, 0, 0);
                yield return new fasttrakg(9, 10, 28, 1, 0, 4, 0, 0, 0, 1);
                yield return new fasttrakg(10, 9, 139, 1, 0, 3, 0, 0, 1, 0);
                yield return new fasttrakg(11, 39, 443, 1, 0, 2, 0, 1, 0, 0);
                yield return new fasttrakg(12, 50, 1374, 1, 0, 1, 1, 0, 0, 0);
                yield return new fasttrakg(13, 1, 6, 1, 1, 3, 0, 0, 1, 0);
                yield return new fasttrakg(14, 3, 16, 1, 1, 2, 0, 1, 0, 0);
                yield return new fasttrakg(15, 2, 27, 1, 1, 1, 1, 0, 0, 0);
            }
        }
    }
}
