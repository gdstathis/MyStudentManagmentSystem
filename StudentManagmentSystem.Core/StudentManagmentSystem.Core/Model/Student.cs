using StudentManagmentSystem.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagmentSystem.Core
{
    public class Student
    {
        public string Firstname;

        public string Lastname;

        public int Id;

        public string Phone;

        public string Email;

        public string UserName;

        public Property Property;

        public Boolean isActive;

        public int ClassYear;

        public List<Course> enrolledCourse;


    }
}
