using System;

namespace DesignPatterns
{
    public class Pizza
    {
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public string[] Topping { get; set; }

        public override string ToString()
        {
            return $"Pizza with {Dough} dough, {Sauce} sauce and {String.Join(", ", Topping)} topping. Mmm.";
        }
    }
}