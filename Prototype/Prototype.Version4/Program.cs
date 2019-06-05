using Prototype.BasketApi;
using Prototype.BasketApi.Model;
using Prototype.Version4.Model;
using System;

namespace Prototype.Version4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Final Example");

            //Inflate match information
            Match match = new Match();
            Console.WriteLine(match.Print());

            //Clone match information - Don't instantiate again
            Console.ForegroundColor = ConsoleColor.Green;
            Match clone = match.Clone() as Match;
            Console.WriteLine(clone.Print());

            Console.ForegroundColor = ConsoleColor.Red;
            BasketEndPoint basketApi = new BasketEndPoint();

            //Get basket match information to Api
            //API returns us a object with private constructors! We can't instantiate the class!
            BasketMatch basketMatch = basketApi.Get();
            Console.WriteLine(basketMatch.Print());

            //INTERNAL Constructors
            //BasketMatch.BasketMatch()' is inaccessible due to its protection level! 
            //var newBasket = new BasketMatch();

            //The class can be cloned
            BasketMatch cloneBasketMatch = basketMatch.Clone() as BasketMatch;
            Console.WriteLine(cloneBasketMatch.Print());
        }
    }
}
