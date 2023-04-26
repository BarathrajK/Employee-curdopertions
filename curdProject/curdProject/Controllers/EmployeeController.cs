using curdProject.Dbset;
using curdProject.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace curdProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeDbContext _db;
        public EmployeeController(EmployeeDbContext db)
        {
            _db = db;
        }


        [HttpPost]
        [Route("Create")] // IactionResult - Multiple data return//return type - string ,int ,float, char
        public IActionResult Create([FromBody]Employee E1) // frombody pass in create and update
        {
            _db.Add(E1);
            _db.SaveChanges();
            return Ok(E1);
        }

        //GET All Employee 
        [HttpGet]
        [Route("GetAllEmpolyee")]
        public IActionResult GetAll()
        {
            List<Employee> employees = new List<Employee>();
            employees = _db.employees.ToList();
            return Ok(employees);
        }

        //Get By Id
        [HttpGet]
        [Route("GetById")]
        public IActionResult GetById(int id) 
        {
            Employee E1 = _db.employees.FirstOrDefault(x => x.Id == id);
            return Ok(E1);
        }

        //Update

        [HttpPut]
        [Route("Update")]

        public IActionResult UpdateEmployee([FromBody]Employee E1)
        {
            _db.Update(E1);
            _db.SaveChanges();
            return Ok(E1);
        }

        //Delete
        [HttpDelete]
        [Route("Delete")]

        public IActionResult DeleteById(int id)
        {
            Employee E1 = _db.employees.FirstOrDefault(x => x.Id == id);
            _db.Remove(E1);
            _db.SaveChanges();
            return Ok(E1);
        }
    }
}
