namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myDrawingPen = new Pen(Color.White);
            Brush myDrawingGroundBrush = new SolidBrush(Color.Brown);
            Brush myDrawingSunBrush = new SolidBrush(Color.Yellow);

            //sun
            g.FillEllipse(myDrawingSunBrush, 10, 10, 100, 100);

            //ground
            g.FillRectangle(myDrawingGroundBrush, 0, this.Height - 100, this.Width, 100);

            //person
            g.DrawLine(myDrawingPen, new PointF(400, 600), new PointF(400, 640));

            //legs
            g.DrawLine(myDrawingPen, new PointF(400, 640), new PointF(410, 668));
            g.DrawLine(myDrawingPen, new PointF(400, 640), new PointF(390, 668));

            //arms
            g.DrawLine(myDrawingPen, new PointF(400, 610), new PointF(380, 600));
            g.DrawLine(myDrawingPen, new PointF(400, 610), new PointF(420, 600));

            //head
            g.DrawEllipse(myDrawingPen, new Rectangle(393, 582, 15, 15));
        }
    }
}