using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//This program is written by Mike Mostafavi
namespace myFirstProject
{
    public partial class myForm : Form
    {
        public myForm()
        {
            InitializeComponent();
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            //This method will display a message 
            MessageBox.Show("You clicked on Process button");
            cabinetPictureBox.Visible = true;
            
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //this method will clear textboxes and make the picture and label invisible
            nameTextBox.Text = null;
            passwordTextBox.Text = null;
            cabinetLabel.Visible = false;
            cabinetPictureBox.Visible = false;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //this method will exit the program
            MessageBox.Show("Your Program will be terminated");
            this.Close();
        }

        
        private void myForm_Load(object sender, EventArgs e)
        {

        }

        private void cabinetPictureBox_Click(object sender, EventArgs e)
        {
            //displays the description
            cabinetLabel.Visible = true;
            cabinetLabel.Text = "The best cabinet for $299.00";
        }
    }
}
