using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace integralafx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void ifx()
        {
            Point[] points = { new Point(10, 10), new Point(10, 100), new Point(100, 10), new Point(100, 100) };
            float integral = 0;
            for (int i = 1; i < points.Length; i++)
            {
                integral += (points[i].Y + points[i - 1].Y) * (points[i].X - points[i - 1].X) / 2;
            }
            Text = integral.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ifx();
        }
    }
}
