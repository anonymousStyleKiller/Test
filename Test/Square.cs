using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Test
{


    class Square :  IShape
    {

        int side;
        Color color;

        public Square(Color color, int side) {
            this.color = color;
            this.side = side;
        }

        public override String  ToString()
        {
            return "Фигура: квадрат, площадь: " + getSpace() + " длина стороны: " + side.ToString() + " Цвет:  " + getColor().ToString() + ".";
        }

        public int getSpace()
        {
            return side * side;
        }

        public Color getColor()
        {
            return Color.Blue;
        }
         public  int[] getSide()
        {
            int[] arr = { side };
            return arr;
        }



        public void Draw() {
            new SquareDrawing(color, side, this);
      
        }

    }
}
