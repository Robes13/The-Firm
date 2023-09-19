using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm.Model
{
    /// <summary>
    /// This class is used for sweepers, they contain the same as an employee.
    /// </summary>
    internal class Sweeper : Employee
    {

        #region Constructors

        protected internal Sweeper(string FirstName, string Lastname, string CprNumber) : base(FirstName, Lastname, CprNumber)
        {
            _firstname = FirstName;
            _lastname = Lastname;
            _cprNumber = CprNumber;
        }

        #endregion Constructors

    }
}
