using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.BL.Model
{
    [Serializable]
    public class Food
    {

        public int Id {get;set;}
        public string Name { get; set; }
        /// <summary>
        /// Протеина на 100г. продукта
        /// </summary>
        public double Proteins { get; set; }
        /// <summary>
        /// Жиров на 100г. продукта
        /// </summary>
        public double Fats { get; set; }
        /// <summary>
        /// Углеводов на 100г. продукта
        /// </summary>
        public double Carbohydrates { get; set; }
        /// <summary>
        /// Калорий на 100г. продукта
        /// </summary>
        public double Callories { get; set; }
        public Food(string name) : this(name, 0, 0, 0, 0) { }
        public Food(string name, double proteins, double fats,double carbohydrates,double callories) 
        {
            #region проверка входящих параметров
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Название еды не можеть быть пустым",nameof(name));
            }
            if (proteins < 0)
            {
                throw new ArgumentException("Количество протеинов не можеть быть отрицательным", nameof(proteins));
            }
            if (fats < 0)
            {
                throw new ArgumentException("Количество жиров не может быть отрицательным", nameof(fats));
            }
            if (carbohydrates <0)
            {
                throw new ArgumentException("Количество углеводов не можеть быть отрицательным", nameof(carbohydrates));
            }
            if (callories < 0)
            {
                throw new ArgumentException("Количество калорий не может быть отрицательным", nameof(callories));
            }
            #endregion

            Name = name;
            Proteins = proteins / 100.0;
            Fats = fats / 100.0;
            Carbohydrates = carbohydrates / 100.0;
            Callories = callories / 100.0;
        }
        public override string ToString()
        {
            return Name;

        }
    }
}
