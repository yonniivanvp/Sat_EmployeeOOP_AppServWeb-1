using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Classes
{
    public abstract class Employee
    {
        #region Properties
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; } //Signo de interrogacion (?) significa que puede tener dato o no

        public Date? BirthDate { get; set; }

        public Date? HiringDate { get; set; }

        public bool? IsActive { get; set; }
        #endregion

        #region Methods

        public abstract decimal GetValueToPay();

        #endregion
    }
}
