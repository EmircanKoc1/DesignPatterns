
namespace DesignPatterns.Singleton
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            



            var countries = await CountryProvider.Instance.GetCountries();

            Console.WriteLine(DateTime.Now.ToLongTimeString());

            foreach (var country in countries)
            {
                Console.WriteLine(country.Name);
            }


            var countries1 = await CountryProvider.Instance.GetCountries();

            Console.WriteLine(DateTime.Now.ToLongTimeString());


        }
    }
}
