using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class CircleBuilder : IShapeBuilder
    {
		Form1 form1 = new Form1();
		public IShape BuildShape()
		{
			return new Circle(
		Color.FromArgb(form1.rand.Next(256), form1.rand.Next(256), form1.rand.Next(256)),
		form1.rand.Next(80) + 5);
		}
	}
}
