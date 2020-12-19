using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class ListOperations
    {
        private const int TabSize = 10;
        private const int MinRandomValue = 0;
        private const int MaxRandomValue = 101;
        private const int ShadowNeighbourValue = 50;
        private int[] RandomNumbers;
        public ListOperations()
        {
            Random rng = new Random();
            RandomNumbers = new int[TabSize];

            for (int i = 0; i < TabSize; ++i)
            {
                RandomNumbers[i] = rng.Next(MinRandomValue, MaxRandomValue);
            }

            foreach (var i in RandomNumbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("=============");
        }

        public List<int> GetEveryThirdReverse(int[] numbersTab)
        {
            List<int> numbersList = new List<int>(numbersTab);
            numbersList.Reverse();

            //var everyFourth = list.Where((x,i) => i % 4 == 0);
            var everyThird = numbersList.Where((x, i) => i % 3 == 0).ToList();

            foreach (var i in everyThird)
            {
                Console.WriteLine(i);
            }

            return everyThird;
        }

        public List<int> GetNeighboursMeanValue(int[] numbersTab)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < TabSize; ++i)
            {
                if (i == 0)
                    result.Add((ShadowNeighbourValue + numbersTab[i] + numbersTab[i + 1]) / 3);
                else if (i == TabSize - 1)
                    result.Add((numbersTab[i - 1] + numbersTab[i] + ShadowNeighbourValue) / 3);
                else
                    result.Add((numbersTab[i - 1] + numbersTab[i] + numbersTab[i + 1]) / 3);
            }

            foreach(var i in result)
            {
                Console.WriteLine(i);
            }

            return result;
        }

        public List<int> GetNumbersGreaterThan90 (int[] numbersTab)
        {
            List<int> result = new List<int>(numbersTab);
            var greaterThan90 = from n in result
                                where n > 90
                                select n;

            foreach(var i in greaterThan90.ToList())
            {
                Console.WriteLine(i);
            }

            return greaterThan90.ToList();
        }

        public int[] GetRandomNumbers()
        {
            return this.RandomNumbers;
        }

        public List<Tuple<int, int>> GetParisOfProductGreaterThan9000 (int[] numbersTab)
        {
            //List<int> result = new List<int>(numbersTab);
            var pairs = new List<Tuple<int, int>>();
            Tuple<int, int> tempTuple;
            TupleComparer distinctTuples = new TupleComparer();

            for (int i = 0; i<TabSize;++i)
            {
                for(int j = 0; j<TabSize; ++j)
                {
                    if ((numbersTab[i] * numbersTab[j]) > 9000)
                    {
                        tempTuple = Tuple.Create(i,j);
                        if (!pairs.Contains(tempTuple, distinctTuples))
                            pairs.Add(tempTuple);
                    }
                }
            }

            foreach(var i in pairs)
            {
                Console.WriteLine(i);
            }

            return pairs;

        }

        public class TupleComparer : IEqualityComparer<Tuple<int, int>>
        {
            public bool Equals(Tuple<int, int> x, Tuple<int, int> y)
            {
                return (x.Item1 == y.Item1 && x.Item2 == y.Item2) ||
                        (x.Item1 == y.Item2 && x.Item2 == y.Item1);
            }

            public int GetHashCode(Tuple<int, int> obj)
            {
                return string.Concat(new int[] { obj.Item1, obj.Item2 }.OrderBy(x => x)).GetHashCode();
                //or
                //return (string.Compare(obj.Item1, obj.Item2) < 0 ? obj.Item1 + obj.Item2 : obj.Item2 + obj.Item1).GetHashCode(); 
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            ListOperations ListTask = new ListOperations();
            //ListTask.GetEveryThirdReverse(ListTask.GetRandomNumbers());
            //ListTask.GetNeighboursMeanValue(ListTask.GetRandomNumbers());
            //ListTask.GetNumbersGreaterThan90(ListTask.GetRandomNumbers());
            ListTask.GetParisOfProductGreaterThan9000(ListTask.GetRandomNumbers());
        }
    }
}
