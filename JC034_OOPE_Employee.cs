using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStep
{
    

    public abstract class JC034_OOPE_Employee
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public decimal BaseSalary {  get; set; }



        public abstract decimal CalculateSalary();


    }

}
