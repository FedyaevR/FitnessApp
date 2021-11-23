using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.BL.Model
{
    [Serializable]
    public class Exercise
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Activity Activity { get; set; }
        public User User { get; set; }
        public Exercise(DateTime start,DateTime finish, Activity activity, User user) 
        {
            #region проверка входящи параметров
            if (finish.Date < start.Date)
            {
                throw new ArgumentException("Активность не можеть закончиться до того как началась",nameof(finish));
            }
            if (user == null)
            {
                throw new ArgumentNullException("Пользователь не можеть быть равен null",nameof(user));
            }
            #endregion

            Start = start;
            Finish = finish;
            Activity = activity;
            User = user;
        }

    }
}
