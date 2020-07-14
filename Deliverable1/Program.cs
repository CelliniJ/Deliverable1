using System;
using System.Text.RegularExpressions;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What kind of trip would you like to go on? Musical, tropical, or adventurous?:");

            string vacationType;
            vacationType = (Console.ReadLine());
            string Destination;
            Destination = (Console.ReadLine());

            if (vacationType == "musical")
            {
                Destination = "New Orleans";
            }
            else if (vacationType == "tropical")
            {
                Destination = "a beach vacation in Mexico";
            }
            else if (vacationType == "adventurous") { Destination = "white water rafting in the Grand Canyon"; }

            Console.Write("How many are in your group?:");

            int GroupSize = int.Parse(Console.ReadLine());
            string TravelSuggestion = (Console.ReadLine());

            if (GroupSize <= 2)
            {
                TravelSuggestion = "first class";
            }
            else if ((GroupSize >= 3) && (GroupSize <= 5))
            {
                TravelSuggestion = "helicopter";
            }
            else if (GroupSize >= 6) { TravelSuggestion = "charter flight"; }

            string result = ("Since you're a group of " + GroupSize + " going on a " + vacationType +
            " trip, you should travel by " + TravelSuggestion + " to " + Destination + ".");

            Console.WriteLine(result);
        }
    }
}
