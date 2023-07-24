//using coursework.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace coursework.Services
//{
//    internal class Employeeservice
//    {
//        public int GetAverageAgeForEmployees()
//        {
//            Employee[] employees = GetEmployees();

//            int sumAge = 0;
//            int employeeCount = employees.Length;
//            foreach (Employee employee in employees)
//            {
//                sumAge += employee.Age;
//            }

//            int result = sumAge / employeeCount;

//            return result;
//        }

//        public void SearchByPosition(string position)
//        {
//            var employees = GetEmployees();
//            foreach (var item in employees)
//            {
//                if (item.Position.Trim().ToLower().Contains(position.Trim().ToLower()))
//                {
//                    Console.WriteLine($"FullName: {item.FullName} , Age: {item.Age} , Position: {position}");
//                }
//            }

//        }
//        private Employee[] GetEmployees()
//        {
//            Employee emp1 = new()
//            {
//                Id = 1,
//                FullName = "Sharaf Tanzili",
//                Age = 26,
//                Position = "Full Stack Developer"
//            };


//            Employee emp2 = new()
//            {
//                Id = 2,
//                FullName = "Pervin Mirzeyev",
//                Age = 30,
//                Position = "Backend Developer"
//            };


//            Employee emp3 = new()
//            {
//                Id = 3,
//                FullName = "Cahangir Axundov",
//                Age = 20,
//                Position = "Jamper"
//            };

//            Employee[] employees = { emp1, emp2, emp3 };
//            return employees;
//        }
//    }

//}


