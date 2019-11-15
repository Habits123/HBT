using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class Program
    {
        static Student[] studentList;
        static void Main(string[] args)
        {
            //Nhap tong so sinh vien
            int numOfStudent;
            try
            {
                numOfStudent = int.Parse(Console.ReadLine());

            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid Input Number Of Student! -{0}", ex.Message);
                return;
                Console.ReadKey();
            }
        }
        InputStudentList(numOfStudent);
        OutputStudentList();
        Console.ReadKey();
      
            //Ham xuat danh sach sinh vien
            private static void OutPutStudentList()
            {
                foreach (var student in studentList)
                {
                    Console.WriteLine("Student ID = {0}", student.StudentID);
                    Console.WriteLine("FullName = {0}", student.FullName);
                    Console.WriteLine("Mark = {0}", student.Mark);
                    Console.WriteLine("Falculty = {0}", student.Falculty);
                }
            }
        }
        //Tao danh sach sinh vien
        
        private static void InputStudentList (int numOfStudent)
        {
            //Tao mang luu danh sach sinh vien
            Student[] studentlist = new Student[numOfStudent];
            Student student;
            for ( int i = 0; i < numOfStudent; i++)
            {
                student = new Student();
                Console.Write("Student ID =  ");
                student.StudentID = int.Parse(Console.ReadLine());
                Console.Write("Full Name = ");
                student.FullName = Console.ReadLine();
                Console.Write("Mark = ");
                student.Mark = float.Parse(Console.ReadLine());
                Console.Write("Falculty = ");
                student.Falculty =Console.ReadLine();
            }
        }
    }
}
