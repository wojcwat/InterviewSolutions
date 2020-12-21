using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class ListOperations
    {
        private const int randomNumbersCount = 200;
        private const int minRandomValue = 0;
        private const int maxRandomValue = 101;
        private const int shadowNeighbourValue = 50;
        private int[] RandomNumbers;

        public int[] GenerateRandomNumbers()
        {
            Random rng = new Random();
            RandomNumbers = new int[randomNumbersCount];

            for (int i = 0; i < randomNumbersCount; ++i)
            {
                RandomNumbers[i] = rng.Next(minRandomValue, maxRandomValue);
            }

            return RandomNumbers;
        }

        public List<int> GetEveryThirdReverse(int[] numbersTab)
        {
            List<int> numbersList = new List<int>(numbersTab);

            //Reverse list
            numbersList.Reverse();
            //Get every third element
            var everyThird = numbersList.Where((val, index) => index % 3 == 0).ToList();

            return everyThird;
        }

        public List<int> GetNeighboursMeanValue(int[] numbersTab)
        {
            List<int> result = new List<int>();

            //first element
            result.Add((shadowNeighbourValue + numbersTab[0] + numbersTab[1]) / 3);

            //every element but last (and first)
            for(int i=1; i< randomNumbersCount -2;++i)
            {
                result.Add((numbersTab[i - 1] + numbersTab[i] + numbersTab[i + 1]) / 3);
            }

            //last element
            result.Add((numbersTab[randomNumbersCount - 2] + numbersTab[randomNumbersCount-1] + shadowNeighbourValue) / 3);


            //Do the same within one loop

            //for (int i = 0; i < randomNumbersCount; ++i)
            //{
            //    //For first and last elements add shadow neighbour
            //    if (i == 0)
            //        result.Add((shadowNeighbourValue + numbersTab[i] + numbersTab[i + 1]) / 3);
            //    else if (i == randomNumbersCount - 1)
            //        result.Add((numbersTab[i - 1] + numbersTab[i] + shadowNeighbourValue) / 3);

            //    //count average for remaining elements
            //    else
            //        result.Add((numbersTab[i - 1] + numbersTab[i] + numbersTab[i + 1]) / 3);
            //}

            return result;
        }

        public List<int> GetNumbersGreaterThan90 (int[] numbersTab)
        {
            List<int> result = new List<int>(numbersTab);
            //get numbers greater than 90 
            var greaterThan90 = from n in result
                                where n > 90
                                select n;

            return greaterThan90.ToList();
        }

        public int[] GetRandomNumbers()
        {
            return this.RandomNumbers;
        }

        public List<Tuple<int, int>> GetParisOfProductGreaterThan9000 (int[] numbersTab)
        {
            var pairs = new List<Tuple<int, int>>();  
            
            //tempTuple to avoid creating tuple twice in for loop
            Tuple<int, int> tempTuple;

            //TupleComparer used for comparing equality of two tuples
            TupleComparer distinctTuples = new TupleComparer();

            for (int i = 0; i<randomNumbersCount;++i)
            {
                for(int j = 0; j<randomNumbersCount; ++j)
                {
                    if ((numbersTab[i] * numbersTab[j]) > 9000)
                    {
                        tempTuple = Tuple.Create(i,j);
                        if (!pairs.Contains(tempTuple, distinctTuples))
                            pairs.Add(tempTuple);
                    }
                }
            }
            return pairs;
        }

        //TupleComparer - tuples (1,2) and (2,1) are equal
        public class TupleComparer : IEqualityComparer<Tuple<int, int>>
        {
            public bool Equals(Tuple<int, int> x, Tuple<int, int> y)
            {
                return (x.Item1 == y.Item1 && x.Item2 == y.Item2) ||
                        (x.Item1 == y.Item2 && x.Item2 == y.Item1);
            }

            public int GetHashCode(Tuple<int, int> obj)
            {
                return obj.Item1.GetHashCode() ^ obj.Item2.GetHashCode();
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            ListOperations listOperations = new ListOperations();

            //Task1
            var generatedNumbers = listOperations.GenerateRandomNumbers();

            var result1 = listOperations.GetEveryThirdReverse(generatedNumbers);
            var result2 = listOperations.GetNeighboursMeanValue(generatedNumbers);
            var result3 = listOperations.GetNumbersGreaterThan90(generatedNumbers);
            var result4 = listOperations.GetParisOfProductGreaterThan9000(generatedNumbers);

            Console.WriteLine("Generated list:\n\n(index) = value");
            //Display generated list 
            for(int i = 0; i < generatedNumbers.Length; ++i)
            {
                Console.WriteLine("({0}) = {1}", i, generatedNumbers[i]);
            }
            //Task2
            Console.WriteLine("\nEvery third element starting from the end of the list:");
            foreach(var i in result1)
            {
                Console.Write(i + " ");
            }
            //Task3
            Console.WriteLine("\n\nEvery element is a mean of current value and its neighbours:");
            foreach(var i in result2)
            {
                Console.Write(i + " ");
            }
            //Task4
            Console.WriteLine("\n\nElements greater than 90:");
            foreach(var i in result3)
            {
                Console.Write(i + " ");
            }
            //Task5
            Console.WriteLine("\n\nPairs of indexes with product greater than 9000:");
            foreach(var i in result4)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

        }
    }
}
