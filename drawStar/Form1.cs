using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drawStar
{
    public partial class drawStar : Form
    {
        public drawStar()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {

        }
        public void DrawStar(Pen pen,int xPos,int yPos,int Size )
        {
            Graphics g = this.CreateGraphics();
            int x1, x2, x3, x4, x5, x6, x7, x8, x9, x10;
            int y1, y2, y3, y4, y5, y6, y7, y8, y9, y10;
            int scale = 133;

            x1 = 50/scale;
            y1 = 50/scale;
            x2 = 1/scale;
            y2 = 50 / scale;
            x3 = 41 / scale;
            y3 = 80 / scale;
            x4 = 26 / scale;
            x4 = 127 / scale;
            y5 = 65 / scale;
            x5 = 100 / scale;

            x6 = 50 / scale;
            y6 = 50 / scale;
            x7 = 1 / scale;
            y7 = 50 / scale;
            x8 = 41 / scale;
            y8 = 80 / scale;
            x9 = 1 / scale;
            x9 = 1 / scale;
            y10 = 50 / scale;
            x10 = 1 / scale;


            g.DrawLine(pen, x1, y1, x2, y2);
       



        }

    }
}
