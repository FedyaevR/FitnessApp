using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.BL.Model
{
    [Serializable]
    public class User
    {
        public string Name { get; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        
        public int Age { get { return DateTime.Now.Year - BirthDate.Year; } }

        public User(string name,
            Gender gender,
            DateTime birthDate,
            double weight, double height)
        {
            #region проверка входящих параметров
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя польззователя не может быть пустым", nameof(name));
            }
            if (gender == null)
            {
                throw new ArgumentNullException("Пол не может быть равне null", nameof(gender));
            }
            if (birthDate < DateTime.Parse("01-01-1990") ||  birthDate > DateTime.Now)
            {
                throw new ArgumentException("Невозможна дата рождения",nameof(birthDate));
            }
            if (weight <= 0)
            {
                throw new ArgumentException("Вес не может быть меньше или равен нулю",nameof(weight));
            }
            if (height <= 0)
            {
                throw new ArgumentException("Рост не может быть равен или меньшу нуля",nameof(height));
            }
            #endregion
            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }
        public User(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя не может быть пустым",nameof(name));
            }
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
