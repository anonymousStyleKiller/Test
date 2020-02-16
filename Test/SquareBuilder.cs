using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class SquareBuilder : IShapeBuilder
    {
		Form1 form1 = new Form1();
		public IShape BuildShape()
		{
			return new Square(
		Color.FromArgb(form1.rand.Next(256), form1.rand.Next(256), form1.rand.Next(256)),
		form1.rand.Next(50) + 5);
		}
	}
}
