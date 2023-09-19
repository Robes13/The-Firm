using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm.Model
{
    /// <summary>
    /// This class is used for projectmanagers, they also have an emailaddress.
    /// </summary>
    internal class ProjectManager : Manager
    {
        #region Fields

        private protected string _emailAddress;

        #endregion Fields

        #region Constructors

        protected internal ProjectManager(string firstName, string lastname, string cprNumber, string phoneNumber, string emailAddress) : base (firstName, lastname, cprNumber, phoneNumber)
        {
            _firstname = firstName;
            _lastname = lastname;
            _cprNumber = cprNumber;
            _phonenumber = phoneNumber;
            _emailAddress = emailAddress;
        }

        #endregion Constructors

        #region Properties

        internal string EmailAddress
        {
            get { return _emailAddress; }
            set { _emailAddress = value; }
        }

        #endregion Properties
    }
}