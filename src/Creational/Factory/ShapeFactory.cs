using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ShapeFactory
    {
        public Shape? getShape(int n)
        {
            if (n == 1)
                return new Square();
            else if (n == 2)
                return new Rectangle();
            else if (n == 3)
                return new Triangle();
            else
                return null;
        }
    }
}
