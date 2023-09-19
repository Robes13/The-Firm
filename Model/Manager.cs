using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm.Model
{
    /// <summary>
    /// This class is used for managers, they have a phonenumber - whereas an employee doesnt.
    /// </summary>
    internal class Manager : Employee
    {
        #region Fields

        private protected string _phonenumber;

        #endregion Fields

        #region Constructors

        protected internal Manager(string firstName, string lastname, string cprNumber, string phoneNumber) : base (firstName, lastname, cprNumber)
        {
            _firstname = firstName;
            _lastname = lastname;
            _cprNumber = cprNumber;
            _phonenumber = phoneNumber;
        }

        #endregion Constructors

        #region Properties

        internal string PhoneNumber
        {
            get { return _phonenumber; }
            set { _phonenumber = value; }
        }

        #endregion Properties
    }
}
