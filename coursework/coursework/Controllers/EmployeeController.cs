//using coursework.Services;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace coursework.Controllers
//{
//    internal class EmployeeController
//    {
//        private Employeeservice _employeeService;
//        public EmployeeController()
//        {
//            _employeeService = new Employeeservice();
//        }
//        public void GetAverageAgeForEmployees()
//        {

//            int averageAge = _employeeService.GetAverageAgeForEmployees();
//            Console.WriteLine(averageAge);
//        }

//        public void SearchByPosition()
//        {
//            Console.WriteLine("Add search text: ");
//            string position = Console.ReadLine();
//            _employeeService.SearchByPosition(position);
//        }
//    }
//}
