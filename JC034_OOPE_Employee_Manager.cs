using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step001
{
    public class JC034_OOPE_Employee_Manager:JC034_OOPE_Employee
    {
        public decimal Bonus {  get; set; }
        public override decimal CalculateSalary()
        {
            return BaseSalary+Bonus;
        }
    }
}
