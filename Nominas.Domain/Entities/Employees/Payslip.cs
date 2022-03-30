using Nominas.Domain.Base;

namespace Nominas.Domain.Entities.Employees
{
    public class Payslip : Entity<int>
    {
        public Payslip(int employeeId, DateTime date, float workingDays)
        {
            EmployeeId = employeeId;
            Date = date;
            WorkingDays = workingDays;
        }


        public PayslipResult Result;
        public DateTime Date { get; private set; }
        public float WorkingDays { get; private set; }
        public int EmployeeId { get; private set; }
        public decimal TotalSalary { get; private set; }

        public virtual Employee Employee { get; private set; }

        public void Pay(float BaseMonthSalary, List<float> Retentions)
        {
            Result = new PayslipResult(BaseMonthSalary, Retentions);
            TotalSalary = Result.TotalSalary;
        }
    }
}
