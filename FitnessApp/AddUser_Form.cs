using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessApp.BL.Model;
using FitnessApp.BL.Controller;

using System.Windows.Forms;

namespace FitnessApp
{
    public partial class AddUser_Form : Form
    {
        UserController userController;
        Form1 form1;
        bool isDataFill = false;
        public AddUser_Form(UserController userController, Form1 form1)
        {
            InitializeComponent();
            Show();
            comboBox_UserGender.SelectedIndex = 0;
            this.userController = userController;
            this.form1 = form1;
            this.form1.Visible = false;
        }

        private void button_AddUser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_UserHeight.Text) &&
                 !string.IsNullOrWhiteSpace(textBox_UserWeight.Text) &&
                 dateTimePicker_BirthDate.Value != DateTime.Now)
            {
                int.TryParse(textBox_UserWeight.Text, out int weightRes);
                int.TryParse(textBox_UserHeight.Text, out int heightRes);
                var gender =comboBox_UserGender.SelectedItem.ToString();
                userController.SetNewUserData(gender, dateTimePicker_BirthDate.Value, weightRes, heightRes);
                isDataFill = true;
                this.Close();
                form1.Visible = true;
            }
          
        }

        private void AddUser_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isDataFill == false)
            {
                Application.Exit();
            }
        }
    }
}
