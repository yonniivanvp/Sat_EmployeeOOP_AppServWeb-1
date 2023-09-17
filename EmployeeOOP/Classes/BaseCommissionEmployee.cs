using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Classes
{
    internal class BaseCommissionEmployee : CommissionEmployee
    {
        #region Properties

        public decimal Base { get; set; }

        #endregion



        #region Methods

        public BaseCommissionEmployee()
        {

        }

        public override decimal GetValueToPay()
        {
            return Base;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Base Comision: {CommisionPercentaje}\n\t";
        }
        #endregion
    }
}
