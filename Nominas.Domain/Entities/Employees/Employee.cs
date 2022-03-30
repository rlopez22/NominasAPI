using Nominas.Domain.Base;
using Nominas.Domain.Entities.Companies;

namespace Nominas.Domain.Entities.Employees
{
    public partial class Employee : Entity
    {
        public Employee()
        {
            PaySlips = new List<Payslip>();
            Company = new Company();
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public virtual Company Company { get; private set; }
        public virtual IReadOnlyCollection<Payslip> PaySlips { get; private set; }
    }
}
