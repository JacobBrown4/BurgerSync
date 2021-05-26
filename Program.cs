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
            Console.WriteLine("Press any key to make a meal");
            Console.ReadKey();

            Kitchen kitchen = new Kitchen();
            Potato potato = new Potato();

            // Syncronous you can't do other stuff while peeling a potato
            potato.Peel();
            // Asynchronously drop the fries
            // Async so I can do other things
            // Because the fries are async, they need to be a Task<> of Fries.
            // This is essentially a result of "Hey I'm making fries" but we don't actually get the Fries object back
            var fries = kitchen.FryPotatoesAsync(potato);


            // Syncronous assemble the burger WHILE the fries are cooking
            // Adjust the timer variable to see different interactions between the async and sync methods
            Hamburger hamburger = kitchen.AssembleBurger();
            // Just an output for if the fries Task has finished
            if (!fries.IsCompleted)
            {
                Console.WriteLine("We gotta wait for the fries");
            }
            // Here we call fries.Result because without result it's just the code saying "Hey I'm making fries" but we want the result of that fry making. So we call .Result to get the usable Fries object. Since .Result needs a finished object to run this makes the Async Task run Synchronously. Meaning we can't move past .Result until we have a result either way. So here we stop until the FryPotatoesAsync method has finished running. If the fries are done before the burger is assembled, we run it no issue, otherwise we wait.
            kitchen.ServeMeal(fries.Result, hamburger);
            Console.ReadLine();

            // What's happening as a metaphor:
            // I want to make a meal, I need to peel the potatoes, fry them, and put the burger together and put the meal together.
            // I can't do other things while I peel a potato = synchronous
            // I can drop the fries into the fryer though and do other things = async
            // I can't focus on other things while assembling a burger = synchronous
            // I need both the burger and fries to be done before I can serve it, so I need the fries (.Result) and burger
        }
    }
}
