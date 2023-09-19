using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm.Model
{
    /// <summary>
    /// This is an employee, they are made up of a firstname, lastname and a cpr number. This class is the super classs all the other classes inherit from.
    /// </summary>
    internal class Employee
    {
        #region Fields

        private protected string _firstname;
        private protected string _lastname;
        private protected string _cprNumber;

        #endregion Fields

        #region Constructors

        protected internal Employee(string FirstName, string Lastname, string CprNumber) 
        {
            _firstname = FirstName;
            _lastname = Lastname;
            _cprNumber = CprNumber;
        }

        #endregion Constructors

        #region Properties

        internal string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        internal string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        internal string CprNumber
        {
            get { return _cprNumber; }
            set { _cprNumber = value; }
        }

        #endregion Properties
    }
}
