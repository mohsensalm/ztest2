using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public abstract class Shape
    {
        public abstract string GetShape();
    }

    public class Triangle : Shape
    {
        public override string GetShape()
        {
            return "Triangle";
        }
    }

    public class Circle : Triangle
    {
        public override string GetShape()
        {
            return "Circle";
        }
    }
}
