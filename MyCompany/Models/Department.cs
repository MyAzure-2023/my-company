using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DepName { get; set; }

        public virtual List<Employee> Employees { get; set; }
    }
}
