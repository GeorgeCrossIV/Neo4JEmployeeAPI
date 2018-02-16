using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Neo4JEmployeeAPI.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public int Emp_Id { get; set; }

        public Employee()
        {

        }

        public Employee(int id, string name)
        {
            this.Name = name;
            this.Emp_Id = id;
        }
    }
}