using Microsoft.AspNetCore.Mvc;
using Car_Test.DataAcces;
using Car_Test.Models;
using Microsoft.AspNetCore.Mvc;

namespace Car_Test.Controllers
{
    [Route("api/[controller]")]
    public class ExaminationController : ControllerBase
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public ExaminationController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        [HttpGet]
        public IEnumerable<TechnicalExamination> Get()
        {
            return _dataAccessProvider.GetTechnicalExaminationsRecords();
        }

        [HttpPost]
        public IActionResult Create([FromBody] TechnicalExamination ex)
        {
            if (ModelState.IsValid)
            {
                Guid obj = Guid.NewGuid();
                ex.id = obj.ToString();
                _dataAccessProvider.AddTechnicalExaminationRecord(ex);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public TechnicalExamination Details(string id)
        {
            return _dataAccessProvider.GetTechnicalExaminationSinglerecord(id);
        }

        [HttpPut]
        public IActionResult Edit([FromBody] TechnicalExamination ex)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateTechnicalExaminationRecord(ex);
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteConfirmed(string id)
        {
            var data = _dataAccessProvider.GetCarSingleRecord(id);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteCarRecord(id);
            return Ok();
        }
    }
}
