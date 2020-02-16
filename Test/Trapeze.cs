using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    class Trapeze :  IShape
    {

        int base1, base2, h;
        Color color;

        public Trapeze(Color color, int base1, int base2, int h)
        {
            this.base1 = base1;
            this.base2 = base2;
            this.h = h;
            this.color = color;
        }

        public  int[] getSide()
        {
            int[] arr = { base1, base2, h };
            return arr;
        }
        public int getSpace()
        {
            return (base1 + base2) / 2 * h;
        }

        public void Draw()
        {
            new TrapezeDrawing(color, base1, base2, h, this);
        }

        public Color getColor()
        {
            return  Color.Red;
        }

        public override String ToString()
        {
            return "Фигура: трапеция, площадь: " + getSpace()  + " Цвет:  " + getColor().ToString() + ".";
        }


    }
}
