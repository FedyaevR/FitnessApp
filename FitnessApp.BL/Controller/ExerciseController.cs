using FitnessApp.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp.BL.Controller
{
    public class ExerciseController: ControllerBase
    {
        private readonly User user;

        private const string EXERCISES_FILE_NAME = "exercises.dat";
        private const string ACTIVITIES_FILE_NAME = "activites.dat";
        public List<Exercise> Exercises { get; }
        public List<Activity> Activities { get; }
        public ExerciseController(User user)
        {
            this.user = user ?? throw new ArgumentNullException("Пользователь не можеть быть null",nameof(user));
            Exercises = GetAllExercises();
            Activities = GetAllActivities();
        }

        private List<Activity> GetAllActivities()
        {
            return Load<Activity>(ACTIVITIES_FILE_NAME) ?? new List<Activity>();
        }

        private List<Exercise> GetAllExercises()
        {
            return Load<Exercise>(EXERCISES_FILE_NAME) ?? new List<Exercise>();
        }
        public void Add(Activity activity,DateTime begin, DateTime end)
        {
            var act = Activities.SingleOrDefault(a => a.Name == activity.Name);
            if (act == null)
            {
                Activities.Add(activity);
                var exercise = new Exercise(begin,end,act,user);
                Exercises.Add(exercise);
            }
            else
            {
                var exercise = new Exercise(begin, end, act, user);
                Exercises.Add(exercise);
            }
            Save();
        }
        private void Save()
        {
            Save(ACTIVITIES_FILE_NAME, Activities);
            Save(EXERCISES_FILE_NAME, Exercises);
        }
    }
}
