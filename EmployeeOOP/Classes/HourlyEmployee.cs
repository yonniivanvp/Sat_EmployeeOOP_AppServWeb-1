using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Classes
{
    public class HourlyEmployee : Employee
    {
        #region Properties

        public int Hours { get; set; }
        public decimal HoursValue { get; set; }

        #endregion

        #region Methods

        public HourlyEmployee() 
        {

        }

        public override decimal GetValueToPay()
        {
            return HoursValue;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Horas Trabajadas: {Hours}\n\t" +
                $"Valor Por Horas: {HoursValue:C2}\n\t";
        }

        #endregion
    }
}
