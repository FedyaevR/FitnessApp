using FitnessApp.BL.Controller;
using FitnessApp.BL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessApp
{
    public partial class Form1 : Form
    {
        UserController userController;
        AddUser_Form addUser_Form;
        EatingController eatingController;
        ExerciseController exerciseController;
        AddExercise_Form tempExercise_Form;
        AddEating_Form tempEating_Form;
        
        string userName;
        public Form1(string userName)
        {
            InitializeComponent();
            
            Show();
            this.userName = userName;
            comboBox_Action.SelectedIndex = 0;
            userController = new UserController(userName);
            eatingController = new EatingController(userController.CurrentUser);
            exerciseController = new ExerciseController(userController.CurrentUser);

            if (userController.IsNewUser)
            {
                addUser_Form = new AddUser_Form(userController, this);
            }
            listBox_Users.Items.Add(userController.Users.SingleOrDefault(u => u.Name == userName));
        }   
  
        private void button_ShowAllUsers_Click(object sender, EventArgs e)
        {
            listBox_Users.Items.Clear();
            foreach (var user in userController.Users)
            {
                listBox_Users.Items.Add(user).ToString();
            }
            label_Eating.Text = "";
            label_Exercise.Text = "";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void listBox_Users_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = userController.Users[listBox_Users.SelectedIndex];
            label_UserInfo.Text = $"Имя: {item.Name}\nВозраст: {item.Age}\nПол: {item.Gender}\nРост: {item.Height}\n" +
                    $"Вес: {item.Weight}\nДата рождения: {item.Age}";
            if (exerciseController.Exercises.Count > 0)
            {
                foreach (var exercise in exerciseController.Exercises)
                {
                    label_Exercise.Text = $"\t{exercise.Activity} с {exercise.Start.ToShortTimeString()} до {exercise.Finish.ToShortTimeString()}";
                }
            }
            if (eatingController.Foods.Count >0)
            {
                foreach (var eating in eatingController.Foods)
                {
                    label_Eating.Text = $"\tName:{eating.Name}\nCallories:{eating.Callories}\nCarbohydtrates:{eating.Carbohydrates}\n " +
                        $"Fats:{eating.Fats}\nProteins:{eating.Proteins}";
                }
            }
            

        }

        private void button_ClearListUsers_Click(object sender, EventArgs e)
        {
            listBox_Users.Items.Clear();
            listBox_Users.Items.Add(userController.Users.SingleOrDefault(u => u.Name == userName));
        }

        private void button_AddAction_Click(object sender, EventArgs e)
        {
            if (comboBox_Action.SelectedIndex == 1)
            {
                if (tempExercise_Form.IsAdded == true)
                {
                    var exe = EnterExercise();
                    exerciseController.Add(exe.Activity, exe.Begin, exe.End);
                    foreach (var item in exerciseController.Exercises)
                    {
                        label_Exercise.Text = $"\t{item.Activity} с {item.Start.ToShortTimeString()} до {item.Finish.ToShortTimeString()}";
                    }
                }
            }
            else
            {
                if (tempEating_Form.IsAdded == true)
                {
                    var foods = EnterEating();
                    eatingController.Add(foods.food,foods.weight);
                    foreach (var item in eatingController.Foods)
                    {
                        label_Eating.Text = $"\tName:{item.Name}\nCallories:{item.Callories}\nCarbohydtrates:{item.Carbohydrates}\n " +
                            $"Fats:{item.Fats}\nProteins:{item.Proteins}";
                    }
                }
            }
        }
        private (DateTime Begin, DateTime End, Activity Activity) EnterExercise()
        {
                return tempExercise_Form.GetAllData();

        }
        private (Food food,double weight) EnterEating()
        {
            return tempEating_Form.GetAllData();

        }
        private void button_Add_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox_Action_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Action.SelectedIndex == 1)
            {
                tempExercise_Form = new AddExercise_Form();
                panel1.Controls.Clear();
                tempExercise_Form.TopLevel = false;
                panel1.Controls.Add(tempExercise_Form);
                tempExercise_Form.Show();
             
            }
            else
            {
                tempEating_Form = new AddEating_Form();
                panel1.Controls.Clear();
                tempEating_Form.TopLevel = false;
                panel1.Controls.Add(tempEating_Form);
                tempEating_Form.Show();
              
            }
        }
    }
}
