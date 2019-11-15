using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class Student
    {
        //ctrl + k + C: Comment
        //ctrl + k + U: UnComment
        //ctrl + k + D: Format Code
        public int StudentID { get; set; }
        public string FullName { get; set; }
        public float Mark { get; set; }
        public string Falculty { get; set; }

        public Student()
        {

        }

        public Student(int studentID, string fullName, string mark, string falculty )
        {
            StudentID = studentID;
            FullName = fullName;
            Mark = mark;
            Falculty = falculty;
        }
    }
}
