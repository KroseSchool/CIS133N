using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kevinRoseCalculatorForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            double result = 0;
            result = double.Parse(num1TextBox.Text) + double.Parse(num2TextBox.Text);
            calcResultsLabel.Text = result.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //when form loaded, file will load too.
            calcPictureBox.Image = Image.FromFile("calc.jpg");
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            // declare output
            double result = 0;
            try
            {
                // calc result
                result = double.Parse(num1TextBox.Text) + double.Parse(num2TextBox.Text);
                // output result
                calcResultsLabel.Text = result.ToString();
            }
            catch
            {
                // if nonalpha or invalid (i.e. 1/0=Nan, throw error on result.ToString)
                // then show error message.
                MessageBox.Show("Wrong Input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
