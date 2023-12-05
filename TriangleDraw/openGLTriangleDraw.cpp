using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.Platform.Windows;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OpenGlControl.InitializeContexts();
            Gl.glClearColor(0f, 0f, 0.5f, 1f);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OpenGlControl_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            Gl.glBegin(Gl.GL_LINES);
                Gl.glVertex3f(0.0f, 1.0f, 1.0F);
                Gl.glVertex3f(0.0f, -1.0f, 0.0F);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_LINES);
                Gl.glVertex3f(-1.0f, -0.1f, 0.0F);
                Gl.glVertex3f(1.0f, -0.1f, 0.0F);
            Gl.glEnd();


            Gl.glBegin(Gl.GL_TRIANGLES);
                Gl.glVertex2f(0.5f, 0.1f);//A
                Gl.glVertex2f(0.8f, 0.1f);//B
                Gl.glVertex2f(0.5f, 0.3f);//C
            Gl.glEnd();

            //Otelenmis Cisim
            Gl.glBegin(Gl.GL_TRIANGLES);
                Gl.glColor3f(1.0f, 1.0f, 0.0f);
                Gl.glVertex2f(0.1f, 0.1f);//A
                Gl.glVertex2f(0.4f, 0.1f);//B
                Gl.glVertex2f(0.1f, 0.3f);//C
            Gl.glEnd();

            //P noktasi
            Gl.glPointSize(5);
            Gl.glBegin(Gl.GL_POINTS);
                Gl.glVertex2f(0.5f, 0.5f);
            Gl.glEnd();


            //Dondurmus ucgen
            Gl.glBegin(Gl.GL_TRIANGLES);
                Gl.glColor3f(1.0f, 0f, 1.0f);
                Gl.glVertex2f(0.04f, 0.824f);//A
                Gl.glVertex2f(0.091f, 0.53f);//B
                Gl.glVertex2f(0.236f, 0.858f);//C
            Gl.glEnd();




        }

        private void OpenGlControl_Load(object sender, EventArgs e)
        {

        }
    }
}
