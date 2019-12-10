using AdventOfCode2019.Common;

namespace AdventOfCode2019
{
    public static class Program
    {
        public static void Main(string[] input)
        {
            var solutions = new ISolution[]
            {
                new Day1(), new Day2(), new Day3()
            };
            foreach (var solution in solutions) Utility.Run(solution, input[0]);
        }
    }
}