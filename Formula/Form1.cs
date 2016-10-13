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
    public partial class myForm : Form
    {
        private Executioner exoner = new Executioner();

        public myForm()
        {
            InitializeComponent();
        }

        private void myForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormulaPlotPanel PlotPanel = new FormulaPlotPanel();
            if (exoner.isInputCorrect(xInput.Text) && exoner.isInputCorrect(yInput.Text))
            {
                PlotPanel.XLabel.Text = xInput.Text;
                PlotPanel.YLabel.Text = yInput.Text;
                PlotPanel.Show();
            }
            else MessageBox.Show("Некорректный Ввод");
        }
    }
}
