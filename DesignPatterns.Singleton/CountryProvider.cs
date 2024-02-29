using DesignPatterns.Singleton.Models;

namespace DesignPatterns.Singleton
{
    public class CountryProvider
    {
        public List<Country> Coutries { get; private set; }

        public static CountryProvider instance;
        public static CountryProvider Instance => instance ??= new CountryProvider();
        private CountryProvider()
        {
            if (Coutries is null)
            {
                Task.Delay(2000).GetAwaiter().GetResult();

                Coutries = new List<Country>()
                {
                     new Country()
                     {
                         Name ="Türkiye"
                     },
                     new Country()
                     {
                         Name = "Birleşik Krallık"
                     }
                };
            }

        }
        public async Task<List<Country>> GetCountries() => Coutries;

    }
}
