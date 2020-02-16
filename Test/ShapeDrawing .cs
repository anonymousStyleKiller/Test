
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    class ShapeDrawing : Form
    {
        public Color colorThis;
        public IShape shapeThis;
        //static int xLocation;
        //static int yLocation;
        public Graphics graphics;

        public ShapeDrawing(IShape shape) : base()
        {
            this.colorThis = shape.getColor();
            this.shapeThis = shape;
        }
    }

    class TriangleDrawing : ShapeDrawing
    {
        public int side1, side2, side3;

        public TriangleDrawing(Color color, int side1, int side2, int side3, IShape shape) : base(shape)
        {
            this.colorThis = color;
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            Paint();
        }

        public new void Paint()
        {

            graphics = CreateGraphics();

            Pen pen = new Pen(colorThis, 4);

            graphics.Clear(SystemColors.Control);          
            graphics.DrawLine(pen, side1, side2, side2, side3);
            graphics.DrawLine(pen, side1, side2, side1, side3);
            graphics.DrawLine(pen, side2, side3, side1, side3);

            pen.Dispose();
            graphics.Dispose();
            MessageBox.Show(shapeThis.ToString());

        }

    }

     class SquareDrawing : ShapeDrawing
    {
        internal int side;
        public SquareDrawing(Color color, int side, IShape shape) : base(shape)
        {
            this.colorThis = color;
            this.side = side;
            Paint();
        }

        public new void Paint()
        {
            graphics = CreateGraphics();
            Pen pen = new Pen(colorThis, 4);
            graphics.Clear(SystemColors.Control);
            graphics.DrawRectangle(pen, 10, 10, side, side);
            pen.Dispose();
            graphics.Dispose();
            MessageBox.Show(shapeThis.ToString());

        }
    }
     class CircleDrawing : ShapeDrawing
    {
        internal int radius;

        public CircleDrawing(Color color, int radius, IShape shape) : base(shape)
        {
            this.colorThis = color;
            this.radius = radius;
            Paint();
        }

        public new void Paint()
        {
            graphics = CreateGraphics();
            Pen pen = new Pen(colorThis, 4);

            graphics.Clear(SystemColors.Control);
            graphics.DrawEllipse(pen, 0, 175, radius, radius);
            pen.Dispose();
            graphics.Dispose();
            MessageBox.Show(shapeThis.ToString());
        }
    }

     class TrapezeDrawing : ShapeDrawing
    {
        int base1, base2, h;


        public TrapezeDrawing(Color color, int base1, int base2, int h, IShape shape) : base(shape)
        {
            this.colorThis = color;
            this.base1 = base1;
            this.base2 = base2;
            this.h = h;
            Paint();
        }

        public new void Paint()
        {
            graphics = CreateGraphics();

            Pen pen = new Pen(colorThis, 4);

            graphics.Clear(SystemColors.Control);
            graphics.DrawLine(pen, 200, 200, 300, 200);
            graphics.DrawLine(pen, 200, 200, 150, 300);
            graphics.DrawLine(pen, 300, 200, 350, 300);
            graphics.DrawLine(pen, 350, 300, 150, 300);

            pen.Dispose();
            graphics.Dispose();
            MessageBox.Show(shapeThis.ToString());


        }
    }
}



