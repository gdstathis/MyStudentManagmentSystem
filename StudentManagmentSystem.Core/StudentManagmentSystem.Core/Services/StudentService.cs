using StudentManagmentSystem.Core.Model.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagmentSystem.Core.Services
{
    public class StudentService
    {
        public Student RegisterStudent(AddStudentOptions options)
        {
            if (options == null) {
                return null;
            }
            if (string.IsNullOrEmpty(options.Firstname)) {
                return null;
            }
            if (string.IsNullOrEmpty(options.Lastname)) {
                return null;
            }
            if (string.IsNullOrEmpty(options.Email)) {
                return null;
            }
            if (string.IsNullOrEmpty(options.Phone)) {
                return null;
            }
            var newStudent = new Student()
            {
                Firstname = options.Firstname,
                Lastname = options.Lastname,
                Email = options.Email,
                Phone=options.Phone
            };

            return newStudent;
        }

    }
}
