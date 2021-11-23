using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessApp
{
    public partial class Authorization_Form : Form
    {
        public Authorization_Form()
        {
            InitializeComponent();
            
        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_FirstName.Text) && !string.IsNullOrWhiteSpace(textBox_Surname.Text))
            {
                var userName = textBox_FirstName.Text + " " + textBox_Surname.Text;
               new Form1(userName);
            }
            this.Visible = false;
            
        }
    }
}
