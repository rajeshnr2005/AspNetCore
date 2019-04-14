using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AspNetMVC5.Models;

namespace AspNetMVC5.Controllers
{
  public class EmployeeController : ApiController
  {


    EmployeeModel[] Employees = new EmployeeModel[]
   {


            new EmployeeModel
            {
                EmployeeId = 1, EmployeeName = "Rajesh", Department = "IT", Address = "Lake Hiawatha"
            },
             new EmployeeModel
            {
                EmployeeId = 2, EmployeeName = "Vijesh", Department = "IT", Address = "Lake Hiawatha"
            },
             new EmployeeModel
            {
                EmployeeId = 3, EmployeeName = "Bablu", Department = "Finance", Address = "Lake Hiawatha"
            },
              new EmployeeModel
            {
                EmployeeId = 4, EmployeeName = "Nayanu", Department = "HR", Address = "Lake Hiawatha"
            },
   };


    // GET api/<controller>
   // [HttpGet]
  //  [Route("api/[controller]/GetEmployee")]
    public IEnumerable<EmployeeModel> Get(int id)
    {
      return Employees;
    }



    //[Route("api/[controller]/GetEmployee1")]
    //public string Get(int id)
    //{
    //  return "value";
    //}

    // POST api/<controller>
    public void Post([FromBody]string value)
    {
    }

    // PUT api/<controller>/5
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/<controller>/5
    public void Delete(int id)
    {
    }
  }
}
