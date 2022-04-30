using Car_Test.DataAcces;
using Car_Test.Models;
using Microsoft.AspNetCore.Mvc;

namespace Car_Test.Controllers
{
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public CarController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return _dataAccessProvider.GetCarRecords();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Car car)
        {
            if (ModelState.IsValid)
            {
                Guid obj = Guid.NewGuid();
                car.id = obj.ToString();
                _dataAccessProvider.AddCarRecord(car);
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public Car Details(string id)
        {
            return _dataAccessProvider.GetCarSingleRecord(id);
        }

        [HttpPut]
        public IActionResult Edit([FromBody] Car car)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateCarRecord(car);
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
