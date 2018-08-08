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
            //IEnumerable<Donation> names = Donation.Where(p => p.Make == "BMW" && p.Year == 2010);

            IEnumerable<Donation> names = Donation.Data;

            foreach (var name in names)
            {

                Console.WriteLine(name.FirstName);
            }


            //var names = from IEnumerable<Donation> FirstName in Donation.Data where Donation.FirstName ;


            //List<Donation> myList = new List<Donation>();

            ////var names = Donation.Data.ToString();

            //foreach (var name in myList){
                //Console.WriteLine(name);
            }
        }
    }

 
//S=18
//N=18
