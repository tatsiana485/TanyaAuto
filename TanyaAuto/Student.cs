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

        public Student (string name, int course, bool scolarship)
        {
            this.Name = name;
            this.Course = course;
            this.Scolarship = scolarship;
        }

        public Student (string name, int course)
        {
            this.Name = name;
            this.Course = course;
        }

        public Student (string name)
        {
            this.Name = name;
        }
    }
}
