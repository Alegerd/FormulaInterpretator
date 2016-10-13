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

        private void inputBtn_Click(object sender, EventArgs e)
        {
            try
            {
                exoner.isInputCorrect(input.Text, xInput.Text, yInput.Text);
                exoner.Formula = input.Text;
                output.Text = (exoner.FindSolution(xInput.Text, yInput.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show(exoner.InputErrorDescription);
            }
        }

        private void myForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormulaPlotPanel PlotPanel = new FormulaPlotPanel();
            if (exoner.isInputCorrect(input.Text, xInput.Text, yInput.Text))
            {
                PlotPanel.FormulaLabel.Text = input.Text;
                PlotPanel.Show();
            }
            else MessageBox.Show("Некорректный Ввод");
        }
    }
}
