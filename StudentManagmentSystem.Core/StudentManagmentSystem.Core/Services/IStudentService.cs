using StudentManagmentSystem.Core.Model.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagmentSystem.Core.Services
{
    public interface IStudentService
    {
        Student RegisterStudent(AddStudentOptions options);
    }
}
