using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    class Triangle : IShape
    {

        int side1, side2;
        int side3;
        Color color;
        Triangle triangle;
        public Triangle(Color color, int side1, int side2, int side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            this.color = color;
        }

        public  int[] getSide()
        {
            int[] arr = { side1, side2, side3 };
            return arr;
        }

        double getHypotenuse()
        {
            double hypotenuse = 0;
            double i = Convert.ToDouble(triangle.getSide());
                if (hypotenuse < i) hypotenuse = i;
            return hypotenuse;
        }


        public void Draw()
        {
             new TriangleDrawing(color, side1, side2, side3, this);
        }

        public Color getColor()
        {
            return  Color.Yellow;
        }
        public int getSpace()
        {
            int p = (int)(side1 + side2 + side3) / 2;
            int s = (int)Math.Sqrt((p * (p - side1) * (p - side2) * (p - side3)));
            return s;

        }

        public override String ToString()
        {
            return "Фигура: треугольник, площадь: " + getSpace() + ", гипотенуза: " + getHypotenuse() + " åä., öâåò (R, G, B) : " + getColor().ToString();
        }
    }
}
