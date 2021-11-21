using CsvHelper.Configuration;

namespace Frank.Libraries.Currency
{
    public class CurrencyClassMap : ClassMap<ApiCurrency>
    {
        public CurrencyClassMap()
        {
            Map(m => m.FREQ)
                .Name("FREQ");
            Map(m => m.Frekvens)
                .Name("Frekvens");
            Map(m => m.BASECUR)
                .Name("BASE_CUR");
            Map(m => m.Basisvaluta)
                .Name("Basisvaluta");
            Map(m => m.QUOTECUR)
                .Name("QUOTE_CUR");
            Map(m => m.Kvoteringsvaluta)
                .Name("Kvoteringsvaluta");
            Map(m => m.TENOR)
                .Name("TENOR");
            Map(m => m.Løpetid)
                .Name("Løpetid");
            Map(m => m.DECIMALS)
                .Name("DECIMALS");
            Map(m => m.CALCULATED)
                .Name("CALCULATED");
            Map(m => m.UNITMULT)
                .Name("UNIT_MULT");
            Map(m => m.Multiplikator)
                .Name("Multiplikator");
            Map(m => m.COLLECTION)
                .Name("COLLECTION");
            Map(m => m.Innsamlingstidspunkt)
                .Name("Innsamlingstidspunkt");
            Map(m => m.TIMEPERIOD)
                .Name("TIME_PERIOD");
            Map(m => m.OBSVALUE)
                .Name("OBS_VALUE");
        }
    }
}