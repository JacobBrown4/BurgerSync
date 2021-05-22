﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerSync
{
    public class Kitchen
    {

        public async Task<Fries> FryPotatoesAsync(Potato potato)
        {
            if (potato.IsPeeled)
            {
                ColorDisplay("Dropping the fries in the fryer",14);
                await Task.Delay(5000);
                ColorDisplay("Fries are still cooking", 14);
                await Task.Delay(5000);
                ColorDisplay("DING! Fries are done",14);
                return new Fries(potato);
            }
            else
            {
                Console.WriteLine("This potato needs to be peeled first");
                return null;
            }
        }

        public Hamburger AssembleBurger()
        {
            Random rand = new Random();
            var time = 1500;
            Console.ForegroundColor = ConsoleColor.White;
            ColorDisplay("Assembling the Hamburger", 13);
            ColorDisplay("Setting the bun down", 4);
            Task.Delay(time).Wait();
            ColorDisplay("Placing the patty delicately", 12);
            Task.Delay(time).Wait();
            ColorDisplay("Placing the cheese slice", 6);
            Task.Delay(time).Wait();
            ColorDisplay("Grabbing some lettuce", 10);
            Task.Delay(time).Wait();
            ColorDisplay("Throwing some pickles down", 2);
            Task.Delay(time).Wait();
            ColorDisplay("Throwing up some ketchup and mustard", 12);
            Task.Delay(time).Wait();
            ColorDisplay("Placing top bun", 4);

            ColorDisplay("Burger Assembled", 13);
            return new Hamburger();
        }
        public bool ServeMeal(Fries fries, Hamburger burger)
        {
            if (fries == null)
            {
                Console.WriteLine("The fries weren't ready");
                return false;
            }
            Console.WriteLine("You put the fries with the burger. Meal is ready!");
            return true;
        }
        public void ColorDisplay(string process, int color)
        {
            //Black   0
            //DarkBlue    1
            //DarkGreen   2
            //DarkCyan    3
            //DarkRed 4
            //DarkMagenta 5
            //DarkYellow  6
            //Gray    7
            //DarkGray    8
            //Blue    9
            //Green   10
            //Cyan    11
            //Red 12
            //Magenta 13
            //Yellow  14
            //White   15
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(process);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
