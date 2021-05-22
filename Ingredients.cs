﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerSync
{
    public class Potato
    {
        public Potato()
        {
            IsPeeled = false;
        }
        public Potato(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }
        public bool IsPeeled { get; set; }

        public bool Peel()
        {
            Console.WriteLine("Started peeling potato");
            // Can't do other things
            // Synchronous
            Task.Delay(2000).Wait();
            IsPeeled = true;
            Console.WriteLine("You peel the potato");
            return true;
        }


    }

    public class Fries
    {
        public Fries(Potato potato)
        {

        }
    }

    public class Hamburger
    {

    }


}
