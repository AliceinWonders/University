using System;
using University.Data;
using University.Data.Models;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new UniversityContext())
            {
                var student = new Student();
                student.Name = "Alice";
                student.PhoneNumber = "1234567890";
                student.RegisteredOn = DateTime.Now;

                context.Students.Add(student);

                context.Courses.Add(new Course
                {
                    Name = "EF CORE",
                    Price = 0,
                    Description = "Курс о разработке приложений работающих с БД",
                    StartDate = DateTime.Today,
                    EndDate = DateTime.Today.AddDays(30)
                });

                context.SaveChanges();
            }
        }
        }
    }
