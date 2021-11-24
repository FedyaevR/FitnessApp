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
        User tempUser;
        bool isFullUserList=false;
        
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
            isFullUserList = true;
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
            if (isFullUserList == false)
            {
                tempUser = userController.Users.SingleOrDefault(u => u.Name == userController.CurrentUser.Name);
            }
            else
            {
                tempUser = userController.Users[listBox_Users.SelectedIndex];
            }

            label_UserInfo.Text = $"Имя: {tempUser.Name}\nВозраст: {tempUser.Age}\nПол: {tempUser.Gender}\nРост: {tempUser.Height}\n" +
                    $"Вес: {tempUser.Weight}\nДата рождения: {tempUser.Age}";
            if (exerciseController.Exercises.Count > 0)
            {
                foreach (var exercise in exerciseController.Exercises)
                {
                    if (exercise.Id == tempUser.Id)
                    {
                        label_Exercise.Text = $"\t{exercise.Activity} с {exercise.Start.ToShortTimeString()} до {exercise.Finish.ToShortTimeString()}";
                    }
                    else
                    {
                        label_Exercise.Text = "";
                    }
                   
                }
            }
            if (eatingController.Foods.Count >0)
            {
                foreach (var eating in eatingController.Foods)
                {
                    if (eating.Id == tempUser.Id)
                    {
                        label_Eating.Text = $"\tName:{eating.Name}\nCallories:{eating.Callories}\nCarbohydtrates:{eating.Carbohydrates}\n " +
                            $"Fats:{eating.Fats}\nProteins:{eating.Proteins}";
                    }
                    else
                    {
                        label_Eating.Text = "";
                    }
                }
            }
        }
        private void button_ClearListUsers_Click(object sender, EventArgs e)
        {
            isFullUserList = false;
            listBox_Users.Items.Clear();
            listBox_Users.Items.Add(userController.Users.SingleOrDefault(u => u.Name == userName));
        }
        int pushCounter = 0;
        private void button_AddAction_Click(object sender, EventArgs e)
        {
           
            if (pushCounter > 0) return;
          
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
                    pushCounter++;
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
                    pushCounter++;
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

        private void comboBox_Action_SelectedIndexChanged(object sender, EventArgs e)
        {
            pushCounter = 0;
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
