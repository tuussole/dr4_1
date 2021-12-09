using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dr4
{
    public partial class Form1 : Form
    {
        private Triangle triangle;
        public Form1()
        {
            InitializeComponent();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            SetTriangle();

            this.label5.Text = triangle.Perimetr().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetTriangle();

            this.angle12.Text = triangle.Angle1and2().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetTriangle();

            this.angle23.Text = triangle.Angle2and3().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetTriangle();

            this.angle31.Text = triangle.Angle3and1().ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var equalTriangle = new EqaulTriangle
            {
                Side1 = int.Parse(textBox1.Text)
            };

            this.label4.Text = equalTriangle.Square().ToString();
        }

        private void SetTriangle()
        {
            triangle = new Triangle
            {
                Side1 = int.Parse(textBox1.Text),
                Side2 = int.Parse(textBox2.Text),
                Side3 = int.Parse(textBox3.Text),
            };
        }
    }
}
