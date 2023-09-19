using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm.Model
{
    /// <summary>
    /// This class is used to continue in the program (waiting for the user to press any key)
    /// </summary>
    internal class Continue
    {
        public void Read()
        {
            Console.ReadKey();
        }
    }
}
