﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class Student
    {
        string department;
        string id;
        string name;
        float cgpa;
        public Student()
        {
            name= "SHEIK NOOR MOHAMMAD NAYAN";
            id = "17-35043-2";
            cgpa = 3.35f;
            department = "SE";
        }

        public Student(string name, string id, float cgpa,string department)
        {
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
            this.department = department;
        }
        public void ShowInfo()
        {
            Console.WriteLine("ID : "+id);
            Console.WriteLine("Name : "+name);
            Console.WriteLine("Cgpa : "+cgpa);
            Console.WriteLine("Department : "+department);
        }
    }
}