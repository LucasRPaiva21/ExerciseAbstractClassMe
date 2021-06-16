﻿using ExAbstractClassMe.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExAbstractClassMe.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color)
            : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
