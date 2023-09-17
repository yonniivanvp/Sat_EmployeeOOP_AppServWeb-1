using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Classes
{
    internal class CommissionEmployee : Employee
    {
        #region Properties

        public int CommisionPercentaje { get; set; }
        public decimal Sales { get; set; }

        #endregion

        #region Methods

        public CommissionEmployee() 
        {
        }

        public override decimal GetValueToPay()
        {
            return Sales;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Porcentaje De Comision: {CommisionPercentaje}\n\t" +
                $"Valor Venta: {Sales:C2}\n\t";
        }

        #endregion
    }
}
