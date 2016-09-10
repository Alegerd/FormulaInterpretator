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
                //exoner.Formula = input.Text;
                //Text = (exoner.FindSolution()).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show(exoner.InputErrorDescription);
            }
        }
    }
}
