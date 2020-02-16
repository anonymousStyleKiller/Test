using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    class Circle :  IShape
    {

        int radius;
        Color color;

        public Circle(Color color, int radius)
        {
            this.radius = radius;
            this.color = color;
        }

        int getRadius() { return radius; }

        public void Draw()
        {
           new CircleDrawing(color, radius, this);
    
        }


        public int getSpace()
        {
            return ((int)(Math.PI * Math.Pow(radius, 2)));
        }

        public Color getColor()
        {
            return  Color.Green;
        }

        public override String ToString()
        {
            return "Фигура: круг, площадь: " + getSpace() + " радиус: " + radius + " цвет: " + getColor().ToString() + ".";
        }

        public int[] getSide()
        {
            throw new NotImplementedException();
        }
    }
}
