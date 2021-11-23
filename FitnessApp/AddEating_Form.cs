using FitnessApp.BL.Model;
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
    public partial class AddEating_Form : Form
    {
        Food food;
        double weight;
        public bool IsAdded  = false;
        public AddEating_Form()
        {
            InitializeComponent();
        }
        public (Food food, double weight) GetAllData()
        {

            return (food,weight);
        }

        private void button_Done_Click(object sender, EventArgs e)
        {
            //?
            #region
            if (string.IsNullOrWhiteSpace(textBox_Name.Text))
            {
                throw new ArgumentNullException("Имя упражнения не может ббыть null", nameof(textBox_Name.Text));
            }
            if (string.IsNullOrWhiteSpace(textBox_Callories.Text))
            {
                throw new ArgumentNullException("Поле каллорий не может ббыть null", nameof(textBox_Callories.Text));
            }
            if (string.IsNullOrWhiteSpace(textBox_Carbohydrates.Text))
            {
                throw new ArgumentNullException("Поле углеводов не может ббыть null", nameof(textBox_Carbohydrates.Text));
            }
            if (string.IsNullOrWhiteSpace(textBox_Fats.Text))
            {
                throw new ArgumentNullException("Поле жиров не может ббыть null", nameof(textBox_Fats.Text));
            }
            if (string.IsNullOrWhiteSpace(textBox_Proteins.Text))
            {
                throw new ArgumentNullException("Поле протеинов не может ббыть null", nameof(textBox_Proteins.Text));
            }
            #endregion//?//? //?

            var name = textBox_Name.Text;
            var callories = DoubleParse("callories",textBox_Callories);
            var proteins = DoubleParse("proteins", textBox_Proteins);
            var fats = DoubleParse("fats", textBox_Fats);
            var carbohydrates = DoubleParse("carbohydrates", textBox_Carbohydrates);
            weight = DoubleParse("weight", textBox_Weight);
            food = new Food(name,proteins,fats,carbohydrates,callories);
            IsAdded = true;
        }
        private double DoubleParse(string name,TextBox textBox)
        {
            if (double.TryParse(textBox.Text, out double value))
            {
               var res = value;
               textBox.BackColor = Color.White;
               return value;
            }
            else
            {
                MessageBox.Show($"Неверный формат {name}");
                textBox.BackColor = Color.Red;
                return 0;
            }
        }
    }
}
