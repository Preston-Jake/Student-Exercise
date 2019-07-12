using System;
using System.Collections.Generic;
namespace NSS
{
    class Cohort
    {
        public string Name { get; set; }

        public List<Student> Students { get; set; } = new List<Student>();

        public List<Instructor> Instructors { get; set; } = new List<Instructor>();

        public void addInstructorToCohort(Instructor instructor)
        {
            instructor.Cohort = Name;

            Instructors.Add(instructor);
        }
        public void addStudentToCohort(Student student)
        {
            student.Cohort = Name;

            Students.Add(student);
        }
    }
}