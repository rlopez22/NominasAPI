using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nominas.Domain.Entities.Companies
{
    public partial class Company
    {
        public Company()
        {
            Employee = new HashSet<Employee>();
        }

        public Company(string name, string description) : this()
        {
            this.Update(name, description);
        }

        public void Update(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
