using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerSync
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            Kitchen kitchen = new Kitchen();
            Potato potato = new Potato();

            // Syncronous you can't do other stuff while peeling a potato
            potato.Peel();
            // Async
            var fries = kitchen.MakeFriesAsync(potato);
            // Syncronous
            Hamburger hamburger = kitchen.AssembleBurger();
            kitchen.PlateMeal(fries.Result, hamburger);
            Console.ReadLine();
        }
    }
}
