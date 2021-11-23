using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.BL.Model
{
    [Serializable]
    public class Activity
    {
        public string Name { get; set; }
        public double CalloriesPerMinute { get; set; }
        //public virtual ICollection<Exercise> Exersices { get; set; }
        public Activity(string name, double calloriesPerMinute)
        {
            #region проверка входящих параметров
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя не можеть быть пустым",nameof(name));
            }
            if (calloriesPerMinute<0)
            {
                throw new ArgumentException("Количество сожженых калорий в минуту не можеть быть меньше нуля", nameof(calloriesPerMinute));
            }
            #endregion
            Name = name;
            CalloriesPerMinute = calloriesPerMinute;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
