// ReSharper disable All

namespace Rdatasets.HSAUR
{
    using System.Collections.Generic;

    /// <summary>
    /// Aspirin Data
    /// </summary>

    public class aspirin
    {
        public readonly string κ;
        public readonly int dp;
        public readonly int tp;
        public readonly int da;
        public readonly int ta;

        public aspirin(string κ, int dp, int tp, int da, int ta)
        {
            this.κ = κ;
            this.dp = dp;
            this.tp = tp;
            this.da = da;
            this.ta = ta;
        }

        public static IEnumerable<aspirin> Data
        {
            get
            {
                yield return new aspirin("\\cite{HSAuR:Elwoodetal1974}", 67, 624, 49, 615);
                yield return new aspirin("\\cite{HSAuR:Coronary1976}", 64, 77, 44, 757);
                yield return new aspirin("\\cite{HSAuR:ElwoodSweetman1979}", 126, 850, 102, 832);
                yield return new aspirin("\\cite{HSAuR:Breddinetal1979}", 38, 309, 32, 317);
                yield return new aspirin("\\cite{HSAuR:Persantine1980}", 52, 406, 85, 810);
                yield return new aspirin("\\cite{HSAuR:Aspirin1980}", 219, 2257, 346, 2267);
                yield return new aspirin("\\cite{HSAuR:ISIS21988}", 1720, 8600, 1570, 8587);
            }
        }
    }
}
