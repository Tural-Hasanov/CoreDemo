using BlogApiDemo.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApiDemo.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult EmployeeList()
        {
            using var c = new Context();
            var values = c.Employees.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult EmployeeAdd(Employee a)
        {
            using var c = new Context();
            c.Add(a);
            c.SaveChanges();
            return Ok();
        }
        [HttpDelete]
        public IActionResult EmployeeDelete(int id)
        {
            using var c = new Context();
            //var values = c.Set<Employee>().FirstOrDefault(x => x.ID == id);
            //c.Set<Employee>().Remove(values);
            var values = c.Employees.Find(id);
            c.Remove(values);
            c.SaveChanges();
            return Ok();
        }
        [HttpPut]
        public IActionResult EmployeeUpdate(Employee employee)
        {
            using var c = new Context();
            var values = c.Set<Employee>().FirstOrDefault(x => x.ID == employee.ID);
            values.Name = employee.Name;
            c.SaveChanges();
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult EmployeeGet(int id)
        {
            using var c = new Context();
            //var value = c.Set<Employee>().Where(x => x.ID == id).Select(y => y.Name).FirstOrDefault();(senin kodun)
            //var value=c.Employees.Where(x => x.ID == id).Select(y => y.Name).FirstOrDefault();
            var value = c.Employees.Find(id);

            if (value==null)
            {
                return NotFound();
            }
            else
            {
                return Ok(value);
            }
            
        }
    }
}
