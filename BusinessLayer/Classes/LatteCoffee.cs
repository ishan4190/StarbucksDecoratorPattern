using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;

namespace BusinessLayer.Classes
{
    public class LatteCoffee : ICoffee
    {
        private readonly ICoffee _concreteCoffee;

        public LatteCoffee(ICoffee concreteCoffee)
        {
            _concreteCoffee = concreteCoffee;
        }

        public string CreateCoffeeRecipe()
        {
            return _concreteCoffee.CreateCoffeeRecipe() + "-> Add steps to make it a Latte";
        }

    }
}
