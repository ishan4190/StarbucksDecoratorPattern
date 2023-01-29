using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;

namespace BusinessLayer.Classes
{
    // Decorator Class
    public class MachiatoCoffee : ICoffee
    {
        private readonly ICoffee _concreteCoffee;

        public MachiatoCoffee(ICoffee concreteCoffee)
        {
            _concreteCoffee = concreteCoffee;
        }

        public string CreateCoffeeRecipe()
        {
            return _concreteCoffee.CreateCoffeeRecipe() + "-> Then add recipe for MachiatoCoffee";

        }
    }
}
