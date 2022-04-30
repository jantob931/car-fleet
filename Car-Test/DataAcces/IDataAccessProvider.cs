using Car_Test.Models;
namespace Car_Test.DataAcces
{
    public interface IDataAccessProvider
    {
        void AddCarRecord(Car car);
        void UpdateCarRecord(Car car);
        void DeleteCarRecord(string id);
        Car GetCarSingleRecord(string id);
        List<Car> GetCarRecords();
        TechnicalExamination GetTechnicalExaminationSinglerecord(string id);
        List<TechnicalExamination> GetTechnicalExaminationsRecords();
        void AddTechnicalExaminationRecord(TechnicalExamination technicalExamination);
        void UpdateTechnicalExaminationRecord(TechnicalExamination technicalExamination);
        void DeleteTechnicalExaminationRecord(string id);

    }
}
