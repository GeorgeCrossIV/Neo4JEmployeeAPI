using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Neo4JEmployeeAPI.Models;
using Neo4j.Driver.V1;
using System.Configuration;

namespace Neo4JEmployeeAPI.Controllers
{
    public class EmployeesController : ApiController
    {
        Employee[] employees;
        string _UserName = ConfigurationManager.AppSettings["UserName"].ToString();
        string _Password = ConfigurationManager.AppSettings["Password"].ToString();
        string _Uri = ConfigurationManager.AppSettings["Uri"].ToString();

        public EmployeesController()
        {
            GetAllEmployees();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            int limit = 25; // sets the maximum number of employees to return
            int empId;
            string name;
            employees = null;   // clear any existing employees from the list

            using (var driver = GraphDatabase.Driver(_Uri, AuthTokens.Basic(_UserName, _Password)))
            using (var session = driver.Session())
            {
                var result = session.Run("MATCH (a:Employee) " +
                    "RETURN a.id as id, a.name as name " +
                    "LIMIT " + limit).ToArray();

                foreach (var record in result)
                {
                    try
                    {
                        empId = Convert.ToInt32(record["id"]);
                        name = record["name"].ToString();

                        if (employees == null)
                            employees = new Employee[] { new Employee { Emp_Id = empId, Name = name } };
                        else
                            Array.Resize(ref employees, employees.Length + 1);
                    
                        employees[employees.Length - 1] = new Employee(empId, name);
                     }
                    catch (Exception ex)
                    {

                    }
               }
            }

            return employees;
        }

        [HttpPost]
        public IHttpActionResult AddEmployee([FromUri] int id,[FromUri] string name)
        {
            using (var driver = GraphDatabase.Driver(_Uri, AuthTokens.Basic(_UserName, _Password)))
            using (var session = driver.Session())
            {
                session.Run("CREATE (a:Employee {id: {id}, name: {name}})",
                            new Dictionary<string, object> { { "id", id.ToString() }, { "name", name } });
            }
            return Ok();
        }

        public IHttpActionResult GetEmployee(int id)
        {
            var employee = employees.FirstOrDefault((e) => e.Emp_Id == id);

            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

    }
}
