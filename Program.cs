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
           
            die1.RollDie();
            die2.RollDie();

            Console.WriteLine("Welcome to the Casino!");
            Console.WriteLine("How much would you like to bet on the dice?");
            bet = Convert.ToDouble(Console.ReadLine());
            if (bet < 0 )
            {
                bet = 0.00;
                Console.WriteLine("You have attempted to enter a negative bet, Youre bet for this round will be 0.");
            }
            else if (bet > bankMoney)
            {
                bet = bankMoney;
                Console.WriteLine("You have attempted to bet more than you have so we have adjusted your bet to all that you have.");
            }
            Console.WriteLine();
            Console.WriteLine($"You have bet {bet}$.");
            Console.WriteLine("would you like to bet on an even sum, odd sum, double or not double?");
            Console.WriteLine("for even and odd sum, you will win or lose your bet.");
            Console.WriteLine("for double you will win/lose double your bet, and for not double you will win/lose half your bet");
            decision = Console.ReadLine().ToLower();
            switch (decision)
            {
                default:
                    Console.WriteLine("");
                    Console.WriteLine("");
                    break;

                case "double":
                    if (die1 == die2)
                    {
                        Console.WriteLine($"Congrats you won, you will now receive double you bet {(bet * 2) + bankMoney}");
                        Console.WriteLine($"Your new balance is {bankMoney}");
                    }
                    else
                    {
                        Console.WriteLine($"Unfortunate you lost double your bet {(bet * 2) - bankMoney}");
                        Console.WriteLine($"Your new balance is {bankMoney}");
                    }
                    break;

                case "not double":
                    if (die1 != die2)
                    {
                        Console.WriteLine($"Congrats you won, since you picked not double you won half you bet {(bet / 2)+ bankMoney}");
                        Console.WriteLine($"Your new balance is {bankMoney}");
                    }
                    else
                    {
                        Console.WriteLine($"Unfortunate you lost, since you picked not double you loss half you bet {(bet / 2) - bankMoney}");
                        Console.WriteLine($"Your new balance is {bankMoney}");
                    }
                    break;

                case "not":
                    if (die1 != die2)
                    {
                        Console.WriteLine($"Congrats you won, since you picked not double you won half you bet {(bet / 2) + bankMoney}");
                        Console.WriteLine($"Your new balance is {bankMoney}");
                    }
                    else
                    {
                        Console.WriteLine($"Unfortunate you lost, since you picked not double you loss half you bet {(bet / 2) - bankMoney}");
                        Console.WriteLine($"Your new balance is {bankMoney}");
                    }
                    break;

                case "even sum":
                    if (die1 + die2 = 2)
                    {

                    }
                    break;

                case "even":
                    if (die1 == die2)
                    {

                    }
                    break;

                case "odd sum":
                    if (die1 == die2)
                    {

                    }
                    break;

                case "odd":
                    if (die1 == die2)
                    {

                    }
                    break;


            }



           

        }
    }
}
