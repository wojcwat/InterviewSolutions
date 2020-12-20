﻿using System;

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
                Console.WriteLine($"\t\t- szerokość geograficzna: {country.LatLng[0]}{Convert.ToChar(176)}");
                Console.WriteLine($"\t\t- długość geograficzna:  {country.LatLng[1]}{Convert.ToChar(176)}");
                Console.WriteLine(String.Format("\t\t- gęstość zaludnienia: {0:F2} os/km^2",(country.Population/country.Area)));
                Console.WriteLine($"\t\t- alpha3code: {country.Alpha3Code}");
            }
        }
    }
}