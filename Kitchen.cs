using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerSync
{
    public class Kitchen
    {
        public async Task<Fries> MakeFriesAsync(Potato potato)
        {
            if (potato.IsPeeled)
            {
                return await FryPotatoesAsync(potato);
            }
            else
            {
                Console.WriteLine("You need to peel the fries");
                return null;
            }
        }

        public async Task<Fries> FryPotatoesAsync(Potato potato)
        {
            if (potato.IsPeeled)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Dropping the fries in the fryer");
                Console.ForegroundColor = ConsoleColor.White;
                await Task.Delay(5000);
                ColorDisplay("Fries are still cooking", ConsoleColor.Yellow);
                await Task.Delay(5000);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("DING! Fries are done");
                Console.ForegroundColor = ConsoleColor.White;
                return new Fries(potato);
            }
            else
            {
                Console.WriteLine("This potato is raw");
                return null;
            }
        }

        public Hamburger AssembleBurger()
        {
            Random rand = new Random();
            var time = rand.Next(1000, 1200);
            Console.ForegroundColor = ConsoleColor.White;
            ColorDisplay("Assembling the Hamburger", ConsoleColor.Magenta);
            ColorDisplay("Setting the bun down", ConsoleColor.DarkRed);
            Task.Delay(time).Wait();
            ColorDisplay("Placing the patty delicately", ConsoleColor.Red);
            Task.Delay(time).Wait();
            ColorDisplay("Placing the cheese slice", ConsoleColor.DarkYellow);
            Task.Delay(time).Wait();
            ColorDisplay("Grabbing some lettuce", ConsoleColor.Green);
            Task.Delay(time).Wait();
            ColorDisplay("Throwing some pickles down", ConsoleColor.Green);
            Task.Delay(time).Wait();
            ColorDisplay("Throwing up some ketchup and mustard", ConsoleColor.Red);
            Task.Delay(time).Wait();
            ColorDisplay("Placing top bun", ConsoleColor.DarkRed);

            ColorDisplay("Burger Assembled", ConsoleColor.Magenta);
            return new Hamburger();
        }
        public bool PlateMeal(Fries fries, Hamburger burger)
        {
            Console.WriteLine("You put the fries with the burger");
            return true;
        }
        public void ColorDisplay(string process, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(process);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
