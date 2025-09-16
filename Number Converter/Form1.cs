using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
             
            try
            {
                int number = int.Parse(txtNumber.Text);
                lblOutput.Text = $"You entered: {number}";
                lblOutput.ForeColor = System.Drawing.Color.Green;
            }
            catch (FormatException)
            {
                lblOutput.Text = "Error: Input is not a valid number.";
                lblOutput.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
        
    

