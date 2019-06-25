using Adapter.Solution2.Entities;
using Adapter.Solution2.Services;
using System;
using System.Collections.Generic;

namespace Adapter.Solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("############# Adapter - Hr Analyser #############");

            var jobHunt = new JobHunt(new List<string> { "dotnet", "java", "python" });
            var analyser = new HrAnalyserService();
            var bestCandidates = analyser.GetBestCandidates(jobHunt);

            Print(bestCandidates);

        }

        private static void Print(IList<Candidate> bestCandidates)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("############# Best Candidates #############");

            foreach (var candidate in bestCandidates)
            {
                Console.WriteLine($"{ bestCandidates.IndexOf(candidate) + 1 }_ { candidate.Name } - {candidate.Technology } ");
            }
        }
    }
}
