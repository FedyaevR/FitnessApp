using FitnessApp.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.BL.Controller
{
    public  class UserController:ControllerBase
    {
        public List<User> Users { get;}
        public User CurrentUser { get; }
        public bool IsNewUser { get; } = false;
        private const string USER_FILE_NAME = "user.dat";
        private Random rand = new Random();
        public UserController() { }
        public UserController(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым", nameof(userName));
            }
            Users = new List<User>();
            Users = GetUsersData();
            CurrentUser = Users.SingleOrDefault(u => u.Name == userName);
            if (CurrentUser == null)
            {
                CurrentUser = new User(userName);
                Users.Add(CurrentUser);
                IsNewUser = true;
                Save();
            }
        }

        private void Save()
        {
            Save(USER_FILE_NAME, Users);
        }

        public void SetNewUserData(string genderName, DateTime birthDate, double weight = 1,double height =1)
        {
            //check
            CurrentUser.Gender = new Gender(genderName);
            CurrentUser.BirthDate = birthDate;
            CurrentUser.Weight = weight;
            CurrentUser.Height = height;
            CurrentUser.Id = rand.Next();
            Save();
        }
        private List<User> GetUsersData()
        {
            return Load<User>(USER_FILE_NAME) ?? new List<User>();
        }
    }
}
