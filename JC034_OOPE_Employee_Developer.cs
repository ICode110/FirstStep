using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step001
{
    internal class JC034_OOPE_Employee_Developer:JC034_OOPE_Employee
    {
        public decimal OvertimePay { get; set; }   
        public override decimal CalculateSalary()
        {
            return BaseSalary + OvertimePay;
        }
    }
}
