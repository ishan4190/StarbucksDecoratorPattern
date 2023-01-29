﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;

namespace BusinessLayer.Classes
{
    public class ColdCoffee : ICoffee
    {
        public string CreateCoffeeRecipe()
        {
            return "-> Make a Basic Cold Coffee";
        }
    }
}
