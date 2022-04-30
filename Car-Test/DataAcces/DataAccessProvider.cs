using Car_Test.Models;

namespace Car_Test.DataAcces
{
    public class DataAccessProvider : IDataAccessProvider
    {
        private readonly PostgreSqlContext _context;

        public DataAccessProvider(PostgreSqlContext context)
        {
            _context = context;
        }

        public void AddCarRecord(Car car)
        {
            _context.car.Add(car);
            _context.SaveChanges();
        }

        public void UpdateCarRecord(Car car)
        {
            _context.car.Update(car);
            _context.SaveChanges();
        }

        public void DeleteCarRecord(string id)
        {
            var entity = _context.car.FirstOrDefault(t => t.id == id);
            _context.car.Remove(entity);
            _context.SaveChanges();
        }

        public Car GetCarSingleRecord(string id)
        { 
            return _context.car.FirstOrDefault(t => t.id == id);
        }

        public List<Car> GetCarRecords()
        {
            return _context.car.ToList();
        }

        public TechnicalExamination GetTechnicalExaminationSinglerecord(string id)
        {
            return _context.technicalExamination.FirstOrDefault(t => t.id == id);
        }

        public List<TechnicalExamination> GetTechnicalExaminationsRecords()
        {
             return _context.technicalExamination.ToList();
        }

        public void AddTechnicalExaminationRecord(TechnicalExamination technicalExamination)
        {
            _context.technicalExamination.Add(technicalExamination);
            _context.SaveChanges();
        }

        public void UpdateTechnicalExaminationRecord(TechnicalExamination technicalExamination)
        {
            _context.technicalExamination.Update(technicalExamination);
            _context.SaveChanges();
        }

        public void DeleteTechnicalExaminationRecord(string id)
        {
            var entity = _context.technicalExamination.FirstOrDefault(t => t.id == id);
            _context.technicalExamination.Remove(entity);
            _context.SaveChanges();
        }
    }
}
