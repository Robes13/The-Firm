using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Firm.Controller;

namespace The_Firm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainController controller = new MainController();
            controller.Start();
        }
    }
}
