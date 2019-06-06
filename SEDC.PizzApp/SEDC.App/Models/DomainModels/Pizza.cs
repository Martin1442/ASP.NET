using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.App.Models.DomainModels
{
    public enum PizzaSize
    {
        Small,
        Medium,
        Large,
        ExtraLarge
    }

    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PizzaSize Size { get; set; }
        public double Price { get; set; }

    }
}
