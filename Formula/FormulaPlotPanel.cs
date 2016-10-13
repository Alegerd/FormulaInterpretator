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
    public partial class FormulaPlotPanel : Form
    {
        Bitmap bitmap;
        Graphics g;
        Executioner exoner;
        Drawer drawer = new Drawer();

        public FormulaPlotPanel()
        {
            InitializeComponent();
            exoner = new Executioner();//создаем объект счетчика
            bitmap = new Bitmap(formulaPlotPB.Width, formulaPlotPB.Height);
            formulaPlotPB.Image = bitmap;
            g = Graphics.FromImage(bitmap);
            g.FillRectangle(Brushes.LightYellow, 0, 0, bitmap.Width, bitmap.Height);
            drawer.DrawAxes(g, bitmap);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.LightYellow);
            drawer.DrawAxes(g, bitmap);
            try {
                drawer.Draw2DformulaPlot(g, bitmap, exoner, label3.Text, label4.Text);//передаем формулу
            }
            catch(Exception)
            {
                MessageBox.Show("Некорректный Ввод");
            }
            formulaPlotPB.Refresh();
        }

        public Label XLabel
        {
            get
            {
                return label3;
            }
            set
            {
                label3 = value;
            }
        }
        public Label YLabel
        {
            get
            {
                return label4;
            }
            set
            {
                label4 = value;
            }
        }
    }
}
