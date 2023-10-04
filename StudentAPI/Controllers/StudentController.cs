using Microsoft.AspNetCore.Mvc;
using StudentAPI.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        static List<Student> students =new List<Student>();
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return students;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return students.FirstOrDefault(s => s.Id==id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post(Student NewStu)
        {
            students.Add(NewStu);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student student)
        {
            int index=students.FindIndex(s => s.Id == id);
            students[index]= student;
            //students.Insert(index,student);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            students.RemoveAll(s => s.Id==id);
        }
    }
}
