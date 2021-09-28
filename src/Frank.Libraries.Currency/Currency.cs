using System;

namespace Frank.Libraries.Currency
{
    public class Currency
    {
        public bool Success { get; set; }
        public long Timestamp { get; set; }
        public DateTime Date { get; set; }
        public CurrencyCode Base { get; set; }
        public Rates Rates { get; set; }
    }
}
