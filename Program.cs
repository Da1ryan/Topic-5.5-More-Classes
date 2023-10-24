using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_5._5_More_Classes
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Die die1 = new Die();
            Die die2 = new Die();

            double bankMoney = 100.0;
            double bet;
            string decision;

            Console.WriteLine("Welcome to the Casino!");
            Console.WriteLine("How much would you likr to bet on the dice?");
            bet = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"You have bet {bet}$.");
            Console.WriteLine("would you like to bet on even sum, odd sum, double or not double?");
            Console.WriteLine("for even and odd sum, you will win or lose your bet.");
            Console.WriteLine("for double you will win/lose double your bet, and for not double you will win/lose half your bet");
            decision = Console.ReadLine().ToLower();

            if (decision == "double") ;
            {
                die1.RollDie();
                die2.RollDie();
            }







        }
    }
}
