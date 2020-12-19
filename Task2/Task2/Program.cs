using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task2
{
    class Program
    {
        public struct CharacterData
        {
            public char character;
            public int ocurrences;
            public int percentage;

            public CharacterData(char symbol, int ocurrences, int percentage)
            {
                this.character = symbol;
                this.ocurrences = ocurrences;
                this.percentage = percentage;
            }

            public override string ToString()
            {
                return String.Format("{0} - {1} / {2}%", this.character, this.ocurrences, this.percentage);
            }
        }

        public static class FileOperations
        {
            public static List<char> ReadFromTextFile(string filePath)
            {
                List<char> FileContents = new List<char>();
                try
                {
                    using (var sr = new StreamReader(filePath))
                    {
                        while (sr.Peek() >= 0)
                            FileContents.Add(Convert.ToChar(sr.Read()));
                    }

                }
                catch (IOException ex)
                {
                    Console.WriteLine("Cannot read file!");
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }


                return FileContents;
            }
        }

        public static class CharacterOperations
        {
            public static List<CharacterData> GetCharacterData(List<char> characters)
            {
                List<CharacterData> CharData = new List<CharacterData>();

                var groupedCharacters = characters.GroupBy(c => c);

                foreach (var i in groupedCharacters)
                {
                    CharData.Add(new CharacterData(i.Key, i.Count(), (i.Count() * 100 / characters.Count)));
                }

                return CharData;
            }

            public static void SortAlphabetical(List<CharacterData> cData)
            {
                cData.Sort((c1, c2) => c1.character.CompareTo(c2.character));
            }

            public static void SortByPercentage(List<CharacterData> cData)
            {
                cData.Sort((c1, c2) => c2.percentage.CompareTo(c1.percentage));
            }

            public static void SortByOccurences(List<CharacterData> cData)
            {
                cData.Sort((c1, c2) => c1.ocurrences.CompareTo(c2.ocurrences));
            }

            public static void DisplayCharacterData(List<CharacterData> cData)
            {
                foreach (var i in cData)
                {
                    Console.WriteLine(i);
                }
            }

        }

        static void Main(string[] args)
        {
            string filePath;
            Console.Write("Provide file path: ");
            filePath = Console.ReadLine();
            Console.Clear();
            List<char> fileContents = FileOperations.ReadFromTextFile(filePath);
            List<CharacterData> charData = CharacterOperations.GetCharacterData(fileContents);
            CharacterOperations.DisplayCharacterData(charData);

            char pressedButton = '\0';
            while (pressedButton!= 'q')
            {
                Console.Clear();
                CharacterOperations.DisplayCharacterData(charData);
                Console.WriteLine("===============");
                Console.WriteLine("Options:");
                Console.WriteLine("q - exit");
                Console.WriteLine("a - sort alphabetically");
                Console.WriteLine("p - sort by percentage(DESC)");
                Console.WriteLine("v - sort by value(ASC)");
                pressedButton = Console.ReadKey().KeyChar;

                switch(pressedButton)
                {
                    case 'q':
                        break;
                    case 'a':
                        CharacterOperations.SortAlphabetical(charData);
                        break;
                    case 'p':
                        CharacterOperations.SortByPercentage(charData);
                        break;
                    case 'v':
                        CharacterOperations.SortByOccurences(charData);
                        break;
                    default:
                        break;

                }

            }

        }
    }
}
