using System;

namespace Frank.Libraries.Currency
{
    public class ApiCurrency
    {
        public string FREQ { get; set; }
        public string Frekvens { get; set; }
        public string BASECUR { get; set; }
        public string Basisvaluta { get; set; }
        public string QUOTECUR { get; set; }
        public string Kvoteringsvaluta { get; set; }
        public string TENOR { get; set; }
        public string Løpetid { get; set; }
        public int DECIMALS { get; set; }
        public bool CALCULATED { get; set; }
        public int UNITMULT { get; set; }
        public string Multiplikator { get; set; }
        public string COLLECTION { get; set; }
        public string Innsamlingstidspunkt { get; set; }
        public DateTime TIMEPERIOD { get; set; }
        public string OBSVALUE { get; set; }
    }
}