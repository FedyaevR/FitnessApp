using FitnessApp.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.BL.Controller
{
    public class EatingController:ControllerBase
    {
        private readonly User user;
        public List<Food> Foods { get; }
        public Eating Eating { get; }
        private const string EATING_FILE_NAME = "eating.dat";
        private const string FOODS_FILE_NAME = "foods.dat";
        public EatingController( User user)
        {
            this.user = user ?? throw new ArgumentNullException("Пользователь не можеть null",nameof(user));
            Foods = GetAllFoods();
            Eating = GetEating();
        }

        public void Add(Food food,double weight)
        {
            var product = Foods.SingleOrDefault(f => f.Name == food.Name);
            if (product == null)
            {
                food.Id = user.Id;
                Foods.Add(food);
                Eating.Id = user.Id;
                Eating.Add(food,weight);
                Save();
            }
            else
            {
                Eating.Add(food,weight);
            }
        }
        private Eating GetEating()
        {
            return Load<Eating>(EATING_FILE_NAME).FirstOrDefault() ?? new Eating(user);
        }

        private List<Food> GetAllFoods()
        {
            return Load<Food>(FOODS_FILE_NAME) ?? new List<Food>();
        }
        private void Save()
        {
            Save(FOODS_FILE_NAME,Foods);
            Save(EATING_FILE_NAME, new List<Eating>() { Eating });
        }
    }
}
