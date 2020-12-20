using System;
using System.Threading.Tasks;

namespace Task5
{
    public class Tester5
    {
        private readonly CountriesRestApiClient _apiClient;
        private readonly ConsoleCountriesSearchReportWriter _countriesSearchReportWriter;

        public Tester5()
        {
            _apiClient = new CountriesRestApiClient();
            _countriesSearchReportWriter = new ConsoleCountriesSearchReportWriter();
        }

        public async Task Test()
        {
            try
            {
                Console.WriteLine("Szukaj państwa (nazwa po angielsku, nie trzeba wpisywać całej nazwy - można np. tylko pierwszą literę):");
                var searchText = Console.ReadLine();

                var countries = await _apiClient.GetCountries(searchText);

                _countriesSearchReportWriter.Write(countries);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
