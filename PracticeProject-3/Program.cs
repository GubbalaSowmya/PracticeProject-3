using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject_3
{
    internal class Program
    {

        class Teachers
        {
            public string Name
            { get; set; }

            public string Class
            { get; set; }

            public string Section
            { get; set; }

            public string Subject
            { get; set; }


        }

        internal class Students
        {
            public string StudentName { get; set; }

            public string StuClass { get; set; }

            public string StuSection
            { get; set; }



        }

        internal class Subjects
        {
            public string SubName { get; set; }
            public int SubjectCode { get; set; }
        }
        static void Main(string[] args)
        {
           Console.WriteLine("Enter Whose data want to be stored \n 1. Teacher 2.Student 3.Subject");
            int choice = Convert.ToInt32(Console.ReadLine());


            switch (choice)
            {
                case 1:

                    if (choice == 1)
                    {


                        Teachers tech = new Teachers();

                        Console.WriteLine("Enter Teacher Details :");

                        Console.WriteLine("Enter Teacher Name");
                        string teachname = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("Enter Teacher's subject");
                        string teachSub = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("Enter Teacher's Section");
                        string teachSec = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("Enter Teacher's Class");
                        string teachClass = Convert.ToString(Console.ReadLine());

                        tech.Name = teachname;
                        tech.Subject = teachSub;
                        tech.Section = teachSec;
                        tech.Class = teachClass;

                        Console.WriteLine($"Teacher Info : ");
                        Console.WriteLine(tech.Name);
                        Console.WriteLine(tech.Subject);
                        Console.WriteLine(tech.Class);
                        Console.WriteLine(tech.Section);
                    }

                    break;


                case 2:
                    if (choice == 2)
                    {

                        Students std = new Students();


                        Console.WriteLine("Enter Student Details:");

                        Console.WriteLine("Enter Student Name");
                        string stdName = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("Enter student Class");
                        string stdClass = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("Enter student Section");
                        string stdSec = Convert.ToString(Console.ReadLine());

                        std.StudentName = stdName;
                        std.StuClass = stdClass;
                        std.StuSection = stdSec;

                        Console.WriteLine($"Student Info : ");
                        Console.WriteLine(std.StudentName);
                        Console.WriteLine(std.StuClass);
                        Console.WriteLine(std.StuSection);
                    }
            

                    break;

                case 3:
                    if (choice == 3)
                    {
                        Subjects sub = new Subjects();

                        Console.WriteLine("Enter Subject Details:");

                        Console.WriteLine("Enter subject Name");
                        string subjname = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("Enter subject code");
                        int subcode = Convert.ToInt32(Console.ReadLine());

                        sub.SubName = subjname;
                        sub.SubjectCode = subcode;
                    }

                    break;
            }

            Console.ReadLine();

        }
    }
}
