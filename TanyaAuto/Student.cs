using System;
using System.Collections.Generic;
using System.Text;

namespace TanyaAuto
{
    class Student
    {
        public string Name;
        public int Course;
        public bool Scolarship;

        public Student()
        {
            Name ="Ivan";
            Course = 1;
            Scolarship = true;
        }

        public Student (string Name, int Course, bool Scolarship)
        {
            this.Name = Name;
            this.Course = Course;
            this.Scolarship = Scolarship;
        }
    }
}
