using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {


        internal static int maxAmountOfShapes = 5;
        public   Random rand = new Random();


        public Form1()
        {
            InitializeComponent();
            base.Text = "Test";
            label1.Text = "The maximum amount of figures: 4;";
            button1.Text = "Start";
            Font = new Font("Times new Roman", 14);    
        }

        private void button1_Click(object sender, EventArgs e)
        {


            IShape[] array = new IShape[(rand.Next(maxAmountOfShapes - 1) + 1)];

            Dictionary<int, IShapeBuilder> fig = new Dictionary<int, IShapeBuilder>
            {
                [1] = new CircleBuilder(),
                [2] = new SquareBuilder(),
                [3] = new TrapezeBuilder(),
                [4] = new TriangleBuilder()
            };

            

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = fig[rand.Next(fig.Count) + 1].BuildShape();
            }

            foreach (IShape i in array)
            {        
                i.Draw();
            }


        }

    }




    }





