using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class TriangleBuilder : IShapeBuilder
	{
		Form1 form1 = new Form1();
		public IShape BuildShape()
		{
			int side1, side2;
			int side3;
			{
				side1 = form1.rand.Next(50) + 5;
				side2 = form1.rand.Next(50) + 5;
				side3 = (int)Math.Sqrt(side1 * side1 + side2 * side2);
			}


			return new Trapeze(
				Color.FromArgb(form1.rand.Next(256), form1.rand.Next(256), form1.rand.Next(256)),
				side1, side2, side3);
			}
	}
}
