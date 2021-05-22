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
            var fries = kitchen.FryPotatoesAsync(potato);
            // Syncronous
            Hamburger hamburger = kitchen.AssembleBurger();
            if (!fries.IsCompleted)
            {
                Console.WriteLine("We gotta wait for the fries");
            }
            kitchen.ServeMeal(fries.Result, hamburger);
            Console.ReadLine();
        }
    }
}
