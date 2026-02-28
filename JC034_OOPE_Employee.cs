using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step001
{
    

    public abstract class JC034_OOPE_Employee
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public decimal BaseSalary {  get; set; }



        public abstract decimal CalculateSalary();


    }

}
