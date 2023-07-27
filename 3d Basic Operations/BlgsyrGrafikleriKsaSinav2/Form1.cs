using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlgsyrGrafikleriKsaSinav2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        System.Drawing.Graphics GrafikCiz;
        Pen klm = new Pen(Color.Blue, 2);

       double[,] Xekseni = new double[2, 4] { { 0, 0, 0, 1 }, { 2, 0, 0, 1 } };
       double[,] Yekseni = new double[2, 4] { { 0, 0, 0, 1 }, { 0, 2, 0, 1 } };
       double[,] Zekseni = new double[2, 4] { { 0, 0, 0, 1 }, { 0, 0, 2, 1 } };

        double[,] Tizometrik = new double[4, 4]
        {
            {0.707,-0.408,0,0 },
            {0,     0.816,0,0 },
            {-0.707,-0.408,0,0 },
            {0,0,0,0 }

        };
        double[,] XCisimNokta = new double[8, 4]
        {
            {0,0,0,1 },    //A
            {1,0,0,1 },    //B
            {1,0,1,1 },    //C
            {0,0,1,1 },    //D
            {0,1,0,1 },    //E
            {1,1,0,1 },    //F
            {1,1,1,1 },    //G
            {0,1,1,1 }     //H
        };
        double[,] XKenar = new double[12, 2]
        {
            {0,1 },
            {1,2 },
            {2,3 },
            {3,0 },
            {4,5 },
            {5,6 },
            {6,7 },
            {7,4 },
            {0,4 },
            {1,5 },
            {2,6 },
            {3,7 }
        };

        private void button1_Click(object sender, EventArgs e)
        {
            //X'=X*Tiz
            double[,] GeciciXekseni = new double[2, 4];
            double[,] GeciciYekseni = new double[2, 4];
            double[,] GeciciZekseni = new double[2, 4];

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    GeciciXekseni[i, j] = 0;
                    GeciciYekseni[i, j] = 0;
                    GeciciZekseni[i, j] = 0;
                    for(int k = 0; k < 4; k++)
                    {
                        GeciciXekseni[i, j] += Xekseni[i,k] * Tizometrik[k, j];
                        GeciciYekseni[i, j] += Yekseni[i, k] * Tizometrik[k, j];
                        GeciciZekseni[i, j] += Zekseni[i, k] * Tizometrik[k, j];
                    }
                }
            }
            klm.Color = Color.Black;
            klm.Width = 4;
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciXekseni[0, 0]), KenarHesaplaY(GeciciXekseni[0, 1]), KenarHesaplaX(GeciciXekseni[1, 0]), KenarHesaplaY(GeciciXekseni[1, 1]));
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciYekseni[0, 0]), KenarHesaplaY(GeciciYekseni[0, 1]), KenarHesaplaX(GeciciYekseni[1, 0]), KenarHesaplaY(GeciciYekseni[1, 1]));
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciZekseni[0, 0]), KenarHesaplaY(GeciciYekseni[0, 1]), KenarHesaplaX(GeciciZekseni[1, 0]), KenarHesaplaY(GeciciZekseni[1, 1]));

        }
        private int KenarHesaplaX(double geciciX)
        {
            return Convert.ToInt32(400 + (100 * geciciX));
        }
        private int KenarHesaplaY(double geciciY)
        {
            return Convert.ToInt32(250 + (-100 * geciciY));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GrafikCiz = this.CreateGraphics();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //X'=X*Tiz
            double[,] GeciciBKup = new double[8, 4];

            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    GeciciBKup[i, j] = 0;
                    for(int k = 0; k < 4; k++)
                    {
                        GeciciBKup[i, j] += XCisimNokta[i, k] * Tizometrik[k, j];
                    }
                }
            }
            klm.Color = Color.BurlyWood;
            klm.Width = 3;

            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[0, 0]), KenarHesaplaY(GeciciBKup[0, 1]), KenarHesaplaX(GeciciBKup[1, 0]), KenarHesaplaY(GeciciBKup[1, 1]));
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[1, 0]), KenarHesaplaY(GeciciBKup[1, 1]), KenarHesaplaX(GeciciBKup[2, 0]), KenarHesaplaY(GeciciBKup[2, 1]));
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[2, 0]), KenarHesaplaY(GeciciBKup[2, 1]), KenarHesaplaX(GeciciBKup[3, 0]), KenarHesaplaY(GeciciBKup[3, 1]));
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[3, 0]), KenarHesaplaY(GeciciBKup[3, 1]), KenarHesaplaX(GeciciBKup[0, 0]), KenarHesaplaY(GeciciBKup[0, 1]));

            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[4, 0]), KenarHesaplaY(GeciciBKup[4, 1]), KenarHesaplaX(GeciciBKup[5, 0]), KenarHesaplaY(GeciciBKup[5, 1]));
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[5, 0]), KenarHesaplaY(GeciciBKup[5, 1]), KenarHesaplaX(GeciciBKup[6, 0]), KenarHesaplaY(GeciciBKup[6, 1]));
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[6, 0]), KenarHesaplaY(GeciciBKup[6, 1]), KenarHesaplaX(GeciciBKup[7, 0]), KenarHesaplaY(GeciciBKup[7, 1]));
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[7, 0]), KenarHesaplaY(GeciciBKup[7, 1]), KenarHesaplaX(GeciciBKup[4, 0]), KenarHesaplaY(GeciciBKup[4, 1]));
           
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[0, 0]), KenarHesaplaY(GeciciBKup[0, 1]), KenarHesaplaX(GeciciBKup[4, 0]), KenarHesaplaY(GeciciBKup[4, 1]));
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[1, 0]), KenarHesaplaY(GeciciBKup[1, 1]), KenarHesaplaX(GeciciBKup[5, 0]), KenarHesaplaY(GeciciBKup[5, 1]));
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[2, 0]), KenarHesaplaY(GeciciBKup[2, 1]), KenarHesaplaX(GeciciBKup[6, 0]), KenarHesaplaY(GeciciBKup[6, 1]));
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[3, 0]), KenarHesaplaY(GeciciBKup[3, 1]), KenarHesaplaX(GeciciBKup[7, 0]), KenarHesaplaY(GeciciBKup[7, 1]));

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x, y, z;
            if (textXotele.Text == "")
            {
                x = 0;
            }
            else
            {
                x = Convert.ToDouble(textXotele.Text);
            }

            if (textYotele.Text == "")
            {
                y = 0;
            }
            else
            {
                y = Convert.ToDouble(textYotele.Text);
            }

            if (textZotele.Text == "")
            {
                z = 0;
            }
            else
            {
                z = Convert.ToDouble(textZotele.Text);
            }
            double [,]Totele = new double[4, 4]
            {
        
                { 1,0,0,0},
                {0,1,0,0},
                {0,0,1,0 },
                {x,y,z,1 }
            };
            double[,] SonucOtele = new double[8, 4];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        SonucOtele[i, j] += XCisimNokta[i, k] * Totele[k,j];
                    }
                }
            }

            //X'=X*Tiz
            double[,] GeciciBKup = new double[8, 4];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    GeciciBKup[i, j] = 0;
                    for (int k = 0; k < 4; k++)
                    {
                        GeciciBKup[i, j] +=SonucOtele[i, k] * Tizometrik[k, j];
                    }
                }
            }

            klm.Color = Color.Red;
            klm.Width = 3;

            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[0, 0]), KenarHesaplaY(GeciciBKup[0, 1]), KenarHesaplaX(GeciciBKup[1, 0]), KenarHesaplaY(GeciciBKup[1, 1]));
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[1, 0]), KenarHesaplaY(GeciciBKup[1, 1]), KenarHesaplaX(GeciciBKup[2, 0]), KenarHesaplaY(GeciciBKup[2, 1]));
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[2, 0]), KenarHesaplaY(GeciciBKup[2, 1]), KenarHesaplaX(GeciciBKup[3, 0]), KenarHesaplaY(GeciciBKup[3, 1]));
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[3, 0]), KenarHesaplaY(GeciciBKup[3, 1]), KenarHesaplaX(GeciciBKup[0, 0]), KenarHesaplaY(GeciciBKup[0, 1]));

            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[4, 0]), KenarHesaplaY(GeciciBKup[4, 1]), KenarHesaplaX(GeciciBKup[5, 0]), KenarHesaplaY(GeciciBKup[5, 1]));
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[5, 0]), KenarHesaplaY(GeciciBKup[5, 1]), KenarHesaplaX(GeciciBKup[6, 0]), KenarHesaplaY(GeciciBKup[6, 1]));
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[6, 0]), KenarHesaplaY(GeciciBKup[6, 1]), KenarHesaplaX(GeciciBKup[7, 0]), KenarHesaplaY(GeciciBKup[7, 1]));
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[7, 0]), KenarHesaplaY(GeciciBKup[7, 1]), KenarHesaplaX(GeciciBKup[4, 0]), KenarHesaplaY(GeciciBKup[4, 1]));
           
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[0, 0]), KenarHesaplaY(GeciciBKup[0, 1]), KenarHesaplaX(GeciciBKup[4, 0]), KenarHesaplaY(GeciciBKup[4, 1]));
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[1, 0]), KenarHesaplaY(GeciciBKup[1, 1]), KenarHesaplaX(GeciciBKup[5, 0]), KenarHesaplaY(GeciciBKup[5, 1]));
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[2, 0]), KenarHesaplaY(GeciciBKup[2, 1]), KenarHesaplaX(GeciciBKup[6, 0]), KenarHesaplaY(GeciciBKup[6, 1]));
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[3, 0]), KenarHesaplaY(GeciciBKup[3, 1]), KenarHesaplaX(GeciciBKup[7, 0]), KenarHesaplaY(GeciciBKup[7, 1]));
           


        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x, y, z;
            if (textXolcekle.Text == "")
            {
                x = 1;
            }
            else
            {
                x = Convert.ToDouble(textXolcekle.Text);
            }
            if (textYolcekle.Text == "")
            {
                y = 1;
            }
            else
            {
                y = Convert.ToDouble(textYolcekle.Text);
            }
            if (textZolcekle.Text == "")
            {
                z = 1;
            }
            else
            {
                z = Convert.ToDouble(textZolcekle.Text);
            }
            double[,] Tolcekle = new double[4, 4]
            {

                { x,0,0,0},
                {0,y,0,0},
                {0,0,z,0 },
                {0,0,0,1 }
            };

            double[,] SonucOlcekle = new double[8, 4];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        SonucOlcekle[i, j] += XCisimNokta[i, k] * Tolcekle[k, j];
                    }
                }
            }

            //X'=X*Tiz
            double[,] GeciciBKup = new double[8, 4];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    GeciciBKup[i, j] = 0;
                    for (int k = 0; k < 4; k++)
                    {
                        GeciciBKup[i, j] += SonucOlcekle[i, k] * Tizometrik[k, j];
                    }
                }
            }

            klm.Color = Color.Yellow;
            klm.Width = 3;
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[0, 0]), KenarHesaplaY(GeciciBKup[0, 1]), KenarHesaplaX(GeciciBKup[1, 0]), KenarHesaplaY(GeciciBKup[1, 1]));
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[1, 0]), KenarHesaplaY(GeciciBKup[1, 1]), KenarHesaplaX(GeciciBKup[2, 0]), KenarHesaplaY(GeciciBKup[2, 1]));
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[2, 0]), KenarHesaplaY(GeciciBKup[2, 1]), KenarHesaplaX(GeciciBKup[3, 0]), KenarHesaplaY(GeciciBKup[3, 1]));
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[3, 0]), KenarHesaplaY(GeciciBKup[3, 1]), KenarHesaplaX(GeciciBKup[0, 0]), KenarHesaplaY(GeciciBKup[0, 1]));

            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[4, 0]), KenarHesaplaY(GeciciBKup[4, 1]), KenarHesaplaX(GeciciBKup[5, 0]), KenarHesaplaY(GeciciBKup[5, 1]));
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[5, 0]), KenarHesaplaY(GeciciBKup[5, 1]), KenarHesaplaX(GeciciBKup[6, 0]), KenarHesaplaY(GeciciBKup[6, 1]));
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[6, 0]), KenarHesaplaY(GeciciBKup[6, 1]), KenarHesaplaX(GeciciBKup[7, 0]), KenarHesaplaY(GeciciBKup[7, 1]));
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[7, 0]), KenarHesaplaY(GeciciBKup[7, 1]), KenarHesaplaX(GeciciBKup[4, 0]), KenarHesaplaY(GeciciBKup[4, 1]));

            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[0, 0]), KenarHesaplaY(GeciciBKup[0, 1]), KenarHesaplaX(GeciciBKup[4, 0]), KenarHesaplaY(GeciciBKup[4, 1]));
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[1, 0]), KenarHesaplaY(GeciciBKup[1, 1]), KenarHesaplaX(GeciciBKup[5, 0]), KenarHesaplaY(GeciciBKup[5, 1]));
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[2, 0]), KenarHesaplaY(GeciciBKup[2, 1]), KenarHesaplaX(GeciciBKup[6, 0]), KenarHesaplaY(GeciciBKup[6, 1]));
            GrafikCiz.DrawLine(klm, KenarHesaplaX(GeciciBKup[3, 0]), KenarHesaplaY(GeciciBKup[3, 1]), KenarHesaplaX(GeciciBKup[7, 0]), KenarHesaplaY(GeciciBKup[7, 1]));



        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
