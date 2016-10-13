using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formula
{
    class Drawer
    {

        public void DrawAxes(Graphics g, Bitmap bitmap)
        {
            g.DrawLine(Pens.Black, 0, bitmap.Height / 2, bitmap.Width, bitmap.Height / 2);//оси
            g.DrawLine(Pens.Black, bitmap.Width / 2, 0, bitmap.Width / 2, bitmap.Height);

            for (int i = 0; i < bitmap.Width; i += 10) //штрихи по X
            {
                g.DrawLine(Pens.Black, i, bitmap.Height / 2 - 3, i, bitmap.Height / 2 + 3);
            }

            for (int i = 0; i < bitmap.Width; i += 10) //штрихи по X
            {
                g.DrawLine(Pens.Black, i, bitmap.Height / 2 - 3, i, bitmap.Height / 2 + 3);
            }

            for (int i = 0; i < bitmap.Height; i += 10)//штрихи по Y
            {
                g.DrawLine(Pens.Black, bitmap.Width / 2 - 3, i, bitmap.Width / 2 + 3, i);
            }

        }
        public void Draw2DformulaPlot(Graphics g, Bitmap bitmap, Executioner exoner, string formulaX, string formulaY)
        {
            double y1 = 0;
            double y2 = 0;
            double x2 = 0;
            double x1 = 0;
            double prevX = 0;
            double prexY = 0;
            int num = 0;
            Point[] Points = new Point[20];

            for (double t = -5; t < 5; t += 0.5)
            {
                y1 = exoner.FindSolution(t.ToString(), formulaY);
                x1 = exoner.FindSolution(t.ToString(), formulaX);

                //if (!(double.IsNaN(prexY)) && !(double.IsNaN(y1)))
                //{
                //    g.DrawLine(Pens.Black, (float)prevX * 10 + bitmap.Width / 2, bitmap.Height / 2 - (float)prexY * 10, (float)x1 * 10 + bitmap.Width / 2, bitmap.Height / 2 - (float)y1 * 10);
                //}

                //x2 = exoner.FindSolution((t+0.1).ToString(), formulaX);
                //y2 = exoner.FindSolution((t+0.1).ToString(), formulaY);

                //if (!(double.IsNaN(y1) && double.IsNaN(y2))) { //область допустимых значений
                //    g.DrawLine(Pens.Black, (float)x1*10 + bitmap.Width / 2, bitmap.Height / 2 - (float)y1 * 10, (float)x2 * 10 + bitmap.Width / 2, bitmap.Height / 2 - (float)y2 * 10);
                //}
                //prevX = x2;
                //prexY = y2;
                y1 = bitmap.Height / 2 - (float)exoner.FindSolution(t.ToString(), formulaY)*10;
                x1 = (float)exoner.FindSolution(t.ToString(), formulaX)*10 + bitmap.Width / 2;

                if (!(double.IsNaN(y1)) && !(double.IsNaN(x1)))
                {
                    Points[num] = new Point((int)x1, (int)y1);
                    num++;
                }
            }
            g.DrawCurve(Pens.Black, Points);

        }
    }
}
