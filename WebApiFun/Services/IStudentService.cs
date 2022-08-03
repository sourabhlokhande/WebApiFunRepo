using System.Collections.Generic;
using WebApiFun.Models;

namespace WebApiFun.Services
{
    public interface IStudentService
    {
        string AddStudent(List<Student> lst, Student student);
        string Modify(List<Student> studentList, Student student);
        string Delete(List<Student> studentList, Student student);
    }
}