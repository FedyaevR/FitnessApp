using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.BL.Model
{
    [Serializable]
    public class Eating
    {

        public DateTime Moment { get; set; }
        /// <summary>
        /// Что и сколько ел пользователь.
        /// </summary>
        public Dictionary<Food, double> Foods { get; set; }
        public virtual User User { get; set; }
        public Eating(User user)
        {
            User = user ?? throw new ArgumentNullException("Пользователь не можеть быть null",nameof(user));
            Moment = DateTime.UtcNow;
            Foods = new Dictionary<Food, double>();
        }

        public void Add(Food food, double weight)
        {
            Food product = Foods.Keys.FirstOrDefault(f => f.Name.Equals(food.Name));
            if (product == null)
            {
                Foods.Add(food,weight);
            }
            else
            {
                Foods[product] += weight;
            }
        }

    }
}
