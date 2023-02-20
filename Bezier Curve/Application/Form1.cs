using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        

        private void button1_Click(object sender, EventArgs e)
        {
            Point origin = new Point(380, 230);
            DrawAxes(origin);
        }

        public void DrawAxes(Point origin)
        {
            Point p1 = new Point(origin.X - 400, origin.Y);
            Point p2 = new Point(origin.X + 400, origin.Y);
            Point p3 = new Point(origin.X, origin.Y - 550);
            Point p4 = new Point(origin.X, origin.Y + 550);
            Graphics gg = CreateGraphics();
            Pen p = new Pen(Color.Green);
            gg.DrawLine(p, p1, p2);
            gg.DrawLine(p, p3, p4);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Point origin2 = new Point(0, 0);
            DrawControl(origin2);
        }

        public void DrawControl(Point origin2)
        {
            Pen red = new Pen(Color.Red);
            System.Drawing.SolidBrush fillRed = new System.Drawing.SolidBrush(Color.Red);

            Rectangle circle = new Rectangle(373, 222, 15, 15);//0 noktasi
            Graphics gg2 = CreateGraphics();
            gg2.DrawEllipse(red, circle);

            Rectangle circle2 = new Rectangle(480, 25, 15, 15);
            Graphics gg3 = CreateGraphics();
            gg3.DrawEllipse(red, circle2);

            Rectangle circle3 = new Rectangle(735, 150, 15, 15);
            Graphics gg4 = CreateGraphics();
            gg4.DrawEllipse(red, circle3);

            Rectangle circle4 = new Rectangle(648, 222, 15, 15);
            Graphics gg5 = CreateGraphics();
            gg5.DrawEllipse(red, circle4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics grafikCiz;
            grafikCiz = CreateGraphics();
            Pen renk = new Pen(System.Drawing.Color.Green, 2);

            PointF P0 = new PointF(380, 222);
            PointF P1 = new PointF(480, 25);
            PointF P2 = new PointF(658, 222);
            PointF P3 = new PointF(735, 150);

            PointF[] noktalar = new PointF[4];

            noktalar[0] = P0;
            noktalar[1] = P1;
            noktalar[2] = P2;
            noktalar[3] = P3;

            for (double u = 0; u < 1; u += 0.01)
            {
                float degerX = (float)(Math.Pow((1 - u), 3) * P0.X + 3 * u * Math.Pow((1 - u), 2) * P1.X + 3 * Math.Pow(u, 2) * (1 - u) * P3.X + Math.Pow(u, 3) * P2.X);
                float degerY = (float)(Math.Pow((1 - u), 3) * P0.Y + 3 * u * Math.Pow((1 - u), 2) * P1.Y + 3 * Math.Pow(u, 2) * (1 - u) * P3.Y + Math.Pow(u, 3) * P2.Y);
                grafikCiz.DrawEllipse(renk, degerX, degerY, 1, 1);
            }

          
        }
    }
}
