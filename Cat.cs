﻿using System;
using System.Collections.Generic;
using System.Text;

namespace zoo_management_system
{
    public class Cat : Animal
    {

        public override void Speak()
        {
            Console.WriteLine("Meo meo");
        }
        public Cat() : base()
        {

        }
        public override void ViewInfo()
        {
            base.ViewInfo();
        }
        public Cat(string Name, int Age, string Description) : base(Name, Age, Description)
        {
        }
    }
}
