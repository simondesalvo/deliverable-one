using System;

namespace DeliverableOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of vacation would you like to go on: musical, tropical, or adventurous?");
            /* if else statements if console readline musical vacationType is (string) New Orleans else else etc 
             * last else error statement? */
            string vacationType = Console.ReadLine();
            if (vacationType=="musical")
            {
                vacationType ="New Orleans";
            }
            else if (vacationType=="tropical")
            {
                vacationType ="Beach Vacation in Mexico";
            }
            else if (vacationType=="adventurous")
            {
                vacationType = "Whitewater Rafting the Grand Canyon";
            }
            Console.WriteLine("How many people are in your group? (Intergers only)");
            int groupSize = int.Parse(Console.ReadLine());
            string transport = "a string";
            //if else again, remember >= and such//
            if (groupSize <= 2 && groupSize >0)
            {
                transport = "travelling first class";
            } else if (groupSize <=5 && groupSize >=3)
            {
                transport = "transported by helicopter";
            }else if (groupSize >= 6)
            {
                transport = "taking a charter flight";
            }
            string result = ("You've chosen " + vacationType + " and since there are " + groupSize +
                " of you, you'll be " + transport);
            Console.Write(result);

        }
    }
}
