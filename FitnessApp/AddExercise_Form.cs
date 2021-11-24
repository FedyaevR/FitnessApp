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
    public partial class AddExercise_Form : Form
    {
        string name;
        double energy;
        DateTime begin;
        DateTime end;
        Activity activity;
        public bool IsAdded = false;
        public AddExercise_Form()
        {
            InitializeComponent();
        }
       
        public (DateTime Begin, DateTime End, Activity Activity) GetAllData()
        {
            
            return (begin, end, activity);
        }

        private void button_Done_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_ExerciseName.Text))
            {
                throw new ArgumentNullException("Имя упражнения не может ббыть null", nameof(textBox_ExerciseName.Text));
            }
            if (dateTimePicker_EndTime.Value < dateTimePicker_StartTime.Value)
            {
                throw new ArgumentException("Время начала упражнения не можеть быть позже его окончания ", nameof(dateTimePicker_StartTime));
            }
            name = textBox_ExerciseName.Text;
            if (double.TryParse(textBox_Energy.Text, out double value))
            {
                energy = value;
                textBox_Energy.BackColor = Color.White;
                  
            }
            else
            {
                MessageBox.Show("Неверный формат energy");
                textBox_Energy.BackColor = Color.Red;
            }
          
            begin = dateTimePicker_StartTime.Value;
            end = dateTimePicker_EndTime.Value;
            activity = new Activity(name, energy);
            IsAdded = true;
        }
    }
}
