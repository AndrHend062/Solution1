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
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Red, 1);
            g.Clear(Color.White);
            DrawStar(pen,1,1,200);
           // g.DrawLine(pen, 10, 10, 40, 50);
          
        }
        public void DrawStar(Pen pen,float xPos,float yPos,float Size )
        {
            
            Graphics g = this.CreateGraphics();
            float x1, x2, x3, x4, x5, x6, x7, x8, x9, x10;
            float y1, y2, y3, y4, y5, y6, y7, y8, y9, y10;
            float scale = Size/133;



            x1 = 50 * scale +xPos;
            y1 = 50 * scale + yPos;
            x2 = 1 * scale + xPos;
            y2 = 50 * scale + yPos;
            x3 = 41 * scale + xPos;
            y3 = 80 * scale + yPos;
            x4 = 26 * scale + xPos;
            y4 = 127 * scale + yPos;
            y5 = 100 * scale + yPos;
            x5 = 65 * scale + xPos;

            x6 = 105 * scale + xPos;
            y6 = 127 * scale + yPos;
            x7 = 90 * scale + xPos;
            y7 = 80 * scale + yPos;
            x8 = 131 * scale + xPos;
            y8 = 51 * scale + yPos;
            x9 = 80 * scale + xPos;
            y9 = 51 * scale + yPos;
            y10 = 3 * scale + yPos;
            x10 = 65 * scale + xPos;

            g.DrawLine(pen, x1, y1, x2, y2);
            g.DrawLine(pen, x2, y2, x3, y3);
            g.DrawLine(pen, x3, y3, x4, y4);
            g.DrawLine(pen, x4, y4, x5, y5);
            g.DrawLine(pen, x5, y5, x6, y6);

            g.DrawLine(pen, x6, y6, x7, y7);
            g.DrawLine(pen, x7, y7, x8, y8);
            g.DrawLine(pen, x8, y8, x9, y9);
            g.DrawLine(pen, x9, y9, x10, y10);
            g.DrawLine(pen, x10, y10, x1, y1);
        }

    }
}
