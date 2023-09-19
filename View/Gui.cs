using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Firm.Model;

namespace The_Firm.View
{
    /// <summary>
    /// This class handles everything gui related. 
    /// </summary>
    internal class Gui
    {
        /// <summary>
        /// Prints an employee
        /// </summary>
        /// <param name="employee"></param>
        public void PrintEmployee(Employee employee)
        {
            Console.WriteLine($"Firstname: {employee.Firstname}");
            Console.WriteLine($"LastName: {employee.Lastname}");
            Console.WriteLine($"Cpr Number: {employee.CprNumber}");
            Console.WriteLine();
        }
        /// <summary>
        /// Prints a manager
        /// </summary>
        /// <param name="manager"></param>
        public void PrintManager(Manager manager)
        {
            Console.WriteLine($"Firstname: {manager.Firstname}");
            Console.WriteLine($"LastName: {manager.Lastname}");
            Console.WriteLine($"Cpr Number: {manager.CprNumber}");
            Console.WriteLine($"Phone Number: {manager.PhoneNumber}");
            Console.WriteLine();
        }
        /// <summary>
        /// Prints a projectManager
        /// </summary>
        /// <param name="projectManager"></param>
        public void PrintProjectManagers(ProjectManager projectManager)
        {
            Console.WriteLine($"Firstname: {projectManager.Firstname}");
            Console.WriteLine($"LastName: {projectManager.Lastname}");
            Console.WriteLine($"Cpr Number: {projectManager.CprNumber}");
            Console.WriteLine($"Phone Number: {projectManager.PhoneNumber}");
            Console.WriteLine($"Email Address: {projectManager.EmailAddress}");
            Console.WriteLine();
        }
        /// <summary>
        /// Prints a sweeper
        /// </summary>
        /// <param name="sweeper"></param>
        public void PrintSweeper(Sweeper sweeper)
        {
            Console.WriteLine($"Firstname: {sweeper.Firstname}");
            Console.WriteLine($"LastName: {sweeper.Lastname}");
            Console.WriteLine($"Cpr Number: {sweeper.CprNumber}");
            Console.WriteLine();
        }
    }
}
