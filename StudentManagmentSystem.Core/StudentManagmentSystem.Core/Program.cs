using StudentManagmentSystem.Core.Model.Options;
using StudentManagmentSystem.Core.Services;
using System;

namespace StudentManagmentSystem.Core
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student st = new Student();
            st.UserName = "gdstathis";
            st.Phone = "6983078378";
            st.isActive = true;
            
            Console.Write(st.UserName +"\n"+ st.Phone);

        }
    }
}
