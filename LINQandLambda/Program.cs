using System;
using SampleDataCore;
using System.Linq;
using System.Collections.Generic;

namespace LINQandLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Donation.Data
                .GroupBy(x => x.State)
                .OrderByDescending(x => x.Sum(y => y.Amount))
                .First()
                .Key);
        }
    }
}
