using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nominas.Domain.Entities.Employees
{
    public class PayslipResult
    {
        public PayslipResult(float BaseMonthSalary, List<float> Retentions)
        {
            if (Retentions.Sum() > 100)
                throw new Exception("The sum of all retentions can not be major of 100%.");

            TotalSalary = (decimal)(BaseMonthSalary * (100 - Retentions.Sum())) / 100;
        }

        public decimal TotalSalary { get; init; }

    }
}
