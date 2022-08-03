using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiFun.Models;

namespace WebApiFun.Services
{
    public class StudentService : IStudentService
    {
        public string AddStudent(List<Student> lst, Student student)
        {
            lst.Add(student);
            return $"{student.name} Added!";
        }

        public string Delete(List<Student> studentList, Student student)
        {
            var item = studentList[studentList.FindIndex(stu => stu.rollno == student.rollno)];
            studentList.Remove(item);
            return "Student Data Deleted";
        }

        public string Modify(List<Student> lst, Student student)
        {
            int index = lst.FindIndex(stu => stu.rollno == student.rollno);
            lst[index].name = student.name;
            lst[index].total = student.total;

            return "Student Data Modified!";
        }
    }
}
