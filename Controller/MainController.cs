using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Firm.Model;
using The_Firm.View;

namespace The_Firm.Controller
{
    /// <summary>
    /// This class runs the entire program.
    /// </summary>
    internal class MainController
    {
        public void Start()
        {
            Employee employee = new Employee("Nicklas", "Gustavsen", "011203-4923");
            Gui gui = new Gui();
            gui.PrintEmployee(employee);
            Continue read = new Continue();
            read.Read();
            Manager manager = new Manager("Robert", "Pedersen", "130401-4589", "61396678");
            gui.PrintManager(manager);
            read.Read();
            ProjectManager projectManager = new ProjectManager("Simon", "Willander", "091201-7823", "23097832", "SimonWillander@gmail.com");
            gui.PrintProjectManagers(projectManager);
            read.Read();
            Sweeper sweeper = new Sweeper("Sweep", "Duden", "130202-3612");
            gui.PrintSweeper(sweeper);
            read.Read();
        }
    }
}
