using System;
using System.Threading.Tasks;
using Common.Repository;
using Microsoft.AspNetCore.Mvc;
using Model;
using RequestModel;
using Service;

namespace RMS.Server.Controllers
{
    [Produces("application/json")]
    [Route("api/Teachers")]
    public class TeachersController : Controller
    {
        private LmsDbContext _db;
        private BaseRepository<Teacher> _repository;
        private TeacherService _service;

        public TeachersController(LmsDbContext db)
        {
            _db = db;
            _repository = new BaseRepository<Teacher>(_db);
            _service = new TeacherService(_repository);
        }

        [HttpPost]
        [Route("Search")]
        public async Task<IActionResult> GetTeachers([FromBody] TeacherRequestModel request)
        {
            var Teachers = await _service.SearchAsync(request);
            return Ok(Teachers);
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult AddTeacher([FromBody] Teacher teacher)
        {
            teacher.Id = Guid.NewGuid().ToString();
            teacher.Created = DateTime.Now;
            teacher.Modified = DateTime.Now;
            teacher.CreatedBy = "system";
            teacher.ModifiedBy = "system";
            teacher.IsActive = true;

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            bool added = _service.Add(teacher);
            if (added)
            {
                return Ok(teacher.Id);
            }

            return BadRequest("Couldn't save course.");
        }
    }
}