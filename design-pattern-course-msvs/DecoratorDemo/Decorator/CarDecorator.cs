﻿using DecoratorDemo.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DecoratorDemo.Decorator
{
    public abstract class CarDecorator : ICar
    {
        private ICar car;
        public CarDecorator(ICar Car)
        {
            car = Car;
        }
        public string Make { get { return car.Make; } }

        public double GetPrice()
        {
            return car.GetPrice();
        }
        public abstract double GetDiscountedPrice();
    }
}