using System;

namespace Task5
{
    public class ConsoleCountriesSearchReportWriter
    {
        public void Write(CountryDto[] foundCountries) // zapis raportu na konsolę
        {
            Console.WriteLine("Odanelziono następujące państwa:");

            foreach (var country in foundCountries)
            {
                Console.WriteLine($"- {country.Name.ToUpper()}");
                Console.WriteLine($"\t-stolica: {country.Capital}");
                Console.WriteLine($"\t\t- ludność: {country.Population / 1e6} milionów");
                Console.WriteLine($"\t\t- powierzchnia: {country.Area} km^2");
                //To prevent bug when searching 'uni' -> United States Minor Outlying Islands have empty LatLng property
                Console.WriteLine($"\t\t- szerokość geograficzna: {(country.LatLng.Length == 0 ? null : (country.LatLng[0] > 0 ? country.LatLng[0].ToString() + $"{Convert.ToChar(176)}(N)" : (country.LatLng[0] == null ? null : country.LatLng[0].ToString() + $"{Convert.ToChar(176)}(S)")))}");
                Console.WriteLine($"\t\t- długość geograficzna:  {(country.LatLng.Length == 0 ? null : (country.LatLng[1] > 0 ? country.LatLng[1].ToString() + $"{Convert.ToChar(176)}(E)" : (country.LatLng[1] == null ? null : country.LatLng[0].ToString() + $"{Convert.ToChar(176)}(W)")))}");
                Console.WriteLine(String.Format("\t\t- gęstość zaludnienia: {0:F2} os/km^2",(country.Population/country.Area)));
                Console.WriteLine($"\t\t- alpha3code: {country.Alpha3Code}");
            }
        }
    }
}
