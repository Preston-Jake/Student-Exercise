using System;

namespace NSS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cohorts
            var c32 = new Cohort()
            {
                Name = "Day Cohort 32"
            };

            var c33 = new Cohort()
            {
                Name = "Day Cohort 33"
            };
            var c34 = new Cohort()
            {
                Name = "Day Cohort 34"
            };
            var c35 = new Cohort()
            {
                Name = "Day Cohort 35"
            };
            // Intructors
            var adam = new Instructor()
            {
                FirstName = "Adam",
                LastName = "Savage",
                SlackHande = "Spicey-Panda",
                Specialty = "Being An Awesome Explainer of Things"
            };

            var jesie = new Instructor()
            {
                FirstName = "Jesie",
                LastName = "David",
                SlackHande = "Panda",
                Specialty = "I speak my mind"
            };

            var john = new Instructor()
            {
                FirstName = "John",
                LastName = "Ward",
                SlackHande = "JohnWard",
                Specialty = "Being a BOSS"
            };


            c32.addInstructorToCohort(adam);
            c32.addInstructorToCohort(jesie);
            c32.addInstructorToCohort(john);

            //Students

            var jake = new Student()
            {
                FirstName = "Jake",
                LastName = "Preston",
                SlackHandle = "Jsmooth"
            };
            var dan = new Student()
            {
                FirstName = "Dance",
                LastName = "Storm",
                SlackHandle = "DanceStorm"
            };
            var jr = new Student()
            {
                FirstName = "J",
                LastName = "R",
                SlackHandle = "iParty"
            };

            c32.addStudentToCohort(jake);
            c32.addStudentToCohort(dan);
            c32.addStudentToCohort(jr);

            //exercises 

            var CsExercise = new Exercise()
            {
                Name = "C# Exercise",
                Language = "C#"
            };

            var JavaScriptExercise = new Exercise()
            {
                Name = "JS Exercise",
                Language = "JavaScript"
            };

            // instructor adding exercise to student

            adam.AssignExercise(jake, CsExercise);
            adam.AssignExercise(jake, JavaScriptExercise);

            foreach (var exercise in jake.Exercises)
            {
                Console.WriteLine(exercise.Name);
            }

        }
    }
}
