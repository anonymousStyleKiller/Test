using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class TrapezeBuilder : IShapeBuilder
    {
		Form1 form1 = new Form1();
		public IShape BuildShape()
		{
			int base1 = form1.rand.Next(50) + 5;
			int base2 = form1.rand.Next(50) + 5;
			int h = form1.rand.Next(50) + 5;
			return new Trapeze(
		Color.FromArgb(form1.rand.Next(256), form1.rand.Next(256), form1.rand.Next(256)),
		base1, base2, h);
		}
	}
}
