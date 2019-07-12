using System;
using System.Collections.Generic;

namespace NSS
{
    class Instructor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHande { get; set; }
        public string Cohort { get; set; }
        public string Specialty { get; set; }
        public void AssignExercise(Student student, Exercise exercise)
        {
            student.Exercises.Add(exercise);
        }
    }
}