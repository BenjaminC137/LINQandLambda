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
            //IEnumerable<Donation> names = Donation.Data;

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name.FirstName);
            //}

            //var n = ("Benjamin"[0] - ('a'));

            //var lastNameOneWay = Donation.Data.Select(x => x.LastName).ElementAt(n);
            //Console.WriteLine(lastNameOneWay);


            IEnumerable<Donation> donation = Donation.Data;
            //var data = Donation.Data;
            //Donation state = data;                                                
            //string mostGenerous = AllStatesDonations.FirstOrDefault(StateDonations(state).OrderedBy(x => x.state.StateDonation));

            //decimal stateDonation = StateDonations(state);

            //IEnumerable<Donation> illinoisDonation = Donation.Data.Where(x => x.State == "IL");
            //foreach(var ammount in illinoisDonation){
            //    Console.WriteLine(ammount.Amount + ammount.FirstName + ammount.LastName);
            //}
            //Console.WriteLine("");

            var states = donation.GroupBy(x => x.State);

            //foreach(state in )
            var mostGenerousState = states.OrderByDescending(x => x.Sum(y => y.Amount));

          //Donation.Data.FirstOrDefault(x => x.State.Sum(s => s.Amount)).OrderedByDescending(x);

            Console.WriteLine(mostGenerousState.FirstOrDefault().Key);
        }

        //private static decimal StateDonations(string state)
        //{
        //    return Donation.Data.Where(x => x.State == state).Sum(x => x.Amount);
        //}
    }
}
//S=18
//N=18
