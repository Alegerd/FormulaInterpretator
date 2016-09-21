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
        public void Draw2DformulaPlot(Graphics g, Bitmap bitmap, Executioner exoner, string formula)
        {
            double y1 = 0;
            double y2= 0;
            float x2 = 0;
            double prevX = 0;
            double prexY = 0;

            exoner.Formula = formula;
            for (double x = -100; x < 100; x+=0.2)
            {
                y1 = exoner.FindSolution(x.ToString(), "");

                if(x != -100)
                {
                    g.DrawLine(Pens.Black, (float)prevX * 10 + bitmap.Width / 2, bitmap.Height / 2 - (float)prexY * 10, (float)x * 10 + bitmap.Width / 2, bitmap.Height / 2 - (float)y1 * 10);
                }

                x2 = (float)(x + 0.1);
                y2 = exoner.FindSolution((x+0.1).ToString(), "");
                //g.FillEllipse(Brushes.Black, (float)x + bitmap.Width/2,  bitmap.Height / 2 - (float)y, 2,2);
                if (!(double.IsNaN(y1) && double.IsNaN(y1))) { //область допустимых значений
                    g.DrawLine(Pens.Black, (float)x*10 + bitmap.Width / 2, bitmap.Height / 2 - (float)y1 * 10, x2 * 10 + bitmap.Width / 2, bitmap.Height / 2 - (float)y2 * 10);
                }
                prevX = x2;
                prexY = y2;

            }
        }
    }
}
