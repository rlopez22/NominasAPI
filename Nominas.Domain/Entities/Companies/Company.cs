using Nominas.Domain.Base;
using Nominas.Domain.Entities.Employees;

namespace Nominas.Domain.Entities.Companies
{
    public partial class Company : Entity<short>
    {
        public string Name { get; internal set; }
        public string Description { get; internal set; }

        public virtual ICollection<Employee> Employees { get; internal set; }
    }
}
